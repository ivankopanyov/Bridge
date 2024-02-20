namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepProdEvRevenue
{
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public decimal? EventId { get; set; }
    public string? EventStatus { get; set; }
    public decimal? EventOwner { get; set; }
    public string? EventOwnerCode { get; set; }
    public string? MarketCode { get; set; }
    public DateTime? EventStartDate { get; set; }
    public DateTime? EventEndDate { get; set; }
    public DateTime? ProductionDate { get; set; }
    public string? EventLinkType { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepProdEvRevenue>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_PROD_EV_REVENUE");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventEndDate)
                .HasColumnName("EVENT_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventLinkType)
                .HasColumnName("EVENT_LINK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventOwner)
                .HasColumnName("EVENT_OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventOwnerCode)
                .HasColumnName("EVENT_OWNER_CODE")
                .IsUnicode(false);

            entity.Property(e => e.EventStartDate)
                .HasColumnName("EVENT_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventStatus)
                .IsRequired()
                .HasColumnName("EVENT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProductionDate)
                .HasColumnName("PRODUCTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
