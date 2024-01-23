namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempMenuDetails
{
    public string ApplicationName { get; set; }
    public string PanelName { get; set; }
    public string PanelTitle { get; set; }
    public string MenuModule { get; set; }
    public string MenuName { get; set; }
    public string MenuItem { get; set; }
    public decimal? MenuSequence { get; set; }
    public string SubMenuLink { get; set; }
    public string ToggleMenuModule { get; set; }
    public string ToggleMenuName { get; set; }
    public string ToggleCheckRoutine { get; set; }
    public string MenuStatus { get; set; }
    public string ResvYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempMenuDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_MENU_DETAILS");

            entity.Property(e => e.ApplicationName)
                .HasColumnName("APPLICATION_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MenuItem)
                .HasColumnName("MENU_ITEM")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.MenuModule)
                .HasColumnName("MENU_MODULE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MenuName)
                .HasColumnName("MENU_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MenuSequence)
                .HasColumnName("MENU_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenuStatus)
                .HasColumnName("MENU_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PanelName)
                .HasColumnName("PANEL_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PanelTitle)
                .HasColumnName("PANEL_TITLE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ResvYn)
                .HasColumnName("RESV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SubMenuLink)
                .HasColumnName("SUB_MENU_LINK")
                .HasMaxLength(80)
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
