namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiLanguages
{
    public string BiLanguageCode { get; set; }
    public string BiLanguageDesc { get; set; }
    public string IsoLanguageCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiLanguages>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_LANGUAGES");

            entity.Property(e => e.BiLanguageCode)
                .HasColumnName("BI_LANGUAGE_CODE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.BiLanguageDesc)
                .HasColumnName("BI_LANGUAGE_DESC")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.IsoLanguageCode)
                .HasColumnName("ISO_LANGUAGE_CODE")
                .HasMaxLength(5)
                .IsUnicode(false);
        });
	}
}
