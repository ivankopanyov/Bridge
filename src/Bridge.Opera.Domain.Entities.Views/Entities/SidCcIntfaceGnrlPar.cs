namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidCcIntfaceGnrlPar
{
    public string? Resort { get; set; }
    public string? HotelId { get; set; }
    public decimal? TimeOut { get; set; }
    public decimal? ApprovalAmountCalcMethod { get; set; }
    public decimal? AmountPercent { get; set; }
    public string? AuthorizationAtCheckinYn { get; set; }
    public string? AuthStlmtAtCheckOutYn { get; set; }
    public string? OnLineSettlementYn { get; set; }
    public string? BatchSettlementYn { get; set; }
    public string? NightAuditRemoteAuthYn { get; set; }
    public string? CourtseyCardHandlingYn { get; set; }
    public string? CreditCardUsageChoicesYn { get; set; }
    public string? CreditCardTypeCheckYn { get; set; }
    public string? BonusCheckValidationYn { get; set; }
    public string? CcReversalAllowedYn { get; set; }
    public string? IgnoreDepositsYn { get; set; }
    public string? CcOverHttpEnabledYn { get; set; }
    public string? CcHttpServiceProvider { get; set; }
    public string? CcHttpServiceUrl { get; set; }
    public decimal? CcDefaultCashier { get; set; }
    public string? SdcLocationYn { get; set; }
    public string? SdcTerminalYn { get; set; }
    public string? CcAmexDirectYn { get; set; }
    public string? CcEodYn { get; set; }
    public string? SendTotalTaxYn { get; set; }
    public string? AuthRequiredAtCheckinYn { get; set; }
    public decimal? MaxDaysToAuthorize { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Percentage { get; set; }
    public string? AuthorizationDuringStayYn { get; set; }
    public string? ManualAuthYn { get; set; }
    public string? AutoAuthActiveYn { get; set; }
    public decimal? AutoAuthInterval { get; set; }
    public string? Cvv2CheckYn { get; set; }
    public string? AddressVerificationYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidCcIntfaceGnrlPar>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_CC_INTFACE_GNRL_PAR");

            entity.Property(e => e.AddressVerificationYn)
                .HasColumnName("ADDRESS_VERIFICATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmountPercent)
                .HasColumnName("AMOUNT_PERCENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ApprovalAmountCalcMethod)
                .HasColumnName("APPROVAL_AMOUNT_CALC_METHOD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AuthRequiredAtCheckinYn)
                .HasColumnName("AUTH_REQUIRED_AT_CHECKIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AuthStlmtAtCheckOutYn)
                .HasColumnName("AUTH_STLMT_AT_CHECK_OUT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AuthorizationAtCheckinYn)
                .HasColumnName("AUTHORIZATION_AT_CHECKIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AuthorizationDuringStayYn)
                .HasColumnName("AUTHORIZATION_DURING_STAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AutoAuthActiveYn)
                .HasColumnName("AUTO_AUTH_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AutoAuthInterval)
                .HasColumnName("AUTO_AUTH_INTERVAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BatchSettlementYn)
                .HasColumnName("BATCH_SETTLEMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BonusCheckValidationYn)
                .HasColumnName("BONUS_CHECK_VALIDATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CcAmexDirectYn)
                .HasColumnName("CC_AMEX_DIRECT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CcDefaultCashier)
                .HasColumnName("CC_DEFAULT_CASHIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcEodYn)
                .HasColumnName("CC_EOD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CcHttpServiceProvider)
                .HasColumnName("CC_HTTP_SERVICE_PROVIDER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CcHttpServiceUrl)
                .HasColumnName("CC_HTTP_SERVICE_URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CcOverHttpEnabledYn)
                .HasColumnName("CC_OVER_HTTP_ENABLED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CcReversalAllowedYn)
                .HasColumnName("CC_REVERSAL_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CourtseyCardHandlingYn)
                .HasColumnName("COURTSEY_CARD_HANDLING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardTypeCheckYn)
                .HasColumnName("CREDIT_CARD_TYPE_CHECK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardUsageChoicesYn)
                .HasColumnName("CREDIT_CARD_USAGE_CHOICES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Cvv2CheckYn)
                .HasColumnName("CVV2_CHECK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HotelId)
                .HasColumnName("HOTEL_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.IgnoreDepositsYn)
                .HasColumnName("IGNORE_DEPOSITS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ManualAuthYn)
                .HasColumnName("MANUAL_AUTH_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MaxDaysToAuthorize)
                .HasColumnName("MAX_DAYS_TO_AUTHORIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NightAuditRemoteAuthYn)
                .HasColumnName("NIGHT_AUDIT_REMOTE_AUTH_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OnLineSettlementYn)
                .HasColumnName("ON_LINE_SETTLEMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Percentage)
                .HasColumnName("PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.SdcLocationYn)
                .HasColumnName("SDC_LOCATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SdcTerminalYn)
                .HasColumnName("SDC_TERMINAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SendTotalTaxYn)
                .HasColumnName("SEND_TOTAL_TAX_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TimeOut)
                .HasColumnName("TIME_OUT")
                .HasColumnType("NUMBER");
        });
	}
}
