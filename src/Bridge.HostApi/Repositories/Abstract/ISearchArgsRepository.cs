namespace Bridge.HostApi.Repositories.Abstract;

public interface ISearchArgsRepository
{
    Task<SearchArgs?> GetAsync();

    Task<SearchArgs?> UpdateAsync(string taskName);
}
