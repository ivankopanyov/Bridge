namespace Bridge.Services.Control.Services.Implement;

internal class ServiceControllerStarter : StarterBase
{
    private static readonly Lazy<Reload> _reload = new(() => new());

    private protected readonly IProducer _producer;

    public ServiceControllerStarter(IServiceController serviceController, IEventBusFactory eventBusFactory)
    {
        _producer = eventBusFactory.CreateProducer();

        serviceController.SetOptionsEvent += (hostName, serviceName, options)
            => _producer.Publish(GetQueueName(hostName, serviceName), options);

        serviceController.ReloadEvent += (hostName, serviceName)
            => _producer.Publish(GetQueueName(hostName, serviceName), _reload.Value);

        UpdatedServiceInfoHandle(eventBusFactory, serviceController);
    }

    private protected virtual void UpdatedServiceInfoHandle(IEventBusFactory eventBusFactory, IServiceController serviceController)
    {
        var serviceInfoConsumer = eventBusFactory.CreateConsumer<UpdatedServiceInfo>();
        serviceInfoConsumer.MessageEvent += (serviceInfo, args) =>
        {
            serviceController.ChangedOptions(serviceInfo);
            return Task.CompletedTask;
        };
        serviceInfoConsumer.RecieveStart();
    }

    protected override sealed Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _producer.Publish(new ServiceControllerStarted());
        return Task.CompletedTask;
    }
}

internal class ServiceControllerStarter<TEnvironment> : ServiceControllerStarter where TEnvironment : class, new()
{
    private TEnvironment? _environment;

    public ServiceControllerStarter(IServiceController<TEnvironment> serviceController, IEventBusFactory eventBusFactory)
        : base(serviceController, eventBusFactory)
    {
        serviceController.SetEnvironmentEvent += (environment) =>
        {
            _environment = environment;
            _producer.Publish(_environment);
        };
    }

    private protected override void UpdatedServiceInfoHandle(IEventBusFactory eventBusFactory, IServiceController serviceController)
    {
        var serviceInfoConsumer = eventBusFactory.CreateConsumer<UpdatedServiceInfoEnvironment>();
        serviceInfoConsumer.MessageEvent += (serviceInfo, args) =>
        {
            serviceController.ChangedOptions(serviceInfo);
            if (serviceInfo.RequestEnvironment && _environment != null)
                _producer.Publish(GetQueueName(serviceInfo.HostName, serviceInfo.Name), _environment);

            return Task.CompletedTask;
        };
        serviceInfoConsumer.RecieveStart();
    }
}
