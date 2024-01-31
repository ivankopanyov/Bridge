namespace Bridge.Opera.Handlers;

public class ReservationHandler(IOperaService operaService, IEventBusService eventBusService,
    ILogger<ReservationHandler> logger) : EventHandler<ReservationInfo, ReservationUpdatedMessage>(eventBusService, logger)
{
    private const string NAME_DATA_QUERY = "select hrs_dev.hrs_sh_sens.dob(n.name_id) as BIRTHDAY, " +
        "hrs_dev.hrs_sh_sens.pass_id(n.name_id) as PASS_ID from opera.name n where rownum <= 1 and n.name_id = {0}";

    private static readonly IReadOnlyDictionary<string, string> _sexAliases = new Dictionary<string, string>()
    {
        { "1", "M" }, 
        { "2", "F" } 
    };

    private readonly IOperaService _operaService = operaService;

    protected override string HandlerName => "OPERA_DB";

    protected override async Task<ReservationUpdatedMessage> HandleAsync(ReservationInfo @in)
    {
        try
        {
            using var context = new OperaDbContext();
            var trxCodes = _operaService.TrxCodes;

            var reservationResponse = await (from rn in context.ReservationNames
                                             from n in context.Names
                                             where rn.Resort == @in.Resort && rn.ResvNameId == @in.Id && n.NameId == rn.NameId
                                             select new
                                             {
                                                 Id = n.NameId,
                                                 LastName = Trim(n.XlastName ?? n.Last),
                                                 FirstName = Trim(n.XfirstName ?? n.First),
                                                 MiddleName = Trim(n.XmiddleName ?? n.Middle),
                                                 Sex = n.Gender,
                                                 //BirthDate =
                                                 //Notes =
                                                 rn.TruncBeginDate,
                                                 rn.TruncEndDate,
                                                 DocumentTypeCode = (from nd in context.NameDocuments
                                                                     where nd.PrimaryYn == "Y" && nd.NameId == n.NameId
                                                                     select nd.IdType).AsNoTracking().FirstOrDefault(),
                                                 //DocumentTypeName =
                                                 //DocumentNumber = 
                                                 DocumentSeries = n.Udfc01,
                                                 DepartmentCode = n.Udfc03,
                                                 IssueDate = ToDateTime(n.Udfc02, "dd.MM.yy"),
                                                 //ExpirationDate = 
                                                 //RegistrationDate = 
                                                 IssuerInfo = Trim(n.Udfc04),
                                                 Timelines = (from rden in context.ReservationDailyElementNames
                                                              from rde in context.ReservationDailyElements
                                                              where rden.Resort == rn.Resort && rden.ResvNameId == rn.ResvNameId &&
                                                                  rde.Resort == rden.Resort && rde.ResvDailyElSeq == rden.ResvDailyElSeq &&
                                                                  rde.ReservationDate == rden.ReservationDate
                                                              select new ReservationMessage.Timeline
                                                              {
                                                                  DateRange = new DateRange
                                                                  {
                                                                      DateTimeFrom = rden.ReservationDate ?? default,
                                                                      DateTimeTo = (rden.ReservationDate ?? default).AddDays(1).AddTicks(-1)
                                                                  },
                                                                  EffectiveDate = rden.ReservationDate,
                                                                  StayPriceLocalCurrencyAmount = CalcShareAmount(rden.ShareAmount, rden.SharePrcnt),
                                                                  RoomTypeCode = (from rrc in context.ResortRoomCategories
                                                                                  where rrc.Resort == rde.Resort && rrc.RoomCategory == rde.RoomCategory
                                                                                  select rrc.Label).AsNoTracking().FirstOrDefault(),
                                                                  RateName = rden.RateCode,
                                                                  RoomCode = rde.Room,
                                                                  Packages = (from rp in context.ReservationProducts
                                                                              from rpp in context.ReservationProductPrices
                                                                              from ppr in context.ProductPostingRules
                                                                              where rp.Resort == rden.Resort && rp.ResvNameId == rden.ResvNameId &&
                                                                                  rpp.Resort == rp.Resort && rpp.ReservationDate == rden.ReservationDate &&
                                                                                  rpp.ReservationProductId == rp.ReservationProductId && ppr.Resort == rpp.Resort &&
                                                                                  ppr.Product == rp.ProductId && (trxCodes == null || trxCodes.Count == 0 || trxCodes.Contains(ppr.TrxCode))
                                                                              select new Package
                                                                              {
                                                                                  Code = rp.ProductId,
                                                                                  Amount = rpp.Price ?? default,
                                                                                  Count = (int?)rpp.Quantity,
                                                                                  CurrencyCode = rp.CurrencyCode
                                                                              }).AsNoTracking().ToArray()
                                                              }).AsNoTracking().ToArray(),
                                                 BusinnesDate = (from b in context.Businessdates
                                                                 where b.Resort == rn.Resort && b.State == "OPEN"
                                                                 select b.BusinessDate1).FirstOrDefault(),
                                                 Address = (from na in context.NameAddresses
                                                            from c in context.Countries
                                                            where na.NameId == n.NameId && na.PrimaryYn == "Y" && na.InactiveDate == null && c.CountryCode == na.Country
                                                            select new
                                                            {
                                                                CountryCode = c.IsoCode,
                                                                Region = Trim(na.State),
                                                                City = Trim(na.City),
                                                                Street = JoinAddress(na.Address1, na.Address2, na.Address3, na.Address4),
                                                            }).AsNoTracking().FirstOrDefault(),
                                                 Phones = (from np in context.NamePhones
                                                           where np.NameId == n.NameId
                                                           select new GuestPhone
                                                           {
                                                               PhoneNumber = np.PhoneNumber,
                                                               PhoneType = np.PhoneType
                                                           }).AsNoTracking().ToArray()
                                             }).AsNoTracking().FirstOrDefaultAsync();

            if (reservationResponse == null)
                return null!;

            var nameInfo = await context.NameData
                .FromSqlRaw(string.Format(NAME_DATA_QUERY, reservationResponse.Id))
                .FirstOrDefaultAsync();

            var reservationId = @in.Id.ToString("0");
            var guestId = reservationResponse.Id?.ToString("0");

            var reservationUpdatedMessage = new ReservationUpdatedMessage
            {
                GenericNo = reservationId,
                Status = @in.Status,
                ArrivalDate = @in.ArrivalDate ?? default,
                DepartureDate = @in.DepartureDate ?? default,
                //CustomFieldValues = 
                ReservationGuests =
                [
                        new()
                        {
                            GenericNo = guestId,
                            Id = $"{guestId}/{reservationId}",
                            FirstName = reservationResponse?.FirstName,
                            LastName = reservationResponse?.LastName,
                            MiddleName = reservationResponse?.MiddleName,
                            Sex = FixSex(reservationResponse?.Sex),
                            BirthDate = ToDateTime(nameInfo?.BirthDay, "dd.MM.yyyy"),
                            CountryCode = reservationResponse?.Address?.CountryCode,
                            Region = reservationResponse?.Address?.Region,
                            City = reservationResponse?.Address?.City,
                            Street = reservationResponse?.Address?.Street,
                            //Notes = 
                            Phones = reservationResponse?.Phones,
                            DocumentData = new DocumentData
                            {
                                DocumentTypeCode = FixDocumentTypeCode(reservationResponse?.DocumentTypeCode),
                                //DocumentTypeName =
                                DocumentSeries = reservationResponse?.DocumentSeries,
                                DocumentNumber = nameInfo?.PassId,
                                IssueDate = reservationResponse?.IssueDate,
                                //ExpirationDate = 
                                DepartmentCode = reservationResponse?.DepartmentCode,
                                IssuerInfo = reservationResponse?.IssuerInfo
                            }
                        }
                ],
                Timelines = reservationResponse.TruncBeginDate == reservationResponse?.TruncEndDate
                    ? reservationResponse?.Timelines
                    : reservationResponse?.Timelines
                        .Where(t => t.DateRange.DateTimeFrom != reservationResponse?.TruncEndDate)
                        .ToArray()
            };

            if (reservationResponse.Timelines.Length == 0)
            {
                reservationUpdatedMessage.Timelines =
                [
                        new ()
                        {
                            DateRange = new DateRange
                            {
                                DateTimeFrom = @in.ArrivalDate ?? default,
                                DateTimeTo = @in.DepartureDate ?? default,
                            },
                            EffectiveDate = @in.ArrivalDate,
                            RoomCode = @in.Room
                        }
                ];

                reservationUpdatedMessage.CurrentTimeline = reservationUpdatedMessage.Timelines[0];
            }

            reservationUpdatedMessage.CurrentTimeline = reservationUpdatedMessage.Timelines
                .FirstOrDefault(t => reservationResponse.BusinnesDate != null && t.DateRange.DateTimeFrom == reservationResponse.BusinnesDate)
                ?? reservationUpdatedMessage.Timelines[0];

            _operaService.Active();
            return reservationUpdatedMessage;
        }
        catch (Exception ex)
        {
            _operaService.Unactive(ex);
            throw;
        }
    }

    private static string? Trim(string value) => value?.Trim();

    private static string FixSex(string value)
    {
        foreach (var alias in _sexAliases)
            if (value == alias.Key)
                return alias.Value;

        return value;
    }

    private static decimal CalcShareAmount(decimal? shareAmount, decimal? sharePrcnt) => (shareAmount ?? 0) * (sharePrcnt ?? 100) / 100;

    private static string? JoinAddress(params string[] addresses)
    {
        if (addresses == null)
            return null;

        var result = new List<string>(addresses.Length);

        foreach (var address in addresses)
        {
            var temp = address?.Trim();
            if (!string.IsNullOrEmpty(temp))
                result.Add(temp);
        }

        return string.Join(", ", result);
    }

    private string FixDocumentTypeCode(string value)
    {
        if (_operaService.DocumentTypeAliases == null || _operaService.DocumentTypeAliases.Count == 0)
            return value;

        foreach (var alias in _operaService.DocumentTypeAliases)
            if (value == alias.Key)
                return alias.Value;

        return value;
    }

    private static DateTime? ToDateTime(string value, string format) 
        => value == null || !DateTime.TryParseExact(value, format, null, System.Globalization.DateTimeStyles.None, out DateTime issue)
            ? null : issue;

    protected override string InputLog(ReservationInfo @in) =>
        $"RESERVATION INFO: {@in.Status ?? "*STATUS*"}  {string.Format("{0:0}", @in.Id)}  {@in.Room ?? "*ROOM*"}  {@in.ArrivalDate?.ToString("dd.MM.yyyy") ?? "*ARRIVAL*"} - {@in.DepartureDate?.ToString("dd.MM.yyyy") ?? "*DEPARTURE*"}";

    protected override string OutputLog(ReservationUpdatedMessage @out)
    {
        var log = $"RESERVATION UPDATE MESSAGE: {@out.GenericNo ?? "*GENERIC NO*"}  {@out.Status ?? "*STATUS*"}  {@out.ArrivalDate:dd.MM.yyyy} - {@out.DepartureDate:dd.MM.yyyy}";

        if (@out.ReservationGuests != null && @out.ReservationGuests.Length > 0 && @out.ReservationGuests[0] != null)
        {
            var guest = @out.ReservationGuests[0];
            log += $"\n\tGUEST: {guest.GenericNo ?? "GENERIC NO"}  {guest.LastName ?? "*LASTNAME*"} {guest.FirstName ?? "*FIRSTNAME*"} {guest.MiddleName ?? "*MIDDLENAME*"}  {guest.Sex ?? "*SEX*"}";
            log += $"\n\t{guest.BirthDate?.ToString("dd.MM.yyyy") ?? "*BIRTHDAY*"}  {guest.CountryCode ?? "*COUNTRYCODE*"}, {guest.Region ?? "*REGION*"}, {guest.City ?? "*CITY*"}, {guest.Street ?? "*STREET*"}";

            if (guest.DocumentData != null)
            {
                var document = guest.DocumentData;
                log += $"\n\tDOCUMENT: {document.DocumentTypeCode ?? "*TYPECODE*"}  {document.DocumentSeries ?? "*SERIES*"} {document.DocumentNumber ?? "*NUMBER*"}";
                log += $"\n\t{document.IssueDate?.ToString("dd.MM.yyyy") ?? "*ISSUEDATE*"}  {document.DepartmentCode ?? "*DEPARTMENT*"}  {document.IssuerInfo ?? "*ISSUERINFO*"}";
            }

            var timelines = @out.Timelines?.Where(t => t != null);

            if (timelines != null && timelines.Any())
            {
                log += $"\n\tTIMELINES:";

                foreach (var timeline in timelines)
                {
                    log += $"\n\t\t{timeline.DateRange?.DateTimeFrom.ToString("dd.MM.yyyy") ?? "*FROM*"} - {timeline.DateRange?.DateTimeTo.ToString("dd.MM.yyyy") ?? "*TO*"}";
                    log += $"\n\t{timeline.RateName ?? "*RATECODE*"}  {timeline.RoomTypeCode ?? "*ROOMTYPE*"}  {timeline.RoomCode ?? "*ROOM*"}  {timeline.StayPriceLocalCurrencyAmount}";

                    var packages = timeline.Packages?.Where(p => p != null);

                    if (packages != null && packages.Any())
                    {
                        log += $"\n\t\tPACKAGES:";

                        foreach (var package in packages)
                            log += $"\n\t\t\t{package.Code ?? "*CODE*"}  {package.Amount} {package.CurrencyCode ?? "*CURRENCYCODE*"}  {package.Count?.ToString() ?? "*COUNT*"}";
                    }
                }
            }

            var phones = guest.Phones?.Where(t => t != null);

            if (phones != null && phones.Any())
                log += $"\n\tPHONES: {string.Join(", ", phones.Where(p => p != null).Select(p => $"{p.PhoneNumber ?? "*NUMBER*"} ({p.PhoneType ?? "*TYPE*"})"))}";
        }

        return log;
    }
}
