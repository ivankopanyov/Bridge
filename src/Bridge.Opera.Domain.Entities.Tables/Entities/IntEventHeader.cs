namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntEventHeader
{
    public string? InterfaceId { get; set; }
    public string? BatchState { get; set; }
    public string? Resort { get; set; }
    public decimal? BatchId { get; set; }
    public decimal? EventCount { get; set; }
    public decimal? BatchSize { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? EventDate { get; set; }
    public DateTime? StateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntEventHeader>(entity =>
        {
            entity.HasKey(e => e.BatchId)
                .HasName("INT_EVENT_HEADER_PK");

            entity.ToTable("INT_EVENT_HEADER");

            entity.HasIndex(e => new { e.InterfaceId, e.Resort, e.BatchState })
                .HasName("INT_EVENT_HEADER_IDX");

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BatchSize)
                .HasColumnName("BATCH_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BatchState)
                .IsRequired()
                .HasColumnName("BATCH_STATE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EventCount)
                .HasColumnName("EVENT_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventDate)
                .HasColumnName("EVENT_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("sysdate ");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("sysdate ");

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StateDate)
                .HasColumnName("STATE_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("sysdate ");
        });
	}
}
