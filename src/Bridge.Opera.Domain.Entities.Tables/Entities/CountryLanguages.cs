namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CountryLanguages
{
    public string? CountryCode { get; set; }
    public string? LanguageCode { get; set; }

    public virtual Country CountryCodeNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CountryLanguages>(entity =>
        {
            entity.HasKey(e => new { e.CountryCode, e.LanguageCode })
                .HasName("COUNTRY_LANGUAGES_PK");

            entity.ToTable("COUNTRY_LANGUAGES");

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(Country)))
				entity.Ignore(e => e.CountryCodeNavigation);
			else
	            entity.HasOne(d => d.CountryCodeNavigation)
	                .WithMany(p => p.CountryLanguages)
	                .HasForeignKey(d => d.CountryCode)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("COUNTRY_LANGUAGES_FK");
        });
	}
}
