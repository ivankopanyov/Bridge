namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidArAccountTypes
{
    public string? Resort { get; set; }
    public decimal? AccountTypeId { get; set; }
    public string? AccountType { get; set; }
    public string? TypeDesc { get; set; }
    public decimal? CreditLimit { get; set; }
    public string? StatementName { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? PrintInvoiceDetailsYn { get; set; }
    public string? StatementTypeMode { get; set; }
    public string? OwnerStatementName { get; set; }
    public string? ReminderCycles { get; set; }
    public string? LetterNameEndOfMonth { get; set; }
    public decimal? DayForFinanceCharge { get; set; }
    public decimal? FinanceChargeAmount { get; set; }
    public decimal? FinanceChargePercentage { get; set; }
    public decimal? MinDaysOlder { get; set; }
    public string? UnallocatedPaymentsYn { get; set; }
    public string? OwnerCashbookName { get; set; }
    public string? OwnerSummaryName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidArAccountTypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_AR$_ACCOUNT_TYPES");

            entity.Property(e => e.AccountType)
                .IsRequired()
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeId)
                .HasColumnName("ACCOUNT_TYPE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayForFinanceCharge)
                .HasColumnName("DAY_FOR_FINANCE_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FinanceChargeAmount)
                .HasColumnName("FINANCE_CHARGE_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FinanceChargePercentage)
                .HasColumnName("FINANCE_CHARGE_PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LetterNameEndOfMonth)
                .HasColumnName("LETTER_NAME_END_OF_MONTH")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MinDaysOlder)
                .HasColumnName("MIN_DAYS_OLDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerCashbookName)
                .HasColumnName("OWNER_CASHBOOK_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OwnerStatementName)
                .HasColumnName("OWNER_STATEMENT_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OwnerSummaryName)
                .HasColumnName("OWNER_SUMMARY_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PrintInvoiceDetailsYn)
                .HasColumnName("PRINT_INVOICE_DETAILS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ReminderCycles)
                .HasColumnName("REMINDER_CYCLES")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatementName)
                .IsRequired()
                .HasColumnName("STATEMENT_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.StatementTypeMode)
                .HasColumnName("STATEMENT_TYPE_MODE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TypeDesc)
                .IsRequired()
                .HasColumnName("TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UnallocatedPaymentsYn)
                .HasColumnName("UNALLOCATED_PAYMENTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
