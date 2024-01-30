namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FolioPurgeTrialBalance
{
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
    public decimal? NonRevenueAmt { get; set; }
    public decimal? InhCredit { get; set; }
    public decimal? InhDebit { get; set; }
    public decimal? OwnerLedDebit { get; set; }
    public decimal? OwnerLedCredit { get; set; }
    public decimal? InternalDbPayments { get; set; }
    public decimal? DepFolioDebit { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FolioPurgeTrialBalance>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TrxDate, e.TrxCode })
                .HasName("FOLIO_PURGE_TRIAL_BALANCE_PK");

            entity.ToTable("FOLIO_PURGE_TRIAL_BALANCE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArLedCredit)
                .HasColumnName("AR_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArLedDebit)
                .HasColumnName("AR_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepFolioDebit)
                .HasColumnName("DEP_FOLIO_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.DepLedCredit)
                .HasColumnName("DEP_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepLedDebit)
                .HasColumnName("DEP_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestLedCredit)
                .HasColumnName("GUEST_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestLedDebit)
                .HasColumnName("GUEST_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InhCredit)
                .HasColumnName("INH_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InhDebit)
                .HasColumnName("INH_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalDbPayments)
                .HasColumnName("INTERNAL_DB_PAYMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenueAmt)
                .HasColumnName("NON_REVENUE_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerLedCredit)
                .HasColumnName("OWNER_LED_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.OwnerLedDebit)
                .HasColumnName("OWNER_LED_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageLedCredit)
                .HasColumnName("PACKAGE_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageLedDebit)
                .HasColumnName("PACKAGE_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Revenue)
                .HasColumnName("REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER");
        });
	}
}
