namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BankAccountView
{
    public string Resort { get; set; }
    public decimal AccountId { get; set; }
    public string AccountNo { get; set; }
    public string BankCode { get; set; }
    public string BranchCode { get; set; }
    public string RoutingNo { get; set; }
    public string PaymentMethod { get; set; }
    public string Format { get; set; }
    public decimal? CurrentCheckNo { get; set; }
    public decimal? MaxCheckNo { get; set; }
    public decimal? MinProcessingAmt { get; set; }
    public string CheckEditYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? CheckStubLines { get; set; }
    public string DefaultYn { get; set; }
    public string BankName { get; set; }
    public string Currency { get; set; }
    public string ValidateIataYn { get; set; }
    public string LanguageCode { get; set; }
    public string Report1099Yn { get; set; }
    public string BankAcctType { get; set; }
    public string PositivePayYn { get; set; }
    public string SourceImportDir { get; set; }
    public string TargetImportDir { get; set; }
    public string CurrencyCommissionDefault { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BankAccountView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BANK_ACCOUNT_VIEW");

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountNo)
                .IsRequired()
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.BankAcctType)
                .HasColumnName("BANK_ACCT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BankCode)
                .IsRequired()
                .HasColumnName("BANK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BankName)
                .HasColumnName("BANK_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BranchCode)
                .IsRequired()
                .HasColumnName("BRANCH_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CheckEditYn)
                .HasColumnName("CHECK_EDIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CheckStubLines)
                .HasColumnName("CHECK_STUB_LINES")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCommissionDefault)
                .HasColumnName("CURRENCY_COMMISSION_DEFAULT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CurrentCheckNo)
                .HasColumnName("CURRENT_CHECK_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Format)
                .HasColumnName("FORMAT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MaxCheckNo)
                .HasColumnName("MAX_CHECK_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinProcessingAmt)
                .HasColumnName("MIN_PROCESSING_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.PositivePayYn)
                .HasColumnName("POSITIVE_PAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Report1099Yn)
                .HasColumnName("REPORT_1099_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoutingNo)
                .IsRequired()
                .HasColumnName("ROUTING_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceImportDir)
                .HasColumnName("SOURCE_IMPORT_DIR")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TargetImportDir)
                .HasColumnName("TARGET_IMPORT_DIR")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValidateIataYn)
                .HasColumnName("VALIDATE_IATA_YN")
                .HasColumnType("CHAR(1)");
        });
	}
}
