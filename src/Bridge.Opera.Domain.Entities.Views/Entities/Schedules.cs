namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Schedules
{
    public string JobName { get; set; }
    public string JobSubname { get; set; }
    public string JobCreator { get; set; }
    public string JobType { get; set; }
    public decimal? NumberOfArguments { get; set; }
    public string ScheduleOwner { get; set; }
    public DateTime? StartDate { get; set; }
    public string RepeatInterval { get; set; }
    public DateTime? EndDate { get; set; }
    public string Enabled { get; set; }
    public string State { get; set; }
    public decimal? RunCount { get; set; }
    public decimal? FailureCount { get; set; }
    public DateTime? LastStartDate { get; set; }
    public DateTime? NextRunDate { get; set; }
    public string Comments { get; set; }
    public string AppUser { get; set; }
    public string RepeatIntervalDisplay { get; set; }
    public string Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Schedules>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SCHEDULES");

            entity.Property(e => e.AppUser)
                .HasColumnName("APP_USER")
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Enabled)
                .HasColumnName("ENABLED")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FailureCount)
                .HasColumnName("FAILURE_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JobCreator)
                .HasColumnName("JOB_CREATOR")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.JobName)
                .HasColumnName("JOB_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.JobSubname)
                .HasColumnName("JOB_SUBNAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.JobType)
                .HasColumnName("JOB_TYPE")
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.LastStartDate)
                .HasColumnName("LAST_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NextRunDate)
                .HasColumnName("NEXT_RUN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NumberOfArguments)
                .HasColumnName("NUMBER_OF_ARGUMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RepeatInterval)
                .HasColumnName("REPEAT_INTERVAL")
                .IsUnicode(false);

            entity.Property(e => e.RepeatIntervalDisplay)
                .HasColumnName("REPEAT_INTERVAL_DISPLAY")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.RunCount)
                .HasColumnName("RUN_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ScheduleOwner)
                .HasColumnName("SCHEDULE_OWNER")
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
