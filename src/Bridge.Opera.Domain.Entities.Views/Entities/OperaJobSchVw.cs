namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OperaJobSchVw
{
    public string? JobNameId { get; set; }
    public string? JobName { get; set; }
    public string? JobNameTitle { get; set; }
    public string? Command { get; set; }
    public decimal? CommandUser { get; set; }
    public string? MsgLogFlg { get; set; }
    public decimal? DebugLogLevel { get; set; }
    public string? InitUser { get; set; }
    public byte[] Password { get; set; }
    public string? InitResort { get; set; }
    public string? InitApplication { get; set; }
    public string? InitCro { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? ActionText { get; set; }
    public string? JobSubname { get; set; }
    public string? JobCreator { get; set; }
    public string? ClientId { get; set; }
    public string? GlobalUid { get; set; }
    public string? ProgramOwner { get; set; }
    public string? ProgramName { get; set; }
    public string? JobType { get; set; }
    public string? JobAction { get; set; }
    public decimal? NumberOfArguments { get; set; }
    public string? ScheduleOwner { get; set; }
    public string? ScheduleName { get; set; }
    public string? ScheduleType { get; set; }
    public DateTime? StartDate { get; set; }
    public string? RepeatInterval { get; set; }
    public string? EventQueueOwner { get; set; }
    public string? EventQueueName { get; set; }
    public string? EventQueueAgent { get; set; }
    public string? EventCondition { get; set; }
    public string? EventRule { get; set; }
    public DateTime? EndDate { get; set; }
    public string? JobClass { get; set; }
    public string? Enabled { get; set; }
    public string? AutoDrop { get; set; }
    public string? Restartable { get; set; }
    public string? State { get; set; }
    public decimal? JobPriority { get; set; }
    public decimal? RunCount { get; set; }
    public decimal? MaxRuns { get; set; }
    public decimal? FailureCount { get; set; }
    public decimal? MaxFailures { get; set; }
    public decimal? RetryCount { get; set; }
    public DateTime? LastStartDate { get; set; }
    public DateTime? NextRunDate { get; set; }
    public string? LoggingLevel { get; set; }
    public string? StopOnWindowClose { get; set; }
    public string? InstanceStickiness { get; set; }
    public string? RaiseEvents { get; set; }
    public string? System { get; set; }
    public decimal? JobWeight { get; set; }
    public string? NlsEnv { get; set; }
    public string? Source { get; set; }
    public string? Destination { get; set; }
    public string? Comments { get; set; }
    public decimal? Flags { get; set; }
    public string? JobProcCode { get; set; }
    public string? ResortRegistered { get; set; }
    public string? CroRegistered { get; set; }
    public string? ChainCode { get; set; }
    public string? UserComments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaJobSchVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OPERA_JOB_SCH_VW");

            entity.Property(e => e.ActionText)
                .HasColumnName("ACTION_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.AutoDrop)
                .HasColumnName("AUTO_DROP")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClientId)
                .HasColumnName("CLIENT_ID")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Command)
                .HasColumnName("COMMAND")
                .IsUnicode(false);

            entity.Property(e => e.CommandUser)
                .HasColumnName("COMMAND_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.CroRegistered)
                .HasColumnName("CRO_REGISTERED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DebugLogLevel)
                .HasColumnName("DEBUG_LOG_LEVEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Destination)
                .HasColumnName("DESTINATION")
                .HasMaxLength(384)
                .IsUnicode(false);

            entity.Property(e => e.Enabled)
                .HasColumnName("ENABLED")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventCondition)
                .HasColumnName("EVENT_CONDITION")
                .IsUnicode(false);

            entity.Property(e => e.EventQueueAgent)
                .HasColumnName("EVENT_QUEUE_AGENT")
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.EventQueueName)
                .HasColumnName("EVENT_QUEUE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.EventQueueOwner)
                .HasColumnName("EVENT_QUEUE_OWNER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.EventRule)
                .HasColumnName("EVENT_RULE")
                .HasMaxLength(65)
                .IsUnicode(false);

            entity.Property(e => e.FailureCount)
                .HasColumnName("FAILURE_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Flags)
                .HasColumnName("FLAGS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GlobalUid)
                .HasColumnName("GLOBAL_UID")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.InitApplication)
                .HasColumnName("INIT_APPLICATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InitCro)
                .HasColumnName("INIT_CRO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InitResort)
                .HasColumnName("INIT_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InitUser)
                .HasColumnName("INIT_USER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InstanceStickiness)
                .HasColumnName("INSTANCE_STICKINESS")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.JobAction)
                .HasColumnName("JOB_ACTION")
                .IsUnicode(false);

            entity.Property(e => e.JobClass)
                .HasColumnName("JOB_CLASS")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.JobCreator)
                .HasColumnName("JOB_CREATOR")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.JobName)
                .IsRequired()
                .HasColumnName("JOB_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.JobNameId)
                .IsRequired()
                .HasColumnName("JOB_NAME_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.JobNameTitle)
                .HasColumnName("JOB_NAME_TITLE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.JobPriority)
                .HasColumnName("JOB_PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JobProcCode)
                .HasColumnName("JOB_PROC_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.JobSubname)
                .HasColumnName("JOB_SUBNAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.JobType)
                .HasColumnName("JOB_TYPE")
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.JobWeight)
                .HasColumnName("JOB_WEIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastStartDate)
                .HasColumnName("LAST_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LoggingLevel)
                .HasColumnName("LOGGING_LEVEL")
                .HasMaxLength(11)
                .IsUnicode(false);

            entity.Property(e => e.MaxFailures)
                .HasColumnName("MAX_FAILURES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxRuns)
                .HasColumnName("MAX_RUNS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MsgLogFlg)
                .HasColumnName("MSG_LOG_FLG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NextRunDate)
                .HasColumnName("NEXT_RUN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NlsEnv)
                .HasColumnName("NLS_ENV")
                .IsUnicode(false);

            entity.Property(e => e.NumberOfArguments)
                .HasColumnName("NUMBER_OF_ARGUMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Password)
                .HasColumnName("PASSWORD")
                .HasMaxLength(240);

            entity.Property(e => e.ProgramName)
                .HasColumnName("PROGRAM_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ProgramOwner)
                .HasColumnName("PROGRAM_OWNER")
                .IsUnicode(false);

            entity.Property(e => e.RaiseEvents)
                .HasColumnName("RAISE_EVENTS")
                .IsUnicode(false);

            entity.Property(e => e.RepeatInterval)
                .HasColumnName("REPEAT_INTERVAL")
                .IsUnicode(false);

            entity.Property(e => e.ResortRegistered)
                .HasColumnName("RESORT_REGISTERED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Restartable)
                .HasColumnName("RESTARTABLE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.RetryCount)
                .HasColumnName("RETRY_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RunCount)
                .HasColumnName("RUN_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ScheduleName)
                .HasColumnName("SCHEDULE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ScheduleOwner)
                .HasColumnName("SCHEDULE_OWNER")
                .IsUnicode(false);

            entity.Property(e => e.ScheduleType)
                .HasColumnName("SCHEDULE_TYPE")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.Source)
                .HasColumnName("SOURCE")
                .HasMaxLength(128)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.StopOnWindowClose)
                .HasColumnName("STOP_ON_WINDOW_CLOSE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.System)
                .HasColumnName("SYSTEM")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserComments)
                .HasColumnName("USER_COMMENTS")
                .IsUnicode(false);
        });
	}
}
