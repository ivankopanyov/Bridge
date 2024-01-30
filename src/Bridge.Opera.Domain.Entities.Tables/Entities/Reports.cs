namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Reports
{
    public string? ReportName { get; set; }
    public string? ReportDescription { get; set; }
    public string? ReportType { get; set; }
    public string? Destination { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? Gateway { get; set; }
    public string? Server { get; set; }
    public string? StationId { get; set; }
    public string? Scheduled { get; set; }
    public string? Format { get; set; }
    public string? Title { get; set; }
    public string? Debug { get; set; }
    public string? ChainCode { get; set; }
    public string? ReportUrl { get; set; }
    public string? ReportId { get; set; }
    public string? Owner { get; set; }
    public string? Resort { get; set; }
    public decimal? ModuleId { get; set; }
    public string? ReportStatus { get; set; }
    public decimal? BatchNo { get; set; }
    public decimal? DownloadTime { get; set; }
    public decimal? PrintspoolTime { get; set; }
    public DateTime? Finished { get; set; }
    public decimal? QueueTime { get; set; }
    public decimal? ReportTime { get; set; }
    public decimal? StatusCode { get; set; }
    public decimal? InvokeTime { get; set; }
    public DateTime? DownloadBeginDate { get; set; }
    public DateTime? DownloadEndDate { get; set; }
    public DateTime? PrintspoolBeginDate { get; set; }
    public DateTime? PrintspoolEndDate { get; set; }
    public DateTime? InvokeBeginDate { get; set; }
    public DateTime? InvokeEndDate { get; set; }
    public DateTime? QueueBeginDate { get; set; }
    public DateTime? QueueEndDate { get; set; }
    public DateTime? ReportBeginDate { get; set; }
    public DateTime? ReportEndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Reports>(entity =>
        {
            entity.HasKey(e => e.ReportId)
                .HasName("REPORTS_PK");

            entity.ToTable("REPORTS");

            entity.HasIndex(e => e.BatchNo)
                .HasName("REPORTS_IND6");

            entity.HasIndex(e => e.ModuleId)
                .HasName("REPORTS_IND5");

            entity.HasIndex(e => e.ReportName)
                .HasName("REPORTS_IND2");

            entity.HasIndex(e => e.Resort)
                .HasName("REPORTS_IND4");

            entity.HasIndex(e => new { e.ChainCode, e.Scheduled })
                .HasName("REPORTS_IND1");

            entity.HasIndex(e => new { e.InsertDate, e.ChainCode, e.Resort, e.Scheduled })
                .HasName("REPORTS_IND3");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BatchNo)
                .HasColumnName("BATCH_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Debug)
                .HasColumnName("DEBUG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Destination)
                .HasColumnName("DESTINATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DownloadBeginDate)
                .HasColumnName("DOWNLOAD_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DownloadEndDate)
                .HasColumnName("DOWNLOAD_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DownloadTime)
                .HasColumnName("DOWNLOAD_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Finished)
                .HasColumnName("FINISHED")
                .HasColumnType("DATE");

            entity.Property(e => e.Format)
                .HasColumnName("FORMAT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Gateway)
                .HasColumnName("GATEWAY")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvokeBeginDate)
                .HasColumnName("INVOKE_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvokeEndDate)
                .HasColumnName("INVOKE_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvokeTime)
                .HasColumnName("INVOKE_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Owner)
                .HasColumnName("OWNER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PrintspoolBeginDate)
                .HasColumnName("PRINTSPOOL_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PrintspoolEndDate)
                .HasColumnName("PRINTSPOOL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PrintspoolTime)
                .HasColumnName("PRINTSPOOL_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QueueBeginDate)
                .HasColumnName("QUEUE_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.QueueEndDate)
                .HasColumnName("QUEUE_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.QueueTime)
                .HasColumnName("QUEUE_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportBeginDate)
                .HasColumnName("REPORT_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ReportDescription)
                .HasColumnName("REPORT_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.ReportEndDate)
                .HasColumnName("REPORT_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ReportName)
                .IsRequired()
                .HasColumnName("REPORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ReportStatus)
                .HasColumnName("REPORT_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.ReportTime)
                .HasColumnName("REPORT_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportType)
                .HasColumnName("REPORT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReportUrl)
                .HasColumnName("REPORT_URL")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Scheduled)
                .HasColumnName("SCHEDULED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Server)
                .HasColumnName("SERVER")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.StationId)
                .HasColumnName("STATION_ID")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.StatusCode)
                .HasColumnName("STATUS_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(1000)
                .IsUnicode(false);
        });
	}
}
