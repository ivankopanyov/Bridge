namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MenuPanels
{
    public string? Resort { get; set; }
    public string? ApplicationName { get; set; }
    public string? PanelName { get; set; }
    public string? DisplayCode { get; set; }
    public decimal? SequenceNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MenuPanels>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ApplicationName, e.PanelName })
                .HasName("MENU_PANELS_PK");

            entity.ToTable("MENU_PANELS");

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

            entity.Property(e => e.DisplayCode)
                .IsRequired()
                .HasColumnName("DISPLAY_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SequenceNo)
                .HasColumnName("SEQUENCE_NO")
                .HasColumnType("NUMBER");
        });
	}
}
