namespace Bridge.Sanatorium.Handlers;

public class ReservationHandler(ISanatoriumService sanatoriumService, IEventBusService eventBusService) 
    : EventBus.EventHandler<ReservationUpdateInfo>(eventBusService)
{
    private readonly ISanatoriumService _sanatoriumService = sanatoriumService;

    protected override string HandlerName => "N_SERVICE_BUS";

    protected override async Task HandleAsync(ReservationUpdateInfo @in)
    {
        var message = new ReservationUpdatedMessage()
        {
            GenericNo = @in.GenericNo,
            Status = @in.Status,
            ArrivalDate = @in.ArrivalDate,
            DepartureDate = @in.DepartureDate,
            //CustomFieldValues = 
            ReservationGuests =
            [
                new()
                {
                    GenericNo = @in.GuestGenericNo,
                    Id = @in.Id,
                    FirstName = @in.FirstName,
                    LastName = @in.LastName,
                    MiddleName = @in.MiddleName,
                    Sex = @in.Sex,
                    BirthDate = @in.BirthDate,
                    CountryCode = @in.Address?.CountryCode,
                    Region = @in.Address?.Region,
                    City = @in.Address?.City,
                    Street = @in.Address?.Street,
                    //Notes = 
                    Phones = @in.Phones.Select(p => new GuestPhone
                    {
                        PhoneNumber = p.PhoneNumber,
                        PhoneType = p.PhoneType
                    }).ToArray(),
                    DocumentData = new DocumentData
                    {
                        DocumentTypeCode = @in.DocumentTypeCode,
                        //DocumentTypeName =
                        DocumentSeries = @in.DocumentSeries,
                        DocumentNumber = @in.DocumentNumber,
                        IssueDate = @in.IssueDate,
                        //ExpirationDate = 
                        DepartmentCode = @in.DepartmentCode,
                        IssuerInfo = @in.IssuerInfo
                    }
                }
            ],
            Timelines = @in.Timelines.Select(t => ToTimeline(t)).ToArray(),
            CurrentTimeline = ToTimeline(@in.CurrentTimeline)
        };

        await _sanatoriumService.PublishAsync(message);
    }

    private ReservationMessage.Timeline ToTimeline(TimelineInfo t) => new()
    {
        DateRange = new DateRange
        {
            DateTimeFrom = t.DateTimeFrom,
            DateTimeTo = t.DateTimeTo
        },
        EffectiveDate = t.EffectiveDate,
        StayPriceLocalCurrencyAmount = t.StayPriceLocalCurrencyAmount,
        RoomTypeCode = t.RoomTypeCode,
        RateName = t.RateName,
        RoomCode = t.RoomCode,
        Packages = t.Packages.Select(p => new Package
        {
            Code = p.Code,
            Amount = p.Amount,
            Count = p.Count,
            CurrencyCode = p.CurrencyCode
        }).ToArray()
    };
}
