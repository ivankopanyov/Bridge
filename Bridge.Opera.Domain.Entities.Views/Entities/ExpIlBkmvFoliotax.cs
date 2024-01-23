namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpIlBkmvFoliotax
{
    public string CurrencyCode { get; set; }
    public string IsDualYn { get; set; }
    public decimal? TotalNetIls { get; set; }
    public decimal? TotalTaxIls { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? BillNo { get; set; }
    public DateTime? BillGenerationDate { get; set; }
    public decimal? InsertUserFoliotax { get; set; }
    public DateTime? InsertDateFoliotax { get; set; }
    public decimal? UpdateUserFoliotax { get; set; }
    public DateTime? UpdateDateFoliotax { get; set; }
    public decimal? TotRevTaxable { get; set; }
    public decimal? TotNonrevTaxable { get; set; }
    public decimal? TotRevNontaxable { get; set; }
    public decimal? TotNonrevNontaxable { get; set; }
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
    public decimal? Net1Amt { get; set; }
    public decimal? Net2Amt { get; set; }
    public decimal? Net3Amt { get; set; }
    public decimal? Net4Amt { get; set; }
    public decimal? Net5Amt { get; set; }
    public decimal? Net6Amt { get; set; }
    public decimal? Net7Amt { get; set; }
    public decimal? Net8Amt { get; set; }
    public decimal? Net9Amt { get; set; }
    public decimal? Net10Amt { get; set; }
    public decimal? Net11Amt { get; set; }
    public decimal? Net12Amt { get; set; }
    public decimal? Net13Amt { get; set; }
    public decimal? Net14Amt { get; set; }
    public decimal? Net15Amt { get; set; }
    public decimal? Net16Amt { get; set; }
    public decimal? Net17Amt { get; set; }
    public decimal? Net18Amt { get; set; }
    public decimal? Net19Amt { get; set; }
    public decimal? Net20Amt { get; set; }
    public decimal? Ptax1Amt { get; set; }
    public decimal? Ptax2Amt { get; set; }
    public decimal? Ptax3Amt { get; set; }
    public decimal? Ptax4Amt { get; set; }
    public decimal? Ptax5Amt { get; set; }
    public decimal? Ptax6Amt { get; set; }
    public decimal? Ptax7Amt { get; set; }
    public decimal? Ptax8Amt { get; set; }
    public decimal? Ptax9Amt { get; set; }
    public decimal? Ptax10Amt { get; set; }
    public decimal? Ptax11Amt { get; set; }
    public decimal? Ptax12Amt { get; set; }
    public decimal? Ptax13Amt { get; set; }
    public decimal? Ptax14Amt { get; set; }
    public decimal? Ptax15Amt { get; set; }
    public decimal? Ptax16Amt { get; set; }
    public decimal? Ptax17Amt { get; set; }
    public decimal? Ptax18Amt { get; set; }
    public decimal? Ptax19Amt { get; set; }
    public decimal? Ptax20Amt { get; set; }
    public decimal? Pnet1Amt { get; set; }
    public decimal? Pnet2Amt { get; set; }
    public decimal? Pnet3Amt { get; set; }
    public decimal? Pnet4Amt { get; set; }
    public decimal? Pnet5Amt { get; set; }
    public decimal? Pnet6Amt { get; set; }
    public decimal? Pnet7Amt { get; set; }
    public decimal? Pnet8Amt { get; set; }
    public decimal? Pnet9Amt { get; set; }
    public decimal? Pnet10Amt { get; set; }
    public decimal? Pnet11Amt { get; set; }
    public decimal? Pnet12Amt { get; set; }
    public decimal? Pnet13Amt { get; set; }
    public decimal? Pnet14Amt { get; set; }
    public decimal? Pnet15Amt { get; set; }
    public decimal? Pnet16Amt { get; set; }
    public decimal? Pnet17Amt { get; set; }
    public decimal? Pnet18Amt { get; set; }
    public decimal? Pnet19Amt { get; set; }
    public decimal? Pnet20Amt { get; set; }
    public string Resort { get; set; }
    public decimal? PayeeNameId { get; set; }
    public string BillGenerationTime { get; set; }
    public string PayeeName { get; set; }
    public string PayeeAddress1 { get; set; }
    public string PayeeAddress2 { get; set; }
    public string PayeeAddress3 { get; set; }
    public string PayeeAddress4 { get; set; }
    public string PayeeCity { get; set; }
    public string PayeeZipCode { get; set; }
    public string PayeeCountry { get; set; }
    public string PayeePhoneNo { get; set; }
    public string PayeeTax1No { get; set; }
    public string PayeeTax2No { get; set; }
    public decimal? PtotRevTaxable { get; set; }
    public decimal? PtotNonrevTaxable { get; set; }
    public decimal? PtotRevNontaxable { get; set; }
    public decimal? PtotNonrevNontaxable { get; set; }
    public string Room { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpIlBkmvFoliotax>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_IL_BKMV_FOLIOTAX");

            entity.Property(e => e.BillGenerationDate)
                .HasColumnName("BILL_GENERATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillGenerationTime)
                .HasColumnName("BILL_GENERATION_TIME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDateFoliotax)
                .HasColumnName("INSERT_DATE_FOLIOTAX")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUserFoliotax)
                .HasColumnName("INSERT_USER_FOLIOTAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsDualYn)
                .HasColumnName("IS_DUAL_YN")
                .IsUnicode(false);

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

            entity.Property(e => e.PayeeAddress1)
                .HasColumnName("PAYEE_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PayeeAddress2)
                .HasColumnName("PAYEE_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PayeeAddress3)
                .HasColumnName("PAYEE_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PayeeAddress4)
                .HasColumnName("PAYEE_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PayeeCity)
                .HasColumnName("PAYEE_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PayeeCountry)
                .HasColumnName("PAYEE_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PayeeName)
                .HasColumnName("PAYEE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PayeeNameId)
                .HasColumnName("PAYEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayeePhoneNo)
                .HasColumnName("PAYEE_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.PayeeTax1No)
                .HasColumnName("PAYEE_TAX1_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PayeeTax2No)
                .HasColumnName("PAYEE_TAX2_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PayeeZipCode)
                .HasColumnName("PAYEE_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.Pnet10Amt)
                .HasColumnName("PNET10_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet11Amt)
                .HasColumnName("PNET11_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet12Amt)
                .HasColumnName("PNET12_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet13Amt)
                .HasColumnName("PNET13_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet14Amt)
                .HasColumnName("PNET14_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet15Amt)
                .HasColumnName("PNET15_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet16Amt)
                .HasColumnName("PNET16_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet17Amt)
                .HasColumnName("PNET17_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet18Amt)
                .HasColumnName("PNET18_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet19Amt)
                .HasColumnName("PNET19_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet1Amt)
                .HasColumnName("PNET1_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet20Amt)
                .HasColumnName("PNET20_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet2Amt)
                .HasColumnName("PNET2_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet3Amt)
                .HasColumnName("PNET3_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet4Amt)
                .HasColumnName("PNET4_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet5Amt)
                .HasColumnName("PNET5_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet6Amt)
                .HasColumnName("PNET6_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet7Amt)
                .HasColumnName("PNET7_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet8Amt)
                .HasColumnName("PNET8_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Pnet9Amt)
                .HasColumnName("PNET9_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax10Amt)
                .HasColumnName("PTAX10_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax11Amt)
                .HasColumnName("PTAX11_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax12Amt)
                .HasColumnName("PTAX12_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax13Amt)
                .HasColumnName("PTAX13_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax14Amt)
                .HasColumnName("PTAX14_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax15Amt)
                .HasColumnName("PTAX15_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax16Amt)
                .HasColumnName("PTAX16_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax17Amt)
                .HasColumnName("PTAX17_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax18Amt)
                .HasColumnName("PTAX18_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax19Amt)
                .HasColumnName("PTAX19_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax1Amt)
                .HasColumnName("PTAX1_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax20Amt)
                .HasColumnName("PTAX20_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax2Amt)
                .HasColumnName("PTAX2_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax3Amt)
                .HasColumnName("PTAX3_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax4Amt)
                .HasColumnName("PTAX4_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax5Amt)
                .HasColumnName("PTAX5_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax6Amt)
                .HasColumnName("PTAX6_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax7Amt)
                .HasColumnName("PTAX7_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax8Amt)
                .HasColumnName("PTAX8_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ptax9Amt)
                .HasColumnName("PTAX9_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PtotNonrevNontaxable)
                .HasColumnName("PTOT_NONREV_NONTAXABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PtotNonrevTaxable)
                .HasColumnName("PTOT_NONREV_TAXABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PtotRevNontaxable)
                .HasColumnName("PTOT_REV_NONTAXABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PtotRevTaxable)
                .HasColumnName("PTOT_REV_TAXABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
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

            entity.Property(e => e.TotNonrevNontaxable)
                .HasColumnName("TOT_NONREV_NONTAXABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotNonrevTaxable)
                .HasColumnName("TOT_NONREV_TAXABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotRevNontaxable)
                .HasColumnName("TOT_REV_NONTAXABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotRevTaxable)
                .HasColumnName("TOT_REV_TAXABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNetIls)
                .HasColumnName("TOTAL_NET_ILS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTaxIls)
                .HasColumnName("TOTAL_TAX_ILS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDateFoliotax)
                .HasColumnName("UPDATE_DATE_FOLIOTAX")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUserFoliotax)
                .HasColumnName("UPDATE_USER_FOLIOTAX")
                .HasColumnType("NUMBER");
        });
	}
}
