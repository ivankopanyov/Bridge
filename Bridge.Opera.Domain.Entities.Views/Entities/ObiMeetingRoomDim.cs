namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiMeetingRoomDim
{
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string Resort { get; set; }
    public string Room { get; set; }
    public string RoomCategory { get; set; }
    public string Description { get; set; }
    public string RoomClass { get; set; }
    public string RoomStatus { get; set; }
    public decimal? OrderBy { get; set; }
    public string Location { get; set; }
    public string SpaceType { get; set; }
    public string Floor { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiMeetingRoomDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_MEETING_ROOM_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.Floor)
                .HasColumnName("FLOOR")
                .IsUnicode(false);

            entity.Property(e => e.Location)
                .HasColumnName("LOCATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomStatus)
                .HasColumnName("ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SpaceType)
                .HasColumnName("SPACE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
