namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProtectedObjects
{
    public string TemplateCode { get; set; }
    public string ObjectCode { get; set; }
    public string ActionList { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProtectedObjects>(entity =>
        {
            entity.HasKey(e => new { e.TemplateCode, e.ObjectCode })
                .HasName("PROTECTED_OBJECTS_PK");

            entity.ToTable("PROTECTED_OBJECTS");

            entity.Property(e => e.TemplateCode)
                .HasColumnName("TEMPLATE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ObjectCode)
                .HasColumnName("OBJECT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActionList)
                .HasColumnName("ACTION_LIST")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
