namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ShRateCategoryRoomTypes
{
    public string? Resort { get; set; }
    public string? RateCategory { get; set; }
    public string? RoomCategory { get; set; }
    public decimal? DisplaySeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ShRateCategoryRoomTypes>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateCategory, e.RoomCategory })
                .HasName("SH_RATE_CATEGORY_ROOM_TYPES_PK");

            entity.ToTable("SH_RATE_CATEGORY_ROOM_TYPES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DisplaySeq)
                .HasColumnName("DISPLAY_SEQ")
                .HasColumnType("NUMBER");
        });
	}
}
