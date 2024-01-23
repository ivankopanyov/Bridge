namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CachedOwsregResults
{
    public string ChannelCode { get; set; }
    public string Resort { get; set; }
    public DateTime ArrivalDate { get; set; }
    public decimal Nights { get; set; }
    public decimal Adults { get; set; }
    public decimal Children { get; set; }
    public decimal Children1 { get; set; }
    public decimal Children2 { get; set; }
    public decimal Children3 { get; set; }
    public decimal? LastUpdateUser { get; set; }
    public DateTime? LastUpdateTime { get; set; }
    public string V1 { get; set; }
    public string V2 { get; set; }
    public decimal? N1 { get; set; }
    public DateTime? D1 { get; set; }
    public string SearchCode { get; set; }
    public string SearchType { get; set; }
    public string PropertyList { get; set; }
    public decimal NoRooms { get; set; }
    public decimal MaxRate { get; set; }
    public decimal MinRate { get; set; }
    public string CurrencyCode { get; set; }
    public string RateCalcMethod { get; set; }
    public string MatchQualifier { get; set; }
    public string RateCodeList { get; set; }
    public string QualifiedList { get; set; }
    public string QualifiedTypes { get; set; }
    public string ChainCode { get; set; }
    public string RegionCode { get; set; }
    public string CityCode { get; set; }
    public string StateCode { get; set; }
    public string CountryCode { get; set; }
    public string LanguageCode { get; set; }
    public string CommissionCode { get; set; }
    public string AvailRoomTypes { get; set; }
    public decimal? ReturnValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CachedOwsregResults>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CACHED$_OWSREG_RESULTS");

            entity.HasIndex(e => new { e.ChannelCode, e.Resort, e.ArrivalDate, e.Nights, e.Adults, e.Children, e.Children1, e.Children2, e.Children3, e.SearchCode, e.SearchType, e.PropertyList, e.NoRooms, e.MaxRate, e.MinRate, e.CurrencyCode, e.RateCalcMethod, e.MatchQualifier, e.RateCodeList, e.QualifiedList, e.QualifiedTypes, e.ChainCode, e.RegionCode, e.CityCode, e.StateCode, e.CountryCode, e.LanguageCode, e.CommissionCode })
                .HasName("CACHED$_OWSREG_RESULTS_IDX");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AvailRoomTypes)
                .IsRequired()
                .HasColumnName("AVAIL_ROOM_TYPES")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChannelCode)
                .IsRequired()
                .HasColumnName("CHANNEL_CODE")
                .HasMaxLength(20)
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

            entity.Property(e => e.CityCode)
                .IsRequired()
                .HasColumnName("CITY_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CommissionCode)
                .IsRequired()
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CountryCode)
                .IsRequired()
                .HasColumnName("COUNTRY_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .IsRequired()
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.D1).HasColumnType("DATE");

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LastUpdateTime)
                .HasColumnName("LAST_UPDATE_TIME")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.LastUpdateUser)
                .HasColumnName("LAST_UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MatchQualifier)
                .IsRequired()
                .HasColumnName("MATCH_QUALIFIER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MaxRate)
                .HasColumnName("MAX_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinRate)
                .HasColumnName("MIN_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.N1).HasColumnType("NUMBER");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoRooms)
                .HasColumnName("NO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropertyList)
                .IsRequired()
                .HasColumnName("PROPERTY_LIST")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.QualifiedList)
                .IsRequired()
                .HasColumnName("QUALIFIED_LIST")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.QualifiedTypes)
                .IsRequired()
                .HasColumnName("QUALIFIED_TYPES")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.RateCalcMethod)
                .IsRequired()
                .HasColumnName("RATE_CALC_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCodeList)
                .IsRequired()
                .HasColumnName("RATE_CODE_LIST")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.RegionCode)
                .IsRequired()
                .HasColumnName("REGION_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReturnValue)
                .HasColumnName("RETURN_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SearchCode)
                .IsRequired()
                .HasColumnName("SEARCH_CODE")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.SearchType)
                .IsRequired()
                .HasColumnName("SEARCH_TYPE")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasColumnName("STATE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.V1)
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.V2)
                .HasMaxLength(400)
                .IsUnicode(false);
        });
	}
}
