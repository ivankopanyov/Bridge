namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class JobSchDetailVw
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
		modelBuilder.Entity<JobSchDetailVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("JOB_SCH_DETAIL_VW");

            entity.Property(e => e.CompletePercent)
                .HasColumnName("COMPLETE_PERCENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DateTimeStamp)
                .HasColumnName("DATE_TIME_STAMP")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.JobNameId)
                .IsRequired()
                .HasColumnName("JOB_NAME_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

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

            entity.Property(e => e.TextSeqId)
                .HasColumnName("TEXT_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TextType)
                .IsRequired()
                .HasColumnName("TEXT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
