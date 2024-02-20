namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PermissionsPalm
{
    public string? Permission { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PermissionsPalm>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PERMISSIONS_PALM");

            entity.Property(e => e.Permission)
                .IsRequired()
                .HasColumnName("PERMISSION")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
