namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSys21PropControlTotals
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? GlBalanceYesterday { get; set; }
    public decimal? GlBalanceToday { get; set; }
    public decimal? ArBalanceYesterday { get; set; }
    public decimal? ArBalanceToday { get; set; }
    public decimal? DpBalanceYesterday { get; set; }
    public decimal? DpBalanceToday { get; set; }
    public decimal? AgeBucket1Balance { get; set; }
    public decimal? AgeBucket2Balance { get; set; }
    public decimal? AgeBucket3Balance { get; set; }
    public decimal? AgeBucket4Balance { get; set; }
    public decimal? AgeBucket5Balance { get; set; }
    public decimal? AgeBucket6Balance { get; set; }
    public decimal? OpenBalanceRooms { get; set; }
    public decimal? OpenBalancePm { get; set; }
    public decimal? OpenBalanceHouse { get; set; }
    public decimal? OpenBalanceCheckedOut { get; set; }
    public decimal? RoomRevenueToday { get; set; }
    public decimal? CcPaymentsToday { get; set; }
    public decimal? CcPaymentsYesterday { get; set; }
    public decimal? BalanceBroughtForward { get; set; }
    public decimal? BalanceCarriedForward { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSys21PropControlTotals>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SYS21_PROP_CONTROL_TOTALS");

            entity.Property(e => e.AgeBucket1Balance)
                .HasColumnName("AGE_BUCKET_1_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgeBucket2Balance)
                .HasColumnName("AGE_BUCKET_2_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgeBucket3Balance)
                .HasColumnName("AGE_BUCKET_3_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgeBucket4Balance)
                .HasColumnName("AGE_BUCKET_4_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgeBucket5Balance)
                .HasColumnName("AGE_BUCKET_5_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgeBucket6Balance)
                .HasColumnName("AGE_BUCKET_6_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArBalanceToday)
                .HasColumnName("AR_BALANCE_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArBalanceYesterday)
                .HasColumnName("AR_BALANCE_YESTERDAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BalanceBroughtForward)
                .HasColumnName("BALANCE_BROUGHT_FORWARD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BalanceCarriedForward)
                .HasColumnName("BALANCE_CARRIED_FORWARD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcPaymentsToday)
                .HasColumnName("CC_PAYMENTS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcPaymentsYesterday)
                .HasColumnName("CC_PAYMENTS_YESTERDAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DpBalanceToday)
                .HasColumnName("DP_BALANCE_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DpBalanceYesterday)
                .HasColumnName("DP_BALANCE_YESTERDAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GlBalanceToday)
                .HasColumnName("GL_BALANCE_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GlBalanceYesterday)
                .HasColumnName("GL_BALANCE_YESTERDAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpenBalanceCheckedOut)
                .HasColumnName("OPEN_BALANCE_CHECKED_OUT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpenBalanceHouse)
                .HasColumnName("OPEN_BALANCE_HOUSE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpenBalancePm)
                .HasColumnName("OPEN_BALANCE_PM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpenBalanceRooms)
                .HasColumnName("OPEN_BALANCE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueToday)
                .HasColumnName("ROOM_REVENUE_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
