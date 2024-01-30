namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidLanguagesChn
{
    public string? ChainCode { get; set; }
    public string? LanguageCode { get; set; }
    public string? LanguageDesc { get; set; }
    public string? TranslationLanguageCode { get; set; }
    public string? NlsLanguage { get; set; }
    public string? Preferredlanguage { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidLanguagesChn>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_LANGUAGES_CHN");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LanguageDesc)
                .HasColumnName("LANGUAGE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NlsLanguage)
                .HasColumnName("NLS_LANGUAGE")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Preferredlanguage)
                .HasColumnName("PREFERREDLANGUAGE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TranslationLanguageCode)
                .HasColumnName("TRANSLATION_LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
