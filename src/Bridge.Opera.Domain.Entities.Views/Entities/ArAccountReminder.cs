namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArAccountReminder
{
    public decimal? AccountCode { get; set; }
    public string? AccountNo { get; set; }
    public string? AccountName { get; set; }
    public string? AccountSname { get; set; }
    public decimal? AccountTypeId { get; set; }
    public string? Resort { get; set; }
    public decimal? NameId { get; set; }
    public string? LetterName { get; set; }
    public decimal? Age { get; set; }
    public string? DateForAging { get; set; }
    public string? Fax { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArAccountReminder>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_ACCOUNT_REMINDER");

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
                .IsUnicode(false);

            entity.Property(e => e.Fax)
                .HasColumnName("FAX")
                .IsUnicode(false);

            entity.Property(e => e.LetterName)
                .HasColumnName("LETTER_NAME")
                .IsUnicode(false);

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
