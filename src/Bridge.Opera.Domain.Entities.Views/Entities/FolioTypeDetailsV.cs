namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FolioTypeDetailsV
{
    public string FolioType { get; set; }
    public string Resort { get; set; }
    public string LanguageCode { get; set; }
    public string FolioName { get; set; }
    public string FolioGroup { get; set; }
    public string LanguageDesc { get; set; }
    public string FolioGroupDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FolioTypeDetailsV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FOLIO_TYPE_DETAILS_V");

            entity.Property(e => e.FolioGroup)
                .HasColumnName("FOLIO_GROUP")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.FolioGroupDesc)
                .HasColumnName("FOLIO_GROUP_DESC")
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

            entity.Property(e => e.LanguageDesc)
                .HasColumnName("LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
