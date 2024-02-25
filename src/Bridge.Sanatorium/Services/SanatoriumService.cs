namespace Bridge.Sanatorium.Services;

public class SanatoriumService(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService,
        ServiceOptions<SanatoriumService, ServiceBusOptions> options, ILogger<SanatoriumService> logger)
        : ServiceControl<ServiceBusOptions>(serviceHostClient, eventService, options, logger), ISanatoriumService
{
    private IEndpointInstance? _endpointInstance;

    public decimal Rvc => Options.Rvc ?? default;

    protected override async Task SetOptionsHandleAsync() => await Task.Run(async () => 
    { 
        try
        {
            if (_endpointInstance != null)
                await _endpointInstance.Stop();

            var endpointConfiguration = new EndpointConfiguration(Options.EndpointName);
            endpointConfiguration.AssemblyScanner().ExcludeAssemblies("Logus.HMS.Messages");
            if (!string.IsNullOrEmpty(Options.License))
                endpointConfiguration.License(Options.License);
            endpointConfiguration.SendFailedMessagesTo("error");
            endpointConfiguration.AuditProcessedMessagesTo("audit");
            endpointConfiguration.UseSerialization<XmlSerializer>();
            endpointConfiguration.UseTransport(new SqlServerTransport(Options.ConnectionString));
            endpointConfiguration.UsePersistence<NHibernatePersistence>().ConnectionString(Options.ConnectionString);
            endpointConfiguration.PurgeOnStartup(false);
            endpointConfiguration.EnableInstallers();

            _endpointInstance = await NServiceBus.Endpoint.Start(endpointConfiguration);
            await ActiveAsync();
        }
        catch (Exception ex)
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            await UnactiveAsync(ex);
        }
    }).ConfigureAwait(false);

    public async Task PublishAsync<T>(T message) where T : class, new()
    {
        try
        {
            await _endpointInstance.Publish(message);
            await ActiveAsync();
        }
        catch (Exception ex)
        {
            await UnactiveAsync(ex);
            await SetOptionsHandleAsync();
            throw;
        }
    }
}
