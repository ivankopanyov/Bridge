namespace Bridge.HostApi.Repositories.Implement;

public class SearchArgsRepository(ICacheService cacheService) : ISearchArgsRepository
{
    private readonly SemaphoreSlim _semaphore = new(1);

    private const string KEY = "SearchFilterArgs";

    public async Task<SearchArgs?> GetAsync()
    {
        await _semaphore.WaitAsync();

        try
        {
            return await cacheService.GetAsync<SearchArgs>(KEY);
        }
        finally
        {
            _semaphore.Release();
        }
    }

    public async Task<SearchArgs?> UpdateAsync(string taskName)
    {
        if (taskName == null)
            return null;

        await _semaphore.WaitAsync();

        try
        {
            var args = await cacheService.GetAsync<SearchArgs>(KEY);

            if (args == null || args.TaskNames.Add(taskName))
            {
                await cacheService.PushAsync(KEY, args ?? new SearchArgs
                {
                    TaskNames = [taskName]
                });

                return args;
            }

            return null;
        }
        finally
        {
            _semaphore.Release();
        }
    }
}
