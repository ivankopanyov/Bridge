namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUpeResvRates
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? RateCode { get; set; }
    public string? MarketCode { get; set; }
    public decimal? ShareAmount { get; set; }
    public string? RateDescription { get; set; }
    public string? CurrencyCode { get; set; }
    public DateTime? RateBeginDate { get; set; }
    public DateTime? RateEndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUpeResvRates>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_UPE_RESV_RATES");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateBeginDate)
                .HasColumnName("RATE_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateDescription)
                .HasColumnName("RATE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateEndDate)
                .HasColumnName("RATE_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareAmount)
                .HasColumnName("SHARE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
