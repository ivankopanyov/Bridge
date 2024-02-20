namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AqOedsMessageQueueTableH
{
    public Guid Msgid { get; set; }
    public decimal? Subscriber { get; set; }
    public string? Name { get; set; }
    public decimal? Address { get; set; }
    public DateTime? DequeueTime { get; set; }
    public string? TransactionId { get; set; }
    public string? DequeueUser { get; set; }
    public Guid? PropagatedMsgid { get; set; }
    public decimal? RetryCount { get; set; }
    public string? Hint { get; set; }
    public Guid? Spare { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AqOedsMessageQueueTableH>(entity =>
        {
            entity.HasKey(e => new { e.Msgid, e.Subscriber, e.Name, e.Address })
                .HasName("SYS_IOT_TOP_142042");

            entity.ToTable("AQ$_OEDS_MESSAGE_QUEUE_TABLE_H");

            entity.Property(e => e.Msgid).HasColumnName("MSGID");

            entity.Property(e => e.Subscriber)
                .HasColumnName("SUBSCRIBER#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Address)
                .HasColumnName("ADDRESS#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DequeueTime)
                .HasColumnName("DEQUEUE_TIME")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.DequeueUser)
                .HasColumnName("DEQUEUE_USER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Hint)
                .HasColumnName("HINT")
                .HasColumnType("ROWID");

            entity.Property(e => e.PropagatedMsgid).HasColumnName("PROPAGATED_MSGID");

            entity.Property(e => e.RetryCount)
                .HasColumnName("RETRY_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Spare).HasColumnName("SPARE");

            entity.Property(e => e.TransactionId)
                .HasColumnName("TRANSACTION_ID")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
