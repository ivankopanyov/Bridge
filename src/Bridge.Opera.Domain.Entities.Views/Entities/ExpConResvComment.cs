namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConResvComment
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? GstViewable { get; set; }
    public string? GstText { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConResvComment>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_RESV_COMMENT");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GstText)
                .HasColumnName("GST_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GstViewable)
                .HasColumnName("GST_VIEWABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
