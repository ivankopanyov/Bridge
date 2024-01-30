namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpCashierDropAmounts
{
    public decimal? CashierId { get; set; }
    public decimal? ClosureNo { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? TotalCashReceived { get; set; }
    public decimal? TotalPaidouts { get; set; }
    public decimal? TotalCheckReceived { get; set; }
    public decimal? ActualCashDrop { get; set; }
    public decimal? ActualCheckDrop { get; set; }
    public decimal? DiffCash { get; set; }
    public decimal? DiffCheck { get; set; }
    public string? CashierAppUser { get; set; }
    public string? CashierName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpCashierDropAmounts>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CASHIER_DROP_AMOUNTS");

            entity.Property(e => e.ActualCashDrop)
                .HasColumnName("ACTUAL_CASH_DROP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualCheckDrop)
                .HasColumnName("ACTUAL_CHECK_DROP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CashierAppUser)
                .IsRequired()
                .HasColumnName("CASHIER_APP_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierName)
                .HasColumnName("CASHIER_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ClosureNo)
                .HasColumnName("CLOSURE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiffCash)
                .HasColumnName("DIFF_CASH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiffCheck)
                .HasColumnName("DIFF_CHECK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCashReceived)
                .HasColumnName("TOTAL_CASH_RECEIVED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCheckReceived)
                .HasColumnName("TOTAL_CHECK_RECEIVED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPaidouts)
                .HasColumnName("TOTAL_PAIDOUTS")
                .HasColumnType("NUMBER");
        });
	}
}
