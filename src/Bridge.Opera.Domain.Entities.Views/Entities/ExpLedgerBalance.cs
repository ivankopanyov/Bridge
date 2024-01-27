namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpLedgerBalance
{
    public DateTime? BusinessDate { get; set; }
    public decimal? DepositLedgerBalance { get; set; }
    public decimal? GuestLedgerBalance { get; set; }
    public decimal? PackageLedgerBalance { get; set; }
    public decimal? ArLedgerBalance { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpLedgerBalance>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_LEDGER_BALANCE");

            entity.Property(e => e.ArLedgerBalance)
                .HasColumnName("AR_LEDGER_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepositLedgerBalance)
                .HasColumnName("DEPOSIT_LEDGER_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestLedgerBalance)
                .HasColumnName("GUEST_LEDGER_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageLedgerBalance)
                .HasColumnName("PACKAGE_LEDGER_BALANCE")
                .HasColumnType("NUMBER");
        });
	}
}
