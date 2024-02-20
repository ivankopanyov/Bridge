namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrsConfigurationView
{
    public string? MenuName { get; set; }
    public string? Flg { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrsConfigurationView>(entity =>
        {
            entity.HasKey(e => e.MenuName)
                .HasName("ORS_CONFIGURATION_VIEW_PK");

            entity.ToTable("ORS_CONFIGURATION_VIEW");

            entity.Property(e => e.MenuName)
                .HasColumnName("MENU_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Flg)
                .IsRequired()
                .HasColumnName("FLG")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
