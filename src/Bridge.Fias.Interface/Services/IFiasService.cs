namespace Bridge.Fias.Interface;

public delegate Task FiasMessageHandle<T>(T message);

public delegate Task FiasSendMessageHandle(string message);

public delegate Task ChangeStateFiasHandle(bool isActive, Exception? ex);

public interface IFiasService
{
    event FiasMessageHandle<FiasLinkStart>? FiasLinkStartEvent;
    event FiasMessageHandle<FiasLinkAlive>? FiasLinkAliveEvent;
    event FiasMessageHandle<FiasLinkEnd>? FiasLinkEndEvent;
    event FiasMessageHandle<FiasMessageDelete>? FiasMessageDeleteEvent;
    event FiasMessageHandle<FiasWakeupClear>? FiasWakeupClearEvent;
    event FiasMessageHandle<FiasWakeupRequest>? FiasWakeupRequestEvent;
    event FiasMessageHandle<FiasDatabaseResyncEnd>? FiasDatabaseResyncEndEvent;
    event FiasMessageHandle<FiasDatabaseResyncStart>? FiasDatabaseResyncStartEvent;
    event FiasMessageHandle<FiasGuestBillBalance>? FiasGuestBillBalanceEvent;
    event FiasMessageHandle<FiasGuestBillItem>? FiasGuestBillItemEvent;
    event FiasMessageHandle<FiasGuestChange>? FiasGuestChangeEvent;
    event FiasMessageHandle<FiasGuestCheckIn>? FiasGuestCheckInEvent;
    event FiasMessageHandle<FiasGuestCheckOut>? FiasGuestCheckOutEvent;
    event FiasMessageHandle<FiasKeyDataChange>? FiasKeyDataChangeEvent;
    event FiasMessageHandle<FiasKeyDelete>? FiasKeyDeleteEvent;
    event FiasMessageHandle<FiasKeyReadResponse>? FiasKeyReadResponseEvent;
    event FiasMessageHandle<FiasKeyRequest>? FiasKeyRequestEvent;
    event FiasMessageHandle<FiasLinkConfiguration>? FiasLinkConfigurationEvent;
    event FiasMessageHandle<FiasLocatorRetrieveResponse>? FiasLocatorRetrieveResponseEvent;
    event FiasMessageHandle<FiasMessageText>? FiasMessageTextEvent;
    event FiasMessageHandle<FiasMessageTextOnlineResponse>? FiasMessageTextOnlineResponseEvent;
    event FiasMessageHandle<FiasNightAuditEnd>? FiasNightAuditEndEvent;
    event FiasMessageHandle<FiasNightAuditStart>? FiasNightAuditStartEvent;
    event FiasMessageHandle<FiasPostingAnswer>? FiasPostingAnswerEvent;
    event FiasMessageHandle<FiasPostingList>? FiasPostingListEvent;
    event FiasMessageHandle<FiasRemoteCheckOutResponse>? FiasRemoteCheckOutResponseEvent;
    event FiasMessageHandle<FiasRoomEquipmentStatusResponse>? FiasRoomEquipmentStatusResponseEvent;
    event FiasMessageHandle<FiasCommonMessage>? FiasUnknownTypeMessageEvent;

    event FiasSendMessageHandle? FiasSendMessageEvent;

    event ChangeStateFiasHandle? ChangeStateEvent;

    string? Hostname { get; }

    int? Port { get; }

    bool IsActive { get; }

    Exception? CurrentException { get; }

    internal CancellationToken CancellationToken { get; }

    void Send(string message);

    void SetFiasOptions(FiasOptions? options);

    void Restart();

    internal void RefreshCancellationToken();

    internal void MessageEventInvoke(object message);

    internal void UnknownTypeMessageEventInvoke(FiasCommonMessage message);

    internal void Active();

    internal void Unactive(Exception ex);
}

