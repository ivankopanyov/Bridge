namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MenuPanelItems
{
    public string Resort { get; set; }
    public string ApplicationName { get; set; }
    public string PanelName { get; set; }
    public string MenuName { get; set; }
    public decimal? MenuSequence { get; set; }
    public string MenuModule { get; set; }
    public string ParentMenuName { get; set; }
    public string HideYn { get; set; }
    public string ToggleMenuModule { get; set; }
    public string ToggleMenuName { get; set; }
    public string ToggleCheckRoutine { get; set; }
    public string ResvYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MenuPanelItems>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ApplicationName, e.PanelName, e.MenuName })
                .HasName("MENU_PANEL_ITEMS_PK");

            entity.ToTable("MENU_PANEL_ITEMS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ApplicationName)
                .HasColumnName("APPLICATION_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PanelName)
                .HasColumnName("PANEL_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MenuName)
                .HasColumnName("MENU_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.HideYn)
                .HasColumnName("HIDE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MenuModule)
                .HasColumnName("MENU_MODULE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MenuSequence)
                .HasColumnName("MENU_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentMenuName)
                .HasColumnName("PARENT_MENU_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ResvYn)
                .HasColumnName("RESV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ToggleCheckRoutine)
                .HasColumnName("TOGGLE_CHECK_ROUTINE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToggleMenuModule)
                .HasColumnName("TOGGLE_MENU_MODULE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToggleMenuName)
                .HasColumnName("TOGGLE_MENU_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
