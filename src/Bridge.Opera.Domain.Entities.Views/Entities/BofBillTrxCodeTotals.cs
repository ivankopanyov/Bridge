namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofBillTrxCodeTotals
{
    public string? Resort { get; set; }
    public decimal? BillNo { get; set; }
    public string? FolioType { get; set; }
    public string? TrxCode { get; set; }
    public DateTime? DateTrxWasDone { get; set; }
    public DateTime? TrxDate { get; set; }
    public DateTime? BusinessDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public DateTime? CheckoutDate { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? GuestDebitAmount { get; set; }
    public decimal? GuestCreditAmount { get; set; }
    public decimal? PackageCredit { get; set; }
    public decimal? PackageDebit { get; set; }
    public decimal? CalcGrossAmount { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? InvoiceNo { get; set; }
    public string? TcGroup { get; set; }
    public string? TcSubgroup { get; set; }
    public string? FtSubtype { get; set; }
    public string? Taxcode { get; set; }
    public decimal? GrossAmount { get; set; }
    public decimal? NetAmount { get; set; }
    public decimal? TaxAmount { get; set; }
    public decimal? PayeeNameId { get; set; }
    public string? TaxPercent { get; set; }
    public decimal? Covers { get; set; }
    public string? GrossSign { get; set; }
    public string? TaxDescription { get; set; }
    public decimal? TaxNo { get; set; }
    public string? Commission { get; set; }
    public string? PayeeLastName { get; set; }
    public string? PayeeFirstName { get; set; }
    public string? GuestLastName { get; set; }
    public string? GuestFirstName { get; set; }
    public string? Title { get; set; }
    public string? Passport { get; set; }
    public string? Nationality { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Salutation { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string? Address4 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? CountryDesc { get; set; }
    public string? ZipCode { get; set; }
    public string? PhoneNo { get; set; }
    public string? Fax { get; set; }
    public string? NameType { get; set; }
    public string? GuestVipStatus { get; set; }
    public string? GuestMemberNo { get; set; }
    public string? GuestMemberType { get; set; }
    public string? GuestMemberLevel { get; set; }
    public string? ArNo { get; set; }
    public string? Gender { get; set; }
    public string? BirthPlace { get; set; }
    public string? BirthCountry { get; set; }
    public string? ProfileTaxId { get; set; }
    public string? MarketCode { get; set; }
    public decimal? BofIntfCode { get; set; }
    public string? BofCode1 { get; set; }
    public string? BofCode2 { get; set; }
    public string? BofCode3 { get; set; }
    public string? BofCode4 { get; set; }
    public string? BofCode5 { get; set; }
    public decimal? BofCode6 { get; set; }
    public decimal? BofCode7 { get; set; }
    public decimal? BofCode8 { get; set; }
    public decimal? BofCode9 { get; set; }
    public decimal? BofCode10 { get; set; }
    public DateTime? BofCode11 { get; set; }
    public DateTime? BofCode12 { get; set; }
    public DateTime? BofCode13 { get; set; }
    public DateTime? BofCode14 { get; set; }
    public DateTime? BofCode15 { get; set; }
    public string? BofCode16 { get; set; }
    public string? BofCode17 { get; set; }
    public string? BofCode18 { get; set; }
    public string? BofCode19 { get; set; }
    public string? BofCode20 { get; set; }
    public string? BofCode21 { get; set; }
    public string? BofCode22 { get; set; }
    public string? BofCode23 { get; set; }
    public string? BofCode24 { get; set; }
    public string? BofCode25 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofBillTrxCodeTotals>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_BILL_TRX_CODE_TOTALS");

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address3)
                .HasColumnName("ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address4)
                .HasColumnName("ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ArNo)
                .HasColumnName("AR_NO")
                .IsUnicode(false);

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BirthCountry)
                .HasColumnName("BIRTH_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BirthDate)
                .HasColumnName("BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BirthPlace)
                .HasColumnName("BIRTH_PLACE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.BofCode1)
                .HasColumnName("BOF_CODE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode10)
                .HasColumnName("BOF_CODE10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofCode11)
                .HasColumnName("BOF_CODE11")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode12)
                .HasColumnName("BOF_CODE12")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode13)
                .HasColumnName("BOF_CODE13")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode14)
                .HasColumnName("BOF_CODE14")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode15)
                .HasColumnName("BOF_CODE15")
                .HasColumnType("DATE");

            entity.Property(e => e.BofCode16)
                .HasColumnName("BOF_CODE16")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode17)
                .HasColumnName("BOF_CODE17")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode18)
                .HasColumnName("BOF_CODE18")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode19)
                .HasColumnName("BOF_CODE19")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode2)
                .HasColumnName("BOF_CODE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode20)
                .HasColumnName("BOF_CODE20")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode21)
                .HasColumnName("BOF_CODE21")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode22)
                .HasColumnName("BOF_CODE22")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode23)
                .HasColumnName("BOF_CODE23")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode24)
                .HasColumnName("BOF_CODE24")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode25)
                .HasColumnName("BOF_CODE25")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BofCode3)
                .HasColumnName("BOF_CODE3")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode4)
                .HasColumnName("BOF_CODE4")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode5)
                .HasColumnName("BOF_CODE5")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BofCode6)
                .HasColumnName("BOF_CODE6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofCode7)
                .HasColumnName("BOF_CODE7")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofCode8)
                .HasColumnName("BOF_CODE8")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofCode9)
                .HasColumnName("BOF_CODE9")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BofIntfCode)
                .HasColumnName("BOF_INTF_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CalcGrossAmount)
                .HasColumnName("CALC_GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckoutDate)
                .HasColumnName("CHECKOUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Commission)
                .HasColumnName("COMMISSION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Covers)
                .HasColumnName("COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DateTrxWasDone)
                .HasColumnName("DATE_TRX_WAS_DONE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Fax)
                .HasColumnName("FAX")
                .IsUnicode(false);

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FtSubtype)
                .HasColumnName("FT_SUBTYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Gender)
                .HasColumnName("GENDER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossSign)
                .HasColumnName("GROSS_SIGN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestCreditAmount)
                .HasColumnName("GUEST_CREDIT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestDebitAmount)
                .HasColumnName("GUEST_DEBIT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestLastName)
                .HasColumnName("GUEST_LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestMemberLevel)
                .HasColumnName("GUEST_MEMBER_LEVEL")
                .IsUnicode(false);

            entity.Property(e => e.GuestMemberNo)
                .HasColumnName("GUEST_MEMBER_NO")
                .IsUnicode(false);

            entity.Property(e => e.GuestMemberType)
                .HasColumnName("GUEST_MEMBER_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.GuestVipStatus)
                .HasColumnName("GUEST_VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageCredit)
                .HasColumnName("PACKAGE_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageDebit)
                .HasColumnName("PACKAGE_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Passport)
                .HasColumnName("PASSPORT")
                .HasMaxLength(200)
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

            entity.Property(e => e.PhoneNo)
                .HasColumnName("PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.ProfileTaxId)
                .HasColumnName("PROFILE_TAX_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Salutation)
                .HasColumnName("SALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TaxAmount)
                .HasColumnName("TAX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxDescription)
                .HasColumnName("TAX_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxNo)
                .HasColumnName("TAX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxPercent)
                .HasColumnName("TAX_PERCENT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Taxcode)
                .HasColumnName("TAXCODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TcGroup)
                .HasColumnName("TC_GROUP")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
