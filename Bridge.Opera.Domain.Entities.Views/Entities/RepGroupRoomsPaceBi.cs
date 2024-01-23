namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepGroupRoomsPaceBi
{
    public decimal? ReportId { get; set; }
    public string Resort { get; set; }
    public decimal? StayYear { get; set; }
    public DateTime? StayDate { get; set; }
    public string RecordType { get; set; }
    public decimal? NewDefRms { get; set; }
    public decimal? CancelRms { get; set; }
    public decimal? RevalRms { get; set; }
    public decimal? SlippageRms { get; set; }
    public decimal? NetChange { get; set; }
    public decimal? OtbActDefRms { get; set; }
    public decimal? OtbActDefRev { get; set; }
    public decimal? OtbActDefAvg { get; set; }
    public decimal? OtbActlyRms { get; set; }
    public decimal? OtbActlyRev { get; set; }
    public decimal? OtbActlyAvg { get; set; }
    public decimal? OtbActlyRmsVar { get; set; }
    public decimal? OtbActlyRevVar { get; set; }
    public decimal? OtbActlyAvgVar { get; set; }
    public decimal? OtbStlyRms { get; set; }
    public decimal? OtbStlyRev { get; set; }
    public decimal? OtbStlyAvg { get; set; }
    public decimal? OtbStlyRmsVar { get; set; }
    public decimal? OtbStlyRevVar { get; set; }
    public decimal? OtbStlyAvgVar { get; set; }
    public decimal? BudgetRms { get; set; }
    public decimal? BudgetRev { get; set; }
    public decimal? BudgetAvg { get; set; }
    public decimal? BudgetRmsVar { get; set; }
    public decimal? BudgetRevVar { get; set; }
    public decimal? BudgetAvgVar { get; set; }
    public decimal? OtbStat2TyRms { get; set; }
    public decimal? OtbStat2TyRev { get; set; }
    public decimal? OtbStat2TyAvg { get; set; }
    public decimal? OtbStat2StlyRms { get; set; }
    public decimal? OtbStat2StlyRev { get; set; }
    public decimal? OtbStat2StlyAvg { get; set; }
    public decimal? OtbStat2RmsVar { get; set; }
    public decimal? OtbStat2RevVar { get; set; }
    public decimal? OtbStat2AvgVar { get; set; }
    public decimal? OtbStat3TyRms { get; set; }
    public decimal? OtbStat3TyRev { get; set; }
    public decimal? OtbStat3TyAvg { get; set; }
    public decimal? OtbStat3StlyRms { get; set; }
    public decimal? OtbStat3StlyRev { get; set; }
    public decimal? OtbStat3StlyAvg { get; set; }
    public decimal? OtbStat3RmsVar { get; set; }
    public decimal? OtbStat3RevVar { get; set; }
    public decimal? OtbStat3AvgVar { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepGroupRoomsPaceBi>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_GROUP_ROOMS_PACE_BI");

            entity.Property(e => e.BudgetAvg)
                .HasColumnName("BUDGET_AVG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetAvgVar)
                .HasColumnName("BUDGET_AVG_VAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetRev)
                .HasColumnName("BUDGET_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetRevVar)
                .HasColumnName("BUDGET_REV_VAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetRms)
                .HasColumnName("BUDGET_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetRmsVar)
                .HasColumnName("BUDGET_RMS_VAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelRms)
                .HasColumnName("CANCEL_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetChange)
                .HasColumnName("NET_CHANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewDefRms)
                .HasColumnName("NEW_DEF_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbActDefAvg)
                .HasColumnName("OTB_ACT_DEF_AVG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbActDefRev)
                .HasColumnName("OTB_ACT_DEF_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbActDefRms)
                .HasColumnName("OTB_ACT_DEF_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbActlyAvg)
                .HasColumnName("OTB_ACTLY_AVG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbActlyAvgVar)
                .HasColumnName("OTB_ACTLY_AVG_VAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbActlyRev)
                .HasColumnName("OTB_ACTLY_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbActlyRevVar)
                .HasColumnName("OTB_ACTLY_REV_VAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbActlyRms)
                .HasColumnName("OTB_ACTLY_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbActlyRmsVar)
                .HasColumnName("OTB_ACTLY_RMS_VAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat2AvgVar)
                .HasColumnName("OTB_STAT2_AVG_VAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat2RevVar)
                .HasColumnName("OTB_STAT2_REV_VAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat2RmsVar)
                .HasColumnName("OTB_STAT2_RMS_VAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat2StlyAvg)
                .HasColumnName("OTB_STAT2_STLY_AVG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat2StlyRev)
                .HasColumnName("OTB_STAT2_STLY_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat2StlyRms)
                .HasColumnName("OTB_STAT2_STLY_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat2TyAvg)
                .HasColumnName("OTB_STAT2_TY_AVG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat2TyRev)
                .HasColumnName("OTB_STAT2_TY_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat2TyRms)
                .HasColumnName("OTB_STAT2_TY_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat3AvgVar)
                .HasColumnName("OTB_STAT3_AVG_VAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat3RevVar)
                .HasColumnName("OTB_STAT3_REV_VAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat3RmsVar)
                .HasColumnName("OTB_STAT3_RMS_VAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat3StlyAvg)
                .HasColumnName("OTB_STAT3_STLY_AVG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat3StlyRev)
                .HasColumnName("OTB_STAT3_STLY_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat3StlyRms)
                .HasColumnName("OTB_STAT3_STLY_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat3TyAvg)
                .HasColumnName("OTB_STAT3_TY_AVG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat3TyRev)
                .HasColumnName("OTB_STAT3_TY_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat3TyRms)
                .HasColumnName("OTB_STAT3_TY_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStlyAvg)
                .HasColumnName("OTB_STLY_AVG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStlyAvgVar)
                .HasColumnName("OTB_STLY_AVG_VAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStlyRev)
                .HasColumnName("OTB_STLY_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStlyRevVar)
                .HasColumnName("OTB_STLY_REV_VAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStlyRms)
                .HasColumnName("OTB_STLY_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStlyRmsVar)
                .HasColumnName("OTB_STLY_RMS_VAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RevalRms)
                .HasColumnName("REVAL_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SlippageRms)
                .HasColumnName("SLIPPAGE_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StayYear)
                .HasColumnName("STAY_YEAR")
                .HasColumnType("NUMBER");
        });
	}
}
