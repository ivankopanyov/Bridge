namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofCreditCardRecords
{
    public string Resort { get; set; }
    public string TrxCode { get; set; }
    public string CcCode { get; set; }
    public string Description { get; set; }
    public decimal? ArNumber { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? TrxNo { get; set; }
    public string GuestName { get; set; }
    public decimal? NameId { get; set; }
    public string Room { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? InvoiceNo { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? TrxAmount { get; set; }
    public string IndAdjustmentYn { get; set; }
    public string Remark { get; set; }
    public string Reference { get; set; }
    public string Currency { get; set; }
    public decimal? ExchangeRate { get; set; }
    public DateTime? InvoiceCloseDate { get; set; }
    public DateTime? ArTransferDate { get; set; }
    public decimal? TranActionId { get; set; }
    public decimal? Commission { get; set; }
    public decimal? BillNumber { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? GuestLedDebit { get; set; }
    public decimal? GuestLedCredit { get; set; }
    public decimal? DepositLedDebit { get; set; }
    public decimal? DepositLedCredit { get; set; }
    public decimal? ArLedDebit { get; set; }
    public decimal? ArLedCredit { get; set; }
    public decimal? Installments { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Title { get; set; }
    public string Passport { get; set; }
    public string Nationality { get; set; }
    public DateTime? BirthDate { get; set; }
    public string Salutation { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string Address3 { get; set; }
    public string Address4 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string CountryDesc { get; set; }
    public string ZipCode { get; set; }
    public string PhoneNo { get; set; }
    public string Fax { get; set; }
    public string NameType { get; set; }
    public string VipStatus { get; set; }
    public string MemberNo { get; set; }
    public string MemberType { get; set; }
    public string MemberLevel { get; set; }
    public string ArNo { get; set; }
    public string Gender { get; set; }
    public string BirthPlace { get; set; }
    public string BirthCountry { get; set; }
    public string Tax1No { get; set; }
    public string Tax2No { get; set; }
    public string AccountName { get; set; }
    public string AccountAddress1 { get; set; }
    public string AccountAddress2 { get; set; }
    public string AccountAddress3 { get; set; }
    public string AccountAddress4 { get; set; }
    public string AccountCity { get; set; }
    public string AccountState { get; set; }
    public string AccountCountry { get; set; }
    public string AccountCountryDesc { get; set; }
    public string AccountZipCode { get; set; }
    public string AccountPhoneNo { get; set; }
    public string AccountFax { get; set; }
    public string AccountNameType { get; set; }
    public string AccountArNo { get; set; }
    public string AccountTax1No { get; set; }
    public string AccountTax2No { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofCreditCardRecords>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_CREDIT_CARD_RECORDS");

            entity.Property(e => e.AccountAddress1)
                .HasColumnName("ACCOUNT_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountAddress2)
                .HasColumnName("ACCOUNT_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountAddress3)
                .HasColumnName("ACCOUNT_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountAddress4)
                .HasColumnName("ACCOUNT_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountArNo)
                .HasColumnName("ACCOUNT_AR_NO")
                .IsUnicode(false);

            entity.Property(e => e.AccountCity)
                .HasColumnName("ACCOUNT_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccountCountry)
                .HasColumnName("ACCOUNT_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountCountryDesc)
                .HasColumnName("ACCOUNT_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AccountFax)
                .HasColumnName("ACCOUNT_FAX")
                .IsUnicode(false);

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountNameType)
                .HasColumnName("ACCOUNT_NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountPhoneNo)
                .HasColumnName("ACCOUNT_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.AccountState)
                .HasColumnName("ACCOUNT_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccountTax1No)
                .HasColumnName("ACCOUNT_TAX1_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccountTax2No)
                .HasColumnName("ACCOUNT_TAX2_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccountZipCode)
                .HasColumnName("ACCOUNT_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

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

            entity.Property(e => e.ArLedCredit)
                .HasColumnName("AR_LED_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ArLedDebit)
                .HasColumnName("AR_LED_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ArNo)
                .HasColumnName("AR_NO")
                .IsUnicode(false);

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArTransferDate)
                .HasColumnName("AR_TRANSFER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillNumber)
                .HasColumnName("BILL_NUMBER")
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

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CcCode)
                .HasColumnName("CC_CODE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Commission)
                .HasColumnName("COMMISSION")
                .HasColumnType("NUMBER(10,2)");

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepositLedCredit)
                .HasColumnName("DEPOSIT_LED_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.DepositLedDebit)
                .HasColumnName("DEPOSIT_LED_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Fax)
                .HasColumnName("FAX")
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gender)
                .HasColumnName("GENDER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GuestLedCredit)
                .HasColumnName("GUEST_LED_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestLedDebit)
                .HasColumnName("GUEST_LED_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.IndAdjustmentYn)
                .HasColumnName("IND_ADJUSTMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Installments)
                .HasColumnName("INSTALLMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceCloseDate)
                .HasColumnName("INVOICE_CLOSE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MemberLevel)
                .HasColumnName("MEMBER_LEVEL")
                .IsUnicode(false);

            entity.Property(e => e.MemberNo)
                .HasColumnName("MEMBER_NO")
                .IsUnicode(false);

            entity.Property(e => e.MemberType)
                .HasColumnName("MEMBER_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Passport)
                .HasColumnName("PASSPORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNo)
                .HasColumnName("PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Salutation)
                .HasColumnName("SALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Tax1No)
                .HasColumnName("TAX1_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Tax2No)
                .HasColumnName("TAX2_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
