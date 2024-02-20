namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidProtectedObjectsSys
{
    public string? TemplateCode { get; set; }
    public string? ObjectCode { get; set; }
    public string? ActionList { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidProtectedObjectsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_PROTECTED_OBJECTS_SYS");

            entity.Property(e => e.ActionList)
                .HasColumnName("ACTION_LIST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ObjectCode)
                .IsRequired()
                .HasColumnName("OBJECT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TemplateCode)
                .IsRequired()
                .HasColumnName("TEMPLATE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
