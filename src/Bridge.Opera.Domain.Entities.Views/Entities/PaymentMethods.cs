namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PaymentMethods
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
    public string? ChipPinYn { get; set; }
    public string? ResvPaymentYn { get; set; }
    public string? CalcPoints { get; set; }
    public string? TrxCodeDisplay { get; set; }
    public string? AutopayAtCheckinYn { get; set; }
    public string? AuthStlmtAtCheckOutYn { get; set; }
    public decimal? MaxAmt { get; set; }
    public string? BonusCheckType { get; set; }
    public string? FiscalPaymentYn { get; set; }
    public string? CurrencyCode { get; set; }
    public string? DepositType { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PaymentMethods>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PAYMENT_METHODS");

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

            entity.Property(e => e.AuthStlmtAtCheckOutYn)
                .HasColumnName("AUTH_STLMT_AT_CHECK_OUT_YN")
                .IsUnicode(false);

            entity.Property(e => e.AutopayAtCheckinYn)
                .HasColumnName("AUTOPAY_AT_CHECKIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BonusCheckType)
                .HasColumnName("BONUS_CHECK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CalcPoints)
                .HasColumnName("CALC_POINTS")
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

            entity.Property(e => e.ChipPinYn)
                .HasColumnName("CHIP_PIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CompPaymentYn)
                .HasColumnName("COMP_PAYMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.Cvv2CheckYn)
                .HasColumnName("CVV2_CHECK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepositType)
                .HasColumnName("DEPOSIT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FiscalPaymentYn)
                .HasColumnName("FISCAL_PAYMENT_YN")
                .HasMaxLength(1)
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

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IssueNumber)
                .HasColumnName("ISSUE_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxAmt)
                .HasColumnName("MAX_AMT")
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

            entity.Property(e => e.ResvPaymentYn)
                .HasColumnName("RESV_PAYMENT_YN")
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

            entity.Property(e => e.TrxCodeDisplay)
                .HasColumnName("TRX_CODE_DISPLAY")
                .HasMaxLength(8)
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

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValidationRule)
                .HasColumnName("VALIDATION_RULE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
