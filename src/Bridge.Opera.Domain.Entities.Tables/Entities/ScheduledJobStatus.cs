namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScheduledJobStatus
{
    public string? JobName { get; set; }
    public DateTime? LastRunDate { get; set; }
    public string? SuccessFlag { get; set; }
    public string? ErrorMessage { get; set; }
    public string? EmailAddresses { get; set; }
    public string? SmtpServer { get; set; }
    public string? SmtpServerPort { get; set; }
    public string? SmtpAuthuser { get; set; }
    public string? SmtpAuthuserpassword { get; set; }
    public string? OutputDataClob { get; set; }
    public string? EmailFrom { get; set; }
    public decimal? JobIterator { get; set; }
    public decimal? DbMemoryLimit { get; set; }
    public string? SendDailyReportsYn { get; set; }
    public string? LogResultsYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScheduledJobStatus>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SCHEDULED_JOB_STATUS");

            entity.Property(e => e.DbMemoryLimit)
                .HasColumnName("DB_MEMORY_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmailAddresses)
                .HasColumnName("EMAIL_ADDRESSES")
                .IsUnicode(false);

            entity.Property(e => e.EmailFrom)
                .HasColumnName("EMAIL_FROM")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasColumnName("ERROR_MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.JobIterator)
                .HasColumnName("JOB_ITERATOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JobName)
                .IsRequired()
                .HasColumnName("JOB_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LastRunDate)
                .HasColumnName("LAST_RUN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LogResultsYn)
                .HasColumnName("LOG_RESULTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OutputDataClob)
                .HasColumnName("OUTPUT_DATA_CLOB")
                .HasColumnType("CLOB");

            entity.Property(e => e.SendDailyReportsYn)
                .HasColumnName("SEND_DAILY_REPORTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SmtpAuthuser)
                .HasColumnName("SMTP_AUTHUSER")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.SmtpAuthuserpassword)
                .HasColumnName("SMTP_AUTHUSERPASSWORD")
                .HasMaxLength(400)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SmtpServer)
                .HasColumnName("SMTP_SERVER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SmtpServerPort)
                .HasColumnName("SMTP_SERVER_PORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SuccessFlag)
                .HasColumnName("SUCCESS_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
