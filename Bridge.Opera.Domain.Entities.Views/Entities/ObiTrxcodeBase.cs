namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiTrxcodeBase
{
    public string Resort { get; set; }
    public string TrxCode { get; set; }
    public string AdjTrxCode { get; set; }
    public string ArrangeCode { get; set; }
    public decimal? ArNameId { get; set; }
    public string CcCode { get; set; }
    public string CcType { get; set; }
    public string CheckNoMandatoryYn { get; set; }
    public decimal? Commission { get; set; }
    public string CompNightsYn { get; set; }
    public string CompPaymentYn { get; set; }
    public string CompYn { get; set; }
    public string Currency { get; set; }
    public decimal? DailyPlanFolio { get; set; }
    public string DedOwnerRevYn { get; set; }
    public decimal? DefaultPrice { get; set; }
    public string DeferredYn { get; set; }
    public string DepositPostingOnlyYn { get; set; }
    public string Description { get; set; }
    public decimal? ExpenseFolio { get; set; }
    public decimal? ExportBucket { get; set; }
    public string FiscalPaymentYn { get; set; }
    public string FiscalTrxCodeType { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string IncludeIn8300Yn { get; set; }
    public string IncludeInDepositRuleYn { get; set; }
    public string IndAr { get; set; }
    public string IndBilling { get; set; }
    public string IndCash { get; set; }
    public string IndDepositYn { get; set; }
    public string IndRevenueGp { get; set; }
    public string InhDepositYn { get; set; }
    public string InhPayYn { get; set; }
    public string InhSalesYn { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public string InternalYn { get; set; }
    public string IsManualPostAllowed { get; set; }
    public string ManualPostCoversYn { get; set; }
    public decimal? MaxAmt { get; set; }
    public decimal? MinAmt { get; set; }
    public string NonTaxableYn { get; set; }
    public string OwnerRevYn { get; set; }
    public string PaymentTaxInvoiceYn { get; set; }
    public string ResultIncludedInSumArray { get; set; }
    public string RotationRevYn { get; set; }
    public string RoundFactorYn { get; set; }
    public decimal? TaxCodeNo { get; set; }
    public string TaxInclusiveYn { get; set; }
    public string TcGroup { get; set; }
    public string TcSubgroup { get; set; }
    public string TcTransactionType { get; set; }
    public decimal? TrxActionId { get; set; }
    public string TrxCodeDisplay { get; set; }
    public string TrxCodeType { get; set; }
    public string TrxServiceType { get; set; }
    public string SDescription { get; set; }
    public string STcTransactionType { get; set; }
    public string SIndRevenueGp { get; set; }
    public string SSubGpType { get; set; }
    public string SInternalYn { get; set; }
    public string GDescription { get; set; }
    public string GIndRevenueGp { get; set; }
    public string GTcTransactionType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiTrxcodeBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_TRXCODE_BASE");

            entity.Property(e => e.AdjTrxCode)
                .HasColumnName("ADJ_TRX_CODE")
                .HasMaxLength(20)
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

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExpenseFolio)
                .HasColumnName("EXPENSE_FOLIO")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.GDescription)
                .HasColumnName("G_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GIndRevenueGp)
                .HasColumnName("G_IND_REVENUE_GP")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GTcTransactionType)
                .IsRequired()
                .HasColumnName("G_TC_TRANSACTION_TYPE")
                .HasColumnType("CHAR(5)");

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

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.SDescription)
                .HasColumnName("S_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SIndRevenueGp)
                .HasColumnName("S_IND_REVENUE_GP")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SInternalYn)
                .HasColumnName("S_INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SSubGpType)
                .HasColumnName("S_SUB_GP_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.STcTransactionType)
                .IsRequired()
                .HasColumnName("S_TC_TRANSACTION_TYPE")
                .HasColumnType("CHAR(5)");

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

            entity.Property(e => e.TrxCode)
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

            entity.Property(e => e.TrxServiceType)
                .HasColumnName("TRX_SERVICE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
