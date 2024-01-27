namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FitContractRateCodes
{
    public string RateCode { get; set; }
    public string Description { get; set; }
    public string CurrencyCode { get; set; }
    public string PrimaryYn { get; set; }
    public string Resort { get; set; }
    public string CommissionableYn { get; set; }
    public decimal? CommissionablePerc { get; set; }
    public string TaxIncludedYn { get; set; }
    public decimal? TaxIncludedPerc { get; set; }
    public string ServiceInclYn { get; set; }
    public decimal? ServicePerc { get; set; }
    public string BfstInclYn { get; set; }
    public decimal? BfstPrice { get; set; }
    public string DblRmSupplementYn { get; set; }
    public decimal? DblRmSupplementPrice { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FitContractRateCodes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIT_CONTRACT_RATE_CODES");

            entity.Property(e => e.BfstInclYn)
                .HasColumnName("BFST_INCL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BfstPrice)
                .HasColumnName("BFST_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionablePerc)
                .HasColumnName("COMMISSIONABLE_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionableYn)
                .HasColumnName("COMMISSIONABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DblRmSupplementPrice)
                .HasColumnName("DBL_RM_SUPPLEMENT_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DblRmSupplementYn)
                .HasColumnName("DBL_RM_SUPPLEMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ServiceInclYn)
                .HasColumnName("SERVICE_INCL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ServicePerc)
                .HasColumnName("SERVICE_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxIncludedPerc)
                .HasColumnName("TAX_INCLUDED_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxIncludedYn)
                .HasColumnName("TAX_INCLUDED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
