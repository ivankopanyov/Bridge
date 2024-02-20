namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepAccStatsData
{
    public decimal? NameId { get; set; }
    public decimal? CompanyId { get; set; }
    public decimal? TravelAgentId { get; set; }
    public decimal? SourceId { get; set; }
    public string? MarketSegmentCode { get; set; }
    public string? OriginCode { get; set; }
    public string? SourceCode { get; set; }
    public decimal? ReservationNoOfStays { get; set; }
    public decimal? IndRoomNights { get; set; }
    public decimal? BlkRoomNights { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepAccStatsData>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_ACC_STATS_DATA");

            entity.Property(e => e.BlkRoomNights)
                .HasColumnName("BLK_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndRoomNights)
                .HasColumnName("IND_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketSegmentCode)
                .HasColumnName("MARKET_SEGMENT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginCode)
                .HasColumnName("ORIGIN_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationNoOfStays)
                .HasColumnName("RESERVATION_NO_OF_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");
        });
	}
}
