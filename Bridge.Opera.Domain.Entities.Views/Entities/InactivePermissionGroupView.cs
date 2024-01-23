namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class InactivePermissionGroupView
{
    public string PermissionGroup { get; set; }
    public string ParameterName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InactivePermissionGroupView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INACTIVE_PERMISSION_GROUP_VIEW");

            entity.Property(e => e.ParameterName)
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PermissionGroup)
                .HasColumnName("PERMISSION_GROUP")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
