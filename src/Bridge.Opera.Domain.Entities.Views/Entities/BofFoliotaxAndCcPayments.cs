namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofFoliotaxAndCcPayments
{
    public string? RecordType { get; set; }
    public decimal? BillNo { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? PayeeNameId { get; set; }
    public decimal? GuestNameId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? RevisionNo { get; set; }
    public decimal? FolioView { get; set; }
    public decimal? TotalRevTaxableAmount { get; set; }
    public decimal? TotalNonrevTaxableAmount { get; set; }
    public decimal? TotalRevNontaxableAmount { get; set; }
    public decimal? TotalNonrevNontaxableAmount { get; set; }
    public decimal? CashAmount { get; set; }
    public decimal? CcAmount { get; set; }
    public decimal? CityledgerAmount { get; set; }
    public decimal? PaidoutAmount { get; set; }
    public decimal? NonClPayAmount { get; set; }
    public decimal? TotalNetAmount { get; set; }
    public decimal? TotalGrossAmount { get; set; }
    public decimal? TotalNontaxableAmount { get; set; }
    public decimal? Tax1Amount { get; set; }
    public decimal? Tax2Amount { get; set; }
    public decimal? Tax3Amount { get; set; }
    public decimal? Tax4Amount { get; set; }
    public decimal? Tax5Amount { get; set; }
    public decimal? Tax6Amount { get; set; }
    public decimal? Tax7Amount { get; set; }
    public decimal? Tax8Amount { get; set; }
    public decimal? Tax9Amount { get; set; }
    public decimal? Tax10Amount { get; set; }
    public decimal? Tax11Amount { get; set; }
    public decimal? Tax12Amount { get; set; }
    public decimal? Tax13Amount { get; set; }
    public decimal? Tax14Amount { get; set; }
    public decimal? Tax15Amount { get; set; }
    public decimal? Tax16Amount { get; set; }
    public decimal? Tax17Amount { get; set; }
    public decimal? Tax18Amount { get; set; }
    public decimal? Tax19Amount { get; set; }
    public decimal? Tax20Amount { get; set; }
    public decimal? Net1Amount { get; set; }
    public decimal? Net2Amount { get; set; }
    public decimal? Net3Amount { get; set; }
    public decimal? Net4Amount { get; set; }
    public decimal? Net5Amount { get; set; }
    public decimal? Net6Amount { get; set; }
    public decimal? Net7Amount { get; set; }
    public decimal? Net8Amount { get; set; }
    public decimal? Net9Amount { get; set; }
    public decimal? Net10Amount { get; set; }
    public decimal? Net11Amount { get; set; }
    public decimal? Net12Amount { get; set; }
    public decimal? Net13Amount { get; set; }
    public decimal? Net14Amount { get; set; }
    public decimal? Net15Amount { get; set; }
    public decimal? Net16Amount { get; set; }
    public decimal? Net17Amount { get; set; }
    public decimal? Net18Amount { get; set; }
    public decimal? Net19Amount { get; set; }
    public decimal? Net20Amount { get; set; }
    public string? Resort { get; set; }
    public decimal? Clarpay { get; set; }
    public string? Status { get; set; }
    public string? QueueName { get; set; }
    public string? AssociatedBillNo { get; set; }
    public string? NameTaxType { get; set; }
    public decimal? InvoiceNo { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? TaxId { get; set; }
    public string? FolioType { get; set; }
    public DateTime? BillStartDate { get; set; }
    public string? CompressBillNo { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? AccountCode { get; set; }
    public decimal? ClTrxNo { get; set; }
    public decimal? TotalRevenueAmount { get; set; }
    public decimal? TotalNonRevenueAmount { get; set; }
    public decimal? DepositAmount { get; set; }
    public decimal? AddressId { get; set; }
    public string? PayeeAddress1 { get; set; }
    public string? PayeeAddress2 { get; set; }
    public string? PayeeCity { get; set; }
    public string? PayeeState { get; set; }
    public string? PayeeCountry { get; set; }
    public string? PayeeCountryDesc { get; set; }
    public string? PayeeZipCode { get; set; }
    public string? PayeeArNo { get; set; }
    public string? PayeeLastName { get; set; }
    public string? PayeeFirstName { get; set; }
    public string? PayeeTax1No { get; set; }
    public string? PayeeTax2No { get; set; }
    public string? GuestLastName { get; set; }
    public string? GuestFirstName { get; set; }
    public string? GuestAddress1 { get; set; }
    public string? GuestAddress2 { get; set; }
    public string? GuestCity { get; set; }
    public string? GuestCountry { get; set; }
    public string? GuestCountryDesc { get; set; }
    public string? GuestZipCode { get; set; }
    public string? GuestTax1No { get; set; }
    public string? GuestTax2No { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofFoliotaxAndCcPayments>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_FOLIOTAX_AND_CC_PAYMENTS");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AssociatedBillNo)
                .HasColumnName("ASSOCIATED_BILL_NO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillStartDate)
                .HasColumnName("BILL_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CashAmount)
                .HasColumnName("CASH_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcAmount)
                .HasColumnName("CC_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CityledgerAmount)
                .HasColumnName("CITYLEDGER_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClTrxNo)
                .HasColumnName("CL_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Clarpay)
                .HasColumnName("CLARPAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompressBillNo)
                .HasColumnName("COMPRESS_BILL_NO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DepositAmount)
                .HasColumnName("DEPOSIT_AMOUNT")
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

            entity.Property(e => e.GuestAddress1)
                .HasColumnName("GUEST_ADDRESS_1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestAddress2)
                .HasColumnName("GUEST_ADDRESS_2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestCity)
                .HasColumnName("GUEST_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestCountry)
                .HasColumnName("GUEST_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.GuestCountryDesc)
                .HasColumnName("GUEST_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestLastName)
                .HasColumnName("GUEST_LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestTax1No)
                .HasColumnName("GUEST_TAX1_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestTax2No)
                .HasColumnName("GUEST_TAX2_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestZipCode)
                .HasColumnName("GUEST_ZIP_CODE")
                .HasMaxLength(15)
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

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Net10Amount)
                .HasColumnName("NET10_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net11Amount)
                .HasColumnName("NET11_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net12Amount)
                .HasColumnName("NET12_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net13Amount)
                .HasColumnName("NET13_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net14Amount)
                .HasColumnName("NET14_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net15Amount)
                .HasColumnName("NET15_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net16Amount)
                .HasColumnName("NET16_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net17Amount)
                .HasColumnName("NET17_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net18Amount)
                .HasColumnName("NET18_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net19Amount)
                .HasColumnName("NET19_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net1Amount)
                .HasColumnName("NET1_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net20Amount)
                .HasColumnName("NET20_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net2Amount)
                .HasColumnName("NET2_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net3Amount)
                .HasColumnName("NET3_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net4Amount)
                .HasColumnName("NET4_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net5Amount)
                .HasColumnName("NET5_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net6Amount)
                .HasColumnName("NET6_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net7Amount)
                .HasColumnName("NET7_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net8Amount)
                .HasColumnName("NET8_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Net9Amount)
                .HasColumnName("NET9_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonClPayAmount)
                .HasColumnName("NON_CL_PAY_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaidoutAmount)
                .HasColumnName("PAIDOUT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayeeAddress1)
                .HasColumnName("PAYEE_ADDRESS_1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PayeeAddress2)
                .HasColumnName("PAYEE_ADDRESS_2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PayeeArNo)
                .HasColumnName("PAYEE_AR_NO")
                .IsUnicode(false);

            entity.Property(e => e.PayeeCity)
                .HasColumnName("PAYEE_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PayeeCountry)
                .HasColumnName("PAYEE_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.PayeeCountryDesc)
                .HasColumnName("PAYEE_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.PayeeFirstName)
                .HasColumnName("PAYEE_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PayeeLastName)
                .HasColumnName("PAYEE_LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PayeeNameId)
                .HasColumnName("PAYEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayeeState)
                .HasColumnName("PAYEE_STATE")
                .HasMaxLength(40)
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

            entity.Property(e => e.QueueName)
                .HasColumnName("QUEUE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(12)
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

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax10Amount)
                .HasColumnName("TAX10_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax11Amount)
                .HasColumnName("TAX11_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax12Amount)
                .HasColumnName("TAX12_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax13Amount)
                .HasColumnName("TAX13_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax14Amount)
                .HasColumnName("TAX14_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax15Amount)
                .HasColumnName("TAX15_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax16Amount)
                .HasColumnName("TAX16_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax17Amount)
                .HasColumnName("TAX17_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax18Amount)
                .HasColumnName("TAX18_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax19Amount)
                .HasColumnName("TAX19_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax1Amount)
                .HasColumnName("TAX1_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax20Amount)
                .HasColumnName("TAX20_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax2Amount)
                .HasColumnName("TAX2_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax3Amount)
                .HasColumnName("TAX3_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax4Amount)
                .HasColumnName("TAX4_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax5Amount)
                .HasColumnName("TAX5_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax6Amount)
                .HasColumnName("TAX6_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax7Amount)
                .HasColumnName("TAX7_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax8Amount)
                .HasColumnName("TAX8_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tax9Amount)
                .HasColumnName("TAX9_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxId)
                .HasColumnName("TAX_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalGrossAmount)
                .HasColumnName("TOTAL_GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNetAmount)
                .HasColumnName("TOTAL_NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNonRevenueAmount)
                .HasColumnName("TOTAL_NON_REVENUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNonrevNontaxableAmount)
                .HasColumnName("TOTAL_NONREV_NONTAXABLE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNonrevTaxableAmount)
                .HasColumnName("TOTAL_NONREV_TAXABLE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNontaxableAmount)
                .HasColumnName("TOTAL_NONTAXABLE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevNontaxableAmount)
                .HasColumnName("TOTAL_REV_NONTAXABLE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevTaxableAmount)
                .HasColumnName("TOTAL_REV_TAXABLE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueAmount)
                .HasColumnName("TOTAL_REVENUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
