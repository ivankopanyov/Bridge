namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CcAuthLog
{
    public string? Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? Room { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? CreditCardNumber { get; set; }
    public string? CreditCardType { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public decimal? AuthorizationCount { get; set; }
    public decimal? ApprovalAmount { get; set; }
    public decimal? TotalApprovalAmount { get; set; }
    public string? AuthStatus { get; set; }
    public string? ApprovalCode { get; set; }
    public string? ReasonText { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? UpdateUser { get; set; }
    public decimal? BatchId { get; set; }
    public string? ExpiryDateStr { get; set; }
    public decimal? FolioView { get; set; }
    public decimal? CreditCardId { get; set; }
    public string? TmpCcn { get; set; }
    public string? TmpEds { get; set; }
    public string? TransactionType { get; set; }
    public string? AuthSettleFlag { get; set; }
    public decimal? NameId { get; set; }
    public decimal? ArNumber { get; set; }
    public decimal? AuthSequenceNo { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? ApprovalAmountFc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CcAuthLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CC$_AUTH_LOG");

            entity.HasIndex(e => new { e.BusinessDate, e.Resort })
                .HasName("CC_AUTH_LOG_BUS_DT");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.BatchId })
                .HasName("CC_AUTH_LOG_RESV_IND");

            entity.Property(e => e.ApprovalAmount)
                .HasColumnName("APPROVAL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ApprovalAmountFc)
                .HasColumnName("APPROVAL_AMOUNT_FC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ApprovalCode)
                .HasColumnName("APPROVAL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AuthSequenceNo)
                .HasColumnName("AUTH_SEQUENCE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AuthSettleFlag)
                .HasColumnName("AUTH_SETTLE_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AuthStatus)
                .HasColumnName("AUTH_STATUS")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.AuthorizationCount)
                .HasColumnName("AUTHORIZATION_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardNumber)
                .HasColumnName("CREDIT_CARD_NUMBER")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardType)
                .HasColumnName("CREDIT_CARD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExpiryDate)
                .HasColumnName("EXPIRY_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpiryDateStr)
                .HasColumnName("EXPIRY_DATE_STR")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReasonText)
                .HasColumnName("REASON_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
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

            entity.Property(e => e.TmpCcn)
                .HasColumnName("TMP_CCN")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TmpEds)
                .HasColumnName("TMP_EDS")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TotalApprovalAmount)
                .HasColumnName("TOTAL_APPROVAL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransactionType)
                .HasColumnName("TRANSACTION_TYPE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
