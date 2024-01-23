namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ForecastDataLoadStatus
{
    public string EventType { get; set; }
    public string EventId { get; set; }
    public string Status { get; set; }
    public DateTime TimeDone { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ForecastDataLoadStatus>(entity =>
        {
            entity.HasKey(e => new { e.EventId, e.EventType })
                .HasName("FDLS_PK");

            entity.ToTable("FORECAST_DATA_LOAD_STATUS");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EventType)
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TimeDone)
                .HasColumnName("TIME_DONE")
                .HasColumnType("DATE");
        });
	}
}
