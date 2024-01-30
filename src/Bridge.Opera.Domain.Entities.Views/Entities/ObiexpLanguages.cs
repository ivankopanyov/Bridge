namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpLanguages
{
    public string? RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public string? Resort { get; set; }
    public string? ChainCode { get; set; }
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? LanguageKey { get; set; }
    public string? LanguageCode { get; set; }
    public string? LanguageDesc { get; set; }
    public string? TranslationLanguageCode { get; set; }
    public string? NlsLanguage { get; set; }
    public string? Preferredlanguage { get; set; }
    public string? Locale { get; set; }
    public string? NativeWritingSystem { get; set; }
    public string? EnrollmentAltYn { get; set; }
    public string? AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpLanguages>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXP_LANGUAGES");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EnrollmentAltYn)
                .HasColumnName("ENROLLMENT_ALT_YN")
                .HasMaxLength(1)
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

            entity.Property(e => e.LanguageKey)
                .IsRequired()
                .HasColumnName("LANGUAGE_KEY")
                .HasMaxLength(20)
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

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(41)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.TranslationLanguageCode)
                .HasColumnName("TRANSLATION_LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
