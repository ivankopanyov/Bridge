namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FolioTaxBuckets2
{
    public DateTime? BillGenerationDate { get; set; }
    public decimal? BillNo { get; set; }
    public decimal? NameId { get; set; }
    public decimal? PayeeNameId { get; set; }
    public string Room { get; set; }
    public decimal? Net1Amt { get; set; }
    public decimal? Tax1Amt { get; set; }
    public decimal? Gr1Amt { get; set; }
    public decimal? Net2Amt { get; set; }
    public decimal? Tax2Amt { get; set; }
    public decimal? Gr2Amt { get; set; }
    public decimal? Net3Amt { get; set; }
    public decimal? Tax3Amt { get; set; }
    public decimal? Gr3Amt { get; set; }
    public decimal? Net4Amt { get; set; }
    public decimal? Tax4Amt { get; set; }
    public decimal? Gr4Amt { get; set; }
    public decimal? Net5Amt { get; set; }
    public decimal? Tax5Amt { get; set; }
    public decimal? Gr5Amt { get; set; }
    public decimal? Net6Amt { get; set; }
    public decimal? Tax6Amt { get; set; }
    public decimal? Gr6Amt { get; set; }
    public decimal? Net7Amt { get; set; }
    public decimal? Tax7Amt { get; set; }
    public decimal? Gr7Amt { get; set; }
    public decimal? Net8Amt { get; set; }
    public decimal? Tax8Amt { get; set; }
    public decimal? Gr8Amt { get; set; }
    public decimal? Net9Amt { get; set; }
    public decimal? Tax9Amt { get; set; }
    public decimal? Gr9Amt { get; set; }
    public decimal? Net10Amt { get; set; }
    public decimal? Tax10Amt { get; set; }
    public decimal? Gr10Amt { get; set; }
    public decimal? Net11Amt { get; set; }
    public decimal? Tax11Amt { get; set; }
    public decimal? Gr11Amt { get; set; }
    public decimal? Net12Amt { get; set; }
    public decimal? Tax12Amt { get; set; }
    public decimal? Gr12Amt { get; set; }
    public decimal? Net13Amt { get; set; }
    public decimal? Tax13Amt { get; set; }
    public decimal? Gr13Amt { get; set; }
    public decimal? Net14Amt { get; set; }
    public decimal? Tax14Amt { get; set; }
    public decimal? Gr14Amt { get; set; }
    public decimal? Net15Amt { get; set; }
    public decimal? Tax15Amt { get; set; }
    public decimal? Gr15Amt { get; set; }
    public decimal? Net16Amt { get; set; }
    public decimal? Tax16Amt { get; set; }
    public decimal? Gr16Amt { get; set; }
    public decimal? Net17Amt { get; set; }
    public decimal? Tax17Amt { get; set; }
    public decimal? Gr17Amt { get; set; }
    public decimal? Net18Amt { get; set; }
    public decimal? Tax18Amt { get; set; }
    public decimal? Gr18Amt { get; set; }
    public decimal? Net19Amt { get; set; }
    public decimal? Tax19Amt { get; set; }
    public decimal? Gr19Amt { get; set; }
    public decimal? Net20Amt { get; set; }
    public decimal? Tax20Amt { get; set; }
    public decimal? Gr20Amt { get; set; }
    public decimal? Deposit { get; set; }
    public decimal? Cashpay { get; set; }
    public decimal? Ccpay { get; set; }
    public decimal? Clpay { get; set; }
    public decimal? TotalGross { get; set; }
    public decimal? TotalNet { get; set; }
    public decimal? TotalTax { get; set; }
    public string Status { get; set; }
    public string AssociatedBillNo { get; set; }
    public string FolioType { get; set; }
    public decimal? Exempt { get; set; }
    public decimal? AddresseeNameId { get; set; }
    public string AddresseeName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FolioTaxBuckets2>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FOLIO_TAX_BUCKETS2");

            entity.Property(e => e.AddresseeName)
                .HasColumnName("ADDRESSEE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AddresseeNameId)
                .HasColumnName("ADDRESSEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AssociatedBillNo)
                .HasColumnName("ASSOCIATED_BILL_NO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BillGenerationDate)
                .HasColumnName("BILL_GENERATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cashpay)
                .HasColumnName("CASHPAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Ccpay)
                .HasColumnName("CCPAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Clpay)
                .HasColumnName("CLPAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Deposit)
                .HasColumnName("DEPOSIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exempt)
                .HasColumnName("EXEMPT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Gr10Amt)
                .HasColumnName("GR10_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr11Amt)
                .HasColumnName("GR11_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr12Amt)
                .HasColumnName("GR12_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr13Amt)
                .HasColumnName("GR13_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr14Amt)
                .HasColumnName("GR14_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr15Amt)
                .HasColumnName("GR15_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr16Amt)
                .HasColumnName("GR16_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr17Amt)
                .HasColumnName("GR17_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr18Amt)
                .HasColumnName("GR18_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr19Amt)
                .HasColumnName("GR19_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr1Amt)
                .HasColumnName("GR1_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr20Amt)
                .HasColumnName("GR20_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr2Amt)
                .HasColumnName("GR2_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr3Amt)
                .HasColumnName("GR3_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr4Amt)
                .HasColumnName("GR4_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr5Amt)
                .HasColumnName("GR5_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr6Amt)
                .HasColumnName("GR6_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr7Amt)
                .HasColumnName("GR7_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr8Amt)
                .HasColumnName("GR8_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gr9Amt)
                .HasColumnName("GR9_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net10Amt)
                .HasColumnName("NET10_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net11Amt)
                .HasColumnName("NET11_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net12Amt)
                .HasColumnName("NET12_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net13Amt)
                .HasColumnName("NET13_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net14Amt)
                .HasColumnName("NET14_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net15Amt)
                .HasColumnName("NET15_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net16Amt)
                .HasColumnName("NET16_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net17Amt)
                .HasColumnName("NET17_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net18Amt)
                .HasColumnName("NET18_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net19Amt)
                .HasColumnName("NET19_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net1Amt)
                .HasColumnName("NET1_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net20Amt)
                .HasColumnName("NET20_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net2Amt)
                .HasColumnName("NET2_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net3Amt)
                .HasColumnName("NET3_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net4Amt)
                .HasColumnName("NET4_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net5Amt)
                .HasColumnName("NET5_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net6Amt)
                .HasColumnName("NET6_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net7Amt)
                .HasColumnName("NET7_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net8Amt)
                .HasColumnName("NET8_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net9Amt)
                .HasColumnName("NET9_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayeeNameId)
                .HasColumnName("PAYEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.TotalGross)
                .HasColumnName("TOTAL_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNet)
                .HasColumnName("TOTAL_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTax)
                .HasColumnName("TOTAL_TAX")
                .HasColumnType("NUMBER");
        });
	}
}
