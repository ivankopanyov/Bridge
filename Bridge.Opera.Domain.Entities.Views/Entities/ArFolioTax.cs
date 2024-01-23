namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArFolioTax
{
    public string Resort { get; set; }
    public decimal? ArNumber { get; set; }
    public decimal AccountTypeId { get; set; }
    public string AccountNo { get; set; }
    public string AccountName { get; set; }
    public DateTime? TrxDate { get; set; }
    public string TrxTime { get; set; }
    public decimal? TrxNo { get; set; }
    public string TrxCode { get; set; }
    public decimal? TrxAmount { get; set; }
    public string GuestName { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? InvoiceNo { get; set; }
    public string AdjustYn { get; set; }
    public string FoStatus { get; set; }
    public string ResvStatus { get; set; }
    public decimal? InvoiceAge { get; set; }
    public decimal? NameId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? BillNumber { get; set; }
    public string FolioType { get; set; }
    public decimal? FolioView { get; set; }
    public DateTime? BillGenerationDate { get; set; }
    public decimal? CashierId { get; set; }
    public string AccountSname { get; set; }
    public string Status { get; set; }
    public decimal? CreditLimit { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArFolioTax>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_FOLIO_TAX");

            entity.Property(e => e.AccountName)
                .IsRequired()
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountSname)
                .HasColumnName("ACCOUNT_SNAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeId)
                .HasColumnName("ACCOUNT_TYPE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdjustYn)
                .HasColumnName("ADJUST_YN")
                .IsUnicode(false);

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillGenerationDate)
                .HasColumnName("BILL_GENERATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillNumber)
                .HasColumnName("BILL_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoStatus)
                .HasColumnName("FO_STATUS")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InvoiceAge)
                .HasColumnName("INVOICE_AGE")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxTime)
                .HasColumnName("TRX_TIME")
                .HasMaxLength(5)
                .IsUnicode(false);
        });
	}
}
