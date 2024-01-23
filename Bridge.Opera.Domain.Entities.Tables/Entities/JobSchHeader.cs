namespace Bridge.Opera.Domain.Entities.Tables;

public partial class JobSchHeader
{
    public string JobNameId { get; set; }
    public string JobName { get; set; }
    public string JobNameTitle { get; set; }
    public string Command { get; set; }
    public decimal? CommandUser { get; set; }
    public string MsgLogFlg { get; set; }
    public decimal? DebugLogLevel { get; set; }
    public string InitUser { get; set; }
    public byte[] Password { get; set; }
    public string InitResort { get; set; }
    public string InitApplication { get; set; }
    public string InitCro { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string ActionText { get; set; }
    public string JobProcCode { get; set; }
    public string ResortRegistered { get; set; }
    public string CroRegistered { get; set; }
    public string ChainCode { get; set; }
    public string Comments { get; set; }
    public string UserComments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<JobSchHeader>(entity =>
        {
            entity.HasKey(e => e.JobNameId)
                .HasName("JSR_PK");

            entity.ToTable("JOB_SCH_HEADER");

            entity.HasIndex(e => e.ChainCode)
                .HasName("JOB_SCH_HEAD_IDX5");

            entity.HasIndex(e => e.CroRegistered)
                .HasName("JOB_SCH_HEAD_IDX4");

            entity.HasIndex(e => e.InitUser)
                .HasName("JOB_SCH_HEAD_IDX6");

            entity.HasIndex(e => e.JobName)
                .HasName("JOB_SCH_HEAD_IDX2");

            entity.HasIndex(e => e.JobProcCode)
                .HasName("JOB_SCH_HEAD_IDX1");

            entity.HasIndex(e => e.ResortRegistered)
                .HasName("JOB_SCH_HEAD_IDX3");

            entity.HasIndex(e => e.UpdateDate)
                .HasName("JOB_SCH_HEAD_IDX7");

            entity.Property(e => e.JobNameId)
                .HasColumnName("JOB_NAME_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ActionText)
                .HasColumnName("ACTION_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
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

            entity.Property(e => e.JobName)
                .IsRequired()
                .HasColumnName("JOB_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.JobNameTitle)
                .HasColumnName("JOB_NAME_TITLE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.JobProcCode)
                .HasColumnName("JOB_PROC_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MsgLogFlg)
                .HasColumnName("MSG_LOG_FLG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Password)
                .HasColumnName("PASSWORD")
                .HasMaxLength(240);

            entity.Property(e => e.ResortRegistered)
                .HasColumnName("RESORT_REGISTERED")
                .HasMaxLength(20)
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
