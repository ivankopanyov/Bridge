namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempRoomClass
{
    public string SessionId { get; set; }
    public string RoomClass { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempRoomClass>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_ROOM_CLASS");

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SessionId)
                .HasColumnName("SESSION_ID")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
