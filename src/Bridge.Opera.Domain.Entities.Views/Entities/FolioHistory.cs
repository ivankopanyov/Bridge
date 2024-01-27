namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FolioHistory
{
    public string Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? BillNo { get; set; }
    public DateTime? BillGenerationDate { get; set; }
    public decimal? NameId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string Room { get; set; }
    public decimal? RevisionNo { get; set; }
    public decimal? FolioView { get; set; }
    public decimal? Clpay { get; set; }
    public decimal? Clarpay { get; set; }
    public string Status { get; set; }
    public string QueueName { get; set; }
    public string AssociatedBillNo { get; set; }
    public string NameTaxType { get; set; }
    public decimal? PayeeNameId { get; set; }
    public decimal? InvoiceNo { get; set; }
    public string FolioType { get; set; }
    public DateTime? BillStartDate { get; set; }
    public string CompressBillNo { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? AccountCode { get; set; }
    public string Sname { get; set; }
    public string Sfirst { get; set; }
    public string GuestName { get; set; }
    public string PayeeName { get; set; }
    public decimal? Gross { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? ClTrxNo { get; set; }
    public DateTime? AssociatedBillDate { get; set; }
    public decimal? Deposit { get; set; }
    public string Sxname { get; set; }
    public string SxfirstName { get; set; }
    public string FolioPdfName { get; set; }
    public string PalmVideoFlag { get; set; }
    public string CheckoutYn { get; set; }
    public string ArYn { get; set; }
    public string CompressYn { get; set; }
    public string PalmYn { get; set; }
    public string VideoYn { get; set; }
    public string FiscalFolioNo { get; set; }
    public decimal? BillSeqNo { get; set; }
    public string BillPrefix { get; set; }
    public decimal? NoOfPages { get; set; }
    public decimal? PostitNo { get; set; }
    public string ActionName { get; set; }
    public decimal? FolioAttachmentLinkId { get; set; }
    public decimal? FolioAttachmentStatus { get; set; }
    public decimal? AddresseeNameId { get; set; }
    public string AddresseeName { get; set; }
    public string XaddresseeName { get; set; }
    public decimal? BillPaymentTrxNo { get; set; }
    public string CreditBillGeneratedYn { get; set; }
    public string FolioAddressCorrectedYn { get; set; }
    public string TaxId { get; set; }
    public string EInvoiceStatus { get; set; }
    public string EInvoiceNumber { get; set; }
    public string EInvoiceLiableYn { get; set; }
    public string Tax1No { get; set; }
    public string Tax2No { get; set; }
    public decimal? FolioTaxSeqNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FolioHistory>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FOLIO_HISTORY");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionName)
                .HasColumnName("ACTION_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AddresseeName)
                .HasColumnName("ADDRESSEE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AddresseeNameId)
                .HasColumnName("ADDRESSEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArYn)
                .HasColumnName("AR_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.AssociatedBillDate)
                .HasColumnName("ASSOCIATED_BILL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AssociatedBillNo)
                .HasColumnName("ASSOCIATED_BILL_NO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BillGenerationDate)
                .HasColumnName("BILL_GENERATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillPaymentTrxNo)
                .HasColumnName("BILL_PAYMENT_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillPrefix)
                .HasColumnName("BILL_PREFIX")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BillSeqNo)
                .HasColumnName("BILL_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillStartDate)
                .HasColumnName("BILL_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CheckoutYn)
                .HasColumnName("CHECKOUT_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.ClTrxNo)
                .HasColumnName("CL_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Clarpay)
                .HasColumnName("CLARPAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Clpay)
                .HasColumnName("CLPAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompressBillNo)
                .HasColumnName("COMPRESS_BILL_NO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CompressYn)
                .HasColumnName("COMPRESS_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.CreditBillGeneratedYn)
                .HasColumnName("CREDIT_BILL_GENERATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Deposit)
                .HasColumnName("DEPOSIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EInvoiceLiableYn)
                .HasColumnName("E_INVOICE_LIABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EInvoiceNumber)
                .HasColumnName("E_INVOICE_NUMBER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EInvoiceStatus)
                .HasColumnName("E_INVOICE_STATUS")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FiscalFolioNo)
                .HasColumnName("FISCAL_FOLIO_NO")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.FolioAddressCorrectedYn)
                .HasColumnName("FOLIO_ADDRESS_CORRECTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioAttachmentLinkId)
                .HasColumnName("FOLIO_ATTACHMENT_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioAttachmentStatus)
                .HasColumnName("FOLIO_ATTACHMENT_STATUS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioPdfName)
                .HasColumnName("FOLIO_PDF_NAME")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.FolioTaxSeqNo)
                .HasColumnName("FOLIO_TAX_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gross)
                .HasColumnName("GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NoOfPages)
                .HasColumnName("NO_OF_PAGES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PalmVideoFlag)
                .HasColumnName("PALM_VIDEO_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PalmYn)
                .HasColumnName("PALM_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.PayeeName)
                .HasColumnName("PAYEE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.PayeeNameId)
                .HasColumnName("PAYEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostitNo)
                .HasColumnName("POSTIT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QueueName)
                .HasColumnName("QUEUE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevisionNo)
                .HasColumnName("REVISION_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Sfirst)
                .HasColumnName("SFIRST")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Sname)
                .HasColumnName("SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SxfirstName)
                .HasColumnName("SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Sxname)
                .HasColumnName("SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Tax1No)
                .HasColumnName("TAX1_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Tax2No)
                .HasColumnName("TAX2_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TaxId)
                .HasColumnName("TAX_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VideoYn)
                .HasColumnName("VIDEO_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.XaddresseeName)
                .HasColumnName("XADDRESSEE_NAME")
                .IsUnicode(false);
        });
	}
}
