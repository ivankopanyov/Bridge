namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEfolioDetails2
{
    public decimal? ExportId { get; set; }
    public decimal? RowSequence { get; set; }
    public decimal? PartySequence { get; set; }
    public decimal? DetailSequence { get; set; }
    public string? ExportType { get; set; }
    public decimal? HInvoiceNo { get; set; }
    public decimal? HByNameId { get; set; }
    public decimal? HPeNameId { get; set; }
    public decimal? HBillNo { get; set; }
    public decimal? HOrgInvoiceNo { get; set; }
    public string? HResort { get; set; }
    public string? HCurrency { get; set; }
    public decimal? HTotRevTaxable { get; set; }
    public decimal? HTotNonrevTaxable { get; set; }
    public decimal? HTotRevNontaxable { get; set; }
    public decimal? HTotNonrevNontaxable { get; set; }
    public decimal? HTotalNet { get; set; }
    public decimal? HTotalGross { get; set; }
    public decimal? HTotalNontaxable { get; set; }
    public decimal? HTax1Amt { get; set; }
    public decimal? HTax2Amt { get; set; }
    public decimal? HTax3Amt { get; set; }
    public decimal? HTax4Amt { get; set; }
    public decimal? HTax5Amt { get; set; }
    public decimal? HTax6Amt { get; set; }
    public decimal? HTax7Amt { get; set; }
    public decimal? HTax8Amt { get; set; }
    public decimal? HTax9Amt { get; set; }
    public decimal? HTax10Amt { get; set; }
    public decimal? HNet1Amt { get; set; }
    public decimal? HNet2Amt { get; set; }
    public decimal? HNet3Amt { get; set; }
    public decimal? HNet4Amt { get; set; }
    public decimal? HNet5Amt { get; set; }
    public decimal? HNet6Amt { get; set; }
    public decimal? HNet7Amt { get; set; }
    public decimal? HNet8Amt { get; set; }
    public decimal? HNet9Amt { get; set; }
    public decimal? HNet10Amt { get; set; }
    public DateTime? HInsertDate { get; set; }
    public DateTime? HInvoicedate { get; set; }
    public string? HCcNo { get; set; }
    public string? HCcName { get; set; }
    public string? HCcType { get; set; }
    public string? HCcExpDtStr { get; set; }
    public string? HCcApprovalCode { get; set; }
    public string? HCcMerchantId { get; set; }
    public DateTime? HArrival { get; set; }
    public DateTime? HDeparture { get; set; }
    public string? HConfirmationNo { get; set; }
    public string? HRoom { get; set; }
    public decimal? HRoomRate { get; set; }
    public decimal? HTax11Amt { get; set; }
    public decimal? HTax12Amt { get; set; }
    public decimal? HTax13Amt { get; set; }
    public decimal? HTax14Amt { get; set; }
    public decimal? HTax15Amt { get; set; }
    public decimal? HTax16Amt { get; set; }
    public decimal? HTax17Amt { get; set; }
    public decimal? HTax18Amt { get; set; }
    public decimal? HTax19Amt { get; set; }
    public decimal? HTax20Amt { get; set; }
    public decimal? HNet11Amt { get; set; }
    public decimal? HNet12Amt { get; set; }
    public decimal? HNet13Amt { get; set; }
    public decimal? HNet14Amt { get; set; }
    public decimal? HNet15Amt { get; set; }
    public decimal? HNet16Amt { get; set; }
    public decimal? HNet17Amt { get; set; }
    public decimal? HNet18Amt { get; set; }
    public decimal? HNet19Amt { get; set; }
    public decimal? HNet20Amt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEfolioDetails2>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_EFOLIO_DETAILS_2");

            entity.Property(e => e.DetailSequence)
                .HasColumnName("DETAIL_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportType)
                .HasColumnName("EXPORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HArrival)
                .HasColumnName("H_ARRIVAL")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HBillNo)
                .HasColumnName("H_BILL_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HByNameId)
                .HasColumnName("H_BY_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HCcApprovalCode)
                .HasColumnName("H_CC_APPROVAL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HCcExpDtStr)
                .HasColumnName("H_CC_EXP_DT_STR")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HCcMerchantId)
                .HasColumnName("H_CC_MERCHANT_ID")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HCcName)
                .HasColumnName("H_CC_NAME")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HCcNo)
                .HasColumnName("H_CC_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HCcType)
                .HasColumnName("H_CC_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HConfirmationNo)
                .HasColumnName("H_CONFIRMATION_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HCurrency)
                .HasColumnName("H_CURRENCY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HDeparture)
                .HasColumnName("H_DEPARTURE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HInsertDate)
                .HasColumnName("H_INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HInvoiceNo)
                .HasColumnName("H_INVOICE_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HInvoicedate)
                .HasColumnName("H_INVOICEDATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet10Amt)
                .HasColumnName("H_NET10_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet11Amt)
                .HasColumnName("H_NET11_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet12Amt)
                .HasColumnName("H_NET12_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet13Amt)
                .HasColumnName("H_NET13_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet14Amt)
                .HasColumnName("H_NET14_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet15Amt)
                .HasColumnName("H_NET15_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet16Amt)
                .HasColumnName("H_NET16_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet17Amt)
                .HasColumnName("H_NET17_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet18Amt)
                .HasColumnName("H_NET18_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet19Amt)
                .HasColumnName("H_NET19_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet1Amt)
                .HasColumnName("H_NET1_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet20Amt)
                .HasColumnName("H_NET20_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet2Amt)
                .HasColumnName("H_NET2_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet3Amt)
                .HasColumnName("H_NET3_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet4Amt)
                .HasColumnName("H_NET4_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet5Amt)
                .HasColumnName("H_NET5_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet6Amt)
                .HasColumnName("H_NET6_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet7Amt)
                .HasColumnName("H_NET7_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet8Amt)
                .HasColumnName("H_NET8_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HNet9Amt)
                .HasColumnName("H_NET9_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HOrgInvoiceNo)
                .HasColumnName("H_ORG_INVOICE_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HPeNameId)
                .HasColumnName("H_PE_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HResort)
                .HasColumnName("H_RESORT")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HRoom)
                .HasColumnName("H_ROOM")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HRoomRate)
                .HasColumnName("H_ROOM_RATE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax10Amt)
                .HasColumnName("H_TAX10_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax11Amt)
                .HasColumnName("H_TAX11_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax12Amt)
                .HasColumnName("H_TAX12_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax13Amt)
                .HasColumnName("H_TAX13_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax14Amt)
                .HasColumnName("H_TAX14_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax15Amt)
                .HasColumnName("H_TAX15_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax16Amt)
                .HasColumnName("H_TAX16_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax17Amt)
                .HasColumnName("H_TAX17_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax18Amt)
                .HasColumnName("H_TAX18_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax19Amt)
                .HasColumnName("H_TAX19_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax1Amt)
                .HasColumnName("H_TAX1_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax20Amt)
                .HasColumnName("H_TAX20_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax2Amt)
                .HasColumnName("H_TAX2_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax3Amt)
                .HasColumnName("H_TAX3_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax4Amt)
                .HasColumnName("H_TAX4_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax5Amt)
                .HasColumnName("H_TAX5_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax6Amt)
                .HasColumnName("H_TAX6_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax7Amt)
                .HasColumnName("H_TAX7_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax8Amt)
                .HasColumnName("H_TAX8_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTax9Amt)
                .HasColumnName("H_TAX9_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTotNonrevNontaxable)
                .HasColumnName("H_TOT_NONREV_NONTAXABLE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTotNonrevTaxable)
                .HasColumnName("H_TOT_NONREV_TAXABLE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTotRevNontaxable)
                .HasColumnName("H_TOT_REV_NONTAXABLE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTotRevTaxable)
                .HasColumnName("H_TOT_REV_TAXABLE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTotalGross)
                .HasColumnName("H_TOTAL_GROSS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTotalNet)
                .HasColumnName("H_TOTAL_NET")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HTotalNontaxable)
                .HasColumnName("H_TOTAL_NONTAXABLE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PartySequence)
                .HasColumnName("PARTY_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RowSequence)
                .HasColumnName("ROW_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
