namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidScrPaintCanvasesSys
{
    public string FormId { get; set; }
    public string CanvasName { get; set; }
    public string ParentCanvas { get; set; }
    public decimal XPos { get; set; }
    public decimal YPos { get; set; }
    public decimal Height { get; set; }
    public decimal Width { get; set; }
    public string DisplayMode { get; set; }
    public string Tabed { get; set; }
    public string Appearance { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidScrPaintCanvasesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_SCR_PAINT_CANVASES_SYS");

            entity.Property(e => e.Appearance)
                .HasColumnName("APPEARANCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CanvasName)
                .HasColumnName("CANVAS_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DisplayMode)
                .HasColumnName("DISPLAY_MODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FormId)
                .IsRequired()
                .HasColumnName("FORM_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Height)
                .HasColumnName("HEIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentCanvas)
                .HasColumnName("PARENT_CANVAS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Tabed)
                .HasColumnName("TABED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Width)
                .HasColumnName("WIDTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.XPos)
                .HasColumnName("X_POS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YPos)
                .HasColumnName("Y_POS")
                .HasColumnType("NUMBER");
        });
	}
}
