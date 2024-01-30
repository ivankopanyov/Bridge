namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GridDetails
{
    public decimal? GridHeaderLink { get; set; }
    public decimal? ColPos { get; set; }
    public string? ColName { get; set; }
    public string? ColTitle { get; set; }
    public decimal? ColWidth { get; set; }
    public string? EditableYn { get; set; }
    public string? VisibleYn { get; set; }
    public string? DataType { get; set; }
    public string? FooterFunction { get; set; }

    public virtual GridHeader GridHeaderLinkNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GridDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GRID$DETAILS");

            entity.HasIndex(e => new { e.GridHeaderLink, e.ColPos })
                .HasName("GD_GH_IDX");

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

			if (!types.Contains(typeof(GridHeader)))
				entity.Ignore(e => e.GridHeaderLinkNavigation);
			else
	            entity.HasOne(d => d.GridHeaderLinkNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.GridHeaderLink)
	                .HasConstraintName("GD_GH_FK");
        });
	}
}
