namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HiroRateCode
{
    public string Resort { get; set; }
    public DateTime? ReservationDate { get; set; }
    public string CharReservationDate { get; set; }
    public string RateCode { get; set; }
    public decimal? Authorization { get; set; }
    public decimal? RoomSold { get; set; }
    public decimal? LeftToSell { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HiroRateCode>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HIRO_RATE_CODE");

            entity.Property(e => e.Authorization)
                .HasColumnName("AUTHORIZATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CharReservationDate)
                .HasColumnName("CHAR_RESERVATION_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.LeftToSell)
                .HasColumnName("LEFT_TO_SELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomSold)
                .HasColumnName("ROOM_SOLD")
                .HasColumnType("NUMBER");
        });
	}
}
