namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ForecastProcessorStatus
{
    public decimal? SessionId { get; set; }
    public string? EventType { get; set; }
    public string? EventId { get; set; }
    public DateTime? TimeDequeued { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ForecastProcessorStatus>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("FORECAST_PROCESSOR_STATUS");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventType)
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SessionId)
                .HasColumnName("SESSION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TimeDequeued)
                .HasColumnName("TIME_DEQUEUED")
                .HasColumnType("DATE");
        });
	}
}
