namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StatusTranslation
{
    public string? Status { get; set; }
    public string? Language { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StatusTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Status, e.Language })
                .HasName("STTRANS_PK");

            entity.ToTable("STATUS$TRANSLATION");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(50)
                .IsUnicode(false);
        });
	}
}
