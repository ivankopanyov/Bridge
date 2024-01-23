namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ConfigModules
{
    public string DefaultModule { get; set; }
    public string ConfigMode { get; set; }
    public string ModuleType { get; set; }
    public string NewModule { get; set; }
    public string Remarks { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ConfigModules>(entity =>
        {
            entity.HasKey(e => new { e.DefaultModule, e.ConfigMode, e.ModuleType })
                .HasName("CONFIG_MODULES_PK");

            entity.ToTable("CONFIG_MODULES");

            entity.Property(e => e.DefaultModule)
                .HasColumnName("DEFAULT_MODULE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConfigMode)
                .HasColumnName("CONFIG_MODE")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.ModuleType)
                .HasColumnName("MODULE_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("'FRM'");

            entity.Property(e => e.NewModule)
                .IsRequired()
                .HasColumnName("NEW_MODULE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Remarks)
                .HasColumnName("REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
