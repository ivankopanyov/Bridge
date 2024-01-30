namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ReportsParams
{
    public string? ReportId { get; set; }
    public string? ReportName { get; set; }
    public string? ReportDescription { get; set; }
    public string? ParamName { get; set; }
    public string? ParamValue { get; set; }
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

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReportsParams>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REPORTS_PARAMS");

            entity.Property(e => e.Debug)
                .HasColumnName("DEBUG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Destination)
                .HasColumnName("DESTINATION")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.ParamName)
                .HasColumnName("PARAM_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ParamValue)
                .HasColumnName("PARAM_VALUE")
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

            entity.Property(e => e.ReportType)
                .HasColumnName("REPORT_TYPE")
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

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(1000)
                .IsUnicode(false);
        });
	}
}
