namespace Bridge.Sanatorium.Services;

public class SanatoriumService : ISanatoriumService
{
    private ServiceBusNode _serviceBus;

    private IEndpointInstance? _endpointInstance;

    public SanatoriumService(ServiceBusNode serviceBus)
    {
        _serviceBus = serviceBus;
        _serviceBus.SetOptionsEvent += ConnectAsync;
    }

    public async Task ConnectAsync() => await Task.Run(async () => 
    { 
        try
        {
            if (_endpointInstance != null)
                await _endpointInstance.Stop();

            var endpointConfiguration = new EndpointConfiguration(_serviceBus.Options.EndpointName);
            endpointConfiguration.AssemblyScanner().ExcludeAssemblies("Logus.HMS.Messages");

            endpointConfiguration.SendFailedMessagesTo("error");
            endpointConfiguration.AuditProcessedMessagesTo("audit");
            endpointConfiguration.EnableInstallers();

            var transport = new SqlServerTransport(_serviceBus.Options.ConnectionString)
            {
                Subscriptions =
                {
                    CacheInvalidationPeriod = TimeSpan.FromMinutes(1),
                    SubscriptionTableName = new SubscriptionTableName(table: "Subscriptions", schema: "dbo")
                },
                TransportTransactionMode = TransportTransactionMode.SendsAtomicWithReceive
            };
            transport.SchemaAndCatalog.UseSchemaForQueue("error", "dbo");
            transport.SchemaAndCatalog.UseSchemaForQueue("audit", "dbo");

            endpointConfiguration.UseSerialization<SystemJsonSerializer>();
            var routing = endpointConfiguration.UseTransport(transport);

            var persistence = endpointConfiguration.UsePersistence<SqlPersistence>();
            var dialect = persistence.SqlDialect<SqlDialect.MsSqlServer>();
            persistence.ConnectionBuilder(() => new SqlConnection(_serviceBus.Options.ConnectionString));

            _endpointInstance = await NServiceBus.Endpoint.Start(endpointConfiguration);
            await _serviceBus.ActiveAsync();
        }
        catch (Exception ex)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            await _serviceBus.UnactiveAsync(ex);
        }
    }).ConfigureAwait(false);

    public async Task PublishAsync<T>(T message) where T : class, new()
    {
        try
        {
            await _endpointInstance.Publish(message);
            await _serviceBus.ActiveAsync();
        }
        catch (Exception ex)
        {
            await _serviceBus.UnactiveAsync(ex);
            await ConnectAsync();
            throw;
        }
    }
}
