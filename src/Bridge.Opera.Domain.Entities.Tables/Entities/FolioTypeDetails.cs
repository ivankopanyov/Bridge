namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FolioTypeDetails
{
    public string FolioType { get; set; }
    public string Resort { get; set; }
    public string LanguageCode { get; set; }
    public string FolioName { get; set; }
    public string FolioGroup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FolioTypeDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("FOLIO_TYPE_DETAILS");

            entity.HasIndex(e => new { e.Resort, e.FolioType, e.LanguageCode })
                .HasName("FLTYDT_IND");

            entity.Property(e => e.FolioGroup)
                .HasColumnName("FOLIO_GROUP")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.FolioName)
                .HasColumnName("FOLIO_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
