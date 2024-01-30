namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEspAward
{
    public decimal? ExportId { get; set; }
    public decimal? RowSequence { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? RecordType { get; set; }
    public string? AwardIndicator { get; set; }
    public string? AwardCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEspAward>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_ESP_AWARD");

            entity.Property(e => e.AwardCode)
                .HasColumnName("AWARD_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AwardIndicator)
                .HasColumnName("AWARD_INDICATOR")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
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
