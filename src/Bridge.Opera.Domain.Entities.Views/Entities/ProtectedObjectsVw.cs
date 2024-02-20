namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ProtectedObjectsVw
{
    public string? TemplateCode { get; set; }
    public string? NameType { get; set; }
    public string? ProtectedFor { get; set; }
    public string? TemplateGroupCode { get; set; }
    public string? ObjectCode { get; set; }
    public string? DisplayName { get; set; }
    public string? ObjAllowNew { get; set; }
    public string? ObjAllowEdit { get; set; }
    public string? ObjAllowDelete { get; set; }
    public string? UsrAllowNew { get; set; }
    public string? UsrAllowEdit { get; set; }
    public string? UsrAllowDelete { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProtectedObjectsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PROTECTED_OBJECTS_VW");

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ObjAllowDelete)
                .HasColumnName("OBJ_ALLOW_DELETE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ObjAllowEdit)
                .HasColumnName("OBJ_ALLOW_EDIT")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ObjAllowNew)
                .HasColumnName("OBJ_ALLOW_NEW")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ObjectCode)
                .HasColumnName("OBJECT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProtectedFor)
                .HasColumnName("PROTECTED_FOR")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TemplateCode)
                .IsRequired()
                .HasColumnName("TEMPLATE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TemplateGroupCode)
                .HasColumnName("TEMPLATE_GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UsrAllowDelete)
                .HasColumnName("USR_ALLOW_DELETE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UsrAllowEdit)
                .HasColumnName("USR_ALLOW_EDIT")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UsrAllowNew)
                .HasColumnName("USR_ALLOW_NEW")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
