namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpMarketRoomcatTierStats
{
    public string MarketCode { get; set; }
    public string RoomCategory { get; set; }
    public decimal? LosTier { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? TotalRooms { get; set; }
    public decimal? TotalMarketRevenue { get; set; }
    public decimal? TotalMarketRooms { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpMarketRoomcatTierStats>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_MARKET_ROOMCAT_TIER_STATS");

            entity.Property(e => e.LosTier)
                .HasColumnName("LOS_TIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .IsUnicode(false);

            entity.Property(e => e.TotalMarketRevenue)
                .HasColumnName("TOTAL_MARKET_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalMarketRooms)
                .HasColumnName("TOTAL_MARKET_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRooms)
                .HasColumnName("TOTAL_ROOMS")
                .HasColumnType("NUMBER");
        });
	}
}
