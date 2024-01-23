namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepRoomCatRevPaceVw
{
    public decimal? ReportId { get; set; }
    public string Resort { get; set; }
    public decimal? BookId { get; set; }
    public string CatOnlyYn { get; set; }
    public decimal? Owner { get; set; }
    public decimal? RmsOwner { get; set; }
    public decimal? CatOwner { get; set; }
    public DateTime? StayDate { get; set; }
    public decimal? NewDefRms { get; set; }
    public decimal? NewDefRev { get; set; }
    public decimal? CancelRms { get; set; }
    public decimal? CancelRev { get; set; }
    public decimal? RevalRms { get; set; }
    public decimal? RevalRev { get; set; }
    public decimal? SlippageRms { get; set; }
    public decimal? SlippageRev { get; set; }
    public decimal? BudgetRms { get; set; }
    public decimal? BudgetRev { get; set; }
    public decimal? OtbActDefRms { get; set; }
    public decimal? OtbActDefRev { get; set; }
    public decimal? OtbStlyRms { get; set; }
    public decimal? OtbStlyRev { get; set; }
    public decimal? OtbActlyRms { get; set; }
    public decimal? OtbActlyRev { get; set; }
    public decimal? OtbStat2TyRms { get; set; }
    public decimal? OtbStat2TyRev { get; set; }
    public decimal? OtbStat3TyRms { get; set; }
    public decimal? OtbStat3TyRev { get; set; }
    public decimal? OtbStat2StlyRms { get; set; }
    public decimal? OtbStat2StlyRev { get; set; }
    public decimal? OtbStat3StlyRms { get; set; }
    public decimal? OtbStat3StlyRev { get; set; }
    public string CatBudgetYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepRoomCatRevPaceVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_ROOM_CAT_REV_PACE_VW");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetRev)
                .HasColumnName("BUDGET_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetRms)
                .HasColumnName("BUDGET_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelRev)
                .HasColumnName("CANCEL_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelRms)
                .HasColumnName("CANCEL_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatBudgetYn)
                .HasColumnName("CAT_BUDGET_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CatOnlyYn)
                .HasColumnName("CAT_ONLY_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CatOwner)
                .HasColumnName("CAT_OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewDefRev)
                .HasColumnName("NEW_DEF_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewDefRms)
                .HasColumnName("NEW_DEF_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbActDefRev)
                .HasColumnName("OTB_ACT_DEF_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbActDefRms)
                .HasColumnName("OTB_ACT_DEF_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbActlyRev)
                .HasColumnName("OTB_ACTLY_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbActlyRms)
                .HasColumnName("OTB_ACTLY_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat2StlyRev)
                .HasColumnName("OTB_STAT2_STLY_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat2StlyRms)
                .HasColumnName("OTB_STAT2_STLY_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat2TyRev)
                .HasColumnName("OTB_STAT2_TY_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat2TyRms)
                .HasColumnName("OTB_STAT2_TY_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat3StlyRev)
                .HasColumnName("OTB_STAT3_STLY_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat3StlyRms)
                .HasColumnName("OTB_STAT3_STLY_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat3TyRev)
                .HasColumnName("OTB_STAT3_TY_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStat3TyRms)
                .HasColumnName("OTB_STAT3_TY_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStlyRev)
                .HasColumnName("OTB_STLY_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbStlyRms)
                .HasColumnName("OTB_STLY_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Owner)
                .HasColumnName("OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RevalRev)
                .HasColumnName("REVAL_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevalRms)
                .HasColumnName("REVAL_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmsOwner)
                .HasColumnName("RMS_OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SlippageRev)
                .HasColumnName("SLIPPAGE_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SlippageRms)
                .HasColumnName("SLIPPAGE_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");
        });
	}
}
