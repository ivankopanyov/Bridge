namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUpeBase
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public string IsoLanguageCode { get; set; }
    public string RetransmissionIndicator { get; set; }
    public decimal? Iteration { get; set; }
    public string HotelCode { get; set; }
    public string HotelName { get; set; }
    public string CurrencyCode { get; set; }
    public string CountryCode { get; set; }
    public string RateCode { get; set; }
    public string RateCurrencyCode { get; set; }
    public decimal? RateAmount1 { get; set; }
    public decimal? RateAmount2 { get; set; }
    public decimal? RateAmount3 { get; set; }
    public decimal? RateAmount4 { get; set; }
    public decimal? RateAmount5 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUpeBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_UPE_BASE");

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HotelName)
                .HasColumnName("HOTEL_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IsoLanguageCode)
                .HasColumnName("ISO_LANGUAGE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Iteration)
                .HasColumnName("ITERATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount1)
                .HasColumnName("RATE_AMOUNT1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount2)
                .HasColumnName("RATE_AMOUNT2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount3)
                .HasColumnName("RATE_AMOUNT3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount4)
                .HasColumnName("RATE_AMOUNT4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount5)
                .HasColumnName("RATE_AMOUNT5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCurrencyCode)
                .HasColumnName("RATE_CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RetransmissionIndicator)
                .HasColumnName("RETRANSMISSION_INDICATOR")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
