namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpTbView
{
    public DateTime? TrxDate { get; set; }
    public string? TrxCode { get; set; }
    public string? Description { get; set; }
    public decimal? Amount { get; set; }
    public string? TrxType { get; set; }
    public string? TrxTypeDescription { get; set; }
    public decimal? NetAmount { get; set; }
    public decimal? NonRevenueAmt { get; set; }
    public decimal? GrossAmount { get; set; }
    public decimal? Tax1Amt { get; set; }
    public decimal? Tax2Amt { get; set; }
    public decimal? Tax3Amt { get; set; }
    public decimal? Tax4Amt { get; set; }
    public decimal? Tax5Amt { get; set; }
    public decimal? Tax6Amt { get; set; }
    public decimal? Tax7Amt { get; set; }
    public decimal? Tax8Amt { get; set; }
    public decimal? Tax9Amt { get; set; }
    public decimal? Tax10Amt { get; set; }
    public decimal? Tax11Amt { get; set; }
    public decimal? Tax12Amt { get; set; }
    public decimal? Tax13Amt { get; set; }
    public decimal? Tax14Amt { get; set; }
    public decimal? Tax15Amt { get; set; }
    public decimal? Tax16Amt { get; set; }
    public decimal? Tax17Amt { get; set; }
    public decimal? Tax18Amt { get; set; }
    public decimal? Tax19Amt { get; set; }
    public decimal? Tax20Amt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpTbView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_TB_VIEW");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenueAmt)
                .HasColumnName("NON_REVENUE_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax10Amt)
                .HasColumnName("TAX10_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax11Amt)
                .HasColumnName("TAX11_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax12Amt)
                .HasColumnName("TAX12_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax13Amt)
                .HasColumnName("TAX13_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax14Amt)
                .HasColumnName("TAX14_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax15Amt)
                .HasColumnName("TAX15_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax16Amt)
                .HasColumnName("TAX16_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax17Amt)
                .HasColumnName("TAX17_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax18Amt)
                .HasColumnName("TAX18_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax19Amt)
                .HasColumnName("TAX19_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax1Amt)
                .HasColumnName("TAX1_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax20Amt)
                .HasColumnName("TAX20_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax2Amt)
                .HasColumnName("TAX2_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax3Amt)
                .HasColumnName("TAX3_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax4Amt)
                .HasColumnName("TAX4_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax5Amt)
                .HasColumnName("TAX5_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax6Amt)
                .HasColumnName("TAX6_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax7Amt)
                .HasColumnName("TAX7_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax8Amt)
                .HasColumnName("TAX8_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax9Amt)
                .HasColumnName("TAX9_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxType)
                .HasColumnName("TRX_TYPE")
                .HasMaxLength(11)
                .IsUnicode(false);

            entity.Property(e => e.TrxTypeDescription)
                .HasColumnName("TRX_TYPE_DESCRIPTION")
                .IsUnicode(false);
        });
	}
}
