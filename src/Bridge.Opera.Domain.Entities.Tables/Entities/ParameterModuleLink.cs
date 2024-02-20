namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ParameterModuleLink
{
    public string? ParameterName { get; set; }
    public string? ModuleType { get; set; }
    public string? ModuleName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ParameterModuleLink>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PARAMETER_MODULE_LINK");

            entity.HasIndex(e => new { e.ModuleType, e.ModuleName })
                .HasName("PARAMETER_MODULES_IND");

            entity.HasIndex(e => new { e.ParameterName, e.ModuleType, e.ModuleName })
                .HasName("PARAMETER_MODULES_UK")
                .IsUnique();

            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ModuleType)
                .IsRequired()
                .HasColumnName("MODULE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
