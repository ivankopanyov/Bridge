namespace Bridge.TelegramBot.Handlers;

public class TelegramMessageHandler(ITelegramBotService telegramBotService, ICacheService cacheService) : LogHandler
{
    private static readonly SemaphoreSlim _semaphore = new(1);

    protected override async Task HandleAsync(EventLog @in)
    {
        if (!telegramBotService.Enabled || !telegramBotService.Chats.Any() || (!@in.IsError && telegramBotService.OnlyError))
            return;

        await telegramBotService.Exec<Task>(async client =>
        {
            string taskId = @in.TaskId ?? "UNKNOWN";
            List<string> errors = [];

            foreach (var chat in telegramBotService.Chats)
            {
                if (!@in.IsError && chat.OnlyError)
                    continue;

                var key = $"{chat.Id}/{chat.MessageThreadId}/{taskId}";

                await _semaphore.WaitAsync();

                try
                {
                    if (await cacheService.GetAsync<TelegramMessage>(key) is TelegramMessage message)
                    {
                        message.Items.Add(@in);
                        await client.EditMessageTextAsync(chat.Id, message.MessageId, message.ToString());
                    }
                    else
                    {
                        message = new TelegramMessage
                        {
                            ChatId = chat.Id
                        };

                        message.Items.Add(@in);
                        var response = await client.SendTextMessageAsync(chat.Id, message.ToString(), messageThreadId: chat.MessageThreadId);
                        message.MessageId = response.MessageId;
                    }

                    if (@in.IsEnd)
                        await cacheService.PopAsync<TelegramMessage>(key);
                    else
                        await cacheService.PushAsync(key, message);
                }
                catch (Exception ex)
                {
                    errors.Add(ex.Message);
                }

                _semaphore.Release();
            }

            if (errors.Count > 0)
                throw new Exception(string.Join(' ', errors));
        });
    }
}
