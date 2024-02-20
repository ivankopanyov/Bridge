namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofFtrevenueMarketRecords
{
    public string? AccountPeriod { get; set; }
    public string? UserName { get; set; }
    public string? TrxCode { get; set; }
    public string? MarketCode { get; set; }
    public string? TaxRateString { get; set; }
    public string? TrxDesc { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? InthotelLedDebit { get; set; }
    public decimal? InthotelLedCredit { get; set; }
    public decimal? InthotelLedControl { get; set; }
    public string? InthotelLedControlFlag { get; set; }
    public decimal? DepLedDebit { get; set; }
    public decimal? DepLedCredit { get; set; }
    public decimal? DepLedControl { get; set; }
    public string? DepLedControlFlag { get; set; }
    public decimal? GuestLedDebit { get; set; }
    public decimal? GuestLedCredit { get; set; }
    public decimal? GuestLedControl { get; set; }
    public string? GuestLedControlFlag { get; set; }
    public decimal? PackageLedDebit { get; set; }
    public decimal? PackageLedCredit { get; set; }
    public decimal? PackageLedControl { get; set; }
    public string? PackageLedControlFlag { get; set; }
    public decimal? ArLedCredit { get; set; }
    public decimal? ArLedDebit { get; set; }
    public decimal? ArLedControl { get; set; }
    public string? ArLedControlFlag { get; set; }
    public decimal? GrossAmount { get; set; }
    public string? GrossDrCrFlag { get; set; }
    public decimal? NetAmount { get; set; }
    public string? NetDrCrFlag { get; set; }
    public decimal? VatAmount { get; set; }
    public string? VatDrCrFlag { get; set; }
    public string? TrxCodeType { get; set; }
    public string? TcGroup { get; set; }
    public string? TcSubgroup { get; set; }
    public string? ArInd { get; set; }
    public decimal? RevBucketId { get; set; }
    public string? CashInd { get; set; }
    public string? ManualPostYn { get; set; }
    public string? IndRevenueGp { get; set; }
    public string? ArrangementCode { get; set; }
    public decimal? ExpenseFolio { get; set; }
    public decimal? GroupFolio { get; set; }
    public decimal? BofIntfCode { get; set; }
    public string? BofCode1 { get; set; }
    public string? BofCode2 { get; set; }
    public string? BofCode3 { get; set; }
    public string? BofCode4 { get; set; }
    public string? BofCode5 { get; set; }
    public decimal? BofCode6 { get; set; }
    public decimal? BofCode7 { get; set; }
    public decimal? BofCode8 { get; set; }
    public decimal? BofCode9 { get; set; }
    public decimal? BofCode10 { get; set; }
    public DateTime? BofCode11 { get; set; }
    public DateTime? BofCode12 { get; set; }
    public DateTime? BofCode13 { get; set; }
    public DateTime? BofCode14 { get; set; }
    public DateTime? BofCode15 { get; set; }
    public string? BofCode16 { get; set; }
    public string? BofCode17 { get; set; }
    public string? BofCode18 { get; set; }
    public string? BofCode19 { get; set; }
    public string? BofCode20 { get; set; }
    public string? BofCode21 { get; set; }
    public string? BofCode22 { get; set; }
    public string? BofCode23 { get; set; }
    public string? BofCode24 { get; set; }
    public string? BofCode25 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofFtrevenueMarketRecords>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_FTREVENUE_MARKET_RECORDS");

            entity.Property(e => e.AccountPeriod)
                .HasColumnName("ACCOUNT_PERIOD")
                .IsUnicode(false);

            entity.Property(e => e.ArInd)
                .HasColumnName("AR_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ArLedControl)
                .HasColumnName("AR_LED_CONTROL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArLedControlFlag)
                .HasColumnName("AR_LED_CONTROL_FLAG")
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

            entity.Property(e => e.BofCode1)
                .HasColumnName("BOF_CODE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode10)
                .HasColumnName("BOF_CODE10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofCode11)
                .HasColumnName("BOF_CODE11")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode12)
                .HasColumnName("BOF_CODE12")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode13)
                .HasColumnName("BOF_CODE13")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode14)
                .HasColumnName("BOF_CODE14")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode15)
                .HasColumnName("BOF_CODE15")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode16)
                .HasColumnName("BOF_CODE16")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode17)
                .HasColumnName("BOF_CODE17")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode18)
                .HasColumnName("BOF_CODE18")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode19)
                .HasColumnName("BOF_CODE19")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode2)
                .HasColumnName("BOF_CODE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode20)
                .HasColumnName("BOF_CODE20")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode21)
                .HasColumnName("BOF_CODE21")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode22)
                .HasColumnName("BOF_CODE22")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode23)
                .HasColumnName("BOF_CODE23")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode24)
                .HasColumnName("BOF_CODE24")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode25)
                .HasColumnName("BOF_CODE25")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode3)
                .HasColumnName("BOF_CODE3")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode4)
                .HasColumnName("BOF_CODE4")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode5)
                .HasColumnName("BOF_CODE5")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode6)
                .HasColumnName("BOF_CODE6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofCode7)
                .HasColumnName("BOF_CODE7")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofCode8)
                .HasColumnName("BOF_CODE8")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofCode9)
                .HasColumnName("BOF_CODE9")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofIntfCode)
                .HasColumnName("BOF_INTF_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashInd)
                .HasColumnName("CASH_IND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepLedControl)
                .HasColumnName("DEP_LED_CONTROL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepLedControlFlag)
                .HasColumnName("DEP_LED_CONTROL_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

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

            entity.Property(e => e.GuestLedControl)
                .HasColumnName("GUEST_LED_CONTROL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestLedControlFlag)
                .HasColumnName("GUEST_LED_CONTROL_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

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

            entity.Property(e => e.InthotelLedControl)
                .HasColumnName("INTHOTEL_LED_CONTROL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InthotelLedControlFlag)
                .HasColumnName("INTHOTEL_LED_CONTROL_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InthotelLedCredit)
                .HasColumnName("INTHOTEL_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InthotelLedDebit)
                .HasColumnName("INTHOTEL_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ManualPostYn)
                .HasColumnName("MANUAL_POST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetDrCrFlag)
                .HasColumnName("NET_DR_CR_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PackageLedControl)
                .HasColumnName("PACKAGE_LED_CONTROL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageLedControlFlag)
                .HasColumnName("PACKAGE_LED_CONTROL_FLAG")
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

            entity.Property(e => e.TaxRateString)
                .HasColumnName("TAX_RATE_STRING")
                .HasMaxLength(300)
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
