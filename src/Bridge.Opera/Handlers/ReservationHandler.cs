namespace Bridge.Opera.Handlers;

public class ReservationHandler(IOperaService operaService) : Handler<ReservationInfo>
{
    private const string NAME_DATA_QUERY = "select hrs_dev.hrs_sh_sens.dob(n.name_id) as BIRTHDAY, " +
        "hrs_dev.hrs_sh_sens.pass_id(n.name_id) as PASS_ID from opera.name n where rownum <= 1 and n.name_id = {0}";

    private static readonly IReadOnlyDictionary<string, string> _sexAliases = new Dictionary<string, string>()
    {
        { "1", "M" }, 
        { "2", "F" } 
    };

    protected override async Task HandleAsync(ReservationInfo @in, IEventContext context)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(operaService.Environment.ResortCode, nameof(operaService.Environment.ResortCode));

        if (await GetReservtionUpdateInfo(@in) is ReservationUpdateInfo reservationResponse)
        {
            var nameInfo = await operaService.Exec<Task<NameData?>>(async context => await context.NameData
                .FromSqlRaw(string.Format(NAME_DATA_QUERY, reservationResponse.Id))
                .FirstOrDefaultAsync());

            reservationResponse.Sex = FixSex(reservationResponse.Sex);
            reservationResponse.BirthDate = ToDateTime(nameInfo?.BirthDay, "dd.MM.yyyy");
            reservationResponse.DocumentTypeCode = FixDocumentTypeCode(reservationResponse.DocumentTypeCode);
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

            context.Send(reservationResponse);
        }
		else
			context.Break("Reservation not found.");
    }

    private async Task<ReservationUpdateInfo?> GetReservtionUpdateInfo(ReservationInfo @in) => await operaService.Exec<Task<ReservationUpdateInfo?>>(async context =>
            await (from rn in context.ReservationNames
                   from n in context.Names
                   where rn.Resort == operaService.Environment.ResortCode && rn.ResvNameId == @in.ReservationNumber && n.NameId == rn.NameId
                   select new ReservationUpdateInfo
                   {
                       GenericNo = @in.ReservationNumber.ToString("0"),
                       Status = @in.Status,
                       ArrivalDate = @in.ArrivalDate ?? default,
                       DepartureDate = @in.DepartureDate ?? default,
                       //CustomFieldValues = 
                       GuestGenericNo = $"{n.NameId:0}",
                       Id = $"{n.NameId:0}/{@in.ReservationNumber:0}",
                       FirstName = Trim(n.XfirstName ?? n.First),
                       LastName = Trim(n.XlastName ?? n.Last),
                       MiddleName = Trim(n.XmiddleName ?? n.Middle),
                       Sex = n.Gender,
                       BirthDateStr = string.Empty,
                       BirthDate = DateTime.Now,
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
                                    select new TimelineInfo
                                    {
                                        DateTimeFrom = rden.ReservationDate ?? default,
                                        DateTimeTo = (rden.ReservationDate ?? default).AddDays(1).AddTicks(-1),
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
                                        ppr.Product == rp.ProductId && (operaService.Environment.TrxCodes.Count == 0 || (ppr.TrxCode != null && operaService.Environment.TrxCodes.Contains(ppr.TrxCode)))
                                                    select new PackageInfo
                                                    {
                                                        Code = rp.ProductId,
                                                        Amount = rpp.Price ?? default,
                                                        Count = (int?)rpp.Quantity,
                                                        CurrencyCode = rp.CurrencyCode
                                                    }).AsNoTracking().ToHashSet()
                                    }).AsNoTracking().ToHashSet(),
                       BusinnesDate = (from b in context.Businessdates
                                       where b.Resort == rn.Resort && b.State == "OPEN"
                                       select b.BusinessDate1).FirstOrDefault(),
                       Address = (from na in context.NameAddresses
                                  from c in context.Countries
                                  where na.NameId == n.NameId && na.PrimaryYn == "Y" && na.InactiveDate == null && c.CountryCode == na.Country
                                  select new AddressInfo
                                  {
                                      CountryCode = c.IsoCode,
                                      Region = Trim(na.State),
                                      City = Trim(na.City),
                                      Street = JoinAddress(na.Address1, na.Address2, na.Address3, na.Address4)
                                  }).AsNoTracking().FirstOrDefault(),
                       Phones = (from np in context.NamePhones
                                 where np.NameId == n.NameId
                                 select new PhoneInfo
                                 {
                                     PhoneNumber = np.PhoneNumber,
                                     PhoneType = np.PhoneType
                                 }).AsNoTracking().ToHashSet()
                   }).AsNoTracking().FirstOrDefaultAsync());

    public string? FixDocumentTypeCode(string? value)
    {
        if (value == null)
            return null;

        if (operaService.Environment.DocumentTypeAliases.Count == 0)
            return value;

        foreach (var alias in operaService.Environment.DocumentTypeAliases)
            if (value == alias.Key)
                return alias.Value;

        return value;
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

    private static string? Trim(string? value) => value?.Trim();

    private static decimal CalcShareAmount(decimal? shareAmount, decimal? sharePrcnt) => (shareAmount ?? 0) * (sharePrcnt ?? 100) / 100;

    private static string? JoinAddress(params string?[] addresses)
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

    protected override string? Message(ReservationInfo @in)
    {
        var result = $"Reservation: {@in.ReservationNumber:0}";

        if (!string.IsNullOrWhiteSpace(@in.Room))
            result += $", Room: {@in.Room}";

        return result;
    }
}
