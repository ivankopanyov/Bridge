namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpRoomTypeBase
{
    public string RowKey { get; set; }
    public DateTime RowTimestamp { get; set; }
    public string Resort { get; set; }
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string RoomClass { get; set; }
    public string RoomClassDesc { get; set; }
    public string RoomCategoryCode { get; set; }
    public string RoomCategoryDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public string RoomCategoryLabel { get; set; }
    public string ShortDescription { get; set; }
    public string RoomClassCent { get; set; }
    public string PseudoYn { get; set; }
    public string ResortId { get; set; }
    public string RoomClassKey { get; set; }
    public string RoomCategoryCodeKey { get; set; }
    public string AllKey { get; set; }
    public string RoomCategory { get; set; }
    public decimal NumberRooms { get; set; }
    public string LongDescription { get; set; }
    public string Compiled { get; set; }
    public string PsuedoRoomType { get; set; }
    public DateTime? ActiveDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string ReplacesCategory { get; set; }
    public decimal? MaxOccupancy { get; set; }
    public decimal? MaxRollaways { get; set; }
    public string RateCategory { get; set; }
    public string Label { get; set; }
    public string GenericFlag { get; set; }
    public string SuiteYn { get; set; }
    public string MeetingroomYn { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string RateCode { get; set; }
    public decimal? RateAmount { get; set; }
    public decimal? DefOccupancy { get; set; }
    public decimal? ImageId { get; set; }
    public string SendToInterfaceYn { get; set; }
    public string YieldableYn { get; set; }
    public string YieldCategory { get; set; }
    public string Housekeeping { get; set; }
    public string CanDeleteYn { get; set; }
    public string RoominfoUrl { get; set; }
    public string OwnerYn { get; set; }
    public string AutoIncludeYn { get; set; }
    public decimal? InitialRoundUp { get; set; }
    public decimal? Increments { get; set; }
    public string RotationGroup { get; set; }
    public string AutoRoomAssignYn { get; set; }
    public string SalesFlag { get; set; }
    public string UpsellYn { get; set; }
    public decimal? OrmsUpsellRank { get; set; }
    public decimal? OrmsUpsellAmt { get; set; }
    public decimal? OrmsDrxtraAdult { get; set; }
    public decimal? OrmsDrxtraChild { get; set; }
    public decimal? MaxOccupancyAdults { get; set; }
    public decimal? MaxOccupancyChildren { get; set; }
    public string RoomPool { get; set; }
    public string MemberAwardRoomGrp { get; set; }
    public decimal? OrmsDrxtra2ndAdult { get; set; }
    public decimal? OrmsDrtier1 { get; set; }
    public decimal? OrmsDrtier2 { get; set; }
    public decimal? OrmsDrtier3 { get; set; }
    public string AutoCheckinYn { get; set; }
    public decimal? RateFloor { get; set; }
    public decimal? MaxFixBedOccupancy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpRoomTypeBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXP_ROOM_TYPE_BASE");

            entity.Property(e => e.ActiveDate)
                .HasColumnName("ACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.AutoCheckinYn)
                .HasColumnName("AUTO_CHECKIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AutoIncludeYn)
                .HasColumnName("AUTO_INCLUDE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AutoRoomAssignYn)
                .HasColumnName("AUTO_ROOM_ASSIGN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Compiled)
                .HasColumnName("COMPILED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DefOccupancy)
                .HasColumnName("DEF_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GenericFlag)
                .HasColumnName("GENERIC_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Housekeeping)
                .HasColumnName("HOUSEKEEPING")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ImageId)
                .HasColumnName("IMAGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Increments)
                .HasColumnName("INCREMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InitialRoundUp)
                .HasColumnName("INITIAL_ROUND_UP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Label)
                .IsRequired()
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LongDescription)
                .HasColumnName("LONG_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MaxFixBedOccupancy)
                .HasColumnName("MAX_FIX_BED_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxOccupancy)
                .HasColumnName("MAX_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxOccupancyAdults)
                .HasColumnName("MAX_OCCUPANCY_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxOccupancyChildren)
                .HasColumnName("MAX_OCCUPANCY_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxRollaways)
                .HasColumnName("MAX_ROLLAWAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MeetingroomYn)
                .HasColumnName("MEETINGROOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MemberAwardRoomGrp)
                .HasColumnName("MEMBER_AWARD_ROOM_GRP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NumberRooms)
                .HasColumnName("NUMBER_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrmsDrtier1)
                .HasColumnName("ORMS_DRTIER1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrmsDrtier2)
                .HasColumnName("ORMS_DRTIER2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrmsDrtier3)
                .HasColumnName("ORMS_DRTIER3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrmsDrxtra2ndAdult)
                .HasColumnName("ORMS_DRXTRA_2ND_ADULT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrmsDrxtraAdult)
                .HasColumnName("ORMS_DRXTRA_ADULT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrmsDrxtraChild)
                .HasColumnName("ORMS_DRXTRA_CHILD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrmsUpsellAmt)
                .HasColumnName("ORMS_UPSELL_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrmsUpsellRank)
                .HasColumnName("ORMS_UPSELL_RANK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerYn)
                .HasColumnName("OWNER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PseudoYn)
                .HasColumnName("PSEUDO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PsuedoRoomType)
                .HasColumnName("PSUEDO_ROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateFloor)
                .HasColumnName("RATE_FLOOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReplacesCategory)
                .HasColumnName("REPLACES_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .IsRequired()
                .HasColumnName("RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryCode)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryCodeKey)
                .HasColumnName("ROOM_CATEGORY_CODE_KEY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryDesc)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY_DESC")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .IsRequired()
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClassCent)
                .HasColumnName("ROOM_CLASS_CENT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClassDesc)
                .HasColumnName("ROOM_CLASS_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomClassKey)
                .HasColumnName("ROOM_CLASS_KEY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RoomPool)
                .HasColumnName("ROOM_POOL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoominfoUrl)
                .HasColumnName("ROOMINFO_URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RotationGroup)
                .HasColumnName("ROTATION_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(41)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.SalesFlag)
                .HasColumnName("SALES_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SendToInterfaceYn)
                .HasColumnName("SEND_TO_INTERFACE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SuiteYn)
                .HasColumnName("SUITE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpsellYn)
                .HasColumnName("UPSELL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YieldableYn)
                .HasColumnName("YIELDABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
