namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepPeriodReports
{
    public decimal? ReportId { get; set; }
    public string MasterValue { get; set; }
    public decimal? MasterValueOrder { get; set; }
    public string Description { get; set; }
    public string SubGrp1 { get; set; }
    public decimal? SubGrp1Order { get; set; }
    public string Heading1 { get; set; }
    public string Heading2 { get; set; }
    public decimal? Heading1Order { get; set; }
    public decimal? Amount { get; set; }
    public string FormattedAmount { get; set; }
    public decimal? LastYear01 { get; set; }
    public string AmountFormatType { get; set; }
    public string PrintLineAfterYn { get; set; }
    public string PeriodMode { get; set; }
    public string ReportMode { get; set; }
    public string Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepPeriodReports>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_PERIOD_REPORTS");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmountFormatType)
                .HasColumnName("AMOUNT_FORMAT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FormattedAmount)
                .HasColumnName("FORMATTED_AMOUNT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Heading1)
                .HasColumnName("HEADING_1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Heading1Order)
                .HasColumnName("HEADING_1_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Heading2)
                .HasColumnName("HEADING_2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LastYear01)
                .HasColumnName("LAST_YEAR_01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterValue)
                .HasColumnName("MASTER_VALUE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MasterValueOrder)
                .HasColumnName("MASTER_VALUE_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PeriodMode)
                .HasColumnName("PERIOD_MODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PrintLineAfterYn)
                .HasColumnName("PRINT_LINE_AFTER_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportMode)
                .HasColumnName("REPORT_MODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SubGrp1)
                .HasColumnName("SUB_GRP_1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SubGrp1Order)
                .HasColumnName("SUB_GRP_1_ORDER")
                .HasColumnType("NUMBER");
        });
	}
}
