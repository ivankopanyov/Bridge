namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AllotmentOffsets
{
    public decimal? AllotmentHeaderId { get; set; }
    public string? Resort { get; set; }
    public string? OffsetType { get; set; }
    public string? RoomCategory { get; set; }
    public DateTime? AllotmentDate { get; set; }
    public string? ScRoomCategory { get; set; }
    public string? RoomClass { get; set; }
    public string? ShoulderYn { get; set; }
    public decimal? TotalRooms { get; set; }
    public decimal? RoomsOcc1 { get; set; }
    public decimal? RoomsOcc2 { get; set; }
    public decimal? RoomsOcc3 { get; set; }
    public decimal? RoomsOcc4 { get; set; }
    public decimal? RateAmount1 { get; set; }
    public decimal? RateAmount2 { get; set; }
    public decimal? RateAmount3 { get; set; }
    public decimal? RateAmount4 { get; set; }
    public decimal? PickupOcc1 { get; set; }
    public decimal? PickupOcc2 { get; set; }
    public decimal? PickupOcc3 { get; set; }
    public decimal? PickupOcc4 { get; set; }
    public string? IgnoreOffsetYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? InternalCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentOffsets>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ALLOTMENT_OFFSETS");

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IgnoreOffsetYn)
                .HasColumnName("IGNORE_OFFSET_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalCode)
                .IsRequired()
                .HasColumnName("INTERNAL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.RateAmount1)
                .HasColumnName("RATE_AMOUNT1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount2)
                .HasColumnName("RATE_AMOUNT2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount3)
                .HasColumnName("RATE_AMOUNT3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount4)
                .HasColumnName("RATE_AMOUNT4")
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
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomsOcc1)
                .HasColumnName("ROOMS_OCC1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsOcc2)
                .HasColumnName("ROOMS_OCC2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsOcc3)
                .HasColumnName("ROOMS_OCC3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsOcc4)
                .HasColumnName("ROOMS_OCC4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ScRoomCategory)
                .HasColumnName("SC_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShoulderYn)
                .HasColumnName("SHOULDER_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.TotalRooms)
                .HasColumnName("TOTAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
