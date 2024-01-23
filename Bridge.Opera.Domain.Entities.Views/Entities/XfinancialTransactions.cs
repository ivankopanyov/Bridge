namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class XfinancialTransactions
{
    public string Resort { get; set; }
    public decimal TrxNo { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? LinkTrxNo { get; set; }
    public decimal? LinkTrxNoInIhd { get; set; }
    public string TargetResort { get; set; }
    public string TrxCode { get; set; }
    public string Room { get; set; }
    public string FtSubtype { get; set; }
    public DateTime? TrxDate { get; set; }
    public DateTime BusinessDate { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? TrxNoAddedBy { get; set; }
    public decimal? TrxNoHeader { get; set; }
    public string Product { get; set; }
    public decimal? TrxNoAgainstPackage { get; set; }
    public decimal? TranActionId { get; set; }
    public decimal? PricePerUnit { get; set; }
    public decimal? TrxAmount { get; set; }
    public decimal? PostedAmount { get; set; }
    public decimal? InhCredit { get; set; }
    public decimal? InhDebit { get; set; }
    public decimal? GuestAccountCredit { get; set; }
    public decimal? GuestAccountDebit { get; set; }
    public decimal? DepLedCredit { get; set; }
    public decimal? DepLedDebit { get; set; }
    public decimal? PackageCredit { get; set; }
    public decimal? PackageDebit { get; set; }
    public decimal? CashierCredit { get; set; }
    public decimal? CashierDebit { get; set; }
    public decimal? GrossAmount { get; set; }
    public decimal? NetAmount { get; set; }
    public string TaxInclusiveYn { get; set; }
    public string Remark { get; set; }
    public string Reference { get; set; }
    public string TaxGeneratedYn { get; set; }
    public string FromResort { get; set; }
    public string ToResort { get; set; }
    public string PostRecFlag { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<XfinancialTransactions>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("XFINANCIAL_TRANSACTIONS");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CashierCredit)
                .HasColumnName("CASHIER_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.CashierDebit)
                .HasColumnName("CASHIER_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.DepLedCredit)
                .HasColumnName("DEP_LED_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.DepLedDebit)
                .HasColumnName("DEP_LED_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FromResort)
                .HasColumnName("FROM_RESORT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.FtSubtype)
                .IsRequired()
                .HasColumnName("FT_SUBTYPE")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestAccountCredit)
                .HasColumnName("GUEST_ACCOUNT_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestAccountDebit)
                .HasColumnName("GUEST_ACCOUNT_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.InhCredit)
                .HasColumnName("INH_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.InhDebit)
                .HasColumnName("INH_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.LinkTrxNo)
                .HasColumnName("LINK_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LinkTrxNoInIhd)
                .HasColumnName("LINK_TRX_NO_IN_IHD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageCredit)
                .HasColumnName("PACKAGE_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageDebit)
                .HasColumnName("PACKAGE_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PostRecFlag)
                .HasColumnName("POST_REC_FLAG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PricePerUnit)
                .HasColumnName("PRICE_PER_UNIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER(12,3)");

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TargetResort)
                .HasColumnName("TARGET_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxGeneratedYn)
                .HasColumnName("TAX_GENERATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TaxInclusiveYn)
                .HasColumnName("TAX_INCLUSIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ToResort)
                .HasColumnName("TO_RESORT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoAddedBy)
                .HasColumnName("TRX_NO_ADDED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoAgainstPackage)
                .HasColumnName("TRX_NO_AGAINST_PACKAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoHeader)
                .HasColumnName("TRX_NO_HEADER")
                .HasColumnType("NUMBER");
        });
	}
}
