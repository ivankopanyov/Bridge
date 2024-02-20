namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsRateroomPrice
{
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? RoomCategory { get; set; }
    public DateTime? ReservationDate { get; set; }
    public decimal? Amount1 { get; set; }
    public decimal? Amount2 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRateroomPrice>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ReservationDate, e.RateCode, e.RoomCategory })
                .HasName("GDS_RATEROOM_PRICE_PK");

            entity.ToTable("GDS_RATEROOM_PRICE");

            entity.HasIndex(e => new { e.Resort, e.ReservationDate, e.Amount1 })
                .HasName("GDS_RATEROOM_PRICE_IND1");

            entity.HasIndex(e => new { e.Resort, e.ReservationDate, e.Amount2 })
                .HasName("GDS_RATEROOM_PRICE_IND2");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Amount1)
                .HasColumnName("AMOUNT_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount2)
                .HasColumnName("AMOUNT_2")
                .HasColumnType("NUMBER");
        });
	}
}
