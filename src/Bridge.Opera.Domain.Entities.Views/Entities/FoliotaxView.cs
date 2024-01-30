namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FoliotaxView
{
    public DateTime? BusinessDate { get; set; }
    public decimal? BillNo { get; set; }
    public DateTime? BillGenerationDate { get; set; }
    public decimal? NameId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? Room { get; set; }
    public decimal? RevisionNo { get; set; }
    public decimal? FolioView { get; set; }
    public decimal? TotRevTaxable { get; set; }
    public decimal? TotNonrevTaxable { get; set; }
    public decimal? TotRevNontaxable { get; set; }
    public decimal? TotNonrevNontaxable { get; set; }
    public decimal? Deposit { get; set; }
    public decimal? Cashpay { get; set; }
    public decimal? Ccpay { get; set; }
    public decimal? Clpay { get; set; }
    public decimal? Paidout { get; set; }
    public decimal? TotalNet { get; set; }
    public decimal? TotalGross { get; set; }
    public decimal? TotalNontaxable { get; set; }
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
    public string? Resort { get; set; }
    public decimal? Clarpay { get; set; }
    public string? Status { get; set; }
    public string? QueueName { get; set; }
    public string? AssociatedBillNo { get; set; }
    public string? NameTaxType { get; set; }
    public string? TaxId { get; set; }
    public decimal? PayeeNameId { get; set; }
    public string? FolioType { get; set; }
    public DateTime? BillStartDate { get; set; }
    public string? CompressBillNo { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? AccountCode { get; set; }
    public decimal? ClTrxNo { get; set; }
    public decimal? CashierId { get; set; }
    public decimal? InvoiceNo { get; set; }
    public decimal? BillPaymentTrxNo { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? AssociatedBillDate { get; set; }
    public string? FullName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FoliotaxView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FOLIOTAX_VIEW");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AssociatedBillDate)
                .HasColumnName("ASSOCIATED_BILL_DATE")
                .HasColumnType("DATE");

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

            entity.Property(e => e.BillPaymentTrxNo)
                .HasColumnName("BILL_PAYMENT_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillStartDate)
                .HasColumnName("BILL_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cashpay)
                .HasColumnName("CASHPAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Ccpay)
                .HasColumnName("CCPAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClTrxNo)
                .HasColumnName("CL_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Clarpay)
                .HasColumnName("CLARPAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Clpay)
                .HasColumnName("CLPAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompressBillNo)
                .HasColumnName("COMPRESS_BILL_NO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Deposit)
                .HasColumnName("DEPOSIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .HasMaxLength(164)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(20)
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

            entity.Property(e => e.Paidout)
                .HasColumnName("PAIDOUT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayeeNameId)
                .HasColumnName("PAYEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QueueName)
                .HasColumnName("QUEUE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevisionNo)
                .HasColumnName("REVISION_NO")
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

            entity.Property(e => e.TaxId)
                .HasColumnName("TAX_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.TotalGross)
                .HasColumnName("TOTAL_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNet)
                .HasColumnName("TOTAL_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNontaxable)
                .HasColumnName("TOTAL_NONTAXABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
