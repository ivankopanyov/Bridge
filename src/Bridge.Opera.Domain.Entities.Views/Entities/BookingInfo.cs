namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BookingInfo
{
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public decimal? RmsBlocked { get; set; }
    public decimal? RmsReserved { get; set; }
    public decimal? RmsAvail { get; set; }
    public decimal? RevBlocked { get; set; }
    public decimal? RevReserved { get; set; }
    public decimal? RevExpected { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BookingInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOOKING_INFO");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevBlocked)
                .HasColumnName("REV_BLOCKED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevExpected)
                .HasColumnName("REV_EXPECTED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevReserved)
                .HasColumnName("REV_RESERVED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmsAvail)
                .HasColumnName("RMS_AVAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmsBlocked)
                .HasColumnName("RMS_BLOCKED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmsReserved)
                .HasColumnName("RMS_RESERVED")
                .HasColumnType("NUMBER");
        });
	}
}
