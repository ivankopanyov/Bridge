namespace Bridge.Sanatorium.Services;

public interface ISanatoriumService
{
    Task ConnectAsync();

    Task PublishAsync<T>(T message) where T : class, new();
}
