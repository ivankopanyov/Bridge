namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ReportsView
{
    public string? ReportId { get; set; }
    public string? ReportName { get; set; }
    public string? ReportDescription { get; set; }
    public decimal? StatusCode { get; set; }
    public string? StatusMessage { get; set; }
    public string? Owner { get; set; }
    public string? Destype { get; set; }
    public string? Filename { get; set; }
    public string? Desname { get; set; }
    public DateTime? Started { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? Finished { get; set; }
    public string? Gateway { get; set; }
    public string? Server { get; set; }
    public string? Scheduled { get; set; }
    public string? StationId { get; set; }
    public string? Format { get; set; }
    public string? Title { get; set; }
    public string? Resort { get; set; }
    public decimal? ModuleId { get; set; }
    public string? Debug { get; set; }
    public string? JobType { get; set; }
    public string? CommandLine { get; set; }
    public decimal? JobId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReportsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REPORTS_VIEW");

            entity.Property(e => e.CommandLine)
                .HasColumnName("COMMAND_LINE")
                .HasColumnType("CHAR(2000)");

            entity.Property(e => e.Debug)
                .HasColumnName("DEBUG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Desname)
                .HasColumnName("DESNAME")
                .IsUnicode(false);

            entity.Property(e => e.Destype)
                .HasColumnName("DESTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Filename)
                .HasColumnName("FILENAME")
                .IsUnicode(false);

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

            entity.Property(e => e.JobId)
                .HasColumnName("JOB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JobType)
                .HasColumnName("JOB_TYPE")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Owner)
                .HasColumnName("OWNER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ReportDescription)
                .HasColumnName("REPORT_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.ReportId)
                .IsRequired()
                .HasColumnName("REPORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReportName)
                .IsRequired()
                .HasColumnName("REPORT_NAME")
                .HasMaxLength(80)
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

            entity.Property(e => e.StartTime)
                .HasColumnName("START_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Started)
                .HasColumnName("STARTED")
                .HasColumnType("DATE");

            entity.Property(e => e.StationId)
                .HasColumnName("STATION_ID")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.StatusCode)
                .HasColumnName("STATUS_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatusMessage)
                .HasColumnName("STATUS_MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(1000)
                .IsUnicode(false);
        });
	}
}
