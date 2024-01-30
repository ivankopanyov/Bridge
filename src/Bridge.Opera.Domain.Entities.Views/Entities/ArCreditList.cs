namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArCreditList
{
    public string? Resort { get; set; }
    public string? TrxCode { get; set; }
    public string? CcSetId { get; set; }
    public decimal? AccountCode { get; set; }
    public string? AccountName { get; set; }
    public DateTime? PostDate { get; set; }
    public decimal? TrxNo { get; set; }
    public string? GuestName { get; set; }
    public decimal? NameId { get; set; }
    public string? Room { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? Invoice { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? OrgAmt { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Aropen { get; set; }
    public string? AdjustYn { get; set; }
    public string? Remark { get; set; }
    public string? Reference { get; set; }
    public string? CreditCardNumberStr { get; set; }
    public string? Currency { get; set; }
    public decimal? ExchangeRate { get; set; }
    public DateTime? InvoiceCloseDate { get; set; }
    public DateTime? ArTransferDate { get; set; }
    public string? InvStatus { get; set; }
    public string? RecType { get; set; }
    public decimal? TranActionId { get; set; }
    public string? AppFull { get; set; }
    public string? InvoiceType { get; set; }
    public decimal? ArNameId { get; set; }
    public decimal? Commission { get; set; }
    public decimal? BillNumber { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? CreditCardId { get; set; }
    public string? FiscalBillNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArCreditList>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_CREDIT_LIST");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AdjustYn)
                .HasColumnName("ADJUST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppFull)
                .HasColumnName("APP_FULL")
                .IsUnicode(false);

            entity.Property(e => e.ArNameId)
                .HasColumnName("AR_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArTransferDate)
                .HasColumnName("AR_TRANSFER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Aropen)
                .HasColumnName("AROPEN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNumber)
                .HasColumnName("BILL_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcSetId)
                .HasColumnName("CC_SET_ID")
                .IsUnicode(false);

            entity.Property(e => e.Commission)
                .HasColumnName("COMMISSION")
                .HasColumnType("NUMBER(10,2)");

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardNumberStr)
                .HasColumnName("CREDIT_CARD_NUMBER_STR")
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .IsRequired()
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FiscalBillNo)
                .HasColumnName("FISCAL_BILL_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InvStatus)
                .HasColumnName("INV_STATUS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Invoice)
                .HasColumnName("INVOICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceCloseDate)
                .HasColumnName("INVOICE_CLOSE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvoiceType)
                .HasColumnName("INVOICE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrgAmt)
                .HasColumnName("ORG_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Paid)
                .HasColumnName("PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostDate)
                .HasColumnName("POST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RecType)
                .HasColumnName("REC_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
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

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

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
        });
	}
}
