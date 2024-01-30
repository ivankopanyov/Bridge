namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class InactiveMenuView
{
    public string? MenuName { get; set; }
    public string? ParameterName { get; set; }
    public string? FormName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InactiveMenuView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INACTIVE_MENU_VIEW");

            entity.Property(e => e.FormName)
                .IsRequired()
                .HasColumnName("FORM_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MenuName)
                .IsRequired()
                .HasColumnName("MENU_NAME")
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
