namespace Bridge.Fiscal.Services;

public class FiscalService(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService,
    ServiceOptions<FiscalService, CheckDbOptions> options, ILogger<FiscalService> logger)
    : ServiceControl<CheckDbOptions>(serviceHostClient, eventService, options, logger), IFiscalService
{
    public async Task<SetCheckResponse> SetCheckAsync(FiscalCheck check)
    {
        try
        {
            var checkDbClient = new CheckDBClient(CheckDBClient.EndpointConfiguration.BasicHttpBinding_ICheckDB, Options.Host);
            var response = await checkDbClient.SetCheckAsync(check);
            await ActiveAsync();
            return response;
        }
        catch (Exception ex)
        {
            await UnactiveAsync(ex);
            throw;
        }
    }

    protected override async Task SetOptionsHandleAsync()
    {
        try
        {
            var checkDbClient = new CheckDBClient(CheckDBClient.EndpointConfiguration.BasicHttpBinding_ICheckDB, Options.Host);
            await checkDbClient.GetCheckAsync(new Request());
            await ActiveAsync();
        }
        catch (Exception ex)
        {
            await UnactiveAsync(ex);
        }
    }
}
