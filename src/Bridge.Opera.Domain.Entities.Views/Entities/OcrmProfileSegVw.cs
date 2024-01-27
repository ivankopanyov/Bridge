namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OcrmProfileSegVw
{
    public decimal SegId { get; set; }
    public string SegCode { get; set; }
    public string SegDesc { get; set; }
    public string SegSourceType { get; set; }
    public string Resort { get; set; }
    public string JobNameId { get; set; }
    public string ActionText { get; set; }
    public string RepeatInterval { get; set; }
    public decimal? TimesExec { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string DynCodeId { get; set; }
    public decimal? SegBatchId { get; set; }
    public DateTime? BatchStartDate { get; set; }
    public DateTime? BatchEndDate { get; set; }
    public string Status { get; set; }
    public decimal? RecordCount { get; set; }
    public string JobName { get; set; }
    public string JobNameTitle { get; set; }
    public string JobState { get; set; }
    public DateTime? JobStartDate { get; set; }
    public DateTime? JobEndDate { get; set; }
    public DateTime? JobLastRunDate { get; set; }
    public DateTime? JobNextRunDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmProfileSegVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OCRM_PROFILE_SEG_VW");

            entity.Property(e => e.ActionText)
                .HasColumnName("ACTION_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.BatchEndDate)
                .HasColumnName("BATCH_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BatchStartDate)
                .HasColumnName("BATCH_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DynCodeId)
                .HasColumnName("DYN_CODE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JobEndDate)
                .HasColumnName("JOB_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.JobLastRunDate)
                .HasColumnName("JOB_LAST_RUN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.JobName)
                .HasColumnName("JOB_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.JobNameId)
                .HasColumnName("JOB_NAME_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.JobNameTitle)
                .HasColumnName("JOB_NAME_TITLE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.JobNextRunDate)
                .HasColumnName("JOB_NEXT_RUN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.JobStartDate)
                .HasColumnName("JOB_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.JobState)
                .HasColumnName("JOB_STATE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.RecordCount)
                .HasColumnName("RECORD_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RepeatInterval)
                .HasColumnName("REPEAT_INTERVAL")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SegBatchId)
                .HasColumnName("SEG_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SegCode)
                .IsRequired()
                .HasColumnName("SEG_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SegDesc)
                .HasColumnName("SEG_DESC")
                .IsUnicode(false);

            entity.Property(e => e.SegId)
                .HasColumnName("SEG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SegSourceType)
                .IsRequired()
                .HasColumnName("SEG_SOURCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TimesExec)
                .HasColumnName("TIMES_EXEC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
