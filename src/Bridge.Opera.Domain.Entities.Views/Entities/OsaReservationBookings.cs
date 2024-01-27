namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OsaReservationBookings
{
    public decimal? ResvNameId { get; set; }
    public string LinkType { get; set; }
    public string Resort { get; set; }
    public string EasActivityId { get; set; }
    public string ExternalSystem { get; set; }
    public decimal? ActivityId { get; set; }
    public string ActivityType { get; set; }
    public string LocationCode { get; set; }
    public string LocationDesc { get; set; }
    public string StatusDesc { get; set; }
    public string ActivityDesc { get; set; }
    public decimal? Pax { get; set; }
    public string Notes { get; set; }
    public DateTime? StartDate { get; set; }
    public string StartTime { get; set; }
    public DateTime? EndDate { get; set; }
    public string EndTime { get; set; }
    public string Duration { get; set; }
    public string StatusCode { get; set; }
    public decimal? DepositAmount { get; set; }
    public string DepositOwner { get; set; }
    public decimal? ActivityAmount { get; set; }
    public string ProblemDesc { get; set; }
    public string GuestType { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? OlmResvNameId { get; set; }
    public decimal? OlmNameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OsaReservationBookings>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OSA_RESERVATION_BOOKINGS");

            entity.Property(e => e.ActivityAmount)
                .HasColumnName("ACTIVITY_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActivityDesc)
                .HasColumnName("ACTIVITY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ActivityId)
                .HasColumnName("ACTIVITY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActivityType)
                .HasColumnName("ACTIVITY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepositAmount)
                .HasColumnName("DEPOSIT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositOwner)
                .HasColumnName("DEPOSIT_OWNER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Duration)
                .HasColumnName("DURATION")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.EasActivityId)
                .HasColumnName("EAS_ACTIVITY_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ExternalSystem)
                .HasColumnName("EXTERNAL_SYSTEM")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestType)
                .HasColumnName("GUEST_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LinkType)
                .HasColumnName("LINK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LocationCode)
                .HasColumnName("LOCATION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.LocationDesc)
                .HasColumnName("LOCATION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .IsUnicode(false);

            entity.Property(e => e.OlmNameId)
                .HasColumnName("OLM_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OlmResvNameId)
                .HasColumnName("OLM_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Pax)
                .HasColumnName("PAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProblemDesc)
                .HasColumnName("PROBLEM_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StartTime)
                .HasColumnName("START_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.StatusCode)
                .HasColumnName("STATUS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatusDesc)
                .HasColumnName("STATUS_DESC")
                .IsUnicode(false);
        });
	}
}
