namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OperaAppDependencies
{
    public string? SourceTable { get; set; }
    public string? TableName { get; set; }
    public string? ColumnName { get; set; }
    public decimal? DependencySeq { get; set; }
    public string? MsgKeyword { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaAppDependencies>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OPERA_APP_DEPENDENCIES");

            entity.HasIndex(e => new { e.SourceTable, e.TableName, e.ColumnName, e.DependencySeq })
                .HasName("OPERA_APP_DEPENDENCIES_IND")
                .IsUnique();

            entity.Property(e => e.ColumnName)
                .HasColumnName("COLUMN_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DependencySeq)
                .HasColumnName("DEPENDENCY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MsgKeyword)
                .HasColumnName("MSG_KEYWORD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SourceTable)
                .HasColumnName("SOURCE_TABLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
