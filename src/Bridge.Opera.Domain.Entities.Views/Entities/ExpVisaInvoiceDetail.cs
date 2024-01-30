namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpVisaInvoiceDetail
{
    public decimal? ExpDataId { get; set; }
    public decimal? ExpViewId { get; set; }
    public string? MultiPropertyYn { get; set; }
    public string? Resort { get; set; }
    public decimal? ExpInvoiceId { get; set; }
    public decimal? DetailSequence { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? GuestAccountDebit { get; set; }
    public decimal? GuestAccountCredit { get; set; }
    public decimal? PricePerUnit { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? CreditCardId { get; set; }
    public decimal? FinDmlSeqNo { get; set; }
    public string? TrxCode { get; set; }
    public string? TrxDesc { get; set; }
    public string? PartNum { get; set; }
    public string? PostingDateTime { get; set; }
    public string? FtSubtype { get; set; }
    public string? PaymentType { get; set; }
    public DateTime? TrxDate { get; set; }
    public DateTime? PostingDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpVisaInvoiceDetail>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_VISA_INVOICE_DETAIL");

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DetailSequence)
                .HasColumnName("DETAIL_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpDataId)
                .HasColumnName("EXP_DATA_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpInvoiceId)
                .HasColumnName("EXP_INVOICE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpViewId)
                .HasColumnName("EXP_VIEW_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FinDmlSeqNo)
                .HasColumnName("FIN_DML_SEQ_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FtSubtype)
                .HasColumnName("FT_SUBTYPE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuestAccountCredit)
                .HasColumnName("GUEST_ACCOUNT_CREDIT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuestAccountDebit)
                .HasColumnName("GUEST_ACCOUNT_DEBIT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MultiPropertyYn)
                .IsRequired()
                .HasColumnName("MULTI_PROPERTY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PartNum)
                .HasColumnName("PART_NUM")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostingDate)
                .HasColumnName("POSTING_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostingDateTime)
                .HasColumnName("POSTING_DATE_TIME")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PricePerUnit)
                .HasColumnName("PRICE_PER_UNIT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxDesc)
                .HasColumnName("TRX_DESC")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
