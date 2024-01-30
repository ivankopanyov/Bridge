namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempTaxPopulation
{
    public string? TaxInclusiveYn { get; set; }
    public string? Resort { get; set; }
    public string? TrxCode { get; set; }
    public string? TcGroup { get; set; }
    public string? TcSubgroup { get; set; }
    public string? TclCodeDfltCl1 { get; set; }
    public string? TclCodeDfltCl2 { get; set; }
    public string? Class1MandatoryYn { get; set; }
    public string? Class2MandatoryYn { get; set; }
    public string? Description { get; set; }
    public string? TcTransactionType { get; set; }
    public string? IsManualPostAllowed { get; set; }
    public string? ResultIncludedInSumArray { get; set; }
    public string? CcType { get; set; }
    public decimal? Commission { get; set; }
    public string? CcCode { get; set; }
    public string? IndBilling { get; set; }
    public string? IndAr { get; set; }
    public string? Currency { get; set; }
    public string? IndRevenueGp { get; set; }
    public string? AdjTrxCode { get; set; }
    public string? ArrangeCode { get; set; }
    public decimal? ExpenseFolio { get; set; }
    public decimal? GroupFolio { get; set; }
    public decimal? RevBucketId { get; set; }
    public decimal? RevGpId { get; set; }
    public string? IndCash { get; set; }
    public string? IndDepositYn { get; set; }
    public string? DeferredYn { get; set; }
    public decimal? ArNameId { get; set; }
    public string? TrxCodeType { get; set; }
    public string? TaxTrxCode { get; set; }
    public string? FlatPercentageFlag { get; set; }
    public decimal? TaxValue { get; set; }
    public string? UdfFunction { get; set; }
    public string? Last { get; set; }
    public string? NameTaxType { get; set; }
    public DateTime? StartDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempTaxPopulation>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_TAX_POPULATION");

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
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Class1MandatoryYn)
                .HasColumnName("CLASS_1_MANDATORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Class2MandatoryYn)
                .HasColumnName("CLASS_2_MANDATORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Commission)
                .HasColumnName("COMMISSION")
                .HasColumnType("NUMBER(10,2)");

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeferredYn)
                .HasColumnName("DEFERRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExpenseFolio)
                .HasColumnName("EXPENSE_FOLIO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlatPercentageFlag)
                .HasColumnName("FLAT_PERCENTAGE_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GroupFolio)
                .HasColumnName("GROUP_FOLIO")
                .HasColumnType("NUMBER");

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
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.IndRevenueGp)
                .HasColumnName("IND_REVENUE_GP")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IsManualPostAllowed)
                .HasColumnName("IS_MANUAL_POST_ALLOWED")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Last)
                .HasColumnName("LAST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(20)
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

            entity.Property(e => e.RevBucketId)
                .HasColumnName("REV_BUCKET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevGpId)
                .HasColumnName("REV_GP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaxInclusiveYn)
                .HasColumnName("TAX_INCLUSIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.TaxTrxCode)
                .HasColumnName("TAX_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxValue)
                .HasColumnName("TAX_VALUE")
                .HasColumnType("NUMBER");

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
                .IsRequired()
                .HasColumnName("TC_TRANSACTION_TYPE")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.TclCodeDfltCl1)
                .HasColumnName("TCL_CODE_DFLT_CL1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TclCodeDfltCl2)
                .HasColumnName("TCL_CODE_DFLT_CL2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeType)
                .HasColumnName("TRX_CODE_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.UdfFunction)
                .HasColumnName("UDF_FUNCTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
