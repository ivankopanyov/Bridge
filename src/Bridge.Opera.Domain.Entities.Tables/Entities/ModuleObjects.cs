namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ModuleObjects
{
    public string? ParameterName { get; set; }
    public string? ModuleType { get; set; }
    public string? ModuleName { get; set; }
    public string? ObjectType { get; set; }
    public string? ObjectName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ModuleObjects>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MODULE_OBJECTS");

            entity.HasIndex(e => new { e.ParameterName, e.ModuleType, e.ModuleName, e.ObjectType, e.ObjectName })
                .HasName("MODULE_OBJECTS_UK")
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

            entity.Property(e => e.ObjectName)
                .IsRequired()
                .HasColumnName("OBJECT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ObjectType)
                .IsRequired()
                .HasColumnName("OBJECT_TYPE")
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
