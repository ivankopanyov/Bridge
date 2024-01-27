namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExternalReportRequestsView
{
    public string Resort { get; set; }
    public decimal OperaRequestId { get; set; }
    public string ExternalSystem { get; set; }
    public string ExternalRequestId { get; set; }
    public string ReportType { get; set; }
    public decimal OperaModuleId { get; set; }
    public string ReportName { get; set; }
    public string ReportDesc { get; set; }
    public DateTime RequestDateTime { get; set; }
    public decimal RequestedBy { get; set; }
    public string RequestStatus { get; set; }
    public DateTime? RequestAcknowledgedDateTime { get; set; }
    public DateTime? ResponseGeneratedDateTime { get; set; }
    public DateTime? ResponseReceivedDateTime { get; set; }
    public DateTime? ResponseProcessedDateTime { get; set; }
    public string FailureReason { get; set; }
    public DateTime? ReportBeginDate { get; set; }
    public DateTime? ReportEndDate { get; set; }
    public string RateCode { get; set; }
    public string RoomCategory { get; set; }
    public string RoomCategoryLabel { get; set; }
    public decimal? BlockId { get; set; }
    public string BlockCode { get; set; }
    public string Duration { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExternalReportRequestsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXTERNAL_REPORT_REQUESTS_VIEW");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BlockId)
                .HasColumnName("BLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Duration)
                .HasColumnName("DURATION")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.OperaRequestId)
                .HasColumnName("OPERA_REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReportBeginDate)
                .HasColumnName("REPORT_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ReportDesc)
                .HasColumnName("REPORT_DESC")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.ReportEndDate)
                .HasColumnName("REPORT_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ReportName)
                .IsRequired()
                .HasColumnName("REPORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

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

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
