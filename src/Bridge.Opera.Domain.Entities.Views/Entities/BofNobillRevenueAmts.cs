namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofNobillRevenueAmts
{
    public string AccountPeriod { get; set; }
    public decimal? UserId { get; set; }
    public string UserName { get; set; }
    public string TrxCode { get; set; }
    public string TrxDesc { get; set; }
    public DateTime? TrxDate { get; set; }
    public string TrxType { get; set; }
    public decimal? InhCredit { get; set; }
    public decimal? InhDebit { get; set; }
    public decimal? DepLedDebit { get; set; }
    public decimal? DepLedCredit { get; set; }
    public decimal? GuestLedDebit { get; set; }
    public decimal? GuestLedCredit { get; set; }
    public decimal? PackageLedDebit { get; set; }
    public decimal? PackageLedCredit { get; set; }
    public decimal? ArLedDebit { get; set; }
    public decimal? InternalDbPayments { get; set; }
    public decimal? ArLedCredit { get; set; }
    public decimal? CashierLedCredit { get; set; }
    public decimal? CashierLedDebit { get; set; }
    public decimal? GrossAmount { get; set; }
    public decimal? CalcGrossAmount { get; set; }
    public string GrossDrCrFlag { get; set; }
    public decimal? NetAmount { get; set; }
    public string NetDrCrFlag { get; set; }
    public decimal? VatAmount { get; set; }
    public string VatDrCrFlag { get; set; }
    public decimal? TaxAmount { get; set; }
    public string TaxDrCrFlag { get; set; }
    public string TrxCodeType { get; set; }
    public string TcGroup { get; set; }
    public string TcSubgroup { get; set; }
    public string ArInd { get; set; }
    public decimal? RevBucketId { get; set; }
    public string CashInd { get; set; }
    public string ManualPostYn { get; set; }
    public string IndRevenueGp { get; set; }
    public string ArrangementCode { get; set; }
    public decimal? ExpenseFolio { get; set; }
    public decimal? GroupFolio { get; set; }
    public string TaxTrxCode { get; set; }
    public decimal? TaxNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofNobillRevenueAmts>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_NOBILL_REVENUE_AMTS");

            entity.Property(e => e.AccountPeriod)
                .HasColumnName("ACCOUNT_PERIOD")
                .IsUnicode(false);

            entity.Property(e => e.ArInd)
                .HasColumnName("AR_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ArLedCredit)
                .HasColumnName("AR_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArLedDebit)
                .HasColumnName("AR_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrangementCode)
                .HasColumnName("ARRANGEMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CalcGrossAmount)
                .HasColumnName("CALC_GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashInd)
                .HasColumnName("CASH_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CashierLedCredit)
                .HasColumnName("CASHIER_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierLedDebit)
                .HasColumnName("CASHIER_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepLedCredit)
                .HasColumnName("DEP_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepLedDebit)
                .HasColumnName("DEP_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpenseFolio)
                .HasColumnName("EXPENSE_FOLIO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossDrCrFlag)
                .HasColumnName("GROSS_DR_CR_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GroupFolio)
                .HasColumnName("GROUP_FOLIO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestLedCredit)
                .HasColumnName("GUEST_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestLedDebit)
                .HasColumnName("GUEST_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndRevenueGp)
                .HasColumnName("IND_REVENUE_GP")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InhCredit)
                .HasColumnName("INH_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InhDebit)
                .HasColumnName("INH_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalDbPayments)
                .HasColumnName("INTERNAL_DB_PAYMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ManualPostYn)
                .HasColumnName("MANUAL_POST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetDrCrFlag)
                .HasColumnName("NET_DR_CR_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PackageLedCredit)
                .HasColumnName("PACKAGE_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageLedDebit)
                .HasColumnName("PACKAGE_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevBucketId)
                .HasColumnName("REV_BUCKET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxAmount)
                .HasColumnName("TAX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxDrCrFlag)
                .HasColumnName("TAX_DR_CR_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TaxNo)
                .HasColumnName("TAX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxTrxCode)
                .HasColumnName("TAX_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcGroup)
                .IsRequired()
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .IsRequired()
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeType)
                .HasColumnName("TRX_CODE_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxDesc)
                .HasColumnName("TRX_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrxType)
                .HasColumnName("TRX_TYPE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserName)
                .HasColumnName("USER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.VatAmount)
                .HasColumnName("VAT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VatDrCrFlag)
                .HasColumnName("VAT_DR_CR_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
