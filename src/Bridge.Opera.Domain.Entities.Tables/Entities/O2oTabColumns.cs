namespace Bridge.Opera.Domain.Entities.Tables;

public partial class O2oTabColumns
{
    public string? TableName { get; set; }
    public string? ColumnName { get; set; }
    public string? Expression { get; set; }
    public string? DefaultValue { get; set; }
    public string? ResortColumnYn { get; set; }
    public string? MappingYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<O2oTabColumns>(entity =>
        {
            entity.HasKey(e => new { e.TableName, e.ColumnName })
                .HasName("O2O_TAB_COLUMNS_PK");

            entity.ToTable("O2O_TAB_COLUMNS");

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ColumnName)
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.DefaultValue)
                .HasColumnName("DEFAULT_VALUE")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Expression)
                .HasColumnName("EXPRESSION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MappingYn)
                .HasColumnName("MAPPING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.ResortColumnYn)
                .HasColumnName("RESORT_COLUMN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
