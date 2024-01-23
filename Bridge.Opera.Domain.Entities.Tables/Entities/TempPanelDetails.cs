namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempPanelDetails
{
    public string ApplicationName { get; set; }
    public string PanelName { get; set; }
    public decimal? StartIndex { get; set; }
    public decimal? TotalMenuItems { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempPanelDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_PANEL_DETAILS");

            entity.Property(e => e.ApplicationName)
                .HasColumnName("APPLICATION_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PanelName)
                .HasColumnName("PANEL_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartIndex)
                .HasColumnName("START_INDEX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalMenuItems)
                .HasColumnName("TOTAL_MENU_ITEMS")
                .HasColumnType("NUMBER");
        });
	}
}
