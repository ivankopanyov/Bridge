namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FacilityTasksForResv
{
    public string Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public DateTime? ReservationDate { get; set; }
    public string Room { get; set; }
    public string RoomCategory { get; set; }
    public string RdeResort { get; set; }
    public DateTime? RdeReservationDate { get; set; }
    public string FacilityTask { get; set; }
    public string Frequency { get; set; }
    public decimal? FrequencyDays { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? Priority { get; set; }
    public string Customized { get; set; }
    public string TaskYn { get; set; }
    public decimal? FacilityTaskSeq { get; set; }
    public decimal? Credits { get; set; }
    public decimal? CycleStartDay { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FacilityTasksForResv>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FACILITY_TASKS_FOR_RESV");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Credits)
                .HasColumnName("CREDITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Customized)
                .HasColumnName("CUSTOMIZED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CycleStartDay)
                .HasColumnName("CYCLE_START_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FacilityTask)
                .HasColumnName("FACILITY_TASK")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FacilityTaskSeq)
                .HasColumnName("FACILITY_TASK_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FrequencyDays)
                .HasColumnName("FREQUENCY_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RdeReservationDate)
                .HasColumnName("RDE_RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RdeResort)
                .HasColumnName("RDE_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaskYn)
                .HasColumnName("TASK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
