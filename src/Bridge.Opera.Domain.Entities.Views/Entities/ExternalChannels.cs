namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExternalChannels
{
    public string GdsHost { get; set; }
    public string Name { get; set; }
    public string ChannelType { get; set; }
    public string RateType { get; set; }
    public string MultiCurrencyYn { get; set; }
    public string SessionControl { get; set; }
    public string AlternateResort { get; set; }
    public string MatchAmenities { get; set; }
    public string AvstatAllRateCode { get; set; }
    public string AvstatAllRoomCategory { get; set; }
    public string AvstatGdsAddress { get; set; }
    public string RateChange { get; set; }
    public string MaxRatePeriods { get; set; }
    public string MaxDataloadDays { get; set; }
    public string FutureAvailabilityDays { get; set; }
    public string MaxAvailabilityItems { get; set; }
    public string ActivateYn { get; set; }
    public string AvstatUpdate { get; set; }
    public string PropUpdateYn { get; set; }
    public string CorpidReqdYn { get; set; }
    public string SellBy { get; set; }
    public string AcceptLowerRatesYn { get; set; }
    public string UseAccessCodeYn { get; set; }
    public string ErrorLowerGdsRates { get; set; }
    public string NegotiatedOnly { get; set; }
    public string CnclPnlyOverride { get; set; }
    public string SessionModificationYn { get; set; }
    public string RateUpdateYn { get; set; }
    public string NoNightLimits { get; set; }
    public string MaximumPropertyDispLimit { get; set; }
    public string AlternateRaterangeYn { get; set; }
    public string SearchByRatelevel { get; set; }
    public string ConfirmLetterName { get; set; }
    public string CancelLetterName { get; set; }
    public string OverrideYn { get; set; }
    public string AcceptBookingNorate { get; set; }
    public string GdsRateCodeLength { get; set; }
    public string GdsRateCategoryYn { get; set; }
    public string BlockSearch { get; set; }
    public string MaxRoomLimit { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExternalChannels>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXTERNAL_CHANNELS");

            entity.Property(e => e.AcceptBookingNorate)
                .HasColumnName("ACCEPT_BOOKING_NORATE")
                .IsUnicode(false);

            entity.Property(e => e.AcceptLowerRatesYn)
                .HasColumnName("ACCEPT_LOWER_RATES_YN")
                .IsUnicode(false);

            entity.Property(e => e.ActivateYn)
                .HasColumnName("ACTIVATE_YN")
                .IsUnicode(false);

            entity.Property(e => e.AlternateRaterangeYn)
                .HasColumnName("ALTERNATE_RATERANGE_YN")
                .IsUnicode(false);

            entity.Property(e => e.AlternateResort)
                .HasColumnName("ALTERNATE_RESORT")
                .IsUnicode(false);

            entity.Property(e => e.AvstatAllRateCode)
                .HasColumnName("AVSTAT_ALL_RATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AvstatAllRoomCategory)
                .HasColumnName("AVSTAT_ALL_ROOM_CATEGORY")
                .IsUnicode(false);

            entity.Property(e => e.AvstatGdsAddress)
                .HasColumnName("AVSTAT_GDS_ADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.AvstatUpdate)
                .HasColumnName("AVSTAT_UPDATE")
                .IsUnicode(false);

            entity.Property(e => e.BlockSearch)
                .HasColumnName("BLOCK_SEARCH")
                .IsUnicode(false);

            entity.Property(e => e.CancelLetterName)
                .HasColumnName("CANCEL_LETTER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ChannelType)
                .HasColumnName("CHANNEL_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.CnclPnlyOverride)
                .HasColumnName("CNCL_PNLY_OVERRIDE")
                .IsUnicode(false);

            entity.Property(e => e.ConfirmLetterName)
                .HasColumnName("CONFIRM_LETTER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.CorpidReqdYn)
                .HasColumnName("CORPID_REQD_YN")
                .IsUnicode(false);

            entity.Property(e => e.ErrorLowerGdsRates)
                .HasColumnName("ERROR_LOWER_GDS_RATES")
                .IsUnicode(false);

            entity.Property(e => e.FutureAvailabilityDays)
                .HasColumnName("FUTURE_AVAILABILITY_DAYS")
                .IsUnicode(false);

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .IsUnicode(false);

            entity.Property(e => e.GdsRateCategoryYn)
                .HasColumnName("GDS_RATE_CATEGORY_YN")
                .IsUnicode(false);

            entity.Property(e => e.GdsRateCodeLength)
                .HasColumnName("GDS_RATE_CODE_LENGTH")
                .IsUnicode(false);

            entity.Property(e => e.MatchAmenities)
                .HasColumnName("MATCH_AMENITIES")
                .IsUnicode(false);

            entity.Property(e => e.MaxAvailabilityItems)
                .HasColumnName("MAX_AVAILABILITY_ITEMS")
                .IsUnicode(false);

            entity.Property(e => e.MaxDataloadDays)
                .HasColumnName("MAX_DATALOAD_DAYS")
                .IsUnicode(false);

            entity.Property(e => e.MaxRatePeriods)
                .HasColumnName("MAX_RATE_PERIODS")
                .IsUnicode(false);

            entity.Property(e => e.MaxRoomLimit)
                .HasColumnName("MAX_ROOM_LIMIT")
                .IsUnicode(false);

            entity.Property(e => e.MaximumPropertyDispLimit)
                .HasColumnName("MAXIMUM_PROPERTY_DISP_LIMIT")
                .IsUnicode(false);

            entity.Property(e => e.MultiCurrencyYn)
                .HasColumnName("MULTI_CURRENCY_YN")
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .IsUnicode(false);

            entity.Property(e => e.NegotiatedOnly)
                .HasColumnName("NEGOTIATED_ONLY")
                .IsUnicode(false);

            entity.Property(e => e.NoNightLimits)
                .HasColumnName("NO_NIGHT_LIMITS")
                .IsUnicode(false);

            entity.Property(e => e.OverrideYn)
                .HasColumnName("OVERRIDE_YN")
                .IsUnicode(false);

            entity.Property(e => e.PropUpdateYn)
                .HasColumnName("PROP_UPDATE_YN")
                .IsUnicode(false);

            entity.Property(e => e.RateChange)
                .HasColumnName("RATE_CHANGE")
                .IsUnicode(false);

            entity.Property(e => e.RateType)
                .HasColumnName("RATE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.RateUpdateYn)
                .HasColumnName("RATE_UPDATE_YN")
                .IsUnicode(false);

            entity.Property(e => e.SearchByRatelevel)
                .HasColumnName("SEARCH_BY_RATELEVEL")
                .IsUnicode(false);

            entity.Property(e => e.SellBy)
                .HasColumnName("SELL_BY")
                .IsUnicode(false);

            entity.Property(e => e.SessionControl)
                .HasColumnName("SESSION_CONTROL")
                .IsUnicode(false);

            entity.Property(e => e.SessionModificationYn)
                .HasColumnName("SESSION_MODIFICATION_YN")
                .IsUnicode(false);

            entity.Property(e => e.UseAccessCodeYn)
                .HasColumnName("USE_ACCESS_CODE_YN")
                .IsUnicode(false);
        });
	}
}
