namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpdRoomcatstat
{
    public string RowKey { get; set; }
    public DateTime RowTimestamp { get; set; }
    public string Resort { get; set; }
    public DateTime BusinessDate { get; set; }
    public string RoomCategory { get; set; }
    public string RoomClass { get; set; }
    public decimal ExistingRooms { get; set; }
    public decimal? OoRooms { get; set; }
    public decimal? OsRooms { get; set; }
    public decimal? ExistingBeds { get; set; }
    public decimal? OoBeds { get; set; }
    public decimal? OsBeds { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpdRoomcatstat>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXPD_ROOMCATSTAT");

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

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");
        });
	}
}
