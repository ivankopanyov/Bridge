namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpTrxcode
{
    public string? RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public string? Resort { get; set; }
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? ResortDesc { get; set; }
    public string? Trxcode { get; set; }
    public string? TrxcodeId { get; set; }
    public string? TrxcodeDesc { get; set; }
    public string? Subgroup { get; set; }
    public string? SubgroupDesc { get; set; }
    public string? TrxGroup { get; set; }
    public string? GroupDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public string? CustomCol1 { get; set; }
    public string? CustomDesc1 { get; set; }
    public string? CustomLabel1 { get; set; }
    public string? CustomCol2 { get; set; }
    public string? CustomDesc2 { get; set; }
    public string? CustomLabel2 { get; set; }
    public string? CustomCol3 { get; set; }
    public string? CustomDesc3 { get; set; }
    public string? CustomLabel3 { get; set; }
    public string? CustomCol4 { get; set; }
    public string? CustomDesc4 { get; set; }
    public string? CustomLabel4 { get; set; }
    public string? CustomCol5 { get; set; }
    public string? CustomDesc5 { get; set; }
    public string? CustomLabel5 { get; set; }
    public string? CustomCol6 { get; set; }
    public string? CustomDesc6 { get; set; }
    public string? CustomLabel6 { get; set; }
    public string? CustomCol7 { get; set; }
    public string? CustomDesc7 { get; set; }
    public string? CustomLabel7 { get; set; }
    public string? CustomCol8 { get; set; }
    public string? CustomDesc8 { get; set; }
    public string? CustomLabel8 { get; set; }
    public string? CustomCol9 { get; set; }
    public string? CustomDesc9 { get; set; }
    public string? CustomLabel9 { get; set; }
    public string? CustomCol10 { get; set; }
    public string? CustomDesc10 { get; set; }
    public string? CustomLabel10 { get; set; }
    public string? ResortId { get; set; }
    public string? AllKey { get; set; }
    public string? AdjTrxCode { get; set; }
    public string? ArrangeCode { get; set; }
    public decimal? ArNameId { get; set; }
    public string? CcCode { get; set; }
    public string? CcType { get; set; }
    public string? CheckNoMandatoryYn { get; set; }
    public decimal? Commission { get; set; }
    public string? CompNightsYn { get; set; }
    public string? CompPaymentYn { get; set; }
    public string? CompYn { get; set; }
    public string? Currency { get; set; }
    public decimal? DailyPlanFolio { get; set; }
    public string? DedOwnerRevYn { get; set; }
    public decimal? DefaultPrice { get; set; }
    public string? DeferredYn { get; set; }
    public string? DepositPostingOnlyYn { get; set; }
    public string? DepositType { get; set; }
    public decimal? ExportBucket { get; set; }
    public string? FiscalPaymentYn { get; set; }
    public string? FiscalTrxCodeType { get; set; }
    public string? GpPointsRedemptionYn { get; set; }
    public decimal? GroupFolio { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? IncludeIn8300Yn { get; set; }
    public string? IncludeInDepositRuleYn { get; set; }
    public string? IndAr { get; set; }
    public string? IndBilling { get; set; }
    public string? IndCash { get; set; }
    public string? IndDepositYn { get; set; }
    public string? IndRevenueGp { get; set; }
    public string? InhDepositYn { get; set; }
    public string? InhPayYn { get; set; }
    public string? InhSalesYn { get; set; }
    public string? InternalYn { get; set; }
    public string? IsManualPostAllowed { get; set; }
    public string? ManualPostCoversYn { get; set; }
    public decimal? MaxAmt { get; set; }
    public decimal? MinAmt { get; set; }
    public string? NonTaxableYn { get; set; }
    public string? OwnerRevYn { get; set; }
    public string? PaymentTaxInvoiceYn { get; set; }
    public string? ResultIncludedInSumArray { get; set; }
    public string? RotationRevYn { get; set; }
    public string? RoundFactorYn { get; set; }
    public decimal? TaxCodeNo { get; set; }
    public string? TaxInclusiveYn { get; set; }
    public string? TcGroup { get; set; }
    public string? TcSubgroup { get; set; }
    public string? TcTransactionType { get; set; }
    public decimal? TrxActionId { get; set; }
    public string? TrxCode1 { get; set; }
    public string? TrxCodeDisplay { get; set; }
    public string? TrxCodeType { get; set; }
    public string? TrxServiceType { get; set; }
    public string? TrxTaxTypeCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpTrxcode>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXP_TRXCODE");

            entity.Property(e => e.AdjTrxCode)
                .HasColumnName("ADJ_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.ArNameId)
                .HasColumnName("AR_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrangeCode)
                .HasColumnName("ARRANGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CcCode)
                .HasColumnName("CC_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CcType)
                .HasColumnName("CC_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.CheckNoMandatoryYn)
                .HasColumnName("CHECK_NO_MANDATORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Commission)
                .HasColumnName("COMMISSION")
                .HasColumnType("NUMBER(10,2)");

            entity.Property(e => e.CompNightsYn)
                .HasColumnName("COMP_NIGHTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CompPaymentYn)
                .HasColumnName("COMP_PAYMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CompYn)
                .HasColumnName("COMP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CustomCol1)
                .HasColumnName("CUSTOM_COL_1")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol10)
                .HasColumnName("CUSTOM_COL_10")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol2)
                .HasColumnName("CUSTOM_COL_2")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol3)
                .HasColumnName("CUSTOM_COL_3")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol4)
                .HasColumnName("CUSTOM_COL_4")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol5)
                .HasColumnName("CUSTOM_COL_5")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol6)
                .HasColumnName("CUSTOM_COL_6")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol7)
                .HasColumnName("CUSTOM_COL_7")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol8)
                .HasColumnName("CUSTOM_COL_8")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol9)
                .HasColumnName("CUSTOM_COL_9")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc1)
                .HasColumnName("CUSTOM_DESC_1")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc10)
                .HasColumnName("CUSTOM_DESC_10")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc2)
                .HasColumnName("CUSTOM_DESC_2")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc3)
                .HasColumnName("CUSTOM_DESC_3")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc4)
                .HasColumnName("CUSTOM_DESC_4")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc5)
                .HasColumnName("CUSTOM_DESC_5")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc6)
                .HasColumnName("CUSTOM_DESC_6")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc7)
                .HasColumnName("CUSTOM_DESC_7")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc8)
                .HasColumnName("CUSTOM_DESC_8")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc9)
                .HasColumnName("CUSTOM_DESC_9")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel1)
                .HasColumnName("CUSTOM_LABEL_1")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel10)
                .HasColumnName("CUSTOM_LABEL_10")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel2)
                .HasColumnName("CUSTOM_LABEL_2")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel3)
                .HasColumnName("CUSTOM_LABEL_3")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel4)
                .HasColumnName("CUSTOM_LABEL_4")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel5)
                .HasColumnName("CUSTOM_LABEL_5")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel6)
                .HasColumnName("CUSTOM_LABEL_6")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel7)
                .HasColumnName("CUSTOM_LABEL_7")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel8)
                .HasColumnName("CUSTOM_LABEL_8")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel9)
                .HasColumnName("CUSTOM_LABEL_9")
                .IsUnicode(false);

            entity.Property(e => e.DailyPlanFolio)
                .HasColumnName("DAILY_PLAN_FOLIO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DedOwnerRevYn)
                .HasColumnName("DED_OWNER_REV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DefaultPrice)
                .HasColumnName("DEFAULT_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeferredYn)
                .IsRequired()
                .HasColumnName("DEFERRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepositPostingOnlyYn)
                .HasColumnName("DEPOSIT_POSTING_ONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepositType)
                .HasColumnName("DEPOSIT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucket)
                .HasColumnName("EXPORT_BUCKET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FiscalPaymentYn)
                .HasColumnName("FISCAL_PAYMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FiscalTrxCodeType)
                .HasColumnName("FISCAL_TRX_CODE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GpPointsRedemptionYn)
                .HasColumnName("GP_POINTS_REDEMPTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GroupDesc)
                .HasColumnName("GROUP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GroupFolio)
                .HasColumnName("GROUP_FOLIO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IncludeIn8300Yn)
                .HasColumnName("INCLUDE_IN_8300_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IncludeInDepositRuleYn)
                .HasColumnName("INCLUDE_IN_DEPOSIT_RULE_YN")
                .HasMaxLength(1)
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

            entity.Property(e => e.IndRevenueGp)
                .HasColumnName("IND_REVENUE_GP")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InhDepositYn)
                .HasColumnName("INH_DEPOSIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InhPayYn)
                .HasColumnName("INH_PAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InhSalesYn)
                .HasColumnName("INH_SALES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IsManualPostAllowed)
                .HasColumnName("IS_MANUAL_POST_ALLOWED")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.ManualPostCoversYn)
                .HasColumnName("MANUAL_POST_COVERS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MaxAmt)
                .HasColumnName("MAX_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinAmt)
                .HasColumnName("MIN_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonTaxableYn)
                .HasColumnName("NON_TAXABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerRevYn)
                .HasColumnName("OWNER_REV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PaymentTaxInvoiceYn)
                .HasColumnName("PAYMENT_TAX_INVOICE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortDesc)
                .HasColumnName("RESORT_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .IsRequired()
                .HasColumnName("RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResultIncludedInSumArray)
                .HasColumnName("RESULT_INCLUDED_IN_SUM_ARRAY")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.RotationRevYn)
                .HasColumnName("ROTATION_REV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RoundFactorYn)
                .HasColumnName("ROUND_FACTOR_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(61)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.Subgroup)
                .HasColumnName("SUBGROUP")
                .HasMaxLength(43)
                .IsUnicode(false);

            entity.Property(e => e.SubgroupDesc)
                .HasColumnName("SUBGROUP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TaxCodeNo)
                .HasColumnName("TAX_CODE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxInclusiveYn)
                .HasColumnName("TAX_INCLUSIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TcGroup)
                .IsRequired()
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .IsRequired()
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcTransactionType)
                .HasColumnName("TC_TRANSACTION_TYPE")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.TrxActionId)
                .HasColumnName("TRX_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode1)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeDisplay)
                .HasColumnName("TRX_CODE_DISPLAY")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeType)
                .HasColumnName("TRX_CODE_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.TrxGroup)
                .HasColumnName("TRX_GROUP")
                .HasMaxLength(43)
                .IsUnicode(false);

            entity.Property(e => e.TrxServiceType)
                .HasColumnName("TRX_SERVICE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxTaxTypeCode)
                .HasColumnName("TRX_TAX_TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Trxcode)
                .IsRequired()
                .HasColumnName("TRXCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxcodeDesc)
                .HasColumnName("TRXCODE_DESC")
                .HasMaxLength(2042)
                .IsUnicode(false);

            entity.Property(e => e.TrxcodeId)
                .HasColumnName("TRXCODE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
