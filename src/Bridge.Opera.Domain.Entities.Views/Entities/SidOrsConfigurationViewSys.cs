namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidOrsConfigurationViewSys
{
    public string? MenuName { get; set; }
    public string? Flg { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidOrsConfigurationViewSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_ORS_CONFIGURATION_VIEW_SYS");

            entity.Property(e => e.Flg)
                .IsRequired()
                .HasColumnName("FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MenuName)
                .IsRequired()
                .HasColumnName("MENU_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
