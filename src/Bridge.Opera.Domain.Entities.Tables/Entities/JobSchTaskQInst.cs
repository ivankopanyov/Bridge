namespace Bridge.Opera.Domain.Entities.Tables;

public partial class JobSchTaskQInst
{
    public decimal? TaskInstId { get; set; }
    public string? TaskCode { get; set; }
    public string? QCode { get; set; }
    public decimal? ExecutionSeq { get; set; }
    public string? TaskStatus { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? ProcessingMessage { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? ParamListId { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? JobNameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<JobSchTaskQInst>(entity =>
        {
            entity.HasKey(e => new { e.TaskInstId, e.ExecutionSeq })
                .HasName("JIT_PK");

            entity.ToTable("JOB_SCH_TASK_Q_INST");

            entity.HasIndex(e => e.InactiveDate)
                .HasName("JOB_SCH_TASK_Q_INST_IND02");

            entity.HasIndex(e => e.JobNameId)
                .HasName("JOB_SCH_TASK_Q_INST_IND03");

            entity.HasIndex(e => new { e.QCode, e.TaskCode })
                .HasName("JOB_SCH_TASK_Q_INST_IND01");

            entity.Property(e => e.TaskInstId)
                .HasColumnName("TASK_INST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExecutionSeq)
                .HasColumnName("EXECUTION_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JobNameId)
                .HasColumnName("JOB_NAME_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ParamListId)
                .HasColumnName("PARAM_LIST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessingMessage)
                .HasColumnName("PROCESSING_MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.QCode)
                .IsRequired()
                .HasColumnName("Q_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaskCode)
                .IsRequired()
                .HasColumnName("TASK_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TaskStatus)
                .IsRequired()
                .HasColumnName("TASK_STATUS")
                .HasMaxLength(20)
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
