namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomRooms
{
    public string? ComponentRoom { get; set; }
    public string? MasterEntryYn { get; set; }
    public string? Resort { get; set; }
    public string? Room { get; set; }
    public decimal? VnPriority { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomRooms>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Room, e.ComponentRoom })
                .HasName("ROOM_ROOMS_PK");

            entity.ToTable("ROOM_ROOMS");

            entity.HasIndex(e => new { e.Resort, e.ComponentRoom })
                .HasName("ROOM_ROOMS_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ComponentRoom)
                .HasColumnName("COMPONENT_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MasterEntryYn)
                .HasColumnName("MASTER_ENTRY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.VnPriority)
                .HasColumnName("VN_PRIORITY")
                .HasColumnType("NUMBER");
        });
	}
}
