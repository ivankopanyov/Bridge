namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CashierResortsView
{
    public string Resort { get; set; }
    public string Name { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string CurrencyCode { get; set; }
    public string CashShiftDrop { get; set; }
    public string CheckShiftDrop { get; set; }
    public string CheckTrxcode { get; set; }
    public string ArCreditTrxCode { get; set; }
    public string ResvYn { get; set; }
    public decimal? CashierId { get; set; }
    public decimal? ClosureNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CashierResortsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CASHIER_RESORTS_VIEW");

            entity.Property(e => e.ArCreditTrxCode)
                .HasColumnName("AR_CREDIT_TRX_CODE")
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CashShiftDrop)
                .HasColumnName("CASH_SHIFT_DROP")
                .IsUnicode(false);

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckShiftDrop)
                .HasColumnName("CHECK_SHIFT_DROP")
                .IsUnicode(false);

            entity.Property(e => e.CheckTrxcode)
                .HasColumnName("CHECK_TRXCODE")
                .IsUnicode(false);

            entity.Property(e => e.ClosureNo)
                .HasColumnName("CLOSURE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvYn)
                .HasColumnName("RESV_YN")
                .IsUnicode(false);
        });
	}
}
