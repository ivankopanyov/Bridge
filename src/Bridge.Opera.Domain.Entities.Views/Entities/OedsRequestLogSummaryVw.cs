namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OedsRequestLogSummaryVw
{
    public DateTime RequestDate { get; set; }
    public decimal ProcessHour { get; set; }
    public string RequestType { get; set; }
    public decimal TotalOwsSuccessRequest { get; set; }
    public decimal TotalOwsFailRequest { get; set; }
    public decimal TotalOwsTime { get; set; }
    public decimal? AvegOws { get; set; }
    public decimal TotalGdsSuccessRequest { get; set; }
    public decimal TotalGdsFailRequest { get; set; }
    public decimal TotalGdsTime { get; set; }
    public decimal? AvegGds { get; set; }
    public decimal TotalAdsSuccessRequest { get; set; }
    public decimal TotalAdsFailRequest { get; set; }
    public decimal TotalAdsTime { get; set; }
    public decimal? AvegAds { get; set; }
    public decimal TotalUiSuccessRequest { get; set; }
    public decimal TotalUiFailRequest { get; set; }
    public decimal TotalUiTime { get; set; }
    public decimal? AvegUi { get; set; }
    public string MachineName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OedsRequestLogSummaryVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OEDS_REQUEST_LOG_SUMMARY_VW");

            entity.Property(e => e.AvegAds)
                .HasColumnName("AVEG_ADS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvegGds)
                .HasColumnName("AVEG_GDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvegOws)
                .HasColumnName("AVEG_OWS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvegUi)
                .HasColumnName("AVEG_UI")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MachineName)
                .IsRequired()
                .HasColumnName("MACHINE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ProcessHour)
                .HasColumnName("PROCESS_HOUR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestDate)
                .HasColumnName("REQUEST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RequestType)
                .IsRequired()
                .HasColumnName("REQUEST_TYPE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TotalAdsFailRequest)
                .HasColumnName("TOTAL_ADS_FAIL_REQUEST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalAdsSuccessRequest)
                .HasColumnName("TOTAL_ADS_SUCCESS_REQUEST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalAdsTime)
                .HasColumnName("TOTAL_ADS_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalGdsFailRequest)
                .HasColumnName("TOTAL_GDS_FAIL_REQUEST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalGdsSuccessRequest)
                .HasColumnName("TOTAL_GDS_SUCCESS_REQUEST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalGdsTime)
                .HasColumnName("TOTAL_GDS_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOwsFailRequest)
                .HasColumnName("TOTAL_OWS_FAIL_REQUEST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOwsSuccessRequest)
                .HasColumnName("TOTAL_OWS_SUCCESS_REQUEST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOwsTime)
                .HasColumnName("TOTAL_OWS_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalUiFailRequest)
                .HasColumnName("TOTAL_UI_FAIL_REQUEST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalUiSuccessRequest)
                .HasColumnName("TOTAL_UI_SUCCESS_REQUEST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalUiTime)
                .HasColumnName("TOTAL_UI_TIME")
                .HasColumnType("NUMBER");
        });
	}
}
