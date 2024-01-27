namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntEventDetails
{
    public decimal BatchId { get; set; }
    public string Module { get; set; }
    public string PrimaryKey { get; set; }
    public decimal ActionId { get; set; }
    public DateTime InsertDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateCount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntEventDetails>(entity =>
        {
            entity.HasKey(e => new { e.BatchId, e.Module, e.PrimaryKey })
                .HasName("INT_EVENT_DETAILS_PK");

            entity.ToTable("INT_EVENT_DETAILS");

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryKey)
                .HasColumnName("PRIMARY_KEY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("sysdate ");

            entity.Property(e => e.UpdateCount)
                .HasColumnName("UPDATE_COUNT")
                .HasColumnType("NUMBER(38)")
                .HasDefaultValueSql("0 ");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("sysdate ");
        });
	}
}
