namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEspRate
{
    public decimal? ExportId { get; set; }
    public decimal? RowSequence { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? RecordType { get; set; }
    public string? RateCode { get; set; }
    public string? RateIndicator { get; set; }
    public decimal? RateNights { get; set; }
    public decimal? EligibleRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEspRate>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_ESP_RATE");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EligibleRevenue)
                .HasColumnName("ELIGIBLE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateIndicator)
                .HasColumnName("RATE_INDICATOR")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RateNights)
                .HasColumnName("RATE_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowSequence)
                .HasColumnName("ROW_SEQUENCE")
                .HasColumnType("NUMBER");
        });
	}
}
