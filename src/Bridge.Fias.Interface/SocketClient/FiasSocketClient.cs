namespace Bridge.Fias.SocketClient;

internal class FiasSocketClient : BackgroundService
{
    private const char HEAD = FiasEnviroments.HEAD;

    private const char TAIL = FiasEnviroments.TAIL;

    private readonly string _separator = $"{TAIL}{HEAD}";

    private readonly IFiasService _fias;

    private Socket? _socket;

    public FiasSocketClient(IFiasService fias)
    {
        _fias = fias;
        _fias.FiasSendMessageEvent += SendAsync;
    }

    protected sealed override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await Task.Run(async () =>
        {
            while (true)
                await ConnectAsync();
        }, stoppingToken).ConfigureAwait(false);
    }
    
    private async Task ConnectAsync()
    {
        if (_fias.CancellationToken.IsCancellationRequested)
            _fias.RefreshCancellationToken();

        try
        {
            await Task.Delay(6000, _fias.CancellationToken);
        }
        catch (OperationCanceledException)
        {
            _fias.Unactive(new OperationCanceledException("Restarting the connection."));
            return;
        }

        using Socket socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        try
        {
            ConnectToFias(socket);
        }
        catch (Exception ex)
        {
            _fias.Unactive(ex);
            return;
        }

        _fias.Active();

        StringBuilder stringBuilder = new();
        _socket = socket;

        try
        {
            while (true)
            {
                if (_fias.CancellationToken.IsCancellationRequested)
                {
                    _fias.Unactive(new OperationCanceledException("Restarting the connection."));
                    break;
                }

                if (!socket.Connected)
                {
                    _fias.Unactive(new InvalidOperationException("Fias connection is failed."));
                    break;
                }

                await ReadAsync(socket, stringBuilder);
            }
        }
        catch (Exception ex)
        {
            _fias.Unactive(ex);
        }

        _socket = null;
    }

    private async Task ReadAsync(Socket socket, StringBuilder stringBuilder)
    {
        var buffer = new byte[8192];
        var size = await socket.ReceiveAsync(buffer);

        if (size > 0)
        {
            var array = buffer.ToArray();
            if (size < array.Length)
                Array.Resize(ref array, size);

            var temp = Encoding.Default.GetString(array, 0, size);
            var messages = temp.Split(_separator);

            if (messages.Length == 1 && messages[0].Length > 0)
            {
                if (messages[0][^1] != TAIL)
                {
                    if (messages[0][0] != HEAD)
                        stringBuilder.Append(messages[0]);
                    else
                        stringBuilder.Clear().Append(messages[0].AsSpan(1));
                }
                else
                {
                    var message = FixHead(messages[0], stringBuilder);
                    MessageHandle(message);
                    stringBuilder.Clear();
                }
            }
            else if (messages.Length > 1)
            {
                var message = messages[0].Length != 0 ? FixHead(messages[0], stringBuilder) : stringBuilder.ToString();
                MessageHandle(message);
                stringBuilder.Clear();

                for (int i = 1; i < messages.Length - 1; i++)
                    MessageHandle(messages[i]);

                message = messages[^1];

                if (message.Length != 0)
                {
                    if (message[^1] != TAIL)
                        stringBuilder.Append(message);
                    else
                        MessageHandle(message[1..]);
                }
            }
        }
        else
            await socket.SendAsync(Array.Empty<byte>());
    }

    private void MessageHandle(string message)
    {
        var commonMessage = FiasCommonMessage.FromString(message);

        if (commonMessage.ToFiasMessageFromPmsObject() is object fiasMessage)
            _fias.MessageEventInvoke(fiasMessage);
        else
            _fias.UnknownTypeMessageEventInvoke(commonMessage);
    }

    private async Task SendAsync(string message)
    {
        if (message is null)
            throw new ArgumentException("The message was not sent because it is null.");

        if (_socket is null)
            throw new InvalidOperationException("The message was not sent because the connection to FIAS was not established.");

        await _socket.SendAsync(Encoding.Default.GetBytes(message));
    }

    private void ConnectToFias(Socket socket)
    {
        if (string.IsNullOrWhiteSpace(_fias.Hostname))
            throw new InvalidOperationException("Hostname is null or whitespace");

        if (_fias.Port < IPEndPoint.MinPort || _fias.Port > IPEndPoint.MaxPort)
            throw new InvalidOperationException($"Port {_fias.Port} out of range [{IPEndPoint.MinPort}..{IPEndPoint.MaxPort}]");

        var ipEndPoint = GetIPEndPointFromHostName(_fias.Hostname, _fias.Port);

        try
        {
            if (!socket.ConnectAsync(ipEndPoint).Wait(1000, _fias.CancellationToken))
                throw new InvalidOperationException($"The remote host {_fias.Hostname}:{_fias.Port} was not found.");
        }
        catch (OperationCanceledException)
        {
            throw new InvalidOperationException($"The remote host {_fias.Hostname}:{_fias.Port} was not found.");
        }
    }

    public static IPEndPoint GetIPEndPointFromHostName(string? hostName, int? port)
    {
        var addresses = Dns.GetHostAddresses(hostName ?? string.Empty);
        if (addresses.Length == 0)
            throw new ArgumentException("Unable to retrieve address from specified host name.", nameof(hostName));

        return new IPEndPoint(addresses[0], port ?? 0);
    }

    private static string FixHead(string message, StringBuilder stringBuilder)
        => message[0] != HEAD ? stringBuilder.Append(message.AsSpan(0, message.Length - 1)).ToString() : message[1..^1];
}

