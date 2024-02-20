namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EisTabColumns
{
    public string? TableName { get; set; }
    public string? ColumnName { get; set; }
    public string? Comments { get; set; }
    public string? DataType { get; set; }
    public decimal? DataLength { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EisTabColumns>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EIS_TAB_COLUMNS");

            entity.Property(e => e.ColumnName)
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.DataLength)
                .HasColumnName("DATA_LENGTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(106)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
