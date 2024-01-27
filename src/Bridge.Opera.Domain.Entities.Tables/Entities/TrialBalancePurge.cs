namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TrialBalancePurge
{
    public string Resort { get; set; }
    public string Description { get; set; }
    public DateTime TrxDate { get; set; }
    public string RoomClass { get; set; }
    public string TrxCode { get; set; }
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
    public decimal? GrossAmount { get; set; }
    public decimal? DepLedDebitMm { get; set; }
    public decimal? DepLedCreditMm { get; set; }
    public decimal? GuestLedDebitMm { get; set; }
    public decimal? GuestLedCreditMm { get; set; }
    public decimal? PackageLedDebitMm { get; set; }
    public decimal? PackageLedCreditMm { get; set; }
    public decimal? ArLedDebitMm { get; set; }
    public decimal? ArLedCreditMm { get; set; }
    public decimal? RevenueMm { get; set; }
    public decimal? TrxAmountMm { get; set; }
    public decimal? NetAmountMm { get; set; }
    public decimal? GrossAmountMm { get; set; }
    public decimal? DepLedDebitYy { get; set; }
    public decimal? DepLedCreditYy { get; set; }
    public decimal? GuestLedDebitYy { get; set; }
    public decimal? GuestLedCreditYy { get; set; }
    public decimal? PackageLedDebitYy { get; set; }
    public decimal? PackageLedCreditYy { get; set; }
    public decimal? ArLedDebitYy { get; set; }
    public decimal? ArLedCreditYy { get; set; }
    public decimal? RevenueYy { get; set; }
    public decimal? TrxAmountYy { get; set; }
    public decimal? NetAmountYy { get; set; }
    public decimal? GrossAmountYy { get; set; }
    public decimal? NonRevenueAmt { get; set; }
    public decimal? InhCredit { get; set; }
    public decimal? InhDebit { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrialBalancePurge>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TRIAL_BALANCE_PURGE");

            entity.Property(e => e.ArLedCredit)
                .HasColumnName("AR_LED_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ArLedCreditMm)
                .HasColumnName("AR_LED_CREDIT_MM")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ArLedCreditYy)
                .HasColumnName("AR_LED_CREDIT_YY")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ArLedDebit)
                .HasColumnName("AR_LED_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ArLedDebitMm)
                .HasColumnName("AR_LED_DEBIT_MM")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ArLedDebitYy)
                .HasColumnName("AR_LED_DEBIT_YY")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.DepLedCredit)
                .HasColumnName("DEP_LED_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.DepLedCreditMm)
                .HasColumnName("DEP_LED_CREDIT_MM")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.DepLedCreditYy)
                .HasColumnName("DEP_LED_CREDIT_YY")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.DepLedDebit)
                .HasColumnName("DEP_LED_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.DepLedDebitMm)
                .HasColumnName("DEP_LED_DEBIT_MM")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.DepLedDebitYy)
                .HasColumnName("DEP_LED_DEBIT_YY")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GrossAmountMm)
                .HasColumnName("GROSS_AMOUNT_MM")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GrossAmountYy)
                .HasColumnName("GROSS_AMOUNT_YY")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestLedCredit)
                .HasColumnName("GUEST_LED_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestLedCreditMm)
                .HasColumnName("GUEST_LED_CREDIT_MM")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestLedCreditYy)
                .HasColumnName("GUEST_LED_CREDIT_YY")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestLedDebit)
                .HasColumnName("GUEST_LED_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestLedDebitMm)
                .HasColumnName("GUEST_LED_DEBIT_MM")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestLedDebitYy)
                .HasColumnName("GUEST_LED_DEBIT_YY")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.InhCredit)
                .HasColumnName("INH_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.InhDebit)
                .HasColumnName("INH_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.NetAmountMm)
                .HasColumnName("NET_AMOUNT_MM")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.NetAmountYy)
                .HasColumnName("NET_AMOUNT_YY")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.NonRevenueAmt)
                .HasColumnName("NON_REVENUE_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageLedCredit)
                .HasColumnName("PACKAGE_LED_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageLedCreditMm)
                .HasColumnName("PACKAGE_LED_CREDIT_MM")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageLedCreditYy)
                .HasColumnName("PACKAGE_LED_CREDIT_YY")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageLedDebit)
                .HasColumnName("PACKAGE_LED_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageLedDebitMm)
                .HasColumnName("PACKAGE_LED_DEBIT_MM")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageLedDebitYy)
                .HasColumnName("PACKAGE_LED_DEBIT_YY")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Revenue)
                .HasColumnName("REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RevenueMm)
                .HasColumnName("REVENUE_MM")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RevenueYy)
                .HasColumnName("REVENUE_YY")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TrxAmountMm)
                .HasColumnName("TRX_AMOUNT_MM")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TrxAmountYy)
                .HasColumnName("TRX_AMOUNT_YY")
                .HasColumnType("NUMBER(38,12)");

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
