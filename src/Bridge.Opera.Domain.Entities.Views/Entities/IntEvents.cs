namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IntEvents
{
    public string? InterfaceId { get; set; }
    public string? Resort { get; set; }
    public string? BatchState { get; set; }
    public string? Module { get; set; }
    public string? PrimaryKey { get; set; }
    public decimal? ActionId { get; set; }
    public decimal? BatchId { get; set; }
    public decimal? EventCount { get; set; }
    public decimal? BatchSize { get; set; }
    public decimal? UpdateCount { get; set; }
    public DateTime? EventDate { get; set; }
    public DateTime? StateDate { get; set; }
    public DateTime? HeaderInsertDate { get; set; }
    public DateTime? DetailInsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntEvents>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INT_EVENTS");

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BatchSize)
                .HasColumnName("BATCH_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BatchState)
                .HasColumnName("BATCH_STATE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.DetailInsertDate)
                .HasColumnName("DETAIL_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventCount)
                .HasColumnName("EVENT_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventDate)
                .HasColumnName("EVENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.HeaderInsertDate)
                .HasColumnName("HEADER_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryKey)
                .HasColumnName("PRIMARY_KEY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StateDate)
                .HasColumnName("STATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateCount)
                .HasColumnName("UPDATE_COUNT")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");
        });
	}
}
