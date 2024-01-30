namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidFolioTypeDetails
{
    public string? FolioType { get; set; }
    public string? Resort { get; set; }
    public string? LanguageCode { get; set; }
    public string? FolioName { get; set; }
    public string? FolioGroup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidFolioTypeDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_FOLIO_TYPE_DETAILS");

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
