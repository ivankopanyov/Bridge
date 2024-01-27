namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepMatrixTmp
{
    public decimal? ReportId { get; set; }
    public string VerticalCode { get; set; }
    public decimal? VerticalOrder { get; set; }
    public string VerticalDescription { get; set; }
    public string HorizontalCode { get; set; }
    public decimal? HorizontalOrder { get; set; }
    public string HorizontalDescription { get; set; }
    public string ValueCode { get; set; }
    public decimal? ValueOrder { get; set; }
    public string ValueDescription { get; set; }
    public decimal? Amount { get; set; }
    public string FormattedAmount { get; set; }
    public string AmountFormatType { get; set; }
    public string AmountFormatMask { get; set; }
    public string IsTotalYn { get; set; }
    public string PrintLineYn { get; set; }
    public string PeriodMode { get; set; }
    public string ReportMode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepMatrixTmp>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_MATRIX_TMP");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmountFormatMask)
                .HasColumnName("AMOUNT_FORMAT_MASK")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AmountFormatType)
                .HasColumnName("AMOUNT_FORMAT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FormattedAmount)
                .HasColumnName("FORMATTED_AMOUNT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HorizontalCode)
                .HasColumnName("HORIZONTAL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HorizontalDescription)
                .HasColumnName("HORIZONTAL_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HorizontalOrder)
                .HasColumnName("HORIZONTAL_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsTotalYn)
                .HasColumnName("IS_TOTAL_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PeriodMode)
                .HasColumnName("PERIOD_MODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PrintLineYn)
                .HasColumnName("PRINT_LINE_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportMode)
                .HasColumnName("REPORT_MODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ValueCode)
                .HasColumnName("VALUE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ValueDescription)
                .HasColumnName("VALUE_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ValueOrder)
                .HasColumnName("VALUE_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VerticalCode)
                .HasColumnName("VERTICAL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.VerticalDescription)
                .HasColumnName("VERTICAL_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.VerticalOrder)
                .HasColumnName("VERTICAL_ORDER")
                .HasColumnType("NUMBER");
        });
	}
}
