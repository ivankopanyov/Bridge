namespace Bridge.Opera.Handlers;

public class ReservationHandler(IOperaService operaService, IEventBusService eventBusService)
    : EventHandler<ReservationInfo, ReservationUpdateInfo>(eventBusService)
{
    private static readonly IReadOnlyDictionary<string, string> _sexAliases = new Dictionary<string, string>()
    {
        { "1", "M" }, 
        { "2", "F" } 
    };

    private readonly IOperaService _operaService = operaService;

    protected override string HandlerName => "OPERA_DB";

    protected override async Task<ReservationUpdateInfo> HandleAsync(ReservationInfo @in, string? taskId)
    {
        if (await _operaService.GetReservationUpdateInfo(@in) is not ReservationUpdateInfo reservationResponse)
            return null!;

        var nameInfo = await _operaService.GetNameData(reservationResponse.Id);

        reservationResponse.Sex = FixSex(reservationResponse.Sex);
        reservationResponse.BirthDate = ToDateTime(nameInfo?.BirthDay, "dd.MM.yyyy");
        reservationResponse.DocumentTypeCode = _operaService.FixDocumentTypeCode(reservationResponse.DocumentTypeCode);
        reservationResponse.DocumentNumber = nameInfo?.PassId;

        if (reservationResponse.TruncBeginDate != reservationResponse.TruncEndDate)
            reservationResponse.Timelines = reservationResponse.Timelines
                    .Where(t => t.DateTimeFrom != reservationResponse.TruncEndDate)
                    .ToHashSet();

        if (!reservationResponse.Timelines.Any())
        {
            var timeline = new TimelineInfo
            {
                DateTimeFrom = @in.ArrivalDate ?? default,
                DateTimeTo = @in.DepartureDate ?? default,
                EffectiveDate = @in.ArrivalDate,
                RoomCode = @in.Room
            };

            reservationResponse.Timelines = new HashSet<TimelineInfo>() { timeline };
            reservationResponse.CurrentTimeline = timeline;
        }
        else
            reservationResponse.CurrentTimeline = reservationResponse.Timelines
                .FirstOrDefault(t => reservationResponse.BusinnesDate != null && t.DateTimeFrom == reservationResponse.BusinnesDate)
                   ?? reservationResponse.Timelines.First();

        return reservationResponse;
    }

    private static string? FixSex(string? value)
    {
        if (value == null)
            return null;

        foreach (var alias in _sexAliases)
            if (value == alias.Key)
                return alias.Value;

        return value;
    }

    private static DateTime? ToDateTime(string? value, string format) 
        => value == null || !DateTime.TryParseExact(value, format, null, System.Globalization.DateTimeStyles.None, out DateTime issue)
            ? null : issue;
}
