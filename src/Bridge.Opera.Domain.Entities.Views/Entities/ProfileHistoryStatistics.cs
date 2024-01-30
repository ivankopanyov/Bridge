namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ProfileHistoryStatistics
{
    public string? Resort { get; set; }
    public string? RecType { get; set; }
    public string? SourceCode { get; set; }
    public string? MarketCode { get; set; }
    public decimal? ResvNo { get; set; }
    public string? ReservationType { get; set; }
    public string? RateCode { get; set; }
    public decimal? ShareRate { get; set; }
    public string? RoomNumber { get; set; }
    public string? BlockCode { get; set; }
    public string? RoomType { get; set; }
    public decimal? RoomRate { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? NoOfRooms { get; set; }
    public DateTime? ReserveBeginDate { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string? GuestName { get; set; }
    public decimal? NameId { get; set; }
    public string? AgentName { get; set; }
    public string? GroupName { get; set; }
    public string? SourceName { get; set; }
    public string? CompanyName { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public DateTime? ActualCheckOutDate { get; set; }
    public string? ResvStatus { get; set; }
    public string? ModifyYn { get; set; }
    public string? RoomClass { get; set; }
    public string? NameUsageType { get; set; }
    public decimal? CompanyId { get; set; }
    public decimal? TravelId { get; set; }
    public decimal? SourceId { get; set; }
    public decimal? GroupId { get; set; }
    public decimal? MembershipId { get; set; }
    public string? MembershipNumber { get; set; }
    public string? GuestCountry { get; set; }
    public string? CompanyCountry { get; set; }
    public string? AgentCountry { get; set; }
    public string? SourceCountry { get; set; }
    public string? GroupCountry { get; set; }
    public string? CompanyZip { get; set; }
    public string? AgentZip { get; set; }
    public string? SourceZip { get; set; }
    public string? GroupZip { get; set; }
    public string? GuestZip { get; set; }
    public string? GuestSalesManager { get; set; }
    public string? CompanySalesManager { get; set; }
    public string? AgentSalesManager { get; set; }
    public string? SourceSalesManager { get; set; }
    public string? GroupSalesManager { get; set; }
    public string? ShareYn { get; set; }
    public decimal? Nights { get; set; }
    public string? RoomCategory { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileHistoryStatistics>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PROFILE_HISTORY_STATISTICS");

            entity.Property(e => e.ActualCheckOutDate)
                .HasColumnName("ACTUAL_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentCountry)
                .HasColumnName("AGENT_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.AgentName)
                .HasColumnName("AGENT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AgentSalesManager)
                .HasColumnName("AGENT_SALES_MANAGER")
                .IsUnicode(false);

            entity.Property(e => e.AgentZip)
                .HasColumnName("AGENT_ZIP")
                .IsUnicode(false);

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyCountry)
                .HasColumnName("COMPANY_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.CompanySalesManager)
                .HasColumnName("COMPANY_SALES_MANAGER")
                .IsUnicode(false);

            entity.Property(e => e.CompanyZip)
                .HasColumnName("COMPANY_ZIP")
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupCountry)
                .HasColumnName("GROUP_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GroupSalesManager)
                .HasColumnName("GROUP_SALES_MANAGER")
                .IsUnicode(false);

            entity.Property(e => e.GroupZip)
                .HasColumnName("GROUP_ZIP")
                .IsUnicode(false);

            entity.Property(e => e.GuestCountry)
                .HasColumnName("GUEST_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(121)
                .IsUnicode(false);

            entity.Property(e => e.GuestSalesManager)
                .HasColumnName("GUEST_SALES_MANAGER")
                .IsUnicode(false);

            entity.Property(e => e.GuestZip)
                .HasColumnName("GUEST_ZIP")
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipNumber)
                .HasColumnName("MEMBERSHIP_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.ModifyYn)
                .HasColumnName("MODIFY_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUsageType)
                .HasColumnName("NAME_USAGE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecType)
                .HasColumnName("REC_TYPE")
                .HasColumnType("CHAR(7)");

            entity.Property(e => e.ReservationType)
                .HasColumnName("RESERVATION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReserveBeginDate)
                .HasColumnName("RESERVE_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNo)
                .HasColumnName("RESV_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomNumber)
                .HasColumnName("ROOM_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRate)
                .HasColumnName("ROOM_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.ShareRate)
                .HasColumnName("SHARE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareYn)
                .HasColumnName("SHARE_YN")
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCountry)
                .HasColumnName("SOURCE_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.SourceSalesManager)
                .HasColumnName("SOURCE_SALES_MANAGER")
                .IsUnicode(false);

            entity.Property(e => e.SourceZip)
                .HasColumnName("SOURCE_ZIP")
                .IsUnicode(false);

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelId)
                .HasColumnName("TRAVEL_ID")
                .HasColumnType("NUMBER");
        });
	}
}
