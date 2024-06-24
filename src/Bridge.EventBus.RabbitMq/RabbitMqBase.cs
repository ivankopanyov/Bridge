namespace Bridge.EventBus.RabbitMq;

public abstract class RabbitMqBase(RabbitMqOptions options)
{
    private protected const string SERVICE_NAME = "RabbitMQ";

    private const int NAME_LENGHT_LIMIT = 127;

    private protected IConnection NewConnection => new ConnectionFactory
    {
        HostName = options?.Host,
        Port = options?.Port ?? 0
    }.CreateConnection();

    private protected JsonSerializerSettings JsonSerializerSettings { get; private init; } = options.JsonSerializerSettings;

    private protected static string GetName<T>(string queue) => $"{FixName(queue)}#{GetName(typeof(T))}";

    private protected static string GetName<T>() => GetName(typeof(T));

    private protected static string GetName<T>(Type queue) => $"{GetName(typeof(T))}#{GetName(queue)}";

    private protected static string GetName(Type type) => FixName(type.FullName ?? type.Name);

    private static string FixName(string name)
    {
        if (name.Length > NAME_LENGHT_LIMIT)
            name = name[..NAME_LENGHT_LIMIT];

        return name;
    }
}
