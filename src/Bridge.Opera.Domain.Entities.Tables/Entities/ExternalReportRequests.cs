namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExternalReportRequests
{
    public ExternalReportRequests()
    {
        ExternalReportRequestParams = new HashSet<ExternalReportRequestParams>();
    }

    public string? Resort { get; set; }
    public decimal? OperaRequestId { get; set; }
    public string? ExternalSystem { get; set; }
    public string? ExternalRequestId { get; set; }
    public string? ReportType { get; set; }
    public decimal? OperaModuleId { get; set; }
    public DateTime? RequestDateTime { get; set; }
    public decimal? RequestedBy { get; set; }
    public string? RequestStatus { get; set; }
    public DateTime? RequestAcknowledgedDateTime { get; set; }
    public DateTime? ResponseGeneratedDateTime { get; set; }
    public DateTime? ResponseReceivedDateTime { get; set; }
    public DateTime? ResponseProcessedDateTime { get; set; }
    public string? FailureReason { get; set; }

    public virtual ICollection<ExternalReportRequestParams> ExternalReportRequestParams { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExternalReportRequests>(entity =>
        {
            entity.HasKey(e => e.OperaRequestId)
                .HasName("EXTERNAL_REPORT_REQUESTS_PK");

            entity.ToTable("EXTERNAL_REPORT_REQUESTS");

            entity.HasIndex(e => new { e.Resort, e.RequestedBy, e.RequestDateTime })
                .HasName("EXTERNAL_REPORT_REQUESTS_IDX1");

            entity.Property(e => e.OperaRequestId)
                .HasColumnName("OPERA_REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalRequestId)
                .HasColumnName("EXTERNAL_REQUEST_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ExternalSystem)
                .HasColumnName("EXTERNAL_SYSTEM")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FailureReason)
                .HasColumnName("FAILURE_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OperaModuleId)
                .HasColumnName("OPERA_MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportType)
                .HasColumnName("REPORT_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RequestAcknowledgedDateTime)
                .HasColumnName("REQUEST_ACKNOWLEDGED_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.RequestDateTime)
                .HasColumnName("REQUEST_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.RequestStatus)
                .IsRequired()
                .HasColumnName("REQUEST_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RequestedBy)
                .HasColumnName("REQUESTED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResponseGeneratedDateTime)
                .HasColumnName("RESPONSE_GENERATED_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.ResponseProcessedDateTime)
                .HasColumnName("RESPONSE_PROCESSED_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.ResponseReceivedDateTime)
                .HasColumnName("RESPONSE_RECEIVED_DATE_TIME")
                .HasColumnType("DATE");
        
			if (!types.Contains(typeof(ExternalReportRequestParams)))
				entity.Ignore(e => e.ExternalReportRequestParams);
		});
	}
}
