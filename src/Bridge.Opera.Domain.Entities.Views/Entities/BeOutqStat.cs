namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BeOutqStat
{
    public string? ConsumerName { get; set; }
    public string? MessageState { get; set; }
    public DateTime? FirstMessageAt { get; set; }
    public DateTime? LastMessageAt { get; set; }
    public decimal? RecCount { get; set; }
    public string? InterfaceId { get; set; }
    public string? Resort { get; set; }
    public string? SystemType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BeOutqStat>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BE_OUTQ_STAT");

            entity.Property(e => e.ConsumerName)
                .HasColumnName("CONSUMER_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FirstMessageAt)
                .HasColumnName("FIRST_MESSAGE_AT")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .IsUnicode(false);

            entity.Property(e => e.LastMessageAt)
                .HasColumnName("LAST_MESSAGE_AT")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.MessageState)
                .HasColumnName("MESSAGE_STATE")
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.RecCount)
                .HasColumnName("REC_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SystemType)
                .HasColumnName("SYSTEM_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
