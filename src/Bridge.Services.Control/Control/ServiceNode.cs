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
        eventService.SetOptionsEvent += async (serviceName, serviceOptions) =>
        {
            if (serviceName != _name)
                return null;

            try 
            {
                Options = serviceOptions != null && JsonConvert.DeserializeObject<T>(serviceOptions) is T newOptions
                    ? newOptions : DefaultOptions;
            }
            catch (Exception ex)
            {
                Options = DefaultOptions;
                _logger.Error(_name, ex);
            }

            await SetOptionsHandleAsync();
            return ToServiceInfo();
        };
    }

    internal async Task GetOptionsAsync() => await Task.Run(async () => await GetOptionsAsync(new Service
    {
        Host = _host,
        Service_ = ToServiceInfo()
    })).ConfigureAwait(false);

    private async Task GetOptionsAsync(Service service, Exception? currentExeption = null) => await Task.Run(async () =>
    {
        try
        {
            var options = await _serviceHostClient.GetOptionsAsync(service);

            if (options?.Options?.Options == null)
                Options = DefaultOptions;
            else
                try
                {
                    Options = JsonConvert.DeserializeObject<T>(options.Options.Options) ?? DefaultOptions;
                }
                catch (Exception ex)
                {
                    _logger.Error(_name, ex);
                    Options = DefaultOptions;
                }

            await SetOptionsHandleAsync();
        }
        catch (Exception ex)
        {
            if (currentExeption == null || currentExeption.Message != ex.Message || currentExeption.StackTrace != ex.StackTrace)
            {
                currentExeption = ex;
                _logger.Error(_name, ex);
            }

            await Task.Delay(1000);
            await GetOptionsAsync(service, currentExeption);
        }
    }).ConfigureAwait(false);

    protected virtual Task SetOptionsHandleAsync() => Task.CompletedTask;

    private protected override ServiceInfo ToServiceInfo()
    {
        var serviceInfo = base.ToServiceInfo();
        serviceInfo.Options = new ServiceOptions();

        if (Options == null)
            return serviceInfo;

        try
        {
            var result = JsonConvert.SerializeObject(Options);
            if (result != null)
                serviceInfo.Options.Options = result;
        }
        catch (Exception ex)
        {
            _logger.Error(_name, ex);
        }

        return serviceInfo;
    }
}

    