namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SimpleDynLov
{
    public string ModuleType { get; set; }
    public string ModuleName { get; set; }
    public string ObjectName { get; set; }
    public decimal ColumnNumbers { get; set; }
    public string Title { get; set; }
    public string Column1 { get; set; }
    public string Column2 { get; set; }
    public string Column3 { get; set; }
    public string LovQuery { get; set; }
    public string OrderBy { get; set; }
    public string MultiSelectYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SimpleDynLov>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SIMPLE_DYN_LOV");

            entity.HasIndex(e => new { e.ModuleType, e.ModuleName, e.ObjectName })
                .HasName("SIMPLE_DYN_LOV_UK")
                .IsUnique();

            entity.Property(e => e.Column1)
                .HasColumnName("COLUMN1")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Column2)
                .HasColumnName("COLUMN2")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Column3)
                .HasColumnName("COLUMN3")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ColumnNumbers)
                .HasColumnName("COLUMN_NUMBERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LovQuery)
                .IsRequired()
                .HasColumnName("LOV_QUERY")
                .IsUnicode(false);

            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ModuleType)
                .IsRequired()
                .HasColumnName("MODULE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MultiSelectYn)
                .IsRequired()
                .HasColumnName("MULTI_SELECT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ObjectName)
                .IsRequired()
                .HasColumnName("OBJECT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(500)
                .IsUnicode(false);
        });
	}
}
