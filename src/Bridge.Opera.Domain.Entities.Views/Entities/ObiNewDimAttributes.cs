namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiNewDimAttributes
{
    public string AttrCode { get; set; }
    public string AttrDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public string DimName { get; set; }
    public string DimTable { get; set; }
    public string DimKeyCol { get; set; }
    public string ReturnCol { get; set; }
    public string ReturnDescCol { get; set; }
    public string ReturnValues { get; set; }
    public string DisplayLabel { get; set; }
    public string DimWhere { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiNewDimAttributes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_NEW_DIM_ATTRIBUTES");

            entity.Property(e => e.AttrCode)
                .HasColumnName("ATTR_CODE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.AttrDesc)
                .HasColumnName("ATTR_DESC")
                .IsUnicode(false);

            entity.Property(e => e.DimKeyCol)
                .HasColumnName("DIM_KEY_COL")
                .HasMaxLength(26)
                .IsUnicode(false);

            entity.Property(e => e.DimName)
                .HasColumnName("DIM_NAME")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.DimTable)
                .HasColumnName("DIM_TABLE")
                .HasMaxLength(18)
                .IsUnicode(false);

            entity.Property(e => e.DimWhere)
                .HasColumnName("DIM_WHERE")
                .HasMaxLength(22)
                .IsUnicode(false);

            entity.Property(e => e.DisplayLabel)
                .HasColumnName("DISPLAY_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReturnCol)
                .HasColumnName("RETURN_COL")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ReturnDescCol)
                .HasColumnName("RETURN_DESC_COL")
                .HasMaxLength(11)
                .IsUnicode(false);

            entity.Property(e => e.ReturnValues)
                .HasColumnName("RETURN_VALUES")
                .HasMaxLength(22)
                .IsUnicode(false);
        });
	}
}
