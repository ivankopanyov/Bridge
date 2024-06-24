namespace Bridge.Sanatorium.Handlers;

public class ReservationHandler(ISanatoriumService sanatoriumService) : Handler<ReservationUpdateInfo>()
{
    protected override async Task HandleAsync(ReservationUpdateInfo @in, IEventContext context)
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

        await sanatoriumService.Exec<Task>(endpoint => endpoint.Publish(message));
    }

    private static ReservationMessage.Timeline ToTimeline(TimelineInfo t) => new()
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

    protected override string? Message(ReservationUpdateInfo @in)
    {
        var result = $"GenericNo: {@in.GenericNo}, Id: {@in.Id}";
        var name = string.Join(' ', @in.LastName, @in.FirstName, @in.MiddleName);

        if (!string.IsNullOrWhiteSpace(name))
            result += $", {name}";

        return result;
    }
}
