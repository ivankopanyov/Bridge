namespace Bridge.Sanatorium.Handlers;

public class PostTransactionsRequestHandler(IControl<ServiceBusOptions, BridgeEnvironment> control,
    IEventBusService<PostingRequest> eventBusService) : IHandleMessages<PostTransactionsRequest>
{
    public Task Handle(PostTransactionsRequest message, IMessageHandlerContext context)
    {
        if (control.Environment.UsePosting)
            eventBusService.Publish(new PostingRequest
            {
                Headers = context.MessageHeaders.ToDictionary(),
                PostTransactionsRequest = message
            });

        return Task.CompletedTask;
    }
}

