namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ImpArAccount
{
    public string? Resort { get; set; }
    public string? AccountNo { get; set; }
    public decimal? AccountCode { get; set; }
    public decimal? NameId { get; set; }
    public string? NameType { get; set; }
    public string? AccountType { get; set; }
    public string? AccountName { get; set; }
    public string? Status { get; set; }
    public string? Vip { get; set; }
    public string? Contact { get; set; }
    public string? Country { get; set; }
    public string? Zip { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    public string? EmailAddress { get; set; }
    public string? CblInd { get; set; }
    public string? Udfc01 { get; set; }
    public string? Udfc02 { get; set; }
    public string? Udfc03 { get; set; }
    public string? Udfc06 { get; set; }
    public string? Udfc07 { get; set; }
    public string? Udfc08 { get; set; }
    public string? Udfc09 { get; set; }
    public decimal? Udfn01 { get; set; }
    public string? Tax1No { get; set; }
    public string? IataCorpNo { get; set; }
    public string? BatchStmtYn { get; set; }
    public string? PermAcctYn { get; set; }
    public decimal? CreditLimit { get; set; }
    public string? SumCurCode { get; set; }
    public string? AccountStatusMsg { get; set; }
    public string? PrimaryYn { get; set; }
    public string? ProfileLastName { get; set; }
    public string? ProfileFirstName { get; set; }
    public string? PaymentDueDays { get; set; }
    public string? UnformattedAccountNo { get; set; }
    public string? Name2 { get; set; }
    public string? CblMsg { get; set; }
    public decimal? ImportId { get; set; }
    public string? ImportTabName { get; set; }
    public string? ImportTabType { get; set; }
    public DateTime? ImportCtrlDte { get; set; }
    public decimal? BatchId { get; set; }
    public decimal? SeqNo { get; set; }
    public DateTime? ImportDate { get; set; }
    public string? ImportStatus { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ImpArAccount>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IMP_AR_ACCOUNT");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AccountStatusMsg)
                .HasColumnName("ACCOUNT_STATUS_MSG")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS2")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Address3)
                .HasColumnName("ADDRESS3")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BatchStmtYn)
                .HasColumnName("BATCH_STMT_YN")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CblInd)
                .HasColumnName("CBL_IND")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CblMsg)
                .HasColumnName("CBL_MSG")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Contact)
                .HasColumnName("CONTACT")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmailAddress)
                .HasColumnName("EMAIL_ADDRESS")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Fax)
                .HasColumnName("FAX")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IataCorpNo)
                .HasColumnName("IATA_CORP_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ImportCtrlDte)
                .HasColumnName("IMPORT_CTRL_DTE")
                .HasColumnType("DATE");

            entity.Property(e => e.ImportDate)
                .HasColumnName("IMPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ImportId)
                .HasColumnName("IMPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ImportStatus)
                .HasColumnName("IMPORT_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ImportTabName)
                .HasColumnName("IMPORT_TAB_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ImportTabType)
                .HasColumnName("IMPORT_TAB_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Name2)
                .HasColumnName("NAME2")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentDueDays)
                .HasColumnName("PAYMENT_DUE_DAYS")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PermAcctYn)
                .HasColumnName("PERM_ACCT_YN")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Phone)
                .HasColumnName("PHONE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProfileFirstName)
                .HasColumnName("PROFILE_FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProfileLastName)
                .HasColumnName("PROFILE_LAST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SumCurCode)
                .HasColumnName("SUM_CUR_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax1No)
                .HasColumnName("TAX1_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc03)
                .HasColumnName("UDFC03")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc07)
                .HasColumnName("UDFC07")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc08)
                .HasColumnName("UDFC08")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfc09)
                .HasColumnName("UDFC09")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Udfn01)
                .HasColumnName("UDFN01")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UnformattedAccountNo)
                .HasColumnName("UNFORMATTED_ACCOUNT_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Vip)
                .HasColumnName("VIP")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Zip)
                .HasColumnName("ZIP")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
