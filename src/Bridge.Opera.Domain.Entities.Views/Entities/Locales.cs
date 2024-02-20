namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Locales
{
    public string? OracleLanguage { get; set; }
    public string? Locale { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Locales>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LOCALES");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Locale)
                .HasColumnName("LOCALE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.OracleLanguage)
                .HasColumnName("ORACLE_LANGUAGE")
                .HasMaxLength(64)
                .IsUnicode(false);
        });
	}
}
