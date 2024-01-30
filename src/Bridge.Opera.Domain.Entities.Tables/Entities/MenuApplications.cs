namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MenuApplications
{
    public string? Resort { get; set; }
    public string? ApplicationName { get; set; }
    public string? Description { get; set; }
    public string? ConfigurableYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MenuApplications>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ApplicationName })
                .HasName("MENU_APPLICATIONS_PK");

            entity.ToTable("MENU_APPLICATIONS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ApplicationName)
                .HasColumnName("APPLICATION_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConfigurableYn)
                .HasColumnName("CONFIGURABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
