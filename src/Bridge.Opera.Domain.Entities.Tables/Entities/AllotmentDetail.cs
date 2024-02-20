namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AllotmentDetail
{
    public decimal? AllotmentDetailId { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? Resort { get; set; }
    public string? RoomCategory { get; set; }
    public string? ScRoomCategory { get; set; }
    public DateTime? AllotmentDate { get; set; }
    public string? RoomClass { get; set; }
    public decimal? ToSell { get; set; }
    public decimal? ForcastedToSell { get; set; }
    public decimal? Elastic { get; set; }
    public decimal? Sold { get; set; }
    public decimal? ElasticSold { get; set; }
    public decimal? Released { get; set; }
    public string? ShoulderYn { get; set; }
    public decimal? RateAmount1 { get; set; }
    public decimal? RateAmount2 { get; set; }
    public decimal? RateAmount3 { get; set; }
    public decimal? RateAmount4 { get; set; }
    public decimal? RateAmountAp { get; set; }
    public decimal? ActionId { get; set; }
    public decimal? DmlSeqNo { get; set; }
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
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? CutoffDate { get; set; }
    public string? RecordType { get; set; }
    public decimal? InventoryDeduct { get; set; }
    public DateTime? InventoryDate { get; set; }
    public decimal? BookingPosition { get; set; }
    public decimal? SubBlockPickup { get; set; }
    public decimal? MaterializationAmnt { get; set; }
    public DateTime? ChangeDate { get; set; }
    public string? DiscountReasonCode { get; set; }
    public decimal? DiscountAmt { get; set; }
    public decimal? DiscountPct { get; set; }
    public string? FixedRateYn { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }
    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentDetail>(entity =>
        {
            entity.HasKey(e => new { e.AllotmentDetailId, e.AllotmentHeaderId, e.Resort })
                .HasName("ALLOTMENT_DETAIL_PK");

            entity.ToTable("ALLOTMENT$DETAIL");

            entity.HasIndex(e => new { e.Resort, e.CutoffDate })
                .HasName("ALLOTMENT_CUTOFF_IDX");

            entity.HasIndex(e => new { e.Resort, e.AllotmentDate, e.RoomCategory })
                .HasName("ALLOTMENT_DATE_RCAT");

            entity.HasIndex(e => new { e.Resort, e.AllotmentHeaderId, e.AllotmentDate })
                .HasName("ALLOTMENT_HID_DATE");

            entity.HasIndex(e => new { e.Resort, e.ChangeDate, e.AllotmentHeaderId })
                .HasName("ALLOT_RESORT_HEADERID_UPD");

            entity.HasIndex(e => new { e.Resort, e.RoomCategory, e.AllotmentHeaderId })
                .HasName("ALLOTMENT_RESORT_RCAT");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort, e.RecordType, e.RoomCategory, e.AllotmentDate })
                .HasName("ALLOTMENT_DETAIL_U1")
                .IsUnique();

            entity.Property(e => e.AllotmentDetailId)
                .HasColumnName("ALLOTMENT_DETAIL_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BookingPosition)
                .HasColumnName("BOOKING_POSITION")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChangeDate)
                .HasColumnName("CHANGE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Contract)
                .HasColumnName("CONTRACT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ContractOcc1)
                .HasColumnName("CONTRACT_OCC1")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ContractOcc2)
                .HasColumnName("CONTRACT_OCC2")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ContractOcc3)
                .HasColumnName("CONTRACT_OCC3")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ContractOcc4)
                .HasColumnName("CONTRACT_OCC4")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CutoffDate)
                .HasColumnName("CUTOFF_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

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
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ElasticSold)
                .HasColumnName("ELASTIC_SOLD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FixedRateYn)
                .HasColumnName("FIXED_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ForcastedToSell)
                .HasColumnName("FORCASTED_TO_SELL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InventoryDate)
                .HasColumnName("INVENTORY_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InventoryDeduct)
                .HasColumnName("INVENTORY_DEDUCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.MaterializationAmnt)
                .HasColumnName("MATERIALIZATION_AMNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PhysicalConversionFactor)
                .HasColumnName("PHYSICAL_CONVERSION_FACTOR")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PickupOcc1)
                .HasColumnName("PICKUP_OCC1")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PickupOcc2)
                .HasColumnName("PICKUP_OCC2")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PickupOcc3)
                .HasColumnName("PICKUP_OCC3")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PickupOcc4)
                .HasColumnName("PICKUP_OCC4")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

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
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProjectedOcc2)
                .HasColumnName("PROJECTED_OCC2")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProjectedOcc3)
                .HasColumnName("PROJECTED_OCC3")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProjectedOcc4)
                .HasColumnName("PROJECTED_OCC4")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateAmount1)
                .HasColumnName("RATE_AMOUNT_1")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateAmount2)
                .HasColumnName("RATE_AMOUNT_2")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateAmount3)
                .HasColumnName("RATE_AMOUNT_3")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateAmount4)
                .HasColumnName("RATE_AMOUNT_4")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateAmountAp)
                .HasColumnName("RATE_AMOUNT_AP")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateAmountChild)
                .HasColumnName("RATE_AMOUNT_CHILD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RecordType)
                .IsRequired()
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Released)
                .HasColumnName("RELEASED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ScRoomCategory)
                .HasColumnName("SC_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShoulderYn)
                .HasColumnName("SHOULDER_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Sold)
                .HasColumnName("SOLD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SubBlockPickup)
                .HasColumnName("SUB_BLOCK_PICKUP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToSell)
                .HasColumnName("TO_SELL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.AllotmentDetail)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ALLOTMENT_DETAIL_FK2");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.AllotmentDetail)
	                .HasForeignKey(d => new { d.AllotmentHeaderId, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ALLOTMENT_DETAIL_FK1");
        });
	}
}
