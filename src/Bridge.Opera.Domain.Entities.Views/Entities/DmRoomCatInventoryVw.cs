namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DmRoomCatInventoryVw
{
    public string? Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? RoomCategory { get; set; }
    public string? GenericYn { get; set; }
    public decimal? PhysicalRooms { get; set; }
    public decimal? RoomTypeOverbook { get; set; }
    public decimal? OutOfOrder { get; set; }
    public decimal? AdultsInHouse { get; set; }
    public decimal? ChildrenInHouse { get; set; }
    public decimal? ArrivalRooms { get; set; }
    public decimal? DepartureRooms { get; set; }
    public decimal? DefiniteRooms { get; set; }
    public decimal? DefiniteBlockRooms { get; set; }
    public decimal? DefiniteResvRooms { get; set; }
    public decimal? TentativeRooms { get; set; }
    public decimal? TentativeBlockRooms { get; set; }
    public decimal? TentativeResvRooms { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DmRoomCatInventoryVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DM_ROOM_CAT_INVENTORY_VW");

            entity.Property(e => e.AdultsInHouse)
                .HasColumnName("ADULTS_IN_HOUSE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalRooms)
                .HasColumnName("ARRIVAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChildrenInHouse)
                .HasColumnName("CHILDREN_IN_HOUSE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefiniteBlockRooms)
                .HasColumnName("DEFINITE_BLOCK_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefiniteResvRooms)
                .HasColumnName("DEFINITE_RESV_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefiniteRooms)
                .HasColumnName("DEFINITE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartureRooms)
                .HasColumnName("DEPARTURE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GenericYn)
                .HasColumnName("GENERIC_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OutOfOrder)
                .HasColumnName("OUT_OF_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhysicalRooms)
                .HasColumnName("PHYSICAL_ROOMS")
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

            entity.Property(e => e.RoomTypeOverbook)
                .HasColumnName("ROOM_TYPE_OVERBOOK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TentativeBlockRooms)
                .HasColumnName("TENTATIVE_BLOCK_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TentativeResvRooms)
                .HasColumnName("TENTATIVE_RESV_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TentativeRooms)
                .HasColumnName("TENTATIVE_ROOMS")
                .HasColumnType("NUMBER");
        });
	}
}
