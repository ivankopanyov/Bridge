namespace Bridge.Fias.Interface;

internal class FiasService : IFiasService
{
    #region Events

    public event FiasMessageHandle<FiasLinkStart>? FiasLinkStartEvent;
    public event FiasMessageHandle<FiasLinkAlive>? FiasLinkAliveEvent;
    public event FiasMessageHandle<FiasLinkEnd>? FiasLinkEndEvent;
    public event FiasMessageHandle<FiasMessageDelete>? FiasMessageDeleteEvent;
    public event FiasMessageHandle<FiasWakeupClear>? FiasWakeupClearEvent;
    public event FiasMessageHandle<FiasWakeupRequest>? FiasWakeupRequestEvent;
    public event FiasMessageHandle<FiasDatabaseResyncEnd>? FiasDatabaseResyncEndEvent;
    public event FiasMessageHandle<FiasDatabaseResyncStart>? FiasDatabaseResyncStartEvent;
    public event FiasMessageHandle<FiasGuestBillBalance>? FiasGuestBillBalanceEvent;
    public event FiasMessageHandle<FiasGuestBillItem>? FiasGuestBillItemEvent;
    public event FiasMessageHandle<FiasGuestChange>? FiasGuestChangeEvent;
    public event FiasMessageHandle<FiasGuestCheckIn>? FiasGuestCheckInEvent;
    public event FiasMessageHandle<FiasGuestCheckOut>? FiasGuestCheckOutEvent;
    public event FiasMessageHandle<FiasKeyDataChange>? FiasKeyDataChangeEvent;
    public event FiasMessageHandle<FiasKeyDelete>? FiasKeyDeleteEvent;
    public event FiasMessageHandle<FiasKeyReadResponse>? FiasKeyReadResponseEvent;
    public event FiasMessageHandle<FiasKeyRequest>? FiasKeyRequestEvent;
    public event FiasMessageHandle<FiasLinkConfiguration>? FiasLinkConfigurationEvent;
    public event FiasMessageHandle<FiasLocatorRetrieveResponse>? FiasLocatorRetrieveResponseEvent;
    public event FiasMessageHandle<FiasMessageText>? FiasMessageTextEvent;
    public event FiasMessageHandle<FiasMessageTextOnlineResponse>? FiasMessageTextOnlineResponseEvent;
    public event FiasMessageHandle<FiasNightAuditEnd>? FiasNightAuditEndEvent;
    public event FiasMessageHandle<FiasNightAuditStart>? FiasNightAuditStartEvent;
    public event FiasMessageHandle<FiasPostingAnswer>? FiasPostingAnswerEvent;
    public event FiasMessageHandle<FiasPostingList>? FiasPostingListEvent;
    public event FiasMessageHandle<FiasRemoteCheckOutResponse>? FiasRemoteCheckOutResponseEvent;
    public event FiasMessageHandle<FiasRoomEquipmentStatusResponse>? FiasRoomEquipmentStatusResponseEvent;
    public event FiasMessageHandle<FiasCommonMessage>? UnknownTypeMessageEvent;
    public event FiasMessageHandle<FiasCommonMessage>? FiasUnknownTypeMessageEvent;

    public event FiasSendMessageHandle? FiasSendMessageEvent;

    public event ChangeStateFiasHandle? ChangeStateEvent;

    #endregion

    private readonly IWritableOptions<FiasOptions> _writableFiasOptions;

    private string? _hostname = null;

    private int? _port = null;

    private bool _isActive = false;

    private Exception? _currentException = null;

    private CancellationTokenSource _cancellationTokenSource;

    private CancellationToken _cancellationToken;

    public string? Hostname => _hostname;

    public int? Port => _port;

    public bool IsActive => _isActive;

    public Exception? CurrentException => _currentException;

    public CancellationToken CancellationToken => _cancellationToken;

    public FiasService(IWritableOptions<FiasOptions> writableFiasOptions)
    {
        _writableFiasOptions = writableFiasOptions;

        var optionsValue = writableFiasOptions?.Value;
        _hostname = optionsValue?.Host;
        _port = optionsValue?.Port;

        RefreshCancellationToken();
    }

    public void RefreshCancellationToken()
    {
        _cancellationTokenSource = new CancellationTokenSource();
        _cancellationToken = _cancellationTokenSource.Token;
    }

    public void Send(string message) => FiasSendMessageEvent?.Invoke(message);

