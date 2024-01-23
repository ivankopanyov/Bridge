namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DmFinancialActualVw
{
    public string Resort { get; set; }
    public DateTime BusinessDate { get; set; }
    public string TrxCode { get; set; }
    public string TrxCodeDescription { get; set; }
    public string TrxSubgroup { get; set; }
    public string TrxSubgroupDescription { get; set; }
    public string TrxGroup { get; set; }
    public string TrxGroupDescription { get; set; }
    public string PmsDeptCode { get; set; }
    public decimal? AmountNet { get; set; }
    public decimal? AmountNetMtd { get; set; }
    public decimal? AmountNetYtd { get; set; }
    public decimal? AmountGross { get; set; }
    public decimal? AmountGrossMtd { get; set; }
    public decimal? AmountGrossYtd { get; set; }
    public decimal? CExchangeRate { get; set; }
    public decimal? CAmountNet { get; set; }
    public decimal? CAmountNetMtd { get; set; }
    public decimal? CAmountNetYtd { get; set; }
    public decimal? CAmountGross { get; set; }
    public decimal? CAmountGrossMtd { get; set; }
    public decimal? CAmountGrossYtd { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DmFinancialActualVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DM_FINANCIAL_ACTUAL_VW");

            entity.Property(e => e.AmountGross)
                .HasColumnName("AMOUNT_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmountGrossMtd)
                .HasColumnName("AMOUNT_GROSS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmountGrossYtd)
                .HasColumnName("AMOUNT_GROSS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmountNet)
                .HasColumnName("AMOUNT_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmountNetMtd)
                .HasColumnName("AMOUNT_NET_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmountNetYtd)
                .HasColumnName("AMOUNT_NET_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CAmountGross)
                .HasColumnName("C_AMOUNT_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CAmountGrossMtd)
                .HasColumnName("C_AMOUNT_GROSS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CAmountGrossYtd)
                .HasColumnName("C_AMOUNT_GROSS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CAmountNet)
                .HasColumnName("C_AMOUNT_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CAmountNetMtd)
                .HasColumnName("C_AMOUNT_NET_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CAmountNetYtd)
                .HasColumnName("C_AMOUNT_NET_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CExchangeRate)
                .HasColumnName("C_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsDeptCode)
                .HasColumnName("PMS_DEPT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeDescription)
                .HasColumnName("TRX_CODE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrxGroup)
                .HasColumnName("TRX_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxGroupDescription)
                .HasColumnName("TRX_GROUP_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrxSubgroup)
                .HasColumnName("TRX_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxSubgroupDescription)
                .HasColumnName("TRX_SUBGROUP_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
