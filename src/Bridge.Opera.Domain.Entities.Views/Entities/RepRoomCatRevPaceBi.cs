namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepRoomCatRevPaceBi
{
    public decimal? ReportId { get; set; }
    public string? Resort { get; set; }
    public decimal? StayYear { get; set; }
    public DateTime? StayDate { get; set; }
    public string? RecordType { get; set; }
    public decimal? NewDefRev { get; set; }
    public decimal? CancelRev { get; set; }
    public decimal? Revaluation { get; set; }
    public decimal? Slippage { get; set; }
    public decimal? NetChange { get; set; }
    public decimal? OtbActDef { get; set; }
    public decimal? OtbBudget { get; set; }
    public decimal? OtbStly { get; set; }
    public decimal? OtbActly { get; set; }
    public decimal? PaceVarBudget { get; set; }
    public decimal? PaceVarBudgetPct { get; set; }
    public decimal? PaceVarStly { get; set; }
    public decimal? PaceVarStlyPct { get; set; }
    public decimal? PaceVarActly { get; set; }
    public decimal? PaceVarActlyPct { get; set; }
    public decimal? OtbStatus2 { get; set; }
    public decimal? OtbStatus3 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepRoomCatRevPaceBi>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_ROOM_CAT_REV_PACE_BI");

            entity.Property(e => e.CancelRev)
                .HasColumnName("CANCEL_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetChange)
                .HasColumnName("NET_CHANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewDefRev)
                .HasColumnName("NEW_DEF_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbActDef)
                .HasColumnName("OTB_ACT_DEF")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbActly)
                .HasColumnName("OTB_ACTLY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbBudget)
                .HasColumnName("OTB_BUDGET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStatus2)
                .HasColumnName("OTB_STATUS2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStatus3)
                .HasColumnName("OTB_STATUS3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStly)
                .HasColumnName("OTB_STLY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaceVarActly)
                .HasColumnName("PACE_VAR_ACTLY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaceVarActlyPct)
                .HasColumnName("PACE_VAR_ACTLY_PCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaceVarBudget)
                .HasColumnName("PACE_VAR_BUDGET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaceVarBudgetPct)
                .HasColumnName("PACE_VAR_BUDGET_PCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaceVarStly)
                .HasColumnName("PACE_VAR_STLY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaceVarStlyPct)
                .HasColumnName("PACE_VAR_STLY_PCT")
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

            entity.Property(e => e.Revaluation)
                .HasColumnName("REVALUATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Slippage)
                .HasColumnName("SLIPPAGE")
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
