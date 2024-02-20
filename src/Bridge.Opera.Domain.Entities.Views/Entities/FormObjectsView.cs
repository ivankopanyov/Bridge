namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FormObjectsView
{
    public string? FormName { get; set; }
    public string? ParameterName { get; set; }
    public string? ObjectType { get; set; }
    public string? ObjectName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FormObjectsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FORM_OBJECTS_VIEW");

            entity.Property(e => e.FormName)
                .IsRequired()
                .HasColumnName("FORM_NAME")
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

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
