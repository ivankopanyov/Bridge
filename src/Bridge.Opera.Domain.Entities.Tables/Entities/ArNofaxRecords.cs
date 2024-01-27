namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ArNofaxRecords
{
    public decimal? Sid { get; set; }
    public string Resort { get; set; }
    public decimal? AccountCode { get; set; }
    public string AccountNo { get; set; }
    public string AccountName { get; set; }
    public string LetterName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArNofaxRecords>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("AR_NOFAX_RECORDS");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LetterName)
                .HasColumnName("LETTER_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasColumnType("NUMBER");
        });
	}
}
