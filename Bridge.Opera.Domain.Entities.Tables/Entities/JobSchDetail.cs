namespace Bridge.Opera.Domain.Entities.Tables;

public partial class JobSchDetail
{
    public string JobNameId { get; set; }
    public decimal TextSeqId { get; set; }
    public string TextType { get; set; }
    public string MessageText { get; set; }
    public decimal? CompletePercent { get; set; }
    public decimal? MsgLevel { get; set; }
    public DateTime? DateTimeStamp { get; set; }
    public string TextMsgCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<JobSchDetail>(entity =>
        {
            entity.HasKey(e => new { e.TextSeqId, e.JobNameId })
                .HasName("JSL_PK");

            entity.ToTable("JOB_SCH_DETAIL");

            entity.HasIndex(e => e.DateTimeStamp)
                .HasName("JOB_SCH_DET_IDX2");

            entity.HasIndex(e => new { e.JobNameId, e.TextType, e.MsgLevel })
                .HasName("JOB_SCH_DET_IDX1");

            entity.Property(e => e.TextSeqId)
                .HasColumnName("TEXT_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JobNameId)
                .HasColumnName("JOB_NAME_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CompletePercent)
                .HasColumnName("COMPLETE_PERCENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DateTimeStamp)
                .HasColumnName("DATE_TIME_STAMP")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.MessageText)
                .HasColumnName("MESSAGE_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.MsgLevel)
                .HasColumnName("MSG_LEVEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TextMsgCode)
                .HasColumnName("TEXT_MSG_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TextType)
                .IsRequired()
                .HasColumnName("TEXT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
