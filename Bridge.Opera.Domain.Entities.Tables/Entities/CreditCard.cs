namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CreditCard
{
    public CreditCard()
    {
        MembershipPaymentTypes = new HashSet<MembershipPaymentTypes>();
        ResortCreditCard = new HashSet<ResortCreditCard>();
    }

    public decimal? ExtraPerc { get; set; }
    public decimal? CreditLimit { get; set; }
    public string CardType { get; set; }
    public string CcTypeIfc { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string MerchantNumber { get; set; }
    public string ExpirationRule { get; set; }
    public string FormatMask { get; set; }
    public decimal? NumberDigits { get; set; }
    public string Description { get; set; }
    public string TrxCode { get; set; }
    public bool? IssueNumber { get; set; }
    public bool? StartDate { get; set; }
    public string Resort { get; set; }
    public string PostYn { get; set; }
    public string CardNumberLength { get; set; }
    public string CardPrefix { get; set; }
    public string ValidationRule { get; set; }
    public string Formula { get; set; }
    public string TrxUsage1 { get; set; }
    public string TrxUsage2 { get; set; }
    public decimal? OrderBy { get; set; }
    public string AuthAtCheckinYn { get; set; }
    public string AuthReversalYn { get; set; }
    public string AuthDuringStayYn { get; set; }
    public string Cvv2CheckYn { get; set; }
    public string AddressVerificationYn { get; set; }
    public string PromptAtCheckinYn { get; set; }
    public string ChipPinYn { get; set; }
    public string ResvPaymentYn { get; set; }
    public string CalcPoints { get; set; }
    public string AutopayAtCheckinYn { get; set; }
    public string AuthStlmtAtCheckOutYn { get; set; }
    public decimal? CcTrxFeePct { get; set; }
    public decimal? CcTrxFeeThreshold { get; set; }
    public string BonusCheckType { get; set; }
    public string CurrencyCode { get; set; }
    public string PrintAuthReceiptYn { get; set; }

    public virtual ICollection<MembershipPaymentTypes> MembershipPaymentTypes { get; set; }
    public virtual ICollection<ResortCreditCard> ResortCreditCard { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CreditCard>(entity =>
        {
            entity.HasKey(e => new { e.CardType, e.Resort })
                .HasName("CREDIT$_CARD_PK");

            entity.ToTable("CREDIT$_CARD");

            entity.HasIndex(e => new { e.CcTypeIfc, e.Resort })
                .HasName("CREDIT_CARD_IND1");

            entity.Property(e => e.CardType)
                .HasColumnName("CARD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

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
                .HasMaxLength(1)
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

            entity.Property(e => e.CcTrxFeePct)
                .HasColumnName("CC_TRX_FEE_PCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcTrxFeeThreshold)
                .HasColumnName("CC_TRX_FEE_THRESHOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcTypeIfc)
                .HasColumnName("CC_TYPE_IFC")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ChipPinYn)
                .HasColumnName("CHIP_PIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Cvv2CheckYn)
                .HasColumnName("CVV2_CHECK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExpirationRule)
                .HasColumnName("EXPIRATION_RULE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExtraPerc)
                .HasColumnName("EXTRA_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FormatMask)
                .HasColumnName("FORMAT_MASK")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Formula)
                .HasColumnName("FORMULA")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IssueNumber).HasColumnName("ISSUE_NUMBER");

            entity.Property(e => e.MerchantNumber)
                .HasColumnName("MERCHANT_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NumberDigits)
                .HasColumnName("NUMBER_DIGITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostYn)
                .HasColumnName("POST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrintAuthReceiptYn)
                .HasColumnName("PRINT_AUTH_RECEIPT_YN")
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

            entity.Property(e => e.StartDate).HasColumnName("START_DATE");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
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
        
			if (!types.Contains(typeof(MembershipPaymentTypes)))
				entity.Ignore(e => e.MembershipPaymentTypes);

			if (!types.Contains(typeof(ResortCreditCard)))
				entity.Ignore(e => e.ResortCreditCard);
		});
	}
}
