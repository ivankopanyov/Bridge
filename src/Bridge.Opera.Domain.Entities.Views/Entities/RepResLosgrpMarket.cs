namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepResLosgrpMarket
{
    public string Resort { get; set; }
    public string RecType { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public string MarketCode { get; set; }
    public string ParentMarketCode { get; set; }
    public string RateCode { get; set; }
    public string BookedRoomCategory { get; set; }
    public string RoomCategory { get; set; }
    public string RoomClass { get; set; }
    public string UpgradeYn { get; set; }
    public string LosGroup { get; set; }
    public decimal? LosTier { get; set; }
    public string LosDescr { get; set; }
    public string LosShortDesc { get; set; }
    public decimal? LengthOfStay { get; set; }
    public decimal? NoRoomsFore { get; set; }
    public decimal? NetRoomRevenueFore { get; set; }
    public decimal? NoRoomsStat { get; set; }
    public decimal? NetRoomRevenueStat { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepResLosgrpMarket>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_RES_LOSGRP_MARKET");

            entity.Property(e => e.BookedRoomCategory)
                .HasColumnName("BOOKED_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LengthOfStay)
                .HasColumnName("LENGTH_OF_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LosDescr)
                .HasColumnName("LOS_DESCR")
                .IsUnicode(false);

            entity.Property(e => e.LosGroup)
                .HasColumnName("LOS_GROUP")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.LosShortDesc)
                .HasColumnName("LOS_SHORT_DESC")
                .IsUnicode(false);

            entity.Property(e => e.LosTier)
                .HasColumnName("LOS_TIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NetRoomRevenueFore)
                .HasColumnName("NET_ROOM_REVENUE_FORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetRoomRevenueStat)
                .HasColumnName("NET_ROOM_REVENUE_STAT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoRoomsFore)
                .HasColumnName("NO_ROOMS_FORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoRoomsStat)
                .HasColumnName("NO_ROOMS_STAT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentMarketCode)
                .HasColumnName("PARENT_MARKET_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
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

            entity.Property(e => e.UpgradeYn)
                .HasColumnName("UPGRADE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
