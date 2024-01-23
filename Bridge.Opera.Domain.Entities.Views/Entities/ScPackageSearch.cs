namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScPackageSearch
{
    public decimal? Duration { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string PkgCode { get; set; }
    public decimal? PkgId { get; set; }
    public string PkgName { get; set; }
    public string Resort { get; set; }
    public decimal? AttendeesMin { get; set; }
    public decimal? AttendeesMax { get; set; }
    public string Bookingtype { get; set; }
    public DateTime? BookEnd { get; set; }
    public DateTime? BookStart { get; set; }
    public string PriceDesc { get; set; }
    public string FlatRateYn { get; set; }
    public string MarketCode { get; set; }
    public decimal? PkgLink { get; set; }
    public decimal? PkgPriceId { get; set; }
    public string PriceCode { get; set; }
    public DateTime? SellEnd { get; set; }
    public DateTime? SellStart { get; set; }
    public decimal? TotalPrice { get; set; }
    public string TemplateYn { get; set; }
    public string PkgWebBookingYn { get; set; }
    public string PkgPriceWebBookingYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScPackageSearch>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_PACKAGE_SEARCH");

            entity.Property(e => e.AttendeesMax)
                .HasColumnName("ATTENDEES_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttendeesMin)
                .HasColumnName("ATTENDEES_MIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookEnd)
                .HasColumnName("BOOK_END")
                .HasColumnType("DATE");

            entity.Property(e => e.BookStart)
                .HasColumnName("BOOK_START")
                .HasColumnType("DATE");

            entity.Property(e => e.Bookingtype)
                .HasColumnName("BOOKINGTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Duration)
                .HasColumnName("DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlatRateYn)
                .HasColumnName("FLAT_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PkgCode)
                .HasColumnName("PKG_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgLink)
                .HasColumnName("PKG_LINK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgName)
                .HasColumnName("PKG_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PkgPriceId)
                .HasColumnName("PKG_PRICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgPriceWebBookingYn)
                .HasColumnName("PKG_PRICE_WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PkgWebBookingYn)
                .HasColumnName("PKG_WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PriceCode)
                .HasColumnName("PRICE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PriceDesc)
                .HasColumnName("PRICE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellEnd)
                .HasColumnName("SELL_END")
                .HasColumnType("DATE");

            entity.Property(e => e.SellStart)
                .HasColumnName("SELL_START")
                .HasColumnType("DATE");

            entity.Property(e => e.TemplateYn)
                .HasColumnName("TEMPLATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TotalPrice)
                .HasColumnName("TOTAL_PRICE")
                .HasColumnType("NUMBER");
        });
	}
}
