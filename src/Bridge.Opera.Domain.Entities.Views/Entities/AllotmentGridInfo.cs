namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AllotmentGridInfo
{
    public decimal AllotmentDetailId { get; set; }
    public string Resort { get; set; }
    public decimal AllotmentHeaderId { get; set; }
    public DateTime GridDate { get; set; }
    public string RoomCategory { get; set; }
    public string AllotmentCode { get; set; }
    public DateTime AllotmentBeginDate { get; set; }
    public DateTime AllotmentEndDate { get; set; }
    public string AllotmentState { get; set; }
    public string AllotmentStatus { get; set; }
    public string RoomCategoryLabel { get; set; }
    public DateTime? CutoffDate { get; set; }
    public decimal? ForcastedToSell { get; set; }
    public decimal? ToSell { get; set; }
    public decimal? Sold { get; set; }
    public decimal? Released { get; set; }
    public decimal? Elastic { get; set; }
    public decimal? ElasticSold { get; set; }
    public decimal? RateAmount1 { get; set; }
    public decimal? RateAmount2 { get; set; }
    public decimal? RateAmount3 { get; set; }
    public decimal? RateAmount4 { get; set; }
    public decimal? RateAmountAp { get; set; }
    public decimal? RateAmountChild { get; set; }
    public decimal? Contract { get; set; }
    public decimal? ContractOcc1 { get; set; }
    public decimal? ContractOcc2 { get; set; }
    public decimal? ContractOcc3 { get; set; }
    public decimal? ContractOcc4 { get; set; }
    public decimal? ProjectedOcc1 { get; set; }
    public decimal? ProjectedOcc2 { get; set; }
    public decimal? ProjectedOcc3 { get; set; }
    public decimal? ProjectedOcc4 { get; set; }
    public decimal? PickupOcc1 { get; set; }
    public decimal? PickupOcc2 { get; set; }
    public decimal? PickupOcc3 { get; set; }
    public decimal? PickupOcc4 { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public decimal? Allotted { get; set; }
    public string ReserveInventoryYn { get; set; }
    public decimal? ReservedCheckedinCnt { get; set; }
    public decimal? DeductAllotted { get; set; }
    public decimal? Available { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentGridInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ALLOTMENT_GRID_INFO");

            entity.Property(e => e.AllotmentBeginDate)
                .HasColumnName("ALLOTMENT_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AllotmentCode)
                .IsRequired()
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentDetailId)
                .HasColumnName("ALLOTMENT_DETAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentEndDate)
                .HasColumnName("ALLOTMENT_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentState)
                .HasColumnName("ALLOTMENT_STATE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentStatus)
                .IsRequired()
                .HasColumnName("ALLOTMENT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Allotted)
                .HasColumnName("ALLOTTED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Available)
                .HasColumnName("AVAILABLE")
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

            entity.Property(e => e.DeductAllotted)
                .HasColumnName("DEDUCT_ALLOTTED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Elastic)
                .HasColumnName("ELASTIC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ElasticSold)
                .HasColumnName("ELASTIC_SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForcastedToSell)
                .HasColumnName("FORCASTED_TO_SELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GridDate)
                .HasColumnName("GRID_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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

            entity.Property(e => e.ReserveInventoryYn)
                .HasColumnName("RESERVE_INVENTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ReservedCheckedinCnt)
                .HasColumnName("RESERVED_CHECKEDIN_CNT")
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

            entity.Property(e => e.RoomCategoryLabel)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Sold)
                .HasColumnName("SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToSell)
                .HasColumnName("TO_SELL")
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
