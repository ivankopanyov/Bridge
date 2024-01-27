namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OperaSchJobRunDetailsVw
{
    public decimal? LogId { get; set; }
    public DateTime? LogDate { get; set; }
    public string Owner { get; set; }
    public string JobName { get; set; }
    public string JobSubname { get; set; }
    public string Status { get; set; }
    public decimal? Error { get; set; }
    public DateTime? ReqStartDate { get; set; }
    public DateTime? ActualStartDate { get; set; }
    public TimeSpan? RunDuration { get; set; }
    public decimal? InstanceId { get; set; }
    public string SessionId { get; set; }
    public string SlavePid { get; set; }
    public TimeSpan? CpuUsed { get; set; }
    public string AdditionalInfo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaSchJobRunDetailsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OPERA_SCH_JOB_RUN_DETAILS_VW");

            entity.Property(e => e.ActualStartDate)
                .HasColumnName("ACTUAL_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AdditionalInfo)
                .HasColumnName("ADDITIONAL_INFO")
                .IsUnicode(false);

            entity.Property(e => e.CpuUsed)
                .HasColumnName("CPU_USED")
                .HasColumnType("INTERVAL DAY(3) TO SECOND(2)");

            entity.Property(e => e.Error)
                .HasColumnName("ERROR#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InstanceId)
                .HasColumnName("INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JobName)
                .HasColumnName("JOB_NAME")
                .HasMaxLength(195)
                .IsUnicode(false);

            entity.Property(e => e.JobSubname)
                .HasColumnName("JOB_SUBNAME")
                .HasMaxLength(195)
                .IsUnicode(false);

            entity.Property(e => e.LogDate)
                .HasColumnName("LOG_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LogId)
                .HasColumnName("LOG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Owner)
                .HasColumnName("OWNER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ReqStartDate)
                .HasColumnName("REQ_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RunDuration)
                .HasColumnName("RUN_DURATION")
                .HasColumnType("INTERVAL DAY(3) TO SECOND(0)");

            entity.Property(e => e.SessionId)
                .HasColumnName("SESSION_ID")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.SlavePid)
                .HasColumnName("SLAVE_PID")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
