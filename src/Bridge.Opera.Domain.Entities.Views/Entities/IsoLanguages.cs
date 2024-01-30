namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IsoLanguages
{
    public string? LanguageCode { get; set; }
    public string? LanguageDesc { get; set; }
    public string? CultureCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IsoLanguages>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ISO_LANGUAGES");

            entity.Property(e => e.CultureCode)
                .HasColumnName("CULTURE_CODE")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.LanguageDesc)
                .HasColumnName("LANGUAGE_DESC")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
