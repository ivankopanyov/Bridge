namespace Bridge.HostApi.Repositories.Abstract;

public interface ILogRepository
{
    Task AddAsync(EventLog eventLog);

    Task<IEnumerable<EventLog>?> GetAsync(string id);

    Task<IEnumerable<EventLog>> FindAsync(SearchFilter? filter = null);
}
