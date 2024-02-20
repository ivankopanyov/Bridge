namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpPaymentMethods
{
    public string? PaymentMethod { get; set; }
    public string? Description { get; set; }
    public string? CcCode { get; set; }
    public string? CcType { get; set; }
    public string? TcGroup { get; set; }
    public string? TcSubgroup { get; set; }
    public string? IndBilling { get; set; }
    public string? IndAr { get; set; }
    public string? IndDepositYn { get; set; }
    public string? IndCash { get; set; }
    public string? TrxCode { get; set; }
    public string? TrxDesc { get; set; }
    public decimal? IssueNumber { get; set; }
    public decimal? StartDate { get; set; }
    public string? PostYn { get; set; }
    public string? CardNumberLength { get; set; }
    public string? CardPrefix { get; set; }
    public string? ValidationRule { get; set; }
    public string? Formula { get; set; }
    public string? TrxUsage1 { get; set; }
    public string? TrxUsage2 { get; set; }
    public decimal? OrderBy { get; set; }
    public string? AuthAtCheckinYn { get; set; }
    public string? AuthDuringStayYn { get; set; }
    public string? AuthReversalYn { get; set; }
    public string? Cvv2CheckYn { get; set; }
    public string? AddressVerificationYn { get; set; }
    public string? CompPaymentYn { get; set; }
    public string? PromptAtCheckinYn { get; set; }
    public string? MerchantNumber { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpPaymentMethods>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_PAYMENT_METHODS");

            entity.Property(e => e.AddressVerificationYn)
                .HasColumnName("ADDRESS_VERIFICATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AuthAtCheckinYn)
                .HasColumnName("AUTH_AT_CHECKIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AuthDuringStayYn)
                .HasColumnName("AUTH_DURING_STAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AuthReversalYn)
                .HasColumnName("AUTH_REVERSAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CardNumberLength)
                .HasColumnName("CARD_NUMBER_LENGTH")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CardPrefix)
                .HasColumnName("CARD_PREFIX")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CcCode)
                .HasColumnName("CC_CODE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.CcType)
                .HasColumnName("CC_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.CompPaymentYn)
                .HasColumnName("COMP_PAYMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Cvv2CheckYn)
                .HasColumnName("CVV2_CHECK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Formula)
                .HasColumnName("FORMULA")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IndAr)
                .HasColumnName("IND_AR")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IndBilling)
                .HasColumnName("IND_BILLING")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IndCash)
                .HasColumnName("IND_CASH")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IndDepositYn)
                .HasColumnName("IND_DEPOSIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IssueNumber)
                .HasColumnName("ISSUE_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MerchantNumber)
                .HasColumnName("MERCHANT_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PostYn)
                .HasColumnName("POST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PromptAtCheckinYn)
                .HasColumnName("PROMPT_AT_CHECKIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TcGroup)
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDesc)
                .HasColumnName("TRX_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrxUsage1)
                .HasColumnName("TRX_USAGE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxUsage2)
                .HasColumnName("TRX_USAGE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ValidationRule)
                .HasColumnName("VALIDATION_RULE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
