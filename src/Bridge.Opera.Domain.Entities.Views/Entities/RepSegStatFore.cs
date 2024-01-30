namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepSegStatFore
{
    public string? Resort { get; set; }
    public string? RecType { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public string? MarketCode { get; set; }
    public string? SourceCode { get; set; }
    public string? Channel { get; set; }
    public string? Country { get; set; }
    public decimal? RoomNights { get; set; }
    public decimal? NetRoomRevenue { get; set; }
    public decimal? RoomRevenueTax { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? TotalGuest { get; set; }
    public decimal? TotalNoAvailRooms { get; set; }
    public decimal? TotalNoSoldRooms { get; set; }
    public decimal? LengthOfStay { get; set; }
    public decimal? MemRoomNights { get; set; }
    public decimal? MemNetRoomRevenue { get; set; }
    public decimal? MemRoomRevenueTax { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepSegStatFore>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_SEG_STAT_FORE");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LengthOfStay)
                .HasColumnName("LENGTH_OF_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemNetRoomRevenue)
                .HasColumnName("MEM_NET_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemRoomNights)
                .HasColumnName("MEM_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MemRoomRevenueTax)
                .HasColumnName("MEM_ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetRoomRevenue)
                .HasColumnName("NET_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecType)
                .HasColumnName("REC_TYPE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomNights)
                .HasColumnName("ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueTax)
                .HasColumnName("ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalGuest)
                .HasColumnName("TOTAL_GUEST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNoAvailRooms)
                .HasColumnName("TOTAL_NO_AVAIL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNoSoldRooms)
                .HasColumnName("TOTAL_NO_SOLD_ROOMS")
                .HasColumnType("NUMBER");
        });
	}
}
