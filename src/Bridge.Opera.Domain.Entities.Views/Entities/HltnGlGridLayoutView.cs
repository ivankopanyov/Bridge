namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HltnGlGridLayoutView
{
    public string? ColumnName { get; set; }
    public decimal? ColumnWidth { get; set; }
    public string? AllowSearchYn { get; set; }
    public string? ColumnTitle { get; set; }
    public decimal? SortOrder { get; set; }
    public decimal? PercentageWidth { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HltnGlGridLayoutView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HLTN_GL_GRID_LAYOUT_VIEW");

            entity.Property(e => e.AllowSearchYn)
                .HasColumnName("ALLOW_SEARCH_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ColumnName)
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ColumnTitle)
                .HasColumnName("COLUMN_TITLE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ColumnWidth)
                .HasColumnName("COLUMN_WIDTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PercentageWidth)
                .HasColumnName("PERCENTAGE_WIDTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SortOrder)
                .HasColumnName("SORT_ORDER")
                .HasColumnType("NUMBER");
        });
	}
}
