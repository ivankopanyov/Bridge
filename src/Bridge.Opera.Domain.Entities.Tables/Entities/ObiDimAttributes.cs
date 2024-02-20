namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiDimAttributes
{
    public string? DimName { get; set; }
    public decimal? AttributeSeq { get; set; }
    public string? DimTable { get; set; }
    public string? DimKeyCol { get; set; }
    public string? ReturnCol { get; set; }
    public string? ReturnDescCol { get; set; }
    public string? ReturnValues { get; set; }
    public string? DimWhere { get; set; }
    public string? DisplayLabel { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiDimAttributes>(entity =>
        {
            entity.HasKey(e => new { e.DimName, e.AttributeSeq })
                .HasName("OBI_DIM_ATTR_PK");

            entity.ToTable("OBI_DIM_ATTRIBUTES");

            entity.Property(e => e.DimName)
                .HasColumnName("DIM_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.AttributeSeq)
                .HasColumnName("ATTRIBUTE_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DimKeyCol)
                .IsRequired()
                .HasColumnName("DIM_KEY_COL")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DimTable)
                .IsRequired()
                .HasColumnName("DIM_TABLE")
                .IsUnicode(false);

            entity.Property(e => e.DimWhere)
                .HasColumnName("DIM_WHERE")
                .IsUnicode(false);

            entity.Property(e => e.DisplayLabel)
                .HasColumnName("DISPLAY_LABEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReturnCol)
                .IsRequired()
                .HasColumnName("RETURN_COL")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ReturnDescCol)
                .HasColumnName("RETURN_DESC_COL")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ReturnValues)
                .HasColumnName("RETURN_VALUES")
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
