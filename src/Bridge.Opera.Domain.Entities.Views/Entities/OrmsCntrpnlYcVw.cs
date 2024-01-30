namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsCntrpnlYcVw
{
    public string? Resort { get; set; }
    public DateTime? RecordDate { get; set; }
    public string? YieldCategory { get; set; }
    public decimal? InvPhysical { get; set; }
    public decimal? InvOoo { get; set; }
    public decimal? InvOversell { get; set; }
    public decimal? InvOnthebooks { get; set; }
    public decimal? InvAvailable { get; set; }
    public decimal? InvAvailableWoOoo { get; set; }
    public decimal? GrpTotblocks { get; set; }
    public decimal? GrpDefblocks { get; set; }
    public decimal? GrpTentblocks { get; set; }
    public decimal? GrpPickedup { get; set; }
    public decimal? GrpForecasted { get; set; }
    public decimal? GrpForecastedNontb { get; set; }
    public decimal? GrpForecastedTb { get; set; }
    public decimal? TrnArrivals { get; set; }
    public decimal? TrnArrivalFore { get; set; }
    public decimal? TrnArrivalFore2 { get; set; }
    public decimal? TrnResvFore { get; set; }
    public decimal? TrnCnclFore { get; set; }
    public decimal? TrnStayFore { get; set; }
    public string? DisplayText { get; set; }
    public string? SeasonColor { get; set; }
    public decimal? OversellForecast { get; set; }
    public decimal? OtbOccupancyPct { get; set; }
    public decimal? OtbOccupancyPctComp { get; set; }
    public decimal? OtbOccupancyPctWoOoo { get; set; }
    public decimal? OtbOccupancyPctWoOooComp { get; set; }
    public decimal? OtbAdr { get; set; }
    public decimal? OtbAdrComp { get; set; }
    public decimal? OtbRevpar { get; set; }
    public decimal? OtbRevparWoOoo { get; set; }
    public decimal? OtbRevparComp { get; set; }
    public decimal? OtbRevparWoOooComp { get; set; }
    public decimal? ForOccupancyPct { get; set; }
    public decimal? ForOccupancyPctComp { get; set; }
    public decimal? ForOccupancyPctWoOoo { get; set; }
    public decimal? ForOccupancyPctWoOooComp { get; set; }
    public decimal? ForAdr { get; set; }
    public decimal? ForAdrComp { get; set; }
    public decimal? ForRevpar { get; set; }
    public decimal? ForRevparWoOoo { get; set; }
    public decimal? ForRevparComp { get; set; }
    public decimal? ForRevparWoOooComp { get; set; }
    public decimal? ForOccupancy { get; set; }
    public string? CeilingOooYn { get; set; }
    public decimal? TransientOtb { get; set; }
    public decimal? GrpTotTbBlocks { get; set; }
    public decimal? GrpTotNontbBlocks { get; set; }
    public decimal? DefNontbRooms { get; set; }
    public decimal? DefTbRooms { get; set; }
    public decimal? TentNontbRooms { get; set; }
    public decimal? TentTbRooms { get; set; }
    public decimal? PickedupNontbRooms { get; set; }
    public decimal? PickedupTbRooms { get; set; }
    public decimal? DepForecast { get; set; }
    public decimal? GroupMtrlNontb { get; set; }
    public decimal? GroupMtrlTb { get; set; }
    public decimal? InvOnthebooksTb { get; set; }
    public decimal? InvOnthebooksNontb { get; set; }
    public decimal? ForOccupancyTb { get; set; }
    public decimal? ForOccupancyNontb { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsCntrpnlYcVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_CNTRPNL_YC_VW");

            entity.Property(e => e.CeilingOooYn)
                .HasColumnName("CEILING_OOO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DefNontbRooms)
                .HasColumnName("DEF_NONTB_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefTbRooms)
                .HasColumnName("DEF_TB_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepForecast)
                .HasColumnName("DEP_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DisplayText)
                .HasColumnName("DISPLAY_TEXT")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ForAdr)
                .HasColumnName("FOR_ADR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForAdrComp)
                .HasColumnName("FOR_ADR_COMP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForOccupancy)
                .HasColumnName("FOR_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForOccupancyNontb)
                .HasColumnName("FOR_OCCUPANCY_NONTB")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForOccupancyPct)
                .HasColumnName("FOR_OCCUPANCY_PCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForOccupancyPctComp)
                .HasColumnName("FOR_OCCUPANCY_PCT_COMP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForOccupancyPctWoOoo)
                .HasColumnName("FOR_OCCUPANCY_PCT_WO_OOO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForOccupancyPctWoOooComp)
                .HasColumnName("FOR_OCCUPANCY_PCT_WO_OOO_COMP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForOccupancyTb)
                .HasColumnName("FOR_OCCUPANCY_TB")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForRevpar)
                .HasColumnName("FOR_REVPAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForRevparComp)
                .HasColumnName("FOR_REVPAR_COMP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForRevparWoOoo)
                .HasColumnName("FOR_REVPAR_WO_OOO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForRevparWoOooComp)
                .HasColumnName("FOR_REVPAR_WO_OOO_COMP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupMtrlNontb)
                .HasColumnName("GROUP_MTRL_NONTB")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupMtrlTb)
                .HasColumnName("GROUP_MTRL_TB")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpDefblocks)
                .HasColumnName("GRP_DEFBLOCKS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpForecasted)
                .HasColumnName("GRP_FORECASTED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpForecastedNontb)
                .HasColumnName("GRP_FORECASTED_NONTB")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpForecastedTb)
                .HasColumnName("GRP_FORECASTED_TB")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpPickedup)
                .HasColumnName("GRP_PICKEDUP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpTentblocks)
                .HasColumnName("GRP_TENTBLOCKS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpTotNontbBlocks)
                .HasColumnName("GRP_TOT_NONTB_BLOCKS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpTotTbBlocks)
                .HasColumnName("GRP_TOT_TB_BLOCKS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpTotblocks)
                .HasColumnName("GRP_TOTBLOCKS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvAvailable)
                .HasColumnName("INV_AVAILABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvAvailableWoOoo)
                .HasColumnName("INV_AVAILABLE_WO_OOO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvOnthebooks)
                .HasColumnName("INV_ONTHEBOOKS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvOnthebooksNontb)
                .HasColumnName("INV_ONTHEBOOKS_NONTB")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvOnthebooksTb)
                .HasColumnName("INV_ONTHEBOOKS_TB")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvOoo)
                .HasColumnName("INV_OOO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvOversell)
                .HasColumnName("INV_OVERSELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvPhysical)
                .HasColumnName("INV_PHYSICAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbAdr)
                .HasColumnName("OTB_ADR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbAdrComp)
                .HasColumnName("OTB_ADR_COMP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbOccupancyPct)
                .HasColumnName("OTB_OCCUPANCY_PCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbOccupancyPctComp)
                .HasColumnName("OTB_OCCUPANCY_PCT_COMP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbOccupancyPctWoOoo)
                .HasColumnName("OTB_OCCUPANCY_PCT_WO_OOO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbOccupancyPctWoOooComp)
                .HasColumnName("OTB_OCCUPANCY_PCT_WO_OOO_COMP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbRevpar)
                .HasColumnName("OTB_REVPAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbRevparComp)
                .HasColumnName("OTB_REVPAR_COMP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbRevparWoOoo)
                .HasColumnName("OTB_REVPAR_WO_OOO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbRevparWoOooComp)
                .HasColumnName("OTB_REVPAR_WO_OOO_COMP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OversellForecast)
                .HasColumnName("OVERSELL_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickedupNontbRooms)
                .HasColumnName("PICKEDUP_NONTB_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickedupTbRooms)
                .HasColumnName("PICKEDUP_TB_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordDate)
                .HasColumnName("RECORD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SeasonColor)
                .HasColumnName("SEASON_COLOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TentNontbRooms)
                .HasColumnName("TENT_NONTB_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TentTbRooms)
                .HasColumnName("TENT_TB_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransientOtb)
                .HasColumnName("TRANSIENT_OTB")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrnArrivalFore)
                .HasColumnName("TRN_ARRIVAL_FORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrnArrivalFore2)
                .HasColumnName("TRN_ARRIVAL_FORE2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrnArrivals)
                .HasColumnName("TRN_ARRIVALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrnCnclFore)
                .HasColumnName("TRN_CNCL_FORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrnResvFore)
                .HasColumnName("TRN_RESV_FORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrnStayFore)
                .HasColumnName("TRN_STAY_FORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
