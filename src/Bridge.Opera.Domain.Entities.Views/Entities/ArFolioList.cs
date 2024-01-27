namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArFolioList
{
    public string InvoiceStyle { get; set; }
    public decimal? AccountCode { get; set; }
    public decimal? NameId { get; set; }
    public int? FolioView { get; set; }
    public string FolioStyle { get; set; }
    public string TrxCode { get; set; }
    public decimal? TrxNo { get; set; }
    public string Description { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? PostedAmount { get; set; }
    public decimal? Debit { get; set; }
    public decimal? PrintedDebit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? PrintedCredit { get; set; }
    public string Room { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? InvoiceNo { get; set; }
    public string Reference { get; set; }
    public string ApprovalCode { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string Currency { get; set; }
    public string PrintedCurrency { get; set; }
    public string PrintedExchInfo { get; set; }
    public string PrintedExchRate { get; set; }
    public string CurrFormatMask { get; set; }
    public decimal? ExchRate { get; set; }
    public decimal? EuroExchRate { get; set; }
    public decimal? BillNumber { get; set; }
    public decimal? RevisionNumber { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArFolioList>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_FOLIO_LIST");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ApprovalCode)
                .HasColumnName("APPROVAL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.BillNumber)
                .HasColumnName("BILL_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Credit)
                .HasColumnName("CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrFormatMask)
                .HasColumnName("CURR_FORMAT_MASK")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Debit)
                .HasColumnName("DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.EuroExchRate)
                .HasColumnName("EURO_EXCH_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ExchRate)
                .HasColumnName("EXCH_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ExpiryDate)
                .HasColumnName("EXPIRY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioStyle)
                .HasColumnName("FOLIO_STYLE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER(9)");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceStyle)
                .HasColumnName("INVOICE_STYLE")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PrintedCredit)
                .HasColumnName("PRINTED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintedCurrency)
                .HasColumnName("PRINTED_CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.PrintedDebit)
                .HasColumnName("PRINTED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintedExchInfo)
                .HasColumnName("PRINTED_EXCH_INFO")
                .IsUnicode(false);

            entity.Property(e => e.PrintedExchRate)
                .HasColumnName("PRINTED_EXCH_RATE")
                .IsUnicode(false);

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RevisionNumber)
                .HasColumnName("REVISION_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
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
