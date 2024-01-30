namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TrialBalance
{
    public string? Resort { get; set; }
    public string? Description { get; set; }
    public DateTime? TrxDate { get; set; }
    public string? RoomClass { get; set; }
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
    public decimal? InternalDbPayments { get; set; }
    public decimal? PackageLedTax { get; set; }
    public decimal? Tax1Amt { get; set; }
    public decimal? Tax2Amt { get; set; }
    public decimal? Tax3Amt { get; set; }
    public decimal? Tax4Amt { get; set; }
    public decimal? Tax5Amt { get; set; }
    public decimal? Tax6Amt { get; set; }
    public decimal? Tax7Amt { get; set; }
    public decimal? Tax8Amt { get; set; }
    public decimal? Tax9Amt { get; set; }
    public decimal? Tax10Amt { get; set; }
    public decimal? Net1Amt { get; set; }
    public decimal? Net2Amt { get; set; }
    public decimal? Net3Amt { get; set; }
    public decimal? Net4Amt { get; set; }
    public decimal? Net5Amt { get; set; }
    public decimal? Net6Amt { get; set; }
    public decimal? Net7Amt { get; set; }
    public decimal? Net8Amt { get; set; }
    public decimal? Net9Amt { get; set; }
    public decimal? Net10Amt { get; set; }
    public decimal? OwnerLedDebit { get; set; }
    public decimal? OwnerLedCredit { get; set; }
    public decimal? Tax11Amt { get; set; }
    public decimal? Tax12Amt { get; set; }
    public decimal? Tax13Amt { get; set; }
    public decimal? Tax14Amt { get; set; }
    public decimal? Tax15Amt { get; set; }
    public decimal? Tax16Amt { get; set; }
    public decimal? Tax17Amt { get; set; }
    public decimal? Tax18Amt { get; set; }
    public decimal? Tax19Amt { get; set; }
    public decimal? Tax20Amt { get; set; }
    public decimal? Net11Amt { get; set; }
    public decimal? Net12Amt { get; set; }
    public decimal? Net13Amt { get; set; }
    public decimal? Net14Amt { get; set; }
    public decimal? Net15Amt { get; set; }
    public decimal? Net16Amt { get; set; }
    public decimal? Net17Amt { get; set; }
    public decimal? Net18Amt { get; set; }
    public decimal? Net19Amt { get; set; }
    public decimal? Net20Amt { get; set; }
    public decimal? DepFolioDebit { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrialBalance>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TRIAL_BALANCE");

            entity.HasIndex(e => new { e.Resort, e.TrxDate, e.TrxCode })
                .HasName("TRIAL_BALANCE_IDX1");

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

            entity.Property(e => e.DepFolioDebit)
                .HasColumnName("DEP_FOLIO_DEBIT")
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

            entity.Property(e => e.InternalDbPayments)
                .HasColumnName("INTERNAL_DB_PAYMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net10Amt)
                .HasColumnName("NET10_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net11Amt)
                .HasColumnName("NET11_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net12Amt)
                .HasColumnName("NET12_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net13Amt)
                .HasColumnName("NET13_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net14Amt)
                .HasColumnName("NET14_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net15Amt)
                .HasColumnName("NET15_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net16Amt)
                .HasColumnName("NET16_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net17Amt)
                .HasColumnName("NET17_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net18Amt)
                .HasColumnName("NET18_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net19Amt)
                .HasColumnName("NET19_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net1Amt)
                .HasColumnName("NET1_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net20Amt)
                .HasColumnName("NET20_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net2Amt)
                .HasColumnName("NET2_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net3Amt)
                .HasColumnName("NET3_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net4Amt)
                .HasColumnName("NET4_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net5Amt)
                .HasColumnName("NET5_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net6Amt)
                .HasColumnName("NET6_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net7Amt)
                .HasColumnName("NET7_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net8Amt)
                .HasColumnName("NET8_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Net9Amt)
                .HasColumnName("NET9_AMT")
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

            entity.Property(e => e.OwnerLedCredit)
                .HasColumnName("OWNER_LED_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.OwnerLedDebit)
                .HasColumnName("OWNER_LED_DEBIT")
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

            entity.Property(e => e.PackageLedTax)
                .HasColumnName("PACKAGE_LED_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Resort)
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

            entity.Property(e => e.Tax10Amt)
                .HasColumnName("TAX10_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax11Amt)
                .HasColumnName("TAX11_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax12Amt)
                .HasColumnName("TAX12_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax13Amt)
                .HasColumnName("TAX13_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax14Amt)
                .HasColumnName("TAX14_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax15Amt)
                .HasColumnName("TAX15_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax16Amt)
                .HasColumnName("TAX16_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax17Amt)
                .HasColumnName("TAX17_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax18Amt)
                .HasColumnName("TAX18_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax19Amt)
                .HasColumnName("TAX19_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax1Amt)
                .HasColumnName("TAX1_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax20Amt)
                .HasColumnName("TAX20_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax2Amt)
                .HasColumnName("TAX2_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax3Amt)
                .HasColumnName("TAX3_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax4Amt)
                .HasColumnName("TAX4_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax5Amt)
                .HasColumnName("TAX5_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax6Amt)
                .HasColumnName("TAX6_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax7Amt)
                .HasColumnName("TAX7_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax8Amt)
                .HasColumnName("TAX8_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Tax9Amt)
                .HasColumnName("TAX9_AMT")
                .HasColumnType("NUMBER(38,12)");

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
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");
        });
	}
}
