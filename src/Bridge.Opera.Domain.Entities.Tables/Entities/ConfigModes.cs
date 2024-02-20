namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ConfigModes
{
    public string? ConfigMode { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ConfigModes>(entity =>
        {
            entity.HasKey(e => e.ConfigMode)
                .HasName("CONFIG_MODES_PK");

            entity.ToTable("CONFIG_MODES");

            entity.Property(e => e.ConfigMode)
                .HasColumnName("CONFIG_MODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
