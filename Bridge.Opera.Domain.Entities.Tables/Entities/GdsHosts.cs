namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsHosts
{
    public GdsHosts()
    {
        GdsConvResorts = new HashSet<GdsConvResorts>();
        GdsHostCarriers = new HashSet<GdsHostCarriers>();
        GdsHostsConfLetters = new HashSet<GdsHostsConfLetters>();
        GdsRoomCategoryTemplate = new HashSet<GdsRoomCategoryTemplate>();
    }

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
    public decimal? MaxRatePeriods { get; set; }
    public decimal? MaxDataloadDays { get; set; }
    public decimal? FutureAvailabilityDays { get; set; }
    public DateTime? LastRolloverDate { get; set; }
    public decimal? MaxAvailabilityItems { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
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
    public decimal? NoNightLimits { get; set; }
    public decimal? MaximumPropertyDispLimit { get; set; }
    public string AlternateRaterangeYn { get; set; }
    public string SearchByRatelevel { get; set; }
    public string ConfirmLetterName { get; set; }
    public string CancelLetterName { get; set; }
    public string OverrideYn { get; set; }
    public string AcceptBookingNorate { get; set; }
    public decimal? GdsRateCodeLength { get; set; }
    public string GdsRateCategoryYn { get; set; }
    public string BlockSearch { get; set; }
    public decimal? MaxRoomLimit { get; set; }
    public DateTime? RateRolloverDate { get; set; }
    public string ExternalYn { get; set; }
    public string AriDestination { get; set; }
    public string PingYn { get; set; }
    public string BookinglimitYn { get; set; }
    public string OnlineCcAuthYn { get; set; }
    public decimal? InitialUploadDays { get; set; }
    public string ResendYn { get; set; }
    public string RetryYn { get; set; }
    public string BusinessEventId { get; set; }
    public string PricingMode { get; set; }
    public string MessageType { get; set; }
    public string InclMultCurrRateCodeYn { get; set; }
    public string InvUpdBlockYn { get; set; }
    public string DepositRuleYn { get; set; }
    public string RateuploadSchema { get; set; }
    public string BlockContractYn { get; set; }
    public string NegrateYn { get; set; }
    public string TotalPricingYn { get; set; }
    public string CcSurchargeYn { get; set; }
    public string TextEditorYn { get; set; }
    public string BuildRpeList { get; set; }
    public string CachingYn { get; set; }
    public string PropLevelYn { get; set; }
    public string BbarRateTier { get; set; }
    public string RealTimeInventory { get; set; }
    public string CmrFilter { get; set; }
    public string AmcFilter { get; set; }
    public string AdvancedPackageHandlingYn { get; set; }
    public string ProductsYn { get; set; }
    public decimal? SequenceId { get; set; }
    public string AddOnLicense { get; set; }
    public string WebsiteUrl { get; set; }
    public string IconUrl { get; set; }
    public string ExposeUpsellsYn { get; set; }
    public string IgnoreRegionSeq { get; set; }
    public string CacheCallstackYn { get; set; }

    public virtual ICollection<GdsConvResorts> GdsConvResorts { get; set; }
    public virtual ICollection<GdsHostCarriers> GdsHostCarriers { get; set; }
    public virtual ICollection<GdsHostsConfLetters> GdsHostsConfLetters { get; set; }
    public virtual ICollection<GdsRoomCategoryTemplate> GdsRoomCategoryTemplate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsHosts>(entity =>
        {
            entity.HasKey(e => e.GdsHost)
                .HasName("GDS_HOSTS_PK");

            entity.ToTable("GDS_HOSTS");

            entity.HasIndex(e => e.CachingYn)
                .HasName("GDS_HOSTS_IDX1");

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AcceptBookingNorate)
                .HasColumnName("ACCEPT_BOOKING_NORATE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AcceptLowerRatesYn)
                .IsRequired()
                .HasColumnName("ACCEPT_LOWER_RATES_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.ActivateYn)
                .HasColumnName("ACTIVATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.AddOnLicense)
                .HasColumnName("ADD_ON_LICENSE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AdvancedPackageHandlingYn)
                .HasColumnName("ADVANCED_PACKAGE_HANDLING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AlternateRaterangeYn)
                .HasColumnName("ALTERNATE_RATERANGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AlternateResort)
                .HasColumnName("ALTERNATE_RESORT")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.AmcFilter)
                .HasColumnName("AMC_FILTER")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AriDestination)
                .HasColumnName("ARI_DESTINATION")
                .HasMaxLength(500)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AvstatAllRateCode)
                .HasColumnName("AVSTAT_ALL_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'ALL'");

            entity.Property(e => e.AvstatAllRoomCategory)
                .HasColumnName("AVSTAT_ALL_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'ALL'");

            entity.Property(e => e.AvstatGdsAddress)
                .HasColumnName("AVSTAT_GDS_ADDRESS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AvstatUpdate)
                .HasColumnName("AVSTAT_UPDATE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.BbarRateTier)
                .HasColumnName("BBAR_RATE_TIER")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BlockContractYn)
                .HasColumnName("BLOCK_CONTRACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BlockSearch)
                .HasColumnName("BLOCK_SEARCH")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BookinglimitYn)
                .HasColumnName("BOOKINGLIMIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.BuildRpeList)
                .HasColumnName("BUILD_RPE_LIST")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BusinessEventId)
                .HasColumnName("BUSINESS_EVENT_ID")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CacheCallstackYn)
                .HasColumnName("CACHE_CALLSTACK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CachingYn)
                .HasColumnName("CACHING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CancelLetterName)
                .HasColumnName("CANCEL_LETTER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcSurchargeYn)
                .HasColumnName("CC_SURCHARGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChannelType)
                .HasColumnName("CHANNEL_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'GDS'");

            entity.Property(e => e.CmrFilter)
                .HasColumnName("CMR_FILTER")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CnclPnlyOverride)
                .IsRequired()
                .HasColumnName("CNCL_PNLY_OVERRIDE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.ConfirmLetterName)
                .HasColumnName("CONFIRM_LETTER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CorpidReqdYn)
                .IsRequired()
                .HasColumnName("CORPID_REQD_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.DepositRuleYn)
                .HasColumnName("DEPOSIT_RULE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ErrorLowerGdsRates)
                .IsRequired()
                .HasColumnName("ERROR_LOWER_GDS_RATES")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.ExposeUpsellsYn)
                .HasColumnName("EXPOSE_UPSELLS_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExternalYn)
                .HasColumnName("EXTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FutureAvailabilityDays)
                .HasColumnName("FUTURE_AVAILABILITY_DAYS")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql(@"365");

            entity.Property(e => e.GdsRateCategoryYn)
                .HasColumnName("GDS_RATE_CATEGORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsRateCodeLength)
                .HasColumnName("GDS_RATE_CODE_LENGTH")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IconUrl)
                .HasColumnName("ICON_URL")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IgnoreRegionSeq)
                .HasColumnName("IGNORE_REGION_SEQ")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InclMultCurrRateCodeYn)
                .HasColumnName("INCL_MULT_CURR_RATE_CODE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InitialUploadDays)
                .HasColumnName("INITIAL_UPLOAD_DAYS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvUpdBlockYn)
                .HasColumnName("INV_UPD_BLOCK_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LastRolloverDate)
                .HasColumnName("LAST_ROLLOVER_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MatchAmenities)
                .HasColumnName("MATCH_AMENITIES")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'ORDERBY'");

            entity.Property(e => e.MaxAvailabilityItems)
                .HasColumnName("MAX_AVAILABILITY_ITEMS")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql(@"16");

            entity.Property(e => e.MaxDataloadDays)
                .HasColumnName("MAX_DATALOAD_DAYS")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql(@"365");

            entity.Property(e => e.MaxRatePeriods)
                .HasColumnName("MAX_RATE_PERIODS")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql(@"26");

            entity.Property(e => e.MaxRoomLimit)
                .HasColumnName("MAX_ROOM_LIMIT")
                .HasColumnType("NUMBER(38)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaximumPropertyDispLimit)
                .HasColumnName("MAXIMUM_PROPERTY_DISP_LIMIT")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("NULL");

            entity.Property(e => e.MessageType)
                .HasColumnName("MESSAGE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MultiCurrencyYn)
                .HasColumnName("MULTI_CURRENCY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NegotiatedOnly)
                .IsRequired()
                .HasColumnName("NEGOTIATED_ONLY")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.NegrateYn)
                .HasColumnName("NEGRATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoNightLimits)
                .HasColumnName("NO_NIGHT_LIMITS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OnlineCcAuthYn)
                .HasColumnName("ONLINE_CC_AUTH_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.OverrideYn)
                .HasColumnName("OVERRIDE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PingYn)
                .HasColumnName("PING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.PricingMode)
                .HasColumnName("PRICING_MODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProductsYn)
                .HasColumnName("PRODUCTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PropLevelYn)
                .HasColumnName("PROP_LEVEL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PropUpdateYn)
                .HasColumnName("PROP_UPDATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.RateChange)
                .HasColumnName("RATE_CHANGE")
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'FIRSTNIGHT'");

            entity.Property(e => e.RateRolloverDate)
                .HasColumnName("RATE_ROLLOVER_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateType)
                .HasColumnName("RATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'DAILY'");

            entity.Property(e => e.RateUpdateYn)
                .HasColumnName("RATE_UPDATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateuploadSchema)
                .HasColumnName("RATEUPLOAD_SCHEMA")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RealTimeInventory)
                .HasColumnName("REAL_TIME_INVENTORY")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResendYn)
                .HasColumnName("RESEND_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RetryYn)
                .HasColumnName("RETRY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SearchByRatelevel)
                .HasColumnName("SEARCH_BY_RATELEVEL")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SellBy)
                .IsRequired()
                .HasColumnName("SELL_BY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'RATE'");

            entity.Property(e => e.SequenceId)
                .HasColumnName("SEQUENCE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SessionControl)
                .HasColumnName("SESSION_CONTROL")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.SessionModificationYn)
                .HasColumnName("SESSION_MODIFICATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TextEditorYn)
                .HasColumnName("TEXT_EDITOR_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalPricingYn)
                .HasColumnName("TOTAL_PRICING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.WebsiteUrl)
                .HasColumnName("WEBSITE_URL")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(GdsConvResorts)))
				entity.Ignore(e => e.GdsConvResorts);

			if (!types.Contains(typeof(GdsHostCarriers)))
				entity.Ignore(e => e.GdsHostCarriers);

			if (!types.Contains(typeof(GdsHostsConfLetters)))
				entity.Ignore(e => e.GdsHostsConfLetters);

			if (!types.Contains(typeof(GdsRoomCategoryTemplate)))
				entity.Ignore(e => e.GdsRoomCategoryTemplate);
		});
	}
}
