namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArAccountView
{
    public string Resort { get; set; }
    public string AccountNo { get; set; }
    public decimal AccountCode { get; set; }
    public decimal NameId { get; set; }
    public string NameType { get; set; }
    public decimal AccountTypeId { get; set; }
    public string AccountType { get; set; }
    public string AccountName { get; set; }
    public string AccountSname { get; set; }
    public string Status { get; set; }
    public string Vip { get; set; }
    public decimal? Balance { get; set; }
    public string Contact { get; set; }
    public string City { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string Address3 { get; set; }
    public string Country { get; set; }
    public string Zip { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public string State { get; set; }
    public string BatchStmtYn { get; set; }
    public string PermAcctYn { get; set; }
    public decimal? CreditLimit { get; set; }
    public string SumCurCode { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? LstStmtSent { get; set; }
    public string LastRemFaxNo { get; set; }
    public string LastStmtFaxNo { get; set; }
    public DateTime Updatedate { get; set; }
    public decimal? NoOfPersons { get; set; }
    public DateTime? LstRemPrtDate { get; set; }
    public string StatementName { get; set; }
    public string XdisplayName { get; set; }
    public string Sxname { get; set; }
    public string PrintInvoiceDetailsYn { get; set; }
    public string EmailAddress { get; set; }
    public string AccTypeFlag { get; set; }
    public decimal? DayForFinanceCharge { get; set; }
    public decimal? FinanceChargeAmount { get; set; }
    public decimal? FinanceChargePercentage { get; set; }
    public decimal? MinDaysOlder { get; set; }
    public string UnallocatedPaymentsYn { get; set; }
    public string AccountStatusMsg { get; set; }
    public decimal? AgentUserId { get; set; }
    public decimal? AddressId { get; set; }
    public string PrimaryYn { get; set; }
    public decimal? PhoneId { get; set; }
    public decimal? FaxId { get; set; }
    public decimal? EmailId { get; set; }
    public string ProfileLastName { get; set; }
    public string ProfileFirstName { get; set; }
    public decimal? PaymentDueDays { get; set; }
    public string UnformattedAccountNo { get; set; }
    public string ArContact { get; set; }
    public DateTime? LastActivityDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArAccountView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_ACCOUNT_VIEW");

            entity.Property(e => e.AccTypeFlag)
                .HasColumnName("ACC_TYPE_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .IsRequired()
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .IsUnicode(false);

            entity.Property(e => e.AccountSname)
                .HasColumnName("ACCOUNT_SNAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AccountStatusMsg)
                .HasColumnName("ACCOUNT_STATUS_MSG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AccountType)
                .IsRequired()
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeId)
                .HasColumnName("ACCOUNT_TYPE_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentUserId)
                .HasColumnName("AGENT_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArContact)
                .HasColumnName("AR_CONTACT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BatchStmtYn)
                .HasColumnName("BATCH_STMT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Contact)
                .HasColumnName("CONTACT")
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayForFinanceCharge)
                .HasColumnName("DAY_FOR_FINANCE_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmailAddress)
                .HasColumnName("EMAIL_ADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.EmailId)
                .HasColumnName("EMAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Fax)
                .HasColumnName("FAX")
                .IsUnicode(false);

            entity.Property(e => e.FaxId)
                .HasColumnName("FAX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FinanceChargeAmount)
                .HasColumnName("FINANCE_CHARGE_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FinanceChargePercentage)
                .HasColumnName("FINANCE_CHARGE_PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastActivityDate)
                .HasColumnName("LAST_ACTIVITY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastRemFaxNo)
                .HasColumnName("LAST_REM_FAX_NO")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.LastStmtFaxNo)
                .HasColumnName("LAST_STMT_FAX_NO")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.LstRemPrtDate)
                .HasColumnName("LST_REM_PRT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LstStmtSent)
                .HasColumnName("LST_STMT_SENT")
                .HasColumnType("DATE");

            entity.Property(e => e.MinDaysOlder)
                .HasColumnName("MIN_DAYS_OLDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NoOfPersons)
                .HasColumnName("NO_OF_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentDueDays)
                .HasColumnName("PAYMENT_DUE_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PermAcctYn)
                .HasColumnName("PERM_ACCT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Phone)
                .HasColumnName("PHONE")
                .IsUnicode(false);

            entity.Property(e => e.PhoneId)
                .HasColumnName("PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrintInvoiceDetailsYn)
                .HasColumnName("PRINT_INVOICE_DETAILS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProfileFirstName)
                .HasColumnName("PROFILE_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ProfileLastName)
                .HasColumnName("PROFILE_LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.StatementName)
                .IsRequired()
                .HasColumnName("STATEMENT_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.SumCurCode)
                .HasColumnName("SUM_CUR_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Sxname)
                .HasColumnName("SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UnallocatedPaymentsYn)
                .HasColumnName("UNALLOCATED_PAYMENTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UnformattedAccountNo)
                .HasColumnName("UNFORMATTED_ACCOUNT_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Updatedate)
                .HasColumnName("UPDATEDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Vip)
                .HasColumnName("VIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XdisplayName)
                .HasColumnName("XDISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.Zip)
                .HasColumnName("ZIP")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
