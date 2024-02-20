namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SampleAuthrecptVw
{
    public decimal? ResvReceiptId { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? CreditCardId { get; set; }
    public decimal? FolioView { get; set; }
    public decimal? RecptNo { get; set; }
    public string? CreditCardType { get; set; }
    public string? CreditCardNumber { get; set; }
    public string? CreditCardExpirationDate { get; set; }
    public string? CcApprovalCode { get; set; }
    public decimal? ApprovalAmountLocal { get; set; }
    public DateTime? ApprovalSystemDateTime { get; set; }
    public DateTime? ApprovalBusinessDate { get; set; }
    public string? ApprovalSystemDateTimeIso { get; set; }
    public string? MerchantId { get; set; }
    public decimal? TransSerialNo { get; set; }
    public decimal? AuthSequenceNo { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? ApprovalAmountFc { get; set; }
    public string? EftOrManual { get; set; }
    public string? SwipedOrManual { get; set; }
    public string? Room { get; set; }
    public string? ConfirmationNo { get; set; }
    public string? GuestFullName { get; set; }
    public string? GuestAddress { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string? UserName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SampleAuthrecptVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SAMPLE_AUTHRECPT_VW");

            entity.Property(e => e.ApprovalAmountFc)
                .HasColumnName("APPROVAL_AMOUNT_FC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ApprovalAmountLocal)
                .HasColumnName("APPROVAL_AMOUNT_LOCAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ApprovalBusinessDate)
                .HasColumnName("APPROVAL_BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ApprovalSystemDateTime)
                .HasColumnName("APPROVAL_SYSTEM_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.ApprovalSystemDateTimeIso)
                .HasColumnName("APPROVAL_SYSTEM_DATE_TIME_ISO")
                .IsUnicode(false);

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.AuthSequenceNo)
                .HasColumnName("AUTH_SEQUENCE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcApprovalCode)
                .HasColumnName("CC_APPROVAL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardExpirationDate)
                .HasColumnName("CREDIT_CARD_EXPIRATION_DATE")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardNumber)
                .HasColumnName("CREDIT_CARD_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardType)
                .IsRequired()
                .HasColumnName("CREDIT_CARD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.EftOrManual)
                .HasColumnName("EFT_OR_MANUAL")
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestAddress)
                .HasColumnName("GUEST_ADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.GuestFullName)
                .HasColumnName("GUEST_FULL_NAME")
                .IsUnicode(false);

            entity.Property(e => e.MerchantId)
                .HasColumnName("MERCHANT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecptNo)
                .HasColumnName("RECPT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvReceiptId)
                .HasColumnName("RESV_RECEIPT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SwipedOrManual)
                .HasColumnName("SWIPED_OR_MANUAL")
                .IsUnicode(false);

            entity.Property(e => e.TransSerialNo)
                .HasColumnName("TRANS_SERIAL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserName)
                .HasColumnName("USER_NAME")
                .IsUnicode(false);
        });
	}
}
