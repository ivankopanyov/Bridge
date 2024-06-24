namespace Bridge.DefaultServices;

public static class EventBusBuilderExtensions
{
    public static IEventBusBuilder AddReservationEventHandler<THandler, TIn>(this IEventBusBuilder eventBusBuilder,
        Action<HandlerOptions> options) where THandler : Handler<TIn>
    {
        ArgumentNullException.ThrowIfNull(options);

        var handlerOptions = new HandlerOptions();
        options.Invoke(handlerOptions);

        return eventBusBuilder.AddEventHandler<THandler, TIn>(options =>
        {
            options.TaskName = "RESV";
            options.HandlerName = handlerOptions.HandlerName;
        });
    }

    public static IEventBusBuilder AddPostingEventHandler<THandler, TIn>(this IEventBusBuilder eventBusBuilder,
        Action<HandlerOptions> options) where THandler : Handler<TIn>
    {
        ArgumentNullException.ThrowIfNull(options);

        var handlerOptions = new HandlerOptions();
        options.Invoke(handlerOptions);

        return eventBusBuilder.AddEventHandler<THandler, TIn>(options =>
        {
            options.TaskName = "POST";
            options.HandlerName = handlerOptions.HandlerName;
        });
    }
}
