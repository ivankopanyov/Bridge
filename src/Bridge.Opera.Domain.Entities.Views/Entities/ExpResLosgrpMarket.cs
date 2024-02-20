namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpResLosgrpMarket
{
    public string? Resort { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public string? MarketCode { get; set; }
    public string? ParentMarketCode { get; set; }
    public decimal? RoomCategory { get; set; }
    public decimal? LosTier { get; set; }
    public decimal? LengthOfStay { get; set; }
    public decimal? NoRoomsStat { get; set; }
    public decimal? NetRoomRevenueStat { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpResLosgrpMarket>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_RES_LOSGRP_MARKET");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LengthOfStay)
                .HasColumnName("LENGTH_OF_STAY")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.LosTier)
                .HasColumnName("LOS_TIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NetRoomRevenueStat)
                .HasColumnName("NET_ROOM_REVENUE_STAT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoRoomsStat)
                .HasColumnName("NO_ROOMS_STAT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentMarketCode)
                .HasColumnName("PARENT_MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasColumnType("NUMBER");
        });
	}
}
