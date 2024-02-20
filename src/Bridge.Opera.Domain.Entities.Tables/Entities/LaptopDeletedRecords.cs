namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LaptopDeletedRecords
{
    public string? TableName { get; set; }
    public string? WhereClause { get; set; }
    public decimal? DeletedOrder { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LaptopDeletedRecords>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("LAPTOP$DELETED_RECORDS");

            entity.Property(e => e.DeletedOrder)
                .HasColumnName("DELETED_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.WhereClause)
                .HasColumnName("WHERE_CLAUSE")
                .IsUnicode(false);
        });
	}
}