    public void MessageEventInvoke(object message)
    {
        var type = message.GetType();

        if (type == typeof(FiasLinkEnd))
        {
            FiasLinkEndEvent?.Invoke((FiasLinkEnd)message);
            _cancellationTokenSource.Cancel();
        }
        else if (type == typeof(FiasLinkStart))
            FiasLinkStartEvent?.Invoke((FiasLinkStart)message);
        else if (type == typeof(FiasLinkAlive))
            FiasLinkAliveEvent?.Invoke((FiasLinkAlive)message);
        else if (type == typeof(FiasLinkEnd))
            FiasLinkEndEvent?.Invoke((FiasLinkEnd)message);
        else if (type == typeof(FiasMessageDelete))
            FiasMessageDeleteEvent?.Invoke((FiasMessageDelete)message);
        else if (type == typeof(FiasWakeupClear))
            FiasWakeupClearEvent?.Invoke((FiasWakeupClear)message);
        else if (type == typeof(FiasWakeupRequest))
            FiasWakeupRequestEvent?.Invoke((FiasWakeupRequest)message);
        else if (type == typeof(FiasDatabaseResyncEnd))
            FiasDatabaseResyncEndEvent?.Invoke((FiasDatabaseResyncEnd)message);
        else if (type == typeof(FiasDatabaseResyncStart))
            FiasDatabaseResyncStartEvent?.Invoke((FiasDatabaseResyncStart)message);
        else if (type == typeof(FiasGuestBillBalance))
            FiasGuestBillBalanceEvent?.Invoke((FiasGuestBillBalance)message);
        else if (type == typeof(FiasGuestBillItem))
            FiasGuestBillItemEvent?.Invoke((FiasGuestBillItem)message);
        else if (type == typeof(FiasGuestChange))
            FiasGuestChangeEvent?.Invoke((FiasGuestChange)message);
        else if (type == typeof(FiasGuestCheckIn))
            FiasGuestCheckInEvent?.Invoke((FiasGuestCheckIn)message);
        else if (type == typeof(FiasGuestCheckOut))
            FiasGuestCheckOutEvent?.Invoke((FiasGuestCheckOut)message);
        else if (type == typeof(FiasKeyDataChange))
            FiasKeyDataChangeEvent?.Invoke((FiasKeyDataChange)message);
        else if (type == typeof(FiasKeyDelete))
            FiasKeyDeleteEvent?.Invoke((FiasKeyDelete)message);
        else if (type == typeof(FiasKeyReadResponse))
            FiasKeyReadResponseEvent?.Invoke((FiasKeyReadResponse)message);
        else if (type == typeof(FiasKeyRequest))
            FiasKeyRequestEvent?.Invoke((FiasKeyRequest)message);
        else if (type == typeof(FiasLinkConfiguration))
            FiasLinkConfigurationEvent?.Invoke((FiasLinkConfiguration)message);
        else if (type == typeof(FiasLocatorRetrieveResponse))
            FiasLocatorRetrieveResponseEvent?.Invoke((FiasLocatorRetrieveResponse)message);
        else if (type == typeof(FiasMessageText))
            FiasMessageTextEvent?.Invoke((FiasMessageText)message);
        else if (type == typeof(FiasMessageTextOnlineResponse))
            FiasMessageTextOnlineResponseEvent?.Invoke((FiasMessageTextOnlineResponse)message);
        else if (type == typeof(FiasNightAuditEnd))
            FiasNightAuditEndEvent?.Invoke((FiasNightAuditEnd)message);
        else if (type == typeof(FiasNightAuditStart))
            FiasNightAuditStartEvent?.Invoke((FiasNightAuditStart)message);
        else if (type == typeof(FiasPostingAnswer))
            FiasPostingAnswerEvent?.Invoke((FiasPostingAnswer)message);
        else if (type == typeof(FiasPostingList))
            FiasPostingListEvent?.Invoke((FiasPostingList)message);
        else if (type == typeof(FiasRemoteCheckOutResponse))
            FiasRemoteCheckOutResponseEvent?.Invoke((FiasRemoteCheckOutResponse)message);
        else if (type == typeof(FiasRoomEquipmentStatusResponse))
            FiasRoomEquipmentStatusResponseEvent?.Invoke((FiasRoomEquipmentStatusResponse)message);
    }

    public void UnknownTypeMessageEventInvoke(FiasCommonMessage message) =>
        UnknownTypeMessageEvent?.Invoke(message);

    public void SetFiasOptions(FiasOptions? options)
    {
        if (((_hostname == null && options?.Host == null)
            || (_hostname != null && options?.Host != null && _hostname == options?.Host))
            && ((_port == null && options?.Port == null)
            || (_port != null && options?.Port != null && _port == options?.Port)))
            return;

        _writableFiasOptions.Update(opt =>
        {
            opt.Host = options?.Host;
            opt.Port = options?.Port;
        });

        _hostname = options?.Host;
        _port = options?.Port;
        _cancellationTokenSource.Cancel();
    }

    public void Restart() => _cancellationTokenSource.Cancel();

    public void Active()
    {
        if (_isActive)
            return;

        _isActive = true;
        _currentException = null;
        ChangeStateEvent?.Invoke(true, null);
    }

    public void Unactive(Exception ex)
    {
        if (!_isActive && _currentException != null && ex?.Message == _currentException.Message)
            return;

        _isActive = false;
        _currentException = ex;
        ChangeStateEvent?.Invoke(false, ex);
    }
}