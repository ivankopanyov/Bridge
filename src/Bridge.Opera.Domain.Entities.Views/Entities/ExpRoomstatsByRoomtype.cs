namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpRoomstatsByRoomtype
{
    public string? Resort { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomCategoryLabel { get; set; }
    public string? Description { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? NoRooms { get; set; }
    public decimal? NoAdults { get; set; }
    public decimal? NoChildren { get; set; }
    public decimal? TotalAvailRooms { get; set; }
    public decimal? TotalMaxOccupancy { get; set; }
    public decimal? OoRooms { get; set; }
    public decimal? OsRooms { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpRoomstatsByRoomtype>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_ROOMSTATS_BY_ROOMTYPE");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NoAdults)
                .HasColumnName("NO_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoChildren)
                .HasColumnName("NO_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoRooms)
                .HasColumnName("NO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OoRooms)
                .HasColumnName("OO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OsRooms)
                .HasColumnName("OS_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalAvailRooms)
                .HasColumnName("TOTAL_AVAIL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalMaxOccupancy)
                .HasColumnName("TOTAL_MAX_OCCUPANCY")
                .HasColumnType("NUMBER");
        });
	}
}
