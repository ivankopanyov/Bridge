namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Languages
{
    public string LanguageCode { get; set; }
    public string TranslationLanguageCode { get; set; }
    public string LanguageDesc { get; set; }
    public string NlsLanguage { get; set; }
    public string Preferredlanguage { get; set; }
    public string ChainCode { get; set; }
    public string Locale { get; set; }
    public string NativeWritingSystem { get; set; }
    public string EnrollmentAltYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Languages>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.LanguageCode })
                .HasName("LANG_PK");

            entity.ToTable("LANGUAGES");

            entity.HasIndex(e => e.TranslationLanguageCode)
                .HasName("LANGUAGE_IDX");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EnrollmentAltYn)
                .HasColumnName("ENROLLMENT_ALT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LanguageDesc)
                .HasColumnName("LANGUAGE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Locale)
                .HasColumnName("LOCALE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NativeWritingSystem)
                .HasColumnName("NATIVE_WRITING_SYSTEM")
                .HasMaxLength(80)
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
