namespace Bridge.Sanatorium.Handlers;

public class PostingResponseHandler(ISanatoriumService sanatoriumService) : Handler<PostResponseInfo>
{
    protected override async Task HandleAsync(PostResponseInfo @in, IEventContext context)
    {
        try
        {
            var options = new SendOptions();

            if (@in.Headers.TryGetValue(Headers.MessageId, out string? messageId))
                options.SetHeader(Headers.RelatedTo, messageId);

            if (@in.Headers.TryGetValue(Headers.ConversationId, out string? conversationId))
                options.SetHeader(Headers.ConversationId, conversationId);

            if (@in.Headers.TryGetValue(Headers.OriginatingEndpoint, out string? originatingEndpoint))
                options.SetDestination(originatingEndpoint);
            
            await sanatoriumService.Exec<Task>(async endpoint => await endpoint!.Send(new PostTransactionsResponse(@in.CorrelationId)
            {
                Succeeded = @in.Succeeded,
                ErrorCode = @in.ErrorCode!,
                ErrorMessage = @in.ErrorMessage!
            }, options));

            if (!@in.Succeeded)
                context.Break(@in.ErrorMessage);
        }
        catch (Exception ex)
        {
            context.Break(ex.Message, ex);
        }
    }

    protected override string? Message(PostResponseInfo @in)
    {
        string result = $"Correlation ID {@in.CorrelationId} {(@in.Succeeded ? "Succeeded" : "Error")}";
        
        if (!string.IsNullOrWhiteSpace(@in.ErrorMessage))
            result += $": {@in.ErrorMessage}";

        return result;
    }
}
