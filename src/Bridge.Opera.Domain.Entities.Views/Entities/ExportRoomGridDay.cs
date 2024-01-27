namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExportRoomGridDay
{
    public string RecordType { get; set; }
    public string SourceSystem { get; set; }
    public string PropertyCode { get; set; }
    public string TransactionType { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? CompanyNameId { get; set; }
    public DateTime? AllotmentDate { get; set; }
    public string BookingStatus { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? CutoffDate { get; set; }
    public string RoomCategoryCode { get; set; }
    public string RoomClass { get; set; }
    public decimal? ProjectedOcc1 { get; set; }
    public decimal? ProjectedOcc2 { get; set; }
    public decimal? ProjectedOcc3 { get; set; }
    public decimal? ProjectedOcc4 { get; set; }
    public decimal? RateAmount1 { get; set; }
    public decimal? RateAmount2 { get; set; }
    public decimal? RateAmount3 { get; set; }
    public decimal? RateAmount4 { get; set; }
    public decimal? ToSell { get; set; }
    public decimal? BlockedRev { get; set; }
    public decimal? Contract { get; set; }
    public decimal? Pickup { get; set; }
    public decimal? ZeroRateNights { get; set; }
    public decimal? ActualGuestRoomRevenue { get; set; }
    public decimal? ProjectedRooms { get; set; }
    public decimal? ProjectedRev { get; set; }
    public decimal? SuperBlockId { get; set; }
    public string SuperBlockResort { get; set; }
    public string BlockCode { get; set; }
    public string PaymentMethod { get; set; }
    public string Bookingmethod { get; set; }
    public string GuaranteeCode { get; set; }
    public string Udfc06 { get; set; }
    public string RmsCurrencyCode { get; set; }
    public decimal? OriginalRooms { get; set; }
    public decimal? SnapProjectedOcc1 { get; set; }
    public decimal? SnapProjectedOcc2 { get; set; }
    public decimal? SnapProjectedOcc3 { get; set; }
    public decimal? SnapProjectedOcc4 { get; set; }
    public decimal? SnapRateAmountOcc1 { get; set; }
    public decimal? SnapRateAmountOcc2 { get; set; }
    public decimal? SnapRateAmountOcc3 { get; set; }
    public decimal? SnapRateAmountOcc4 { get; set; }
    public decimal? PickupOcc1 { get; set; }
    public decimal? PickupOcc2 { get; set; }
    public decimal? PickupOcc3 { get; set; }
    public decimal? PickupOcc4 { get; set; }
    public decimal? RateAmount1Net { get; set; }
    public decimal? RateAmount2Net { get; set; }
    public decimal? RateAmount3Net { get; set; }
    public decimal? RateAmount4Net { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExportRoomGridDay>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXPORT_ROOM_GRID_DAY");

            entity.Property(e => e.ActualGuestRoomRevenue)
                .HasColumnName("ACTUAL_GUEST_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BlockedRev)
                .HasColumnName("BLOCKED_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingStatus)
                .HasColumnName("BOOKING_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.Bookingmethod)
                .HasColumnName("BOOKINGMETHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompanyNameId)
                .HasColumnName("COMPANY_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Contract)
                .HasColumnName("CONTRACT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CutoffDate)
                .HasColumnName("CUTOFF_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OriginalRooms)
                .HasColumnName("ORIGINAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Pickup)
                .HasColumnName("PICKUP")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.ProjectedOcc1)
                .HasColumnName("PROJECTED_OCC1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProjectedOcc2)
                .HasColumnName("PROJECTED_OCC2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProjectedOcc3)
                .HasColumnName("PROJECTED_OCC3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProjectedOcc4)
                .HasColumnName("PROJECTED_OCC4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProjectedRev)
                .HasColumnName("PROJECTED_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProjectedRooms)
                .HasColumnName("PROJECTED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateAmount1)
                .HasColumnName("RATE_AMOUNT_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount1Net)
                .HasColumnName("RATE_AMOUNT_1_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount2)
                .HasColumnName("RATE_AMOUNT_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount2Net)
                .HasColumnName("RATE_AMOUNT_2_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount3)
                .HasColumnName("RATE_AMOUNT_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount3Net)
                .HasColumnName("RATE_AMOUNT_3_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount4)
                .HasColumnName("RATE_AMOUNT_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount4Net)
                .HasColumnName("RATE_AMOUNT_4_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.RmsCurrencyCode)
                .HasColumnName("RMS_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryCode)
                .HasColumnName("ROOM_CATEGORY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SnapProjectedOcc1)
                .HasColumnName("SNAP_PROJECTED_OCC1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapProjectedOcc2)
                .HasColumnName("SNAP_PROJECTED_OCC2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapProjectedOcc3)
                .HasColumnName("SNAP_PROJECTED_OCC3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapProjectedOcc4)
                .HasColumnName("SNAP_PROJECTED_OCC4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapRateAmountOcc1)
                .HasColumnName("SNAP_RATE_AMOUNT_OCC1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapRateAmountOcc2)
                .HasColumnName("SNAP_RATE_AMOUNT_OCC2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapRateAmountOcc3)
                .HasColumnName("SNAP_RATE_AMOUNT_OCC3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SnapRateAmountOcc4)
                .HasColumnName("SNAP_RATE_AMOUNT_OCC4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SuperBlockId)
                .HasColumnName("SUPER_BLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SuperBlockResort)
                .HasColumnName("SUPER_BLOCK_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToSell)
                .HasColumnName("TO_SELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransactionType)
                .HasColumnName("TRANSACTION_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ZeroRateNights)
                .HasColumnName("ZERO_RATE_NIGHTS")
                .HasColumnType("NUMBER");
        });
	}
}
