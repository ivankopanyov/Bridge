namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiScRoomblockFact
{
    public decimal? BookId { get; set; }
    public string? Resort { get; set; }
    public decimal? NoOfNights { get; set; }
    public string? ScRoomCategory { get; set; }
    public string? ScRoomLabel { get; set; }
    public string? PmsRoomCategory { get; set; }
    public string? PmsRoomLabel { get; set; }
    public string? RoomStatusCode { get; set; }
    public DateTime? AllotmentDate { get; set; }
    public string? SnapshotType { get; set; }
    public string? IgnoreOffsetYn { get; set; }
    public string? OffsetType { get; set; }
    public decimal? AvailableRooms { get; set; }
    public decimal? CurrentRooms { get; set; }
    public decimal? ContractRooms { get; set; }
    public decimal? PickupRooms { get; set; }
    public decimal? InitialRooms { get; set; }
    public decimal? Rate1 { get; set; }
    public decimal? Rate2 { get; set; }
    public decimal? Rate3 { get; set; }
    public decimal? Rate4 { get; set; }
    public decimal? ProjOcc1 { get; set; }
    public decimal? ProjOcc2 { get; set; }
    public decimal? ProjOcc3 { get; set; }
    public decimal? ProjOcc4 { get; set; }
    public decimal? PickupOcc1 { get; set; }
    public decimal? PickupOcc2 { get; set; }
    public decimal? PickupOcc3 { get; set; }
    public decimal? PickupOcc4 { get; set; }
    public decimal? ContractOcc1 { get; set; }
    public decimal? ContractOcc2 { get; set; }
    public decimal? ContractOcc3 { get; set; }
    public decimal? ContractOcc4 { get; set; }
    public decimal? ExpectedRooms { get; set; }
    public decimal? SnapshotOcc1 { get; set; }
    public decimal? SnapshotOcc2 { get; set; }
    public decimal? SnapshotOcc3 { get; set; }
    public decimal? SnapshotOcc4 { get; set; }
    public decimal? SnapshotRate1 { get; set; }
    public decimal? SnapshotRate2 { get; set; }
    public decimal? SnapshotRate3 { get; set; }
    public decimal? SnapshotRate4 { get; set; }
    public decimal? SnapshotQuantity { get; set; }
    public decimal? OffsetOcc1 { get; set; }
    public decimal? OffsetOcc2 { get; set; }
    public decimal? OffsetOcc3 { get; set; }
    public decimal? OffsetOcc4 { get; set; }
    public decimal? OffsetPocc1 { get; set; }
    public decimal? OffsetPocc2 { get; set; }
    public decimal? OffsetPocc3 { get; set; }
    public decimal? OffsetPocc4 { get; set; }
    public decimal? OffsetRate1 { get; set; }
    public decimal? OffsetRate2 { get; set; }
    public decimal? OffsetRate3 { get; set; }
    public decimal? OffsetRate4 { get; set; }
    public decimal? AvgBlockedRate { get; set; }
    public decimal? AvgContractRate { get; set; }
    public decimal? AvgOffsetRate { get; set; }
    public decimal? AvgPickupRate { get; set; }
    public decimal? AvgSnapshotRate { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? ContractRevenue { get; set; }
    public decimal? PickupRevenue { get; set; }
    public decimal? SnapshotRevenue { get; set; }
    public decimal? OffsetRooms { get; set; }
    public decimal? OffsetRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiScRoomblockFact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SC_ROOMBLOCK_FACT");

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AvailableRooms)
                .HasColumnName("AVAILABLE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgBlockedRate)
                .HasColumnName("AVG_BLOCKED_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgContractRate)
                .HasColumnName("AVG_CONTRACT_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgOffsetRate)
                .HasColumnName("AVG_OFFSET_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgPickupRate)
                .HasColumnName("AVG_PICKUP_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgSnapshotRate)
                .HasColumnName("AVG_SNAPSHOT_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractOcc1)
                .HasColumnName("CONTRACT_OCC1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractOcc2)
                .HasColumnName("CONTRACT_OCC2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractOcc3)
                .HasColumnName("CONTRACT_OCC3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractOcc4)
                .HasColumnName("CONTRACT_OCC4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractRevenue)
                .HasColumnName("CONTRACT_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractRooms)
                .HasColumnName("CONTRACT_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrentRooms)
                .HasColumnName("CURRENT_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRooms)
                .HasColumnName("EXPECTED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IgnoreOffsetYn)
                .HasColumnName("IGNORE_OFFSET_YN")
                .IsUnicode(false);

            entity.Property(e => e.InitialRooms)
                .HasColumnName("INITIAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfNights)
                .HasColumnName("NO_OF_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetOcc1)
                .HasColumnName("OFFSET_OCC1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetOcc2)
                .HasColumnName("OFFSET_OCC2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetOcc3)
                .HasColumnName("OFFSET_OCC3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetOcc4)
                .HasColumnName("OFFSET_OCC4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetPocc1)
                .HasColumnName("OFFSET_POCC1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetPocc2)
                .HasColumnName("OFFSET_POCC2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetPocc3)
                .HasColumnName("OFFSET_POCC3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetPocc4)
                .HasColumnName("OFFSET_POCC4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetRate1)
                .HasColumnName("OFFSET_RATE1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetRate2)
                .HasColumnName("OFFSET_RATE2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetRate3)
                .HasColumnName("OFFSET_RATE3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetRate4)
                .HasColumnName("OFFSET_RATE4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetRevenue)
                .HasColumnName("OFFSET_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetRooms)
                .HasColumnName("OFFSET_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetType)
                .HasColumnName("OFFSET_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.PickupOcc1)
                .HasColumnName("PICKUP_OCC1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickupOcc2)
                .HasColumnName("PICKUP_OCC2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickupOcc3)
                .HasColumnName("PICKUP_OCC3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickupOcc4)
                .HasColumnName("PICKUP_OCC4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickupRevenue)
                .HasColumnName("PICKUP_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickupRooms)
                .HasColumnName("PICKUP_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsRoomCategory)
                .HasColumnName("PMS_ROOM_CATEGORY")
                .IsUnicode(false);

            entity.Property(e => e.PmsRoomLabel)
                .HasColumnName("PMS_ROOM_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.ProjOcc1)
                .HasColumnName("PROJ_OCC1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProjOcc2)
                .HasColumnName("PROJ_OCC2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProjOcc3)
                .HasColumnName("PROJ_OCC3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProjOcc4)
                .HasColumnName("PROJ_OCC4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate1)
                .HasColumnName("RATE1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate2)
                .HasColumnName("RATE2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate3)
                .HasColumnName("RATE3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate4)
                .HasColumnName("RATE4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomStatusCode)
                .HasColumnName("ROOM_STATUS_CODE")
                .IsUnicode(false);

            entity.Property(e => e.ScRoomCategory)
                .HasColumnName("SC_ROOM_CATEGORY")
                .IsUnicode(false);

            entity.Property(e => e.ScRoomLabel)
                .HasColumnName("SC_ROOM_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.SnapshotOcc1)
                .HasColumnName("SNAPSHOT_OCC1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapshotOcc2)
                .HasColumnName("SNAPSHOT_OCC2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapshotOcc3)
                .HasColumnName("SNAPSHOT_OCC3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapshotOcc4)
                .HasColumnName("SNAPSHOT_OCC4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapshotQuantity)
                .HasColumnName("SNAPSHOT_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapshotRate1)
                .HasColumnName("SNAPSHOT_RATE1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapshotRate2)
                .HasColumnName("SNAPSHOT_RATE2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapshotRate3)
                .HasColumnName("SNAPSHOT_RATE3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapshotRate4)
                .HasColumnName("SNAPSHOT_RATE4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapshotRevenue)
                .HasColumnName("SNAPSHOT_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapshotType)
                .HasColumnName("SNAPSHOT_TYPE")
                .IsUnicode(false);
        });
	}
}
