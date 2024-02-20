namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidGdsHostsSys
{
    public string? GdsHost { get; set; }
    public string? Name { get; set; }
    public string? ChannelType { get; set; }
    public string? RateType { get; set; }
    public string? MultiCurrencyYn { get; set; }
    public string? SessionControl { get; set; }
    public string? AlternateResort { get; set; }
    public string? MatchAmenities { get; set; }
    public string? AvstatAllRateCode { get; set; }
    public string? AvstatAllRoomCategory { get; set; }
    public string? AvstatGdsAddress { get; set; }
    public string? RateChange { get; set; }
    public decimal? MaxRatePeriods { get; set; }
    public decimal? MaxDataloadDays { get; set; }
    public decimal? FutureAvailabilityDays { get; set; }
    public DateTime? LastRolloverDate { get; set; }
    public decimal? MaxAvailabilityItems { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? ActivateYn { get; set; }
    public string? AvstatUpdate { get; set; }
    public string? PropUpdateYn { get; set; }
    public string? CorpidReqdYn { get; set; }
    public string? SellBy { get; set; }
    public string? AcceptLowerRatesYn { get; set; }
    public string? UseAccessCodeYn { get; set; }
    public string? ErrorLowerGdsRates { get; set; }
    public string? NegotiatedOnly { get; set; }
    public string? CnclPnlyOverride { get; set; }
    public string? SessionModificationYn { get; set; }
    public string? RateUpdateYn { get; set; }
    public decimal? NoNightLimits { get; set; }
    public decimal? MaximumPropertyDispLimit { get; set; }
    public string? AlternateRaterangeYn { get; set; }
    public string? SearchByRatelevel { get; set; }
    public string? ConfirmLetterName { get; set; }
    public string? CancelLetterName { get; set; }
    public string? OverrideYn { get; set; }
    public string? AcceptBookingNorate { get; set; }
    public decimal? GdsRateCodeLength { get; set; }
    public string? GdsRateCategoryYn { get; set; }
    public string? BlockSearch { get; set; }
    public decimal? MaxRoomLimit { get; set; }
    public DateTime? RateRolloverDate { get; set; }
    public string? ExternalYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidGdsHostsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_GDS_HOSTS_SYS");

            entity.Property(e => e.AcceptBookingNorate)
                .HasColumnName("ACCEPT_BOOKING_NORATE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AcceptLowerRatesYn)
                .IsRequired()
                .HasColumnName("ACCEPT_LOWER_RATES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ActivateYn)
                .HasColumnName("ACTIVATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AlternateRaterangeYn)
                .HasColumnName("ALTERNATE_RATERANGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AlternateResort)
                .HasColumnName("ALTERNATE_RESORT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AvstatAllRateCode)
                .HasColumnName("AVSTAT_ALL_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AvstatAllRoomCategory)
                .HasColumnName("AVSTAT_ALL_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AvstatGdsAddress)
                .HasColumnName("AVSTAT_GDS_ADDRESS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AvstatUpdate)
                .HasColumnName("AVSTAT_UPDATE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BlockSearch)
                .HasColumnName("BLOCK_SEARCH")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancelLetterName)
                .HasColumnName("CANCEL_LETTER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ChannelType)
                .HasColumnName("CHANNEL_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.CnclPnlyOverride)
                .IsRequired()
                .HasColumnName("CNCL_PNLY_OVERRIDE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmLetterName)
                .HasColumnName("CONFIRM_LETTER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CorpidReqdYn)
                .IsRequired()
                .HasColumnName("CORPID_REQD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ErrorLowerGdsRates)
                .IsRequired()
                .HasColumnName("ERROR_LOWER_GDS_RATES")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExternalYn)
                .HasColumnName("EXTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FutureAvailabilityDays)
                .HasColumnName("FUTURE_AVAILABILITY_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsRateCategoryYn)
                .HasColumnName("GDS_RATE_CATEGORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GdsRateCodeLength)
                .HasColumnName("GDS_RATE_CODE_LENGTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastRolloverDate)
                .HasColumnName("LAST_ROLLOVER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MatchAmenities)
                .HasColumnName("MATCH_AMENITIES")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MaxAvailabilityItems)
                .HasColumnName("MAX_AVAILABILITY_ITEMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxDataloadDays)
                .HasColumnName("MAX_DATALOAD_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxRatePeriods)
                .HasColumnName("MAX_RATE_PERIODS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxRoomLimit)
                .HasColumnName("MAX_ROOM_LIMIT")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.MaximumPropertyDispLimit)
                .HasColumnName("MAXIMUM_PROPERTY_DISP_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultiCurrencyYn)
                .HasColumnName("MULTI_CURRENCY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NegotiatedOnly)
                .IsRequired()
                .HasColumnName("NEGOTIATED_ONLY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NoNightLimits)
                .HasColumnName("NO_NIGHT_LIMITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OverrideYn)
                .HasColumnName("OVERRIDE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PropUpdateYn)
                .HasColumnName("PROP_UPDATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateChange)
                .HasColumnName("RATE_CHANGE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.RateRolloverDate)
                .HasColumnName("RATE_ROLLOVER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateType)
                .HasColumnName("RATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateUpdateYn)
                .HasColumnName("RATE_UPDATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SearchByRatelevel)
                .HasColumnName("SEARCH_BY_RATELEVEL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SellBy)
                .IsRequired()
                .HasColumnName("SELL_BY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SessionControl)
                .HasColumnName("SESSION_CONTROL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SessionModificationYn)
                .HasColumnName("SESSION_MODIFICATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UseAccessCodeYn)
                .IsRequired()
                .HasColumnName("USE_ACCESS_CODE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
