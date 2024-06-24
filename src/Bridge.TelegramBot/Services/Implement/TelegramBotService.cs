namespace Bridge.TelegramBot.Services.Implement;

public class TelegramBotService : ITelegramBotService
{
    private readonly IControl<TelegramBotOptions, BridgeEnvironment> _control;

    public IEnumerable<TelegramChat> Chats { get; private set; }

    public bool Enabled => _control.Options.Enabled;

    public bool OnlyError { get; private set; }

    public BridgeEnvironment Environment => _control.Environment;

    private TelegramBotClient Client => _control.Options.Enabled ? new(_control.Options.Token!) : throw new Exception("Service is disabled.");

    public TelegramBotService(IControl<TelegramBotOptions, BridgeEnvironment> control)
    {
        _control = control;
        Chats = GetChats();
    }

    public void Exec(Action<ITelegramBotClient> action)
    {
        ArgumentNullException.ThrowIfNull(action, nameof(action));

        try
        {
            action.Invoke(Client);
            _control.Active();
        }
        catch (Exception ex)
        {
            _control.Unactive(ex);
            throw;
        }
    }

    public T Exec<T>(Func<ITelegramBotClient, T> func)
    {
        ArgumentNullException.ThrowIfNull(func, nameof(func));

        try
        {
            var result = func.Invoke(Client);
            _control.Active();
            return result;
        }
        catch (Exception ex)
        {
            _control.Unactive(ex);
            throw;
        }
    }

    public async Task ChangedOptionsHandleAsync(TelegramBotOptions options)
    {
        if (!_control.Options.Enabled)
            throw new Exception("Service is disabled.");

        if (!await Client.TestApiAsync())
            throw new Exception("API token is specified incorrectly.");
    }

    public Task ChangedEnvironmentHandleAsync(BridgeEnvironment current, BridgeEnvironment previous)
    {
        Chats = GetChats();
        return Task.CompletedTask;
    }

    private IEnumerable<TelegramChat> GetChats()
    {
        OnlyError = true;

        var result = _control.Environment.TelegramChats.Select(chat =>
        {
            var split = chat.Key.Split('/', StringSplitOptions.RemoveEmptyEntries);
            if (!long.TryParse(split[0], out long chatId))
                return null;

            int? messageThreadId = null;
            if (split.Length > 1)
            {
                if (!int.TryParse(split[1], out int threadId))
                    return null;

                messageThreadId = threadId;
            }

            if (!chat.Value)
                OnlyError = false;

            return new TelegramChat
            {
                Id = chatId,
                MessageThreadId = messageThreadId,
                OnlyError = chat.Value
            };
        }).Where(chat => chat != null);

        return result!;
    }
}
