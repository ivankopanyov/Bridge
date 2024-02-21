namespace Bridge.Services.Control;

public abstract class ServiceNode : ServiceNodeBase
{
    public ServiceNode(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService, ServiceNodeOptions options, ILogger logger)
        : base(serviceHostClient, eventService, options, logger) { }
}

public abstract class ServiceNode<T> : ServiceNodeBase where T : class, new()
{
    private static T DefaultOptions => Activator.CreateInstance<T>();

    public T Options { get; protected set; } = DefaultOptions;

    public ServiceNode(ServiceHost.ServiceHostClient serviceHostClient, IEventService eventService, ServiceNodeOptions options,
        ILogger logger) : base(serviceHostClient, eventService, options, logger)
    {
        eventService.SetOptionsEvent += async (options) =>
        {
            if (options.ServiceName != _name)
                return null;

            var response = new SetOptionsResponse();

            if (string.IsNullOrWhiteSpace(options.JsonOptions))
            {
                response.Ok = false;
                response.Error = "Options is null";
                return response;
            }

            try 
            {
                var newOptions = JsonConvert.DeserializeObject<T>(options.JsonOptions);
                if (newOptions != null)
                {
                    Options = newOptions;
                    await SetOptionsHandleAsync();

                    response.Ok = true;
                    response.Service = ToServiceInfo();
                }
                else
                {
                    response.Ok = false;
                    response.Error = "Options is null";
                }
            }
            catch (Exception ex)
            {
                response.Ok = false;
                response.Error = ex.Message;
            }

            return response;
        };
    }

    internal async Task GetOptionsAsync() => await Task.Run(async () => await GetOptionsAsync(ToServiceInfo())).ConfigureAwait(false);

    private async Task GetOptionsAsync(ServiceInfo service, Exception? currentExeption = null) => await Task.Run(async () =>
    {
        try
        {
            var options = await _serviceHostClient.GetOptionsAsync(service);

            if (options == null)
                Options = DefaultOptions;
            else
                try
                {
                    Options = JsonConvert.DeserializeObject<T>(options.JsonOptions) ?? DefaultOptions;
                }
                catch
                {
                    Options = DefaultOptions;
                }

            await SetOptionsHandleAsync();
        }
        catch (Exception ex)
        {
            if (currentExeption == null || currentExeption.Message != ex.Message || currentExeption.StackTrace != ex.StackTrace)
                currentExeption = ex;

            await Task.Delay(1000);
            await GetOptionsAsync(service, currentExeption);
        }
    }).ConfigureAwait(false);

    protected virtual Task SetOptionsHandleAsync() => Task.CompletedTask;

    private protected override ServiceInfo ToServiceInfo()
    {
        var serviceInfo = base.ToServiceInfo();

        try
        {
            var result = JsonConvert.SerializeObject(Options);
            if (result != null)
                serviceInfo.JsonOptions = result;
        }
        catch { }

        return serviceInfo;
    }
}

    