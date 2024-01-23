namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TransactionSequences
{
    public string TableName { get; set; }
    public string ColumnName { get; set; }
    public string SequenceName { get; set; }
    public string ParentSequence { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TransactionSequences>(entity =>
        {
            entity.HasKey(e => new { e.TableName, e.ColumnName })
                .HasName("TS_PK");

            entity.ToTable("TRANSACTION$SEQUENCES");

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ColumnName)
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ParentSequence)
                .HasColumnName("PARENT_SEQUENCE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SequenceName)
                .HasColumnName("SEQUENCE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
