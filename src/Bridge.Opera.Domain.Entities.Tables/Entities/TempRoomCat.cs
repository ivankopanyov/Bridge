namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempRoomCat
{
    public string? SessionId { get; set; }
    public string? RoomCat { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempRoomCat>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_ROOM_CAT");

            entity.Property(e => e.RoomCat)
                .HasColumnName("ROOM_CAT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SessionId)
                .HasColumnName("SESSION_ID")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
