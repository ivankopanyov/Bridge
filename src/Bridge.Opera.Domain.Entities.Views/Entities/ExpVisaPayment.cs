namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpVisaPayment
{
    public decimal? ExpDataId { get; set; }
    public decimal? ExpViewId { get; set; }
    public string? MultiPropertyYn { get; set; }
    public string? Resort { get; set; }
    public decimal? ExpInvoiceId { get; set; }
    public decimal? PaymentSequence { get; set; }
    public decimal? GuestAccountCredit { get; set; }
    public string? CcNo { get; set; }
    public string? CcApprovalCode { get; set; }
    public string? CcRefNum { get; set; }
    public string? CreditCardExpirationDtStr { get; set; }
    public string? CreditCardType { get; set; }
    public string? CreditCardName { get; set; }
    public string? ExpPaymentType { get; set; }
    public string? PaymentTrxDescription { get; set; }
    public DateTime? PaymentDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpVisaPayment>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_VISA_PAYMENT");

            entity.Property(e => e.CcApprovalCode)
                .HasColumnName("CC_APPROVAL_CODE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcNo)
                .HasColumnName("CC_NO")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcRefNum)
                .HasColumnName("CC_REF_NUM")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardExpirationDtStr)
                .HasColumnName("CREDIT_CARD_EXPIRATION_DT_STR")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardName)
                .HasColumnName("CREDIT_CARD_NAME")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardType)
                .HasColumnName("CREDIT_CARD_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpDataId)
                .HasColumnName("EXP_DATA_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpInvoiceId)
                .HasColumnName("EXP_INVOICE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpPaymentType)
                .HasColumnName("EXP_PAYMENT_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpViewId)
                .HasColumnName("EXP_VIEW_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuestAccountCredit)
                .HasColumnName("GUEST_ACCOUNT_CREDIT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MultiPropertyYn)
                .IsRequired()
                .HasColumnName("MULTI_PROPERTY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentDate)
                .HasColumnName("PAYMENT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentSequence)
                .HasColumnName("PAYMENT_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentTrxDescription)
                .HasColumnName("PAYMENT_TRX_DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
