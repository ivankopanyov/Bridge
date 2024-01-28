using System;
using System.Runtime.CompilerServices;

namespace Bridge.EventBus;

public abstract class StartEventHandler<TIn, TOut> : EventHandlerBase<TIn, TOut> where TIn : class, new() where TOut : Message, new()
{
    protected StartEventHandler(IEventBusService eventBusService, ILogger logger) : base(eventBusService, logger) { }

    protected async Task InputDataAsync(string? queueName, TIn? @in)
    {
        var @event = new Event<TIn>
        {
            QueueName = queueName,
            TaskId = Guid.NewGuid().ToString(),
            Message = @in
        };

        try
        {
            await HandleProcessAsync(@event);
        }
        catch (Exception ex)
        {
            Logger.Error(@event.QueueName, HandlerName, @event.TaskId, InputLog(@event.Message), ex);
            await TrySendAsync(async () => await EventBusService.SendAsync(@event));
        }
    }

    private async Task TrySendAsync(Action action)
    {
        try
        {
            action.Invoke();
        }
        catch (Exception ex)
        {
            EventBusService.Unactive(ex);
            await Task.Run(async () =>
            {
                await ConnectAsync();
                await TrySendAsync(action);
            }).ConfigureAwait(false);
        }
    }
}
