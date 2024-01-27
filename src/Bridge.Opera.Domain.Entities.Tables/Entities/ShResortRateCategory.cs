namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ShResortRateCategory
{
    public string Resort { get; set; }
    public string RateCategory { get; set; }
    public string LastRoomAvailability { get; set; }
    public decimal? DefaultNoOrRooms { get; set; }
    public string EntitlementsYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ShResortRateCategory>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateCategory })
                .HasName("SH_RESORT_RATE_CATEGORY_PK");

            entity.ToTable("SH_RESORT_RATE_CATEGORY");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultNoOrRooms)
                .HasColumnName("DEFAULT_NO_OR_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EntitlementsYn)
                .HasColumnName("ENTITLEMENTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LastRoomAvailability)
                .HasColumnName("LAST_ROOM_AVAILABILITY")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
