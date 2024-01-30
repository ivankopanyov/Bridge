namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempRoomInventory
{
    public string? Resort { get; set; }
    public string? RoomCategory { get; set; }
    public string? Room { get; set; }
    public string? RoomList { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempRoomInventory>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_ROOM_INVENTORY");

            entity.HasIndex(e => new { e.Resort, e.RoomCategory })
                .HasName("TMP_RM_INV_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomList)
                .HasColumnName("ROOM_LIST")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
