namespace Bridge.Fias.Services;

public interface IFias : IOptinable
{
    event FiasMessageHandle<FiasLinkStart>? FiasLinkStartEvent;
    event FiasMessageHandle<FiasLinkAlive>? FiasLinkAliveEvent;
    event FiasMessageHandle<FiasLinkEnd>? FiasLinkEndEvent;
    event FiasMessageHandle<FiasGuestChange>? FiasGuestChangeEvent;
    event FiasMessageHandle<FiasGuestCheckIn>? FiasGuestCheckInEvent;
    event FiasMessageHandle<FiasGuestCheckOut>? FiasGuestCheckOutEvent;
    event FiasMessageHandle<FiasLinkConfiguration>? FiasLinkConfigurationEvent;
    event FiasMessageHandle<FiasPostingAnswer>? FiasPostingAnswerEvent;
    event FiasMessageHandle<FiasPostingList>? FiasPostingListEvent;

    IDictionary<string, bool> TaxCodes { get; }

    void Send(string message);
}
