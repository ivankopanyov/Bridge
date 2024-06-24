namespace Bridge.DefaultServices;

public static class DependencyInjection
{
    private static readonly Lazy<RabbitMqOptions> _rabbitMqOptions = new(() => new RabbitMqOptions
    {
        Host = Environment.GetEnvironmentVariable("RABBIT_MQ_HOST") ?? "rabbitmq",
        Port = int.TryParse(Environment.GetEnvironmentVariable("RABBIT_MQ_PORT"), out int port) ? port : 5672
    });

    private static readonly Lazy<LoggerConfiguration> _loggerConfiguration = new(() => new LoggerConfiguration()
        .WriteTo.Console()
        .WriteTo.File("logs/all_logs_.log", rollingInterval: RollingInterval.Day));

    public static IServiceCollection AddDefaultServices(this IServiceCollection services, string hostName, int hostId,
        Action<IEventBusBuilder> eventBusBuilder, Action<IServiceControlBuilder<BridgeEnvironment>> serviceControlBuilder)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(hostName, nameof(hostName));
        ArgumentNullException.ThrowIfNull(eventBusBuilder, nameof(eventBusBuilder));
        ArgumentNullException.ThrowIfNull(serviceControlBuilder, nameof(serviceControlBuilder));

        var rabbitMqOptions = _rabbitMqOptions.Value;
        var loggerConfiguration = _loggerConfiguration.Value;

        eventBusBuilder.Invoke(services.AddEventBus<RabbitMqTransport, RabbitMqOptions>(options =>
        {
            options.Host = rabbitMqOptions.Host;
            options.Port = rabbitMqOptions.Port;
            options.HostId = hostId;
        }, options => options.LoggerConfiguration = loggerConfiguration));

        serviceControlBuilder.Invoke(services.AddServiceControl<RabbitMqTransport, RabbitMqOptions, BridgeEnvironment>(options =>
        {
            options.Host = rabbitMqOptions.Host;
            options.Port = rabbitMqOptions.Port;
            options.JsonSerializerSettings.ContractResolver = new DescriptionContractResolver();
        }, options =>
        {
            options.HostName = hostName;
            options.LoggerConfiguration = loggerConfiguration;
        }));

        return services.AddSerilog(loggerConfiguration.CreateLogger());
    }

    public static IServiceCollection AddRedis(this IServiceCollection services) => services.AddCache<RedisService, RedisOptions>(options =>
    {
        options.Host = Environment.GetEnvironmentVariable("REDIS_HOST") ?? "redis";
        options.Port = int.TryParse(Environment.GetEnvironmentVariable("REDIS_PORT"), out int port) ? port : 6379;
        options.JsonSerializerSettings.ContractResolver = new DescriptionContractResolver();
    });

    public static IServiceCollection AddMemoryCache(this IServiceCollection services) => services.AddCache<MemoryService, MemoryOptions>();
}
