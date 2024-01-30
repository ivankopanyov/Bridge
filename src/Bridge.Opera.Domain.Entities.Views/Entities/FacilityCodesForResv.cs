namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FacilityCodesForResv
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public DateTime? ReservationDate { get; set; }
    public string? Room { get; set; }
    public string? RoomCategory { get; set; }
    public string? FacilityTask { get; set; }
    public string? Frequency { get; set; }
    public decimal? FrequencyDays { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? TaskYn { get; set; }
    public string? Customized { get; set; }
    public string? FacilityCode { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? FacilityTaskSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FacilityCodesForResv>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FACILITY_CODES_FOR_RESV");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Customized)
                .HasColumnName("CUSTOMIZED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FacilityCode)
                .HasColumnName("FACILITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

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
