namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CustomRcatFacilityTasks
{
    public string? Resort { get; set; }
    public string? RoomCategory { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? RoomCategoryLabel { get; set; }
    public string? FacilityTask { get; set; }
    public string? TaskDescription { get; set; }
    public decimal? Credits { get; set; }
    public string? Frequency { get; set; }
    public decimal? FrequencyDays { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? Priority { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CustomRcatFacilityTasks>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CUSTOM_RCAT_FACILITY_TASKS");

            entity.Property(e => e.Credits)
                .HasColumnName("CREDITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FacilityTask)
                .IsRequired()
                .HasColumnName("FACILITY_TASK")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FrequencyDays)
                .HasColumnName("FREQUENCY_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaskDescription)
                .IsRequired()
                .HasColumnName("TASK_DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
