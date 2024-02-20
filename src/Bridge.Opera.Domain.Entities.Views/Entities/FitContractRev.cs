namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FitContractRev
{
    public decimal? ReportId { get; set; }
    public string? ColLabel { get; set; }
    public decimal? Projected { get; set; }
    public decimal? LastYearActual { get; set; }
    public decimal? LastYear1Actual { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FitContractRev>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIT_CONTRACT_REV");

            entity.Property(e => e.ColLabel)
                .HasColumnName("COL_LABEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LastYear1Actual)
                .HasColumnName("LAST_YEAR_1_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastYearActual)
                .HasColumnName("LAST_YEAR_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Projected)
                .HasColumnName("PROJECTED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");
        });
	}
}
