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
        while (true)
            await Task.Run(ConnectAsync, stoppingToken);
    }
    
    private async Task ConnectAsync()
    {
        if (_fias.CancellationToken.IsCancellationRequested)
        {
            _fias.RefreshCancellationToken();
            await Task.Delay(6000);
        }

        if (_fias.CancellationToken.IsCancellationRequested)
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

        if (_fias.CancellationToken.IsCancellationRequested)
        {
            _fias.Unactive(new OperationCanceledException("Restarting the connection."));
            return;
        }

        _fias.Active();

        StringBuilder stringBuilder = new();

        try
        {
            _socket = socket;
            while (true)
            {
                if (!socket.Connected)
                {
                    _socket = null;
                    _fias.Unactive(new InvalidOperationException());
                    return;
                }

                await Task.Run(async () => await ReadAsync(socket, stringBuilder));

                if (_fias.CancellationToken.IsCancellationRequested)
                {
                    _fias.Unactive(new OperationCanceledException("Restarting the connection."));
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            _socket = null;
            _fias.Unactive(ex);
        }
    }

    private async Task ReadAsync(Socket socket, StringBuilder stringBuilder)
    {
        ArraySegment<byte> buffer = new(new byte[8192]);
        var size = await socket.ReceiveAsync(buffer, SocketFlags.None);

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
    }

    private void MessageHandle(string message)
    {
        var commonMessage = FiasCommonMessage.FromString(message);

        if (commonMessage.ToFiasMessageFromPmsObject() is object fiasMessage)
            _fias.MessageEventInvoke(fiasMessage);
        else
            _fias.UnknownTypeMessageEventInvoke(commonMessage);
    }

    private Task SendAsync(string message)
    {
        if (message is null)
            throw new ArgumentException("The message was not sent because it is null.");

        if (_socket is null)
            throw new InvalidOperationException("The message was not sent because the connection to FIAS was not established.");

        var buffer = Encoding.Default.GetBytes(message);
        _socket.SendAsync(new ArraySegment<byte>(buffer), SocketFlags.None);
        return Task.CompletedTask;
    }

    private void ConnectToFias(Socket socket)
    {
        if (string.IsNullOrWhiteSpace(_fias.Hostname))
            throw new InvalidOperationException("Hostname is null or whitespace");

        if (_fias.Port < IPEndPoint.MinPort || _fias.Port > IPEndPoint.MaxPort)
            throw new InvalidOperationException($"Port {_fias.Port} out of range [{IPEndPoint.MinPort}..{IPEndPoint.MaxPort}]");

        var ipEndPoint = GetIPEndPointFromHostName(_fias.Hostname, _fias.Port);
        if (!socket.ConnectAsync(ipEndPoint).Wait(1000, _fias.CancellationToken))
            throw new InvalidOperationException($"The remote host {_fias.Hostname}:{_fias.Port} was not found.");
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
