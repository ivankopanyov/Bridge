namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SimpleDynFieldsSid
{
    public string? ModuleType { get; set; }
    public string? ModuleName { get; set; }
    public string? ObjectType { get; set; }
    public string? ObjectName { get; set; }
    public string? ObjectDatatype { get; set; }
    public string? ObjectWindow { get; set; }
    public string? ChildObjectType1 { get; set; }
    public string? ChildObjectName1 { get; set; }
    public string? ChildObjectType2 { get; set; }
    public string? ChildObjectName2 { get; set; }
    public string? HideYn { get; set; }
    public string? DefaultYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SimpleDynFieldsSid>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SIMPLE_DYN_FIELDS_SID");

            entity.HasIndex(e => new { e.ModuleType, e.ModuleName, e.ObjectName })
                .HasName("SIMPLE_DYN_FIELDS_SID_UK")
                .IsUnique();

            entity.Property(e => e.ChildObjectName1)
                .HasColumnName("CHILD_OBJECT_NAME1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ChildObjectName2)
                .HasColumnName("CHILD_OBJECT_NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ChildObjectType1)
                .HasColumnName("CHILD_OBJECT_TYPE1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ChildObjectType2)
                .HasColumnName("CHILD_OBJECT_TYPE2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DefaultYn)
                .IsRequired()
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HideYn)
                .IsRequired()
                .HasColumnName("HIDE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

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

            entity.Property(e => e.ObjectDatatype)
                .IsRequired()
                .HasColumnName("OBJECT_DATATYPE")
                .HasMaxLength(80)
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

            entity.Property(e => e.ObjectWindow)
                .IsRequired()
                .HasColumnName("OBJECT_WINDOW")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
