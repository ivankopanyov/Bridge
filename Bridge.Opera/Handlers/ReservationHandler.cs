namespace Bridge.Opera.Handlers;

public class ReservationHandler : EventHandler<ReservationInfo, ReservationUpdatedInfo>
{
    private const string NAME_DATA_QUERY = "select hrs_dev.hrs_sh_sens.dob(n.name_id) as BIRTHDAY, " +
        "hrs_dev.hrs_sh_sens.pass_id(n.name_id) as PASS_ID from opera.name n where rownum <= 1 and n.name_id = {0}";

    private static readonly string[] _trxCodes = ["4324"];

    private static readonly IReadOnlyDictionary<string, string> _sexAliases =
        new Dictionary<string, string>() { { "1", "M" }, { "2", "F" } };

    private static readonly IReadOnlyDictionary<string, string> _documentTypeAliases =
        new Dictionary<string, string>() { { "PASSPORT", "103008" } };

    private readonly IOperaService _operaService;

    public ReservationHandler(IOperaService operaService, IEventBusService eventBusService,
        ILogger<ReservationHandler> logger) : base(eventBusService, logger)
    {
        _operaService = operaService;
    }

    protected override async Task<ReservationUpdatedInfo> HandleAsync(ReservationInfo @in)
    {
        using var context = new OperaDbContext();

        try
        {
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
                                                 TruncBeginDate = rn.TruncBeginDate,
                                                 TruncEndDate = rn.TruncEndDate,
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
                                                              select new
                                                              {
                                                                  DateRange = new
                                                                  {
                                                                      DateTimeFrom = rden.ReservationDate,
                                                                      DateTimeTo = rden.ReservationDate
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
                                                                                  ppr.Product == rp.ProductId && (_trxCodes == null || _trxCodes.Length == 0 || _trxCodes.Contains(ppr.TrxCode))
                                                                              select new
                                                                              {
                                                                                  Code = rp.ProductId,
                                                                                  Amount = rpp.Price,
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
                                                           select new
                                                           {
                                                               PhoneNumber = np.PhoneNumber,
                                                               PhoneType = np.PhoneType
                                                           }).AsNoTracking().ToArray()
                                             }).AsNoTracking().FirstOrDefaultAsync();

            _operaService.Active();
            return new();
        }
        catch (Exception ex)
        {
            _operaService.Unactive(ex);
            throw;
        }
    }

    private static string Trim(string value) => value?.Trim();

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

    private static DateTime? ToDateTime(string value, string format)
    {
        if (value == null || !DateTime.TryParseExact(value, format, null, System.Globalization.DateTimeStyles.None, out DateTime issue))
            return null;

        return issue;
    }

    protected override string InputLog(ReservationInfo @in) =>
        $"RESERVATION INFO: {@in.Status ?? "*STATUS*"}  {string.Format("{0:0}", @in.Id)}  {@in.Room ?? "*ROOM*"}  {@in.ArrivalDate?.ToString("dd.MM.yyyy") ?? "*ARRIVAL*"} - {@in.DepartureDate?.ToString("dd.MM.yyyy") ?? "*DEPARTURE*"}";
}
