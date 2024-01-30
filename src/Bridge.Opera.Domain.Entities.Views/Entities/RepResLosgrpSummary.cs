namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepResLosgrpSummary
{
    public string? Resort { get; set; }
    public string? RecType { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public string? MarketCode { get; set; }
    public string? ParentMarketCode { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomClass { get; set; }
    public decimal? LosTier { get; set; }
    public decimal? LengthOfStay { get; set; }
    public decimal? NoRooms { get; set; }
    public decimal? NetRoomRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepResLosgrpSummary>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_RES_LOSGRP_SUMMARY");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LengthOfStay)
                .HasColumnName("LENGTH_OF_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LosTier)
                .HasColumnName("LOS_TIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NetRoomRevenue)
                .HasColumnName("NET_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoRooms)
                .HasColumnName("NO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentMarketCode)
                .HasColumnName("PARENT_MARKET_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RecType)
                .HasColumnName("REC_TYPE")
                .HasColumnType("CHAR(6)");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
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
        });
	}
}
