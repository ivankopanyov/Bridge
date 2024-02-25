namespace Bridge.Opera.Services;

public interface IOperaService : IOptinable
{
    Task<ReservationUpdateInfo?> GetReservationUpdateInfo(ReservationInfo reservationInfo);

    Task<NameData?> GetNameData(string reservationId);

    string? FixDocumentTypeCode(string? value);
}
