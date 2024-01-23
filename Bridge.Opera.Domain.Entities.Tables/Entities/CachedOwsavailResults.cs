namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CachedOwsavailResults
{
    public string SourceCode { get; set; }
    public string MerchantCode { get; set; }
    public string PropertyCode { get; set; }
    public DateTime ArrivalDate { get; set; }
    public decimal Nights { get; set; }
    public decimal Adults { get; set; }
    public decimal Children { get; set; }
    public decimal Children1 { get; set; }
    public decimal Children2 { get; set; }
    public decimal Children3 { get; set; }
    public decimal MaxRate { get; set; }
    public decimal MinRate { get; set; }
    public string AllotmentCode { get; set; }
    public string PromoCode { get; set; }
    public string QualifiedTypes { get; set; }
    public string QualifiedCodes { get; set; }
    public string RateCodes { get; set; }
    public string PagingKey { get; set; }
    public string BestAvailableYn { get; set; }
    public string ChildAges { get; set; }
    public decimal MembershipId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public decimal CompanyId { get; set; }
    public string LanguageCode { get; set; }
    public string RoomTypes { get; set; }
    public string RateCalculation { get; set; }
    public string ExtraBedPrefix { get; set; }
    public string AvailRoomTypes { get; set; }
    public string ChannelCode { get; set; }
    public string Resort { get; set; }
    public string AlternateDates { get; set; }
    public decimal? ReturnValue { get; set; }
    public string ErrorId { get; set; }
    public string ErrorCode { get; set; }
    public string ErrorText { get; set; }
    public string OraErrorText { get; set; }
    public string MarketingText { get; set; }
    public string PropertyCheckinTime { get; set; }
    public string PropertyCheckoutTime { get; set; }
    public string PropertyName { get; set; }
    public string PropertyAddress { get; set; }
    public string PropertyCity { get; set; }
    public string PropertyState { get; set; }
    public string PropertyCountry { get; set; }
    public string PropertyPostcode { get; set; }
    public string PropertyPhone { get; set; }
    public string PropertyFax { get; set; }
    public string PropertyEmail { get; set; }
    public string PropertyDirection { get; set; }
    public string RegretCode { get; set; }
    public DateTime LastUpdateTime { get; set; }
    public decimal LastUpdateUser { get; set; }
    public decimal? AllotmentId { get; set; }
    public string V1 { get; set; }
    public string V2 { get; set; }
    public string V3 { get; set; }
    public decimal? N1 { get; set; }
    public decimal? N2 { get; set; }
    public decimal? N3 { get; set; }
    public DateTime? D1 { get; set; }
    public DateTime? D2 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CachedOwsavailResults>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CACHED$_OWSAVAIL_RESULTS");

            entity.HasIndex(e => new { e.SourceCode, e.MerchantCode, e.PropertyCode, e.ArrivalDate, e.Nights, e.Adults, e.Children, e.Children1, e.Children2, e.Children3, e.MaxRate, e.MinRate, e.AllotmentCode, e.PromoCode, e.QualifiedTypes, e.QualifiedCodes, e.RateCodes, e.PagingKey, e.BestAvailableYn, e.ChildAges, e.MembershipId, e.UserName, e.Password, e.CompanyId, e.LanguageCode, e.RoomTypes, e.RateCalculation, e.ExtraBedPrefix, e.AvailRoomTypes })
                .HasName("CACHED$_OWSAVAIL_RESULTS_IDX");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentCode)
                .IsRequired()
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentId)
                .HasColumnName("ALLOTMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AlternateDates)
                .HasColumnName("ALTERNATE_DATES")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AvailRoomTypes)
                .IsRequired()
                .HasColumnName("AVAIL_ROOM_TYPES")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.BestAvailableYn)
                .IsRequired()
                .HasColumnName("BEST_AVAILABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChannelCode)
                .HasColumnName("CHANNEL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChildAges)
                .IsRequired()
                .HasColumnName("CHILD_AGES")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children1)
                .HasColumnName("CHILDREN1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children2)
                .HasColumnName("CHILDREN2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children3)
                .HasColumnName("CHILDREN3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.D1).HasColumnType("DATE");

            entity.Property(e => e.D2).HasColumnType("DATE");

            entity.Property(e => e.ErrorCode)
                .HasColumnName("ERROR_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorId)
                .HasColumnName("ERROR_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorText)
                .HasColumnName("ERROR_TEXT")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.ExtraBedPrefix)
                .IsRequired()
                .HasColumnName("EXTRA_BED_PREFIX")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LastUpdateTime)
                .HasColumnName("LAST_UPDATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.LastUpdateUser)
                .HasColumnName("LAST_UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketingText)
                .HasColumnName("MARKETING_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MaxRate)
                .HasColumnName("MAX_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MerchantCode)
                .IsRequired()
                .HasColumnName("MERCHANT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MinRate)
                .HasColumnName("MIN_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.N1).HasColumnType("NUMBER");

            entity.Property(e => e.N2).HasColumnType("NUMBER");

            entity.Property(e => e.N3).HasColumnType("NUMBER");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OraErrorText)
                .HasColumnName("ORA_ERROR_TEXT")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.PagingKey)
                .IsRequired()
                .HasColumnName("PAGING_KEY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Password)
                .IsRequired()
                .HasColumnName("PASSWORD")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PromoCode)
                .IsRequired()
                .HasColumnName("PROMO_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PropertyAddress)
                .HasColumnName("PROPERTY_ADDRESS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCheckinTime)
                .HasColumnName("PROPERTY_CHECKIN_TIME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCheckoutTime)
                .HasColumnName("PROPERTY_CHECKOUT_TIME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCity)
                .HasColumnName("PROPERTY_CITY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .IsRequired()
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCountry)
                .HasColumnName("PROPERTY_COUNTRY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PropertyDirection)
                .HasColumnName("PROPERTY_DIRECTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropertyEmail)
                .HasColumnName("PROPERTY_EMAIL")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PropertyFax)
                .HasColumnName("PROPERTY_FAX")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PropertyName)
                .HasColumnName("PROPERTY_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PropertyPhone)
                .HasColumnName("PROPERTY_PHONE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PropertyPostcode)
                .HasColumnName("PROPERTY_POSTCODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PropertyState)
                .HasColumnName("PROPERTY_STATE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.QualifiedCodes)
                .IsRequired()
                .HasColumnName("QUALIFIED_CODES")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.QualifiedTypes)
                .IsRequired()
                .HasColumnName("QUALIFIED_TYPES")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.RateCalculation)
                .IsRequired()
                .HasColumnName("RATE_CALCULATION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateCodes)
                .IsRequired()
                .HasColumnName("RATE_CODES")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.RegretCode)
                .HasColumnName("REGRET_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReturnValue)
                .HasColumnName("RETURN_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomTypes)
                .IsRequired()
                .HasColumnName("ROOM_TYPES")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .IsRequired()
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UserName)
                .IsRequired()
                .HasColumnName("USER_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.V1)
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.V2)
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.V3)
                .HasMaxLength(400)
                .IsUnicode(false);
        });
	}
}
