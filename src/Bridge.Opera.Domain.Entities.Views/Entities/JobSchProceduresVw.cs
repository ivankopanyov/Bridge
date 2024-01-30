namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class JobSchProceduresVw
{
    public string? JobProcCode { get; set; }
    public string? DisplayTitle { get; set; }
    public decimal? JobCreateMode { get; set; }
    public string? JobType { get; set; }
    public string? JobProcGroup { get; set; }
    public string? Comments { get; set; }
    public decimal? MaxInstances { get; set; }
    public string? MaxInstancesFlag { get; set; }
    public string? UsedInApp { get; set; }
    public string? DefaultApplication { get; set; }
    public string? JobAction { get; set; }
    public decimal? NumberOfArguments { get; set; }
    public string? JobClass { get; set; }
    public string? AutoDropYn { get; set; }
    public string? ProgramName { get; set; }
    public string? ScheduleName { get; set; }
    public string? EventCondition { get; set; }
    public string? EventQueue { get; set; }
    public string? QueueSpec { get; set; }
    public string? RepeatInterval { get; set; }
    public string? Mandatory { get; set; }
    public string? InactiveYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<JobSchProceduresVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("JOB_SCH_PROCEDURES_VW");

            entity.Property(e => e.AutoDropYn)
                .HasColumnName("AUTO_DROP_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultApplication)
                .HasColumnName("DEFAULT_APPLICATION")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplayTitle)
                .IsRequired()
                .HasColumnName("DISPLAY_TITLE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventCondition)
                .HasColumnName("EVENT_CONDITION")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventQueue)
                .HasColumnName("EVENT_QUEUE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .IsUnicode(false);

            entity.Property(e => e.JobAction)
                .HasColumnName("JOB_ACTION")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.JobClass)
                .HasColumnName("JOB_CLASS")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.JobCreateMode)
                .HasColumnName("JOB_CREATE_MODE")
                .HasColumnType("NUMBER(38)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.JobProcCode)
                .IsRequired()
                .HasColumnName("JOB_PROC_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.JobProcGroup)
                .HasColumnName("JOB_PROC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.JobType)
                .IsRequired()
                .HasColumnName("JOB_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Mandatory)
                .HasColumnName("MANDATORY")
                .IsUnicode(false);

            entity.Property(e => e.MaxInstances)
                .HasColumnName("MAX_INSTANCES")
                .HasColumnType("NUMBER(38)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxInstancesFlag)
                .HasColumnName("MAX_INSTANCES_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NumberOfArguments)
                .HasColumnName("NUMBER_OF_ARGUMENTS")
                .HasColumnType("NUMBER(38)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProgramName)
                .HasColumnName("PROGRAM_NAME")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.QueueSpec)
                .HasColumnName("QUEUE_SPEC")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RepeatInterval)
                .HasColumnName("REPEAT_INTERVAL")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ScheduleName)
                .HasColumnName("SCHEDULE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UsedInApp)
                .HasColumnName("USED_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
