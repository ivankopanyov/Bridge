namespace Bridge.Sanatorium.Services;

public interface ISanatoriumService : IOptinable
{
    decimal Rvc { get; }

    Task PublishAsync<T>(T message) where T : class, new();
}
