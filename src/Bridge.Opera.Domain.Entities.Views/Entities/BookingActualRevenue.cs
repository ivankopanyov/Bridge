namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BookingActualRevenue
{
    public string ResortBooked { get; set; }
    public decimal ProfileId { get; set; }
    public decimal BookId { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Description { get; set; }
    public string CurrencyCode { get; set; }
    public string Resort { get; set; }
    public decimal? Rooms { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? AvgRate { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public string Status { get; set; }
    public string BookingStatus { get; set; }
    public string LostToDestination { get; set; }
    public string LostToProperty { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BookingActualRevenue>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOOKING_ACTUAL_REVENUE");

            entity.Property(e => e.AvgRate)
                .HasColumnName("AVG_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingStatus)
                .IsRequired()
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LostToDestination)
                .HasColumnName("LOST_TO_DESTINATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LostToProperty)
                .HasColumnName("LOST_TO_PROPERTY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileId)
                .HasColumnName("PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortBooked)
                .HasColumnName("RESORT_BOOKED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rooms)
                .HasColumnName("ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
