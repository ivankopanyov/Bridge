namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofArOldbalPayments
{
    public string Resort { get; set; }
    public string BillNo { get; set; }
    public DateTime TrxDate { get; set; }
    public decimal ArAppliedAmount { get; set; }
    public string PayTrxCode { get; set; }
    public string PaymentDesc { get; set; }
    public DateTime OrgInvDate { get; set; }
    public decimal? TaxAmount { get; set; }
    public decimal? TaxNo { get; set; }
    public string TaxDescription { get; set; }
    public decimal? NetAmount { get; set; }
    public decimal? GrossAmount { get; set; }
    public string GrossSign { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? ConsumptionNameId { get; set; }
    public decimal? PayeeNameId { get; set; }
    public decimal? ConsumptionTrxno { get; set; }
    public decimal? ConsumptionInvoice { get; set; }
    public decimal? ConsumptionDebit { get; set; }
    public decimal? ConsumptionCredit { get; set; }
    public decimal? PaymentTrxno { get; set; }
    public decimal? PaymentInvoice { get; set; }
    public decimal? PaymentBillno { get; set; }
    public string PaymentBillType { get; set; }
    public decimal? PaymentDebit { get; set; }
    public decimal? PaymentCredit { get; set; }
    public decimal? Commission { get; set; }
    public string PayeeFirstName { get; set; }
    public string PayeeLastName { get; set; }
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
    public string FaxNo { get; set; }
    public string NameType { get; set; }
    public string VipStatus { get; set; }
    public string MembershipNumber { get; set; }
    public string MembershipType { get; set; }
    public string MembershipLevel { get; set; }
    public string ArNo { get; set; }
    public string Gender { get; set; }
    public string BirthPlace { get; set; }
    public string BirthCountry { get; set; }
    public string ProfileTaxId { get; set; }
    public string GuestName { get; set; }
    public string GuestFirstName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofArOldbalPayments>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_AR_OLDBAL_PAYMENTS");

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

            entity.Property(e => e.ArAppliedAmount)
                .HasColumnName("AR_APPLIED_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArNo)
                .HasColumnName("AR_NO")
                .IsUnicode(false);

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasMaxLength(2000)
                .IsUnicode(false);

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

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Commission)
                .HasColumnName("COMMISSION")
                .HasColumnType("NUMBER(10,2)");

            entity.Property(e => e.ConsumptionCredit)
                .HasColumnName("CONSUMPTION_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsumptionDebit)
                .HasColumnName("CONSUMPTION_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsumptionInvoice)
                .HasColumnName("CONSUMPTION_INVOICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsumptionNameId)
                .HasColumnName("CONSUMPTION_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsumptionTrxno)
                .HasColumnName("CONSUMPTION_TRXNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.FaxNo)
                .HasColumnName("FAX_NO")
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
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .IsUnicode(false);

            entity.Property(e => e.MembershipNumber)
                .HasColumnName("MEMBERSHIP_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
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
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.OrgInvDate)
                .HasColumnName("ORG_INV_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Passport)
                .HasColumnName("PASSPORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PayTrxCode)
                .HasColumnName("PAY_TRX_CODE")
                .HasMaxLength(20)
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

            entity.Property(e => e.PaymentBillType)
                .HasColumnName("PAYMENT_BILL_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PaymentBillno)
                .HasColumnName("PAYMENT_BILLNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentCredit)
                .HasColumnName("PAYMENT_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentDebit)
                .HasColumnName("PAYMENT_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentDesc)
                .HasColumnName("PAYMENT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PaymentInvoice)
                .HasColumnName("PAYMENT_INVOICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentTrxno)
                .HasColumnName("PAYMENT_TRXNO")
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
                .HasMaxLength(200)
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
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TaxDescription)
                .HasColumnName("TAX_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TaxNo)
                .HasColumnName("TAX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

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
