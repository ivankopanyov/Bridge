namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NaFinreportStatus
{
    public string? Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? Reportid { get; set; }
    public string? Status { get; set; }
    public decimal? OrderBy { get; set; }
    public string? InterimYn { get; set; }
    public decimal? RequestId { get; set; }
    public string? LinkedReportId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NaFinreportStatus>(entity =>
        {
            entity.HasKey(e => e.RequestId)
                .HasName("NA_FINREPORT_STATUS_PK");

            entity.ToTable("NA_FINREPORT_STATUS");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate })
                .HasName("NA_FINREP_IND");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InterimYn)
                .HasColumnName("INTERIM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.LinkedReportId)
                .HasColumnName("LINKED_REPORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reportid)
                .HasColumnName("REPORTID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
