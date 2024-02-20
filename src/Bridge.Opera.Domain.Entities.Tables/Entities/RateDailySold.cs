namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateDailySold
{
    public string? Resort { get; set; }
    public string? RoomCategory { get; set; }
    public DateTime? ReservationDate { get; set; }
    public string? ComponentRoomYn { get; set; }
    public decimal? NumberSold { get; set; }
    public string? RoomClass { get; set; }
    public string? OutOfOrderYn { get; set; }
    public decimal? OwnerNumberSold { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateDailySold>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RATE_DAILY_SOLD");

            entity.HasIndex(e => new { e.Resort, e.ReservationDate, e.RoomCategory, e.ComponentRoomYn, e.OutOfOrderYn })
                .HasName("RATE_DAILY_SOLD_UK")
                .IsUnique();

            entity.Property(e => e.ComponentRoomYn)
                .IsRequired()
                .HasColumnName("COMPONENT_ROOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.NumberSold)
                .HasColumnName("NUMBER_SOLD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OutOfOrderYn)
                .HasColumnName("OUT_OF_ORDER_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.OwnerNumberSold)
                .HasColumnName("OWNER_NUMBER_SOLD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
