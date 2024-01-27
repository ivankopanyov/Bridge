namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofRevenueRecordColumns
{
    public string TableType { get; set; }
    public string TableName { get; set; }
    public string DataType { get; set; }
    public string ColumnName { get; set; }
    public string ColumnDefinition { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofRevenueRecordColumns>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_REVENUE_RECORD_COLUMNS");

            entity.Property(e => e.ColumnDefinition)
                .HasColumnName("COLUMN_DEFINITION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ColumnName)
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(106)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.TableType)
                .HasColumnName("TABLE_TYPE")
                .HasColumnType("CHAR(3)");
        });
	}
}
