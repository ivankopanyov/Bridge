namespace Bridge.HostApi.Repositories.Implement;

public class SearchArgsRepository(IElasticSearchService elasticSearchService, ICacheService cache) : ISearchArgsRepository
{
    private readonly SemaphoreSlim _semaphore = new(1);

    private const string KEY = "SearchArgs";
     
    public async Task<SearchArgs> GetAsync()
    {
        await _semaphore.WaitAsync();

        try
        {
            if (await cache.GetAsync<Search>(KEY) is not Search search)
                search = await GetSearchAsync();

            return search.SearchArgs;
        }
        finally
        {
            _semaphore.Release();
        }
    }

    public async Task<SearchArgs?> UpdateAsync(TaskName taskName)
    {
        ArgumentNullException.ThrowIfNull(taskName?.Id, nameof(taskName.Id));

        await _semaphore.WaitAsync();

        try
        {
            var result = await elasticSearchService.Exec<Task<bool>>(async (client, index) =>
            {
                var getResponse = await client.GetAsync<TaskName>(taskName.Id, i => i.Index(index));
                if (!getResponse.IsSuccess())
                    throw new Exception(getResponse.DebugInformation);

                if (getResponse.IsValidResponse)
                {
                    if (getResponse.Source is not TaskName name || name.DateTime < taskName.DateTime)
                    {
                        var response = await client.UpdateAsync<TaskName, TaskName>(index, taskName.Id, u => u.Doc(taskName));

                        if (!response.IsSuccess())
                            throw new Exception(response.DebugInformation);
                    }
                    else
                        return false;
                }
                else
                {
                    var response = await client.IndexAsync(taskName, index);

                    if (!response.IsSuccess())
                        throw new Exception(response.DebugInformation);
                }

                return true;
            });

            if (!result)
                return null;

            if (await cache.GetAsync<Search>(KEY) is not Search search)
                search = await GetSearchAsync();

            search.SearchArgs.TaskNames.Add(taskName.Id);
            if (taskName.DateTime < search.DateTime)
                search.DateTime = taskName.DateTime;

            await cache.PushAsync(KEY, search);
            return search.SearchArgs;
        }
        finally
        {
            _semaphore.Release();
        }
    }

    private async Task<Search> GetSearchAsync()
    {
        var taskNames = await GetAllAsync();
        return new()
        {
            SearchArgs = new()
            {
                TaskNames = taskNames.Select(t => t.Id).ToHashSet()
            },
            DateTime = taskNames.FirstOrDefault() is TaskName name ? name.DateTime : DateTime.MaxValue
        };
    }

    private async Task<IEnumerable<TaskName>> GetAllAsync()
    {
        var searchRequestDescriptor = new SearchRequestDescriptor<TaskName>()
            .Sort(config => config.Field(field => field.DateTime))
            .Size(ElasticSearchService.PageMaxSize);

        var result = new List<TaskName>();
        for (int i = 0; true; i++)
        {
            var logs = await elasticSearchService.Exec<Task<IEnumerable<TaskName>>>(async (client, index) =>
            {
                var response = await client.SearchAsync(searchRequestDescriptor.Index(index).From(i));
                if (!response.IsSuccess())
                    throw new Exception(response.DebugInformation);

                return response.Total <= 0 ? Enumerable.Empty<TaskName>() : response.Documents;
            });

            result.AddRange(logs);
            if (logs.Count() < ElasticSearchService.PageMaxSize)
                return result;
        }
    }
}
