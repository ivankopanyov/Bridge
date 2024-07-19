namespace Bridge.HostApi.Repositories.Implement;

public class LogRepository(IElasticSearchService elasticSearchService) : ILogRepository
{
    private readonly SemaphoreSlim _semaphore = new(1);

    public async Task AddAsync(EventLog eventLog) => await elasticSearchService.Exec<Task>(async (client, index) =>
    {
        await _semaphore.WaitAsync();

        try
        {
            var getResponse = await client.GetAsync<TaskLog>(eventLog.TaskId, i => i.Index(index));
            if (!getResponse.IsSuccess())
                throw new Exception(getResponse.DebugInformation);

            ElasticsearchResponse response = getResponse.IsValidResponse
                ? await client.UpdateAsync<TaskLog, TaskLog>(index, eventLog.TaskId, u => u.Doc(getResponse.Source?.AddLog(eventLog) ?? new TaskLog().AddLog(eventLog)))
                : await client.IndexAsync(new TaskLog().AddLog(eventLog), index);

            if (!response.IsSuccess())
                throw new Exception(response.DebugInformation);
        }
        finally
        {
            _semaphore.Release();
        }
    });

    public async Task<IEnumerable<EventLog>?> GetAsync(string id) => await elasticSearchService.Exec<Task<IEnumerable<EventLog>?>>(async (client, index) => 
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(id, nameof(id));

        var response = await client.GetAsync<TaskLog>(id, i => i.Index(index));

        if (!response.IsSuccess())
            throw new Exception(response.DebugInformation);

        return response.IsValidResponse ? response.Source?.Logs : null;
    });

    public async Task<IEnumerable<EventLog>> FindAsync(SearchFilter? filter = null)
    {
        if (filter?.Size != null && filter.Size <= 0)
            return Enumerable.Empty<EventLog>();

        var search = new SearchRequestDescriptor<TaskLog>()
            .Sort(config => config.Field(field => field.DateTime, new FieldSort { Order = SortOrder.Desc }));

        if (filter != null)
        {
            var filters = GetFilters(filter);

            if (filters.Count == 1)
                search.Query(filters[0]);
            else if (filters.Count > 1)
                search.Query(configure => configure.Bool(configure => configure.Filter(filters.ToArray())));
        }

        if (filter?.Size == null)
        {
            search.Size(ElasticSearchService.PageMaxSize);

            var result = new List<EventLog>();
            for (int i = 0; true; i++)
            {
                var logs = await FindAsync(search.From(i));
                result.AddRange(logs);
                if (logs.Count() < ElasticSearchService.PageMaxSize)
                    return result;
            }
        }

        if (filter.Size > ElasticSearchService.PageMaxSize)
        {
            search.Size(ElasticSearchService.PageMaxSize);

            var result = new List<EventLog>();
            for (int i = 0, j = (int)filter.Size; j > 0; i++, j -= ElasticSearchService.PageMaxSize)
            {
                if (j < ElasticSearchService.PageMaxSize)
                    search.Size(j);

                var logs = await FindAsync(search.From(i));
                result.AddRange(logs);
                if (logs.Count() < ElasticSearchService.PageMaxSize)
                    return result;
            }
        }

        return await FindAsync(search.From(0).Size(filter.Size));
    }

    private async Task<IEnumerable<EventLog>> FindAsync(SearchRequestDescriptor<TaskLog> searchRequestDescriptor) =>
        await elasticSearchService.Exec(async (client, index) => 
        {
            var response = await client.SearchAsync(searchRequestDescriptor.Index(index));

            if (!response.IsSuccess())
                throw new Exception(response.DebugInformation);

            return response.Total <= 0 ? [] : response.Documents.Select(task =>
            {
                if (task.Logs.FirstOrDefault() is not EventLog log)
                    return null!;
                
                log.Data = null;
                return log;
            })
            .Where(el => el != null);
        });

    private static List<Action<QueryDescriptor<TaskLog>>> GetFilters(SearchFilter filter)
    {
        var filters = new List<Action<QueryDescriptor<TaskLog>>>();

        if (filter.From != null || filter.To != null)
            filters.Add(GetDateRangeFilter(filter.From, filter.To));

        var taskNames = filter.TaskNames?
            .Where(taskName => taskName != null)
            .Select(taskName => taskName.ToLower());

        if (taskNames?.Any() == true)
            filters.Add(GetTaskNameFilter(taskNames));

        if (filter.IsError is bool isError)
            filters.Add(GetIsErrorFilter(isError));

        if (filter.IsEnd is bool isEnd)
            filters.Add(GetIsEndFilter(isEnd));

        var pattern = filter.Pattern?.Trim().ToLower();
        if (!string.IsNullOrEmpty(pattern))
            filters.Add(GetPatternFilter(pattern));

        return filters;
    }

    private static Action<QueryDescriptor<TaskLog>> GetDateRangeFilter(DateTime? from, DateTime? to) =>
        configure => configure.Range(configure => configure.DateRange(configure =>
        {
            configure.Field(field => field.DateTime);

            if (from is DateTime fromDateTime)
                configure.Gt(fromDateTime);

            if (to is DateTime toDateTime)
                configure.Lt(toDateTime);
        }));

    private static Action<QueryDescriptor<TaskLog>> GetTaskNameFilter(IEnumerable<string> taskNames) =>
        configure => configure.Terms(configure => configure
            .Field(field => field.TaskName)
            .Terms(new([.. taskNames])));

    private static Action<QueryDescriptor<TaskLog>> GetIsErrorFilter(bool isError) =>
        configure => configure.Term(configure => configure
            .Field(field => field.IsError)
            .Value(isError));

    private static Action<QueryDescriptor<TaskLog>> GetIsEndFilter(bool isEnd) =>
        configure => configure.Term(configure => configure
            .Field(field => field.IsEnd)
            .Value(isEnd));

    private static Action<QueryDescriptor<TaskLog>> GetPatternFilter(string pattern)
    {
        Expression<Func<TaskLog, object?>>[] fields = [
            taskLog => taskLog.Id,
            taskLog => taskLog.Logs.First().HandlerName,
            taskLog => taskLog.Logs.First().Message,
            taskLog => taskLog.Logs.First().Data.Error,
            taskLog => taskLog.Logs.First().Data.StackTrace,
            taskLog => taskLog.Logs.First().Data.InputObjectJson
        ];

        return configure => configure.QueryString(configure => configure
            .Fields(fields)
            .Query($"*{pattern}*")
            .AnalyzeWildcard()
            .AllowLeadingWildcard());
    }
}
