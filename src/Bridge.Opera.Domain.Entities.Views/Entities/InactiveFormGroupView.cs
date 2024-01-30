namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class InactiveFormGroupView
{
    public string? FormName { get; set; }
    public string? ParameterName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InactiveFormGroupView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INACTIVE_FORM_GROUP_VIEW");

            entity.Property(e => e.FormName)
                .IsRequired()
                .HasColumnName("FORM_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
