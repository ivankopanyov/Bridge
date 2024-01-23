namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArAgingReportAccounts
{
    public decimal? AccountCode { get; set; }
    public string Style { get; set; }
    public string AccountName { get; set; }
    public string AccountNo { get; set; }
    public string AccountType { get; set; }
    public string TypeDesc { get; set; }
    public decimal? AccountTypeId { get; set; }
    public string Contact { get; set; }
    public string City { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string Address3 { get; set; }
    public string Country { get; set; }
    public string Zip { get; set; }
    public string Phone { get; set; }
    public string State { get; set; }
    public string BatchStmtYn { get; set; }
    public string PermAcctYn { get; set; }
    public decimal? CreditLimit { get; set; }
    public decimal? Age1 { get; set; }
    public decimal? Age2 { get; set; }
    public decimal? Age3 { get; set; }
    public decimal? Age4 { get; set; }
    public decimal? Age5 { get; set; }
    public decimal? Age6 { get; set; }
    public decimal? Total { get; set; }
    public string AccTypeFlag { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArAgingReportAccounts>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_AGING_REPORT_ACCOUNTS");

            entity.Property(e => e.AccTypeFlag)
                .HasColumnName("ACC_TYPE_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .IsUnicode(false);

            entity.Property(e => e.AccountType)
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

            entity.Property(e => e.Age1)
                .HasColumnName("AGE1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Age2)
                .HasColumnName("AGE2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Age3)
                .HasColumnName("AGE3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Age4)
                .HasColumnName("AGE4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Age5)
                .HasColumnName("AGE5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Age6)
                .HasColumnName("AGE6")
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
                .IsUnicode(false);

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PermAcctYn)
                .HasColumnName("PERM_ACCT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Phone)
                .HasColumnName("PHONE")
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Style)
                .HasColumnName("STYLE")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.Total)
                .HasColumnName("TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TypeDesc)
                .HasColumnName("TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Zip)
                .HasColumnName("ZIP")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
