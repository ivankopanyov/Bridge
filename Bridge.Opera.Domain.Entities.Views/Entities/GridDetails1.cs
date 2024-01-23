namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GridDetails1
{
    public decimal GridHeaderLink { get; set; }
    public decimal? ColPos { get; set; }
    public string ColName { get; set; }
    public string ColTitle { get; set; }
    public decimal? ColWidth { get; set; }
    public string DataType { get; set; }
    public string EditableYn { get; set; }
    public string VisibleYn { get; set; }
    public string FooterFunction { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GridDetails1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GRID_DETAILS");

            entity.Property(e => e.ColName)
                .HasColumnName("COL_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ColPos)
                .HasColumnName("COL_POS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ColTitle)
                .HasColumnName("COL_TITLE")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.ColWidth)
                .HasColumnName("COL_WIDTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EditableYn)
                .HasColumnName("EDITABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FooterFunction)
                .HasColumnName("FOOTER_FUNCTION")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.GridHeaderLink)
                .HasColumnName("GRID_HEADER_LINK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VisibleYn)
                .HasColumnName("VISIBLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
