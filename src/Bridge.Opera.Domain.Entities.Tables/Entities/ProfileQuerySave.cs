namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProfileQuerySave
{
    public decimal QueryId { get; set; }
    public string QueryCode { get; set; }
    public string ShortDescription { get; set; }
    public string ToSubscribe { get; set; }
    public string FromDatabaseLst { get; set; }
    public string FromCountryLst { get; set; }
    public string FromTerritoryLst { get; set; }
    public string NameType { get; set; }
    public string MembershipType { get; set; }
    public string MembershipLevelLst { get; set; }
    public string NationalityLst { get; set; }
    public string VipStatusLst { get; set; }
    public string Restricted { get; set; }
    public string KeywordType { get; set; }
    public string Keyword { get; set; }
    public string GuestLanguageLst { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime? FromStayDate { get; set; }
    public DateTime? ToStayDate { get; set; }
    public string RoomLabelLst { get; set; }
    public string StayResortLst { get; set; }
    public string StayChainLst { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? TotalRoomRevenue { get; set; }
    public decimal? TotalNights { get; set; }
    public decimal? TotalStays { get; set; }
    public decimal? MinNoStayResorts { get; set; }
    public DateTime? LastRunDate { get; set; }
    public string IncludeInactiveProfiles { get; set; }
    public string CreditRating { get; set; }
    public decimal? TopNumber { get; set; }
    public string TopBasedOn { get; set; }
    public string ExcludeStay { get; set; }
    public string RevenueType { get; set; }
    public decimal? TotalRevTypeAmt { get; set; }
    public string CustomFilter { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileQuerySave>(entity =>
        {
            entity.HasKey(e => e.QueryId)
                .HasName("PQE_PK");

            entity.ToTable("PROFILE_QUERY_SAVE");

            entity.HasIndex(e => e.LastRunDate)
                .HasName("PROFILE_QUERY_IND2");

            entity.HasIndex(e => e.QueryCode)
                .HasName("PROFILE_QUERY_IND1")
                .IsUnique();

            entity.Property(e => e.QueryId)
                .HasColumnName("QUERY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditRating)
                .HasColumnName("CREDIT_RATING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CustomFilter)
                .HasColumnName("CUSTOM_FILTER")
                .IsUnicode(false);

            entity.Property(e => e.ExcludeStay)
                .HasColumnName("EXCLUDE_STAY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FromCountryLst)
                .HasColumnName("FROM_COUNTRY_LST")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FromDatabaseLst)
                .HasColumnName("FROM_DATABASE_LST")
                .IsUnicode(false);

            entity.Property(e => e.FromStayDate)
                .HasColumnName("FROM_STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FromTerritoryLst)
                .HasColumnName("FROM_TERRITORY_LST")
                .IsUnicode(false);

            entity.Property(e => e.GuestLanguageLst)
                .HasColumnName("GUEST_LANGUAGE_LST")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.IncludeInactiveProfiles)
                .HasColumnName("INCLUDE_INACTIVE_PROFILES")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Keyword)
                .HasColumnName("KEYWORD")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.KeywordType)
                .HasColumnName("KEYWORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LastRunDate)
                .HasColumnName("LAST_RUN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MembershipLevelLst)
                .HasColumnName("MEMBERSHIP_LEVEL_LST")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MinNoStayResorts)
                .HasColumnName("MIN_NO_STAY_RESORTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NationalityLst)
                .HasColumnName("NATIONALITY_LST")
                .IsUnicode(false);

            entity.Property(e => e.QueryCode)
                .HasColumnName("QUERY_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Restricted)
                .HasColumnName("RESTRICTED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RevenueType)
                .HasColumnName("REVENUE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.RoomLabelLst)
                .HasColumnName("ROOM_LABEL_LST")
                .IsUnicode(false);

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.StayChainLst)
                .HasColumnName("STAY_CHAIN_LST")
                .IsUnicode(false);

            entity.Property(e => e.StayResortLst)
                .HasColumnName("STAY_RESORT_LST")
                .IsUnicode(false);

            entity.Property(e => e.ToStayDate)
                .HasColumnName("TO_STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ToSubscribe)
                .HasColumnName("TO_SUBSCRIBE")
                .IsUnicode(false);

            entity.Property(e => e.TopBasedOn)
                .HasColumnName("TOP_BASED_ON")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TopNumber)
                .HasColumnName("TOP_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNights)
                .HasColumnName("TOTAL_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevTypeAmt)
                .HasColumnName("TOTAL_REV_TYPE_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomRevenue)
                .HasColumnName("TOTAL_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalStays)
                .HasColumnName("TOTAL_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VipStatusLst)
                .HasColumnName("VIP_STATUS_LST")
                .IsUnicode(false);
        });
	}
}
