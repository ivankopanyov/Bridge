namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DmBookingpaceVw
{
    public string Resort { get; set; }
    public string RegionCode { get; set; }
    public DateTime? BusinessDate { get; set; }
    public DateTime? SnapshotDate { get; set; }
    public string MarketCode { get; set; }
    public string MarketCodeDesc { get; set; }
    public string MarketGroup { get; set; }
    public string MarketGroupDesc { get; set; }
    public decimal? TotalRoomOccDeduct { get; set; }
    public decimal? RoomsOccDeductInd { get; set; }
    public decimal? RoomsOccDeductBlk { get; set; }
    public decimal? RoomsOccDeductNotpickBlk { get; set; }
    public decimal? TotalRoomOccNondeduct { get; set; }
    public decimal? RoomsOccNondeductInd { get; set; }
    public decimal? RoomsOccNondeductBlk { get; set; }
    public decimal? RoomsOccNondedNotpickBlk { get; set; }
    public decimal? TotalRevenueDeduct { get; set; }
    public decimal? RevenueDeductInd { get; set; }
    public decimal? RevenueDeductBlk { get; set; }
    public decimal? RevenueDeductNotpickBlk { get; set; }
    public decimal? TotalRevenueNondeduct { get; set; }
    public decimal? RevenueNondeductInd { get; set; }
    public decimal? RevenueNondeductBlk { get; set; }
    public decimal? RevenueNondeductNotpickBlk { get; set; }
    public decimal? RoomsOutOfOrder { get; set; }
    public decimal? CExchangeRate { get; set; }
    public decimal? CTotalRevenueDeduct { get; set; }
    public decimal? CRevenueDeductInd { get; set; }
    public decimal? CRevenueDeductBlk { get; set; }
    public decimal? CRevenueDeductNotpickBlk { get; set; }
    public decimal? CTotalRevenueNondeduct { get; set; }
    public decimal? CRevenueNondeductInd { get; set; }
    public decimal? CRevenueNondeductBlk { get; set; }
    public decimal? CRevNondeductNotpickBlk { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DmBookingpaceVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DM_BOOKINGPACE_VW");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CExchangeRate)
                .HasColumnName("C_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRevNondeductNotpickBlk)
                .HasColumnName("C_REV_NONDEDUCT_NOTPICK_BLK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRevenueDeductBlk)
                .HasColumnName("C_REVENUE_DEDUCT_BLK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRevenueDeductInd)
                .HasColumnName("C_REVENUE_DEDUCT_IND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRevenueDeductNotpickBlk)
                .HasColumnName("C_REVENUE_DEDUCT_NOTPICK_BLK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRevenueNondeductBlk)
                .HasColumnName("C_REVENUE_NONDEDUCT_BLK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRevenueNondeductInd)
                .HasColumnName("C_REVENUE_NONDEDUCT_IND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTotalRevenueDeduct)
                .HasColumnName("C_TOTAL_REVENUE_DEDUCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTotalRevenueNondeduct)
                .HasColumnName("C_TOTAL_REVENUE_NONDEDUCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketCodeDesc)
                .HasColumnName("MARKET_CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MarketGroup)
                .HasColumnName("MARKET_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketGroupDesc)
                .HasColumnName("MARKET_GROUP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueDeductBlk)
                .HasColumnName("REVENUE_DEDUCT_BLK")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RevenueDeductInd)
                .HasColumnName("REVENUE_DEDUCT_IND")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RevenueDeductNotpickBlk)
                .HasColumnName("REVENUE_DEDUCT_NOTPICK_BLK")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RevenueNondeductBlk)
                .HasColumnName("REVENUE_NONDEDUCT_BLK")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RevenueNondeductInd)
                .HasColumnName("REVENUE_NONDEDUCT_IND")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RevenueNondeductNotpickBlk)
                .HasColumnName("REVENUE_NONDEDUCT_NOTPICK_BLK")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RoomsOccDeductBlk)
                .HasColumnName("ROOMS_OCC_DEDUCT_BLK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsOccDeductInd)
                .HasColumnName("ROOMS_OCC_DEDUCT_IND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsOccDeductNotpickBlk)
                .HasColumnName("ROOMS_OCC_DEDUCT_NOTPICK_BLK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsOccNondedNotpickBlk)
                .HasColumnName("ROOMS_OCC_NONDED_NOTPICK_BLK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsOccNondeductBlk)
                .HasColumnName("ROOMS_OCC_NONDEDUCT_BLK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsOccNondeductInd)
                .HasColumnName("ROOMS_OCC_NONDEDUCT_IND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsOutOfOrder)
                .HasColumnName("ROOMS_OUT_OF_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapshotDate)
                .HasColumnName("SNAPSHOT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TotalRevenueDeduct)
                .HasColumnName("TOTAL_REVENUE_DEDUCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueNondeduct)
                .HasColumnName("TOTAL_REVENUE_NONDEDUCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomOccDeduct)
                .HasColumnName("TOTAL_ROOM_OCC_DEDUCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomOccNondeduct)
                .HasColumnName("TOTAL_ROOM_OCC_NONDEDUCT")
                .HasColumnType("NUMBER");
        });
	}
}
