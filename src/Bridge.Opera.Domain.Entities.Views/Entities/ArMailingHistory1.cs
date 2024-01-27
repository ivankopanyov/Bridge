namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArMailingHistory1
{
    public string RecordType { get; set; }
    public string Resort { get; set; }
    public string AccountNo { get; set; }
    public decimal? AccountCode { get; set; }
    public DateTime? LetterDate { get; set; }
    public DateTime? TruncLetterDate { get; set; }
    public string AccountSname { get; set; }
    public string AccountName { get; set; }
    public decimal? AccountTypeId { get; set; }
    public string AccountType { get; set; }
    public DateTime? ForwardDate { get; set; }
    public DateTime? TillDate { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public string PrintzeroYn { get; set; }
    public string PrintfullYn { get; set; }
    public string PromotionalText { get; set; }
    public string LetterName { get; set; }
    public string Fax { get; set; }
    public decimal? Age { get; set; }
    public decimal? SequenceId { get; set; }
    public decimal? StatementNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArMailingHistory1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_MAILING_HISTORY");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
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

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeId)
                .HasColumnName("ACCOUNT_TYPE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Age)
                .HasColumnName("AGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Fax)
                .HasColumnName("FAX")
                .IsUnicode(false);

            entity.Property(e => e.ForwardDate)
                .HasColumnName("FORWARD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FromDate)
                .HasColumnName("FROM_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LetterDate)
                .HasColumnName("LETTER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LetterName)
                .HasColumnName("LETTER_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PrintfullYn)
                .HasColumnName("PRINTFULL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrintzeroYn)
                .HasColumnName("PRINTZERO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PromotionalText)
                .HasColumnName("PROMOTIONAL_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(17)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SequenceId)
                .HasColumnName("SEQUENCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatementNo)
                .HasColumnName("STATEMENT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TillDate)
                .HasColumnName("TILL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ToDate)
                .HasColumnName("TO_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncLetterDate)
                .HasColumnName("TRUNC_LETTER_DATE")
                .HasColumnType("DATE");
        });
	}
}
