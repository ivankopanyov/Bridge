namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AllotmentDetail1
{
    public decimal? AllotmentHeaderId { get; set; }
    public string? Resort { get; set; }
    public string? RoomCategory { get; set; }
    public DateTime? AllotmentDate { get; set; }
    public string? ScRoomCategory { get; set; }
    public string? RoomClass { get; set; }
    public string? ShoulderYn { get; set; }
    public decimal? ForcastedToSell { get; set; }
    public decimal? ToSell { get; set; }
    public decimal? Sold { get; set; }
    public decimal? Released { get; set; }
    public decimal? RateAmount1 { get; set; }
    public decimal? RateAmount2 { get; set; }
    public decimal? RateAmount3 { get; set; }
    public decimal? RateAmount4 { get; set; }
    public decimal? RateAmountAp { get; set; }
    public decimal? RateAmountChild { get; set; }
    public decimal? PhysicalConversionFactor { get; set; }
    public decimal? Contract { get; set; }
    public decimal? ProjectedOcc1 { get; set; }
    public decimal? ProjectedOcc2 { get; set; }
    public decimal? ProjectedOcc3 { get; set; }
    public decimal? ProjectedOcc4 { get; set; }
    public decimal? PickupOcc1 { get; set; }
    public decimal? PickupOcc2 { get; set; }
    public decimal? PickupOcc3 { get; set; }
    public decimal? PickupOcc4 { get; set; }
    public decimal? PickupRate1 { get; set; }
    public decimal? PickupRate2 { get; set; }
    public decimal? PickupRate3 { get; set; }
    public decimal? PickupRate4 { get; set; }
    public decimal? PickupRateap { get; set; }
    public decimal? ContractOcc1 { get; set; }
    public decimal? ContractOcc2 { get; set; }
    public decimal? ContractOcc3 { get; set; }
    public decimal? ContractOcc4 { get; set; }
    public byte? LaptopChange { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? CutoffDate { get; set; }
    public decimal? DmlSeqNo { get; set; }
    public decimal? TotToSell { get; set; }
    public decimal? BookingPosition { get; set; }
    public decimal? Elastic { get; set; }
    public decimal? SubBlockPickup { get; set; }
    public decimal? MaterializationAmnt { get; set; }
    public decimal? CalcMaterialization { get; set; }
    public decimal? DiscountAmt { get; set; }
    public decimal? DiscountPct { get; set; }
    public string? DiscountReasonCode { get; set; }
    public string? FixedRateYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentDetail1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ALLOTMENT_DETAIL");

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingPosition)
                .HasColumnName("BOOKING_POSITION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CalcMaterialization)
                .HasColumnName("CALC_MATERIALIZATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Contract)
                .HasColumnName("CONTRACT")
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

            entity.Property(e => e.CutoffDate)
                .HasColumnName("CUTOFF_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DiscountAmt)
                .HasColumnName("DISCOUNT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountPct)
                .HasColumnName("DISCOUNT_PCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountReasonCode)
                .HasColumnName("DISCOUNT_REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DmlSeqNo)
                .HasColumnName("DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Elastic)
                .HasColumnName("ELASTIC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FixedRateYn)
                .HasColumnName("FIXED_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ForcastedToSell)
                .HasColumnName("FORCASTED_TO_SELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.MaterializationAmnt)
                .HasColumnName("MATERIALIZATION_AMNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhysicalConversionFactor)
                .HasColumnName("PHYSICAL_CONVERSION_FACTOR")
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

            entity.Property(e => e.PickupRate1)
                .HasColumnName("PICKUP_RATE1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickupRate2)
                .HasColumnName("PICKUP_RATE2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickupRate3)
                .HasColumnName("PICKUP_RATE3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickupRate4)
                .HasColumnName("PICKUP_RATE4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickupRateap)
                .HasColumnName("PICKUP_RATEAP")
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

            entity.Property(e => e.RateAmount1)
                .HasColumnName("RATE_AMOUNT_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount2)
                .HasColumnName("RATE_AMOUNT_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount3)
                .HasColumnName("RATE_AMOUNT_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount4)
                .HasColumnName("RATE_AMOUNT_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmountAp)
                .HasColumnName("RATE_AMOUNT_AP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmountChild)
                .HasColumnName("RATE_AMOUNT_CHILD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Released)
                .HasColumnName("RELEASED")
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

            entity.Property(e => e.ScRoomCategory)
                .HasColumnName("SC_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShoulderYn)
                .HasColumnName("SHOULDER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Sold)
                .HasColumnName("SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SubBlockPickup)
                .HasColumnName("SUB_BLOCK_PICKUP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToSell)
                .HasColumnName("TO_SELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotToSell)
                .HasColumnName("TOT_TO_SELL")
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
