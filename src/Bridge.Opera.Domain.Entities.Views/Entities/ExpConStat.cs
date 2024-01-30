namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConStat
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? StatGrpId { get; set; }
    public decimal? StatId { get; set; }
    public decimal? StatAppSetNoOfRecords { get; set; }
    public string? ReportCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConStat>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_STAT");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportCode)
                .HasColumnName("REPORT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StatAppSetNoOfRecords)
                .HasColumnName("STAT_APP_SET_NO_OF_RECORDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatGrpId)
                .HasColumnName("STAT_GRP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatId)
                .HasColumnName("STAT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
