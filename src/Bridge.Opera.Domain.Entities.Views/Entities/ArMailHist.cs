namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArMailHist
{
    public string? Resort { get; set; }
    public decimal? AccountCode { get; set; }
    public string? AccountName { get; set; }
    public string? AccountSname { get; set; }
    public decimal? AccountTypeId { get; set; }
    public string? LetterName { get; set; }
    public DateTime? LetterSentDate { get; set; }
    public decimal? Age { get; set; }
    public string? DateForAging { get; set; }
    public string? Fax { get; set; }
    public string? AccountNo { get; set; }
    public decimal? NameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArMailHist>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_MAIL_HIST");

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

            entity.Property(e => e.AccountTypeId)
                .HasColumnName("ACCOUNT_TYPE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Age)
                .HasColumnName("AGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DateForAging)
                .HasColumnName("DATE_FOR_AGING")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Fax)
                .HasColumnName("FAX")
                .IsUnicode(false);

            entity.Property(e => e.LetterName)
                .HasColumnName("LETTER_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LetterSentDate)
                .HasColumnName("LETTER_SENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
