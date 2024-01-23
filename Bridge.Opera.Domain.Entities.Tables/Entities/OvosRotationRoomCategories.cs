namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosRotationRoomCategories
{
    public decimal Id { get; set; }
    public string RoomCategory { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosRotationRoomCategories>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.RoomCategory })
                .HasName("ORRC_PK");

            entity.ToTable("OVOS_ROTATION_ROOM_CATEGORIES");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");
        });
	}
}
