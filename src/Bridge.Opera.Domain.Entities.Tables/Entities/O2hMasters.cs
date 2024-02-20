namespace Bridge.Opera.Domain.Entities.Tables;

public partial class O2hMasters
{
    public decimal? MapId { get; set; }
    public string? MigrationId { get; set; }
    public string? TableName { get; set; }
    public string? ColumnName { get; set; }
    public string? ColumnType { get; set; }
    public string? SequenceName { get; set; }
    public string? Remark { get; set; }
    public string? Expression { get; set; }
    public string? Filter { get; set; }
    public string? RegenerateYn { get; set; }
    public string? MappingExpression { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<O2hMasters>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.TableName, e.ColumnName })
                .HasName("O2H_MASTERS_PK");

            entity.ToTable("O2H_MASTERS");

            entity.HasIndex(e => e.MapId)
                .HasName("O2H_MASTERS_MAP_ID_IDX");

            entity.Property(e => e.MigrationId)
                .HasColumnName("MIGRATION_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ColumnName)
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ColumnType)
                .HasColumnName("COLUMN_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Expression)
                .HasColumnName("EXPRESSION")
                .IsUnicode(false);

            entity.Property(e => e.Filter)
                .HasColumnName("FILTER")
                .IsUnicode(false);

            entity.Property(e => e.MapId)
                .HasColumnName("MAP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MappingExpression)
                .HasColumnName("MAPPING_EXPRESSION")
                .IsUnicode(false);

            entity.Property(e => e.RegenerateYn)
                .HasColumnName("REGENERATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .IsUnicode(false);

            entity.Property(e => e.SequenceName)
                .HasColumnName("SEQUENCE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
