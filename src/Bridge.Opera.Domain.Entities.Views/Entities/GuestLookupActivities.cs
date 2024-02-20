namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GuestLookupActivities
{
    public decimal? LookupSeqId { get; set; }
    public string? LookupRequestId { get; set; }
    public string? ActivityType { get; set; }
    public string? ActivityLocation { get; set; }
    public decimal? NoOfPersons { get; set; }
    public string? Notes { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Duration { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestLookupActivities>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GUEST_LOOKUP_ACTIVITIES");

            entity.Property(e => e.ActivityLocation)
                .HasColumnName("ACTIVITY_LOCATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ActivityType)
                .HasColumnName("ACTIVITY_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Duration)
                .HasColumnName("DURATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LookupRequestId)
                .HasColumnName("LOOKUP_REQUEST_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LookupSeqId)
                .HasColumnName("LOOKUP_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfPersons)
                .HasColumnName("NO_OF_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");
        });
	}
}
