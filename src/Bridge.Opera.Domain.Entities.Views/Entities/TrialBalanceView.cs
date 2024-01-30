namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TrialBalanceView
{
    public string? Description { get; set; }
    public string? Resort { get; set; }
    public DateTime? TrxDate { get; set; }
    public string? TrxCode { get; set; }
    public decimal? DepLedDebit { get; set; }
    public decimal? DepLedCredit { get; set; }
    public decimal? GuestLedDebit { get; set; }
    public decimal? GuestLedCredit { get; set; }
    public decimal? PackageLedDebit { get; set; }
    public decimal? PackageLedCredit { get; set; }
    public decimal? ArLedDebit { get; set; }
    public decimal? ArLedCredit { get; set; }
    public decimal? Revenue { get; set; }
    public decimal? TrxAmount { get; set; }
    public decimal? NetAmount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrialBalanceView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TRIAL_BALANCE_VIEW");

            entity.Property(e => e.ArLedCredit)
                .HasColumnName("AR_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArLedDebit)
                .HasColumnName("AR_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepLedCredit)
                .HasColumnName("DEP_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepLedDebit)
                .HasColumnName("DEP_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GuestLedCredit)
                .HasColumnName("GUEST_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestLedDebit)
                .HasColumnName("GUEST_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageLedCredit)
                .HasColumnName("PACKAGE_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageLedDebit)
                .HasColumnName("PACKAGE_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Revenue)
                .HasColumnName("REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");
        });
	}
}
