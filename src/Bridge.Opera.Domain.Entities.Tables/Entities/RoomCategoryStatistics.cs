namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomCategoryStatistics
{
    public string? Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomClass { get; set; }
    public decimal? ExistingRooms { get; set; }
    public decimal? OoRooms { get; set; }
    public decimal? OsRooms { get; set; }
    public decimal? ExistingBeds { get; set; }
    public decimal? OoBeds { get; set; }
    public decimal? OsBeds { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomCategoryStatistics>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ROOM_CATEGORY_STATISTICS");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate, e.RoomCategory })
                .HasName("ROOM_CATEGORY_STATISTICS_PK")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.BusinessDate, e.RoomClass, e.RoomCategory })
                .HasName("ROOM_CATEGORY_STATISTICS_IND1");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExistingBeds)
                .HasColumnName("EXISTING_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExistingRooms)
                .HasColumnName("EXISTING_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OoBeds)
                .HasColumnName("OO_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OoRooms)
                .HasColumnName("OO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OsBeds)
                .HasColumnName("OS_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OsRooms)
                .HasColumnName("OS_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .IsRequired()
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
