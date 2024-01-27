namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class InactivePermissionView
{
    public string Permission { get; set; }
    public string ParameterName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InactivePermissionView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INACTIVE_PERMISSION_VIEW");

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Permission)
                .IsRequired()
                .HasColumnName("PERMISSION")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
