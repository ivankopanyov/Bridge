namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RoomClassDailySold
{
    public string Resort { get; set; }
    public DateTime ReservationDate { get; set; }
    public string RoomClass { get; set; }
    public decimal? Ooo { get; set; }
    public decimal? Sold { get; set; }
    public decimal? OwnerOoo { get; set; }
    public decimal? OwnerSold { get; set; }
    public decimal? SuiteRoomTypes { get; set; }
    public decimal? PhysicalRoomTypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomClassDailySold>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ROOM_CLASS_DAILY_SOLD");

            entity.Property(e => e.Ooo)
                .HasColumnName("OOO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerOoo)
                .HasColumnName("OWNER_OOO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerSold)
                .HasColumnName("OWNER_SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhysicalRoomTypes)
                .HasColumnName("PHYSICAL_ROOM_TYPES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Sold)
                .HasColumnName("SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SuiteRoomTypes)
                .HasColumnName("SUITE_ROOM_TYPES")
                .HasColumnType("NUMBER");
        });
	}
}
