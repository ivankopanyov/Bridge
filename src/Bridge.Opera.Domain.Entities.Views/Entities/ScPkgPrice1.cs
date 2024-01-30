namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScPkgPrice1
{
    public decimal? AttendeesMin { get; set; }
    public decimal? AttendeesMax { get; set; }
    public string? Bookingtype { get; set; }
    public DateTime? BookEnd { get; set; }
    public DateTime? BookStart { get; set; }
    public string? Description { get; set; }
    public string? FlatRateYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? MarketCode { get; set; }
    public decimal? PkgLink { get; set; }
    public decimal? PkgPriceId { get; set; }
    public string? PriceCode { get; set; }
    public DateTime? SellEnd { get; set; }
    public DateTime? SellStart { get; set; }
    public decimal? TotalPrice { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? WebBookingYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScPkgPrice1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_PKG_PRICE");

            entity.Property(e => e.AttendeesMax)
                .HasColumnName("ATTENDEES_MAX")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AttendeesMin)
                .HasColumnName("ATTENDEES_MIN")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BookEnd)
                .HasColumnName("BOOK_END")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BookStart)
                .HasColumnName("BOOK_START")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Bookingtype)
                .HasColumnName("BOOKINGTYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FlatRateYn)
                .HasColumnName("FLAT_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PkgLink)
                .HasColumnName("PKG_LINK")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PkgPriceId)
                .HasColumnName("PKG_PRICE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PriceCode)
                .IsRequired()
                .HasColumnName("PRICE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SellEnd)
                .HasColumnName("SELL_END")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SellStart)
                .HasColumnName("SELL_START")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalPrice)
                .HasColumnName("TOTAL_PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WebBookingYn)
                .HasColumnName("WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
