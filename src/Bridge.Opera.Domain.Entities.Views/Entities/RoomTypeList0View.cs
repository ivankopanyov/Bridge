namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RoomTypeList0View
{
    public string? RoomType { get; set; }
    public string? RoomCategory { get; set; }
    public string? LongDescription { get; set; }
    public decimal? PhysicalInventory { get; set; }
    public decimal? OverbookInventory { get; set; }
    public decimal? ExternalSystemInv { get; set; }
    public string? FlowThroughYn { get; set; }
    public decimal? MaxOccupancy { get; set; }
    public string? RoomPreferenceYn { get; set; }
    public string? ComponentRoomCatYn { get; set; }
    public string? RotationGroupYn { get; set; }
    public decimal? DefaultOccupancy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomTypeList0View>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ROOM_TYPE_LIST_0_VIEW");

            entity.Property(e => e.ComponentRoomCatYn)
                .HasColumnName("COMPONENT_ROOM_CAT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DefaultOccupancy)
                .HasColumnName("DEFAULT_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalSystemInv)
                .HasColumnName("EXTERNAL_SYSTEM_INV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FlowThroughYn)
                .HasColumnName("FLOW_THROUGH_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LongDescription)
                .HasColumnName("LONG_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MaxOccupancy)
                .HasColumnName("MAX_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OverbookInventory)
                .HasColumnName("OVERBOOK_INVENTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhysicalInventory)
                .HasColumnName("PHYSICAL_INVENTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomPreferenceYn)
                .HasColumnName("ROOM_PREFERENCE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RotationGroupYn)
                .HasColumnName("ROTATION_GROUP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
