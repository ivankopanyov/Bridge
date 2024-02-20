namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidMenuPanels
{
    public string? Resort { get; set; }
    public string? ApplicationName { get; set; }
    public string? PanelName { get; set; }
    public string? DisplayCode { get; set; }
    public decimal? SequenceNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidMenuPanels>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_MENU_PANELS");

            entity.Property(e => e.ApplicationName)
                .IsRequired()
                .HasColumnName("APPLICATION_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DisplayCode)
                .IsRequired()
                .HasColumnName("DISPLAY_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PanelName)
                .IsRequired()
                .HasColumnName("PANEL_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SequenceNo)
                .HasColumnName("SEQUENCE_NO")
                .HasColumnType("NUMBER");
        });
	}
}
