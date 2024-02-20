namespace Bridge.Opera.Domain.Entities.Tables;

public partial class O2oMappingTable
{
    public string? O2oMigId { get; set; }
    public string? TableName { get; set; }
    public string? ColumnName { get; set; }
    public decimal? SourceId { get; set; }
    public decimal? TargetId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<O2oMappingTable>(entity =>
        {
            entity.HasKey(e => new { e.O2oMigId, e.TableName, e.ColumnName, e.SourceId })
                .HasName("O2O_MAPPING_TABLE_PK");

            entity.ToTable("O2O_MAPPING_TABLE");

            entity.HasIndex(e => new { e.O2oMigId, e.TableName, e.ColumnName, e.TargetId })
                .HasName("O2O_MAPPING_TABLE_UK")
                .IsUnique();

            entity.Property(e => e.O2oMigId)
                .HasColumnName("O2O_MIG_ID")
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

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TargetId)
                .HasColumnName("TARGET_ID")
                .HasColumnType("NUMBER");
        });
	}
}
