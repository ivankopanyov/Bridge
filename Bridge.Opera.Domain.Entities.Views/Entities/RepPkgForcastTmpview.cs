namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepPkgForcastTmpview
{
    public decimal? ReportId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? Number1 { get; set; }
    public DateTime? StayDate { get; set; }
    public string StayDateChar { get; set; }
    public string InResort { get; set; }
    public string InRepType { get; set; }
    public DateTime? InFromDate { get; set; }
    public DateTime? InToDate { get; set; }
    public string InForcastGrpList { get; set; }
    public string InProductList { get; set; }
    public string InRoomClassList { get; set; }
    public string InResvType { get; set; }
    public string InInclBlocksYn { get; set; }
    public string InInclResvDetails { get; set; }
    public decimal? TotalPkgs { get; set; }
    public string ArrivalDayYn { get; set; }
    public string StayDay { get; set; }
    public decimal? PkgQty { get; set; }
    public string CalculationRule { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? Persons { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? NoOfRooms { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? GuestNameId { get; set; }
    public string Room { get; set; }
    public string RoomCategory { get; set; }
    public string RoomCategoryLabel { get; set; }
    public string RoomClass { get; set; }
    public string GuestFirstName { get; set; }
    public string GuestName { get; set; }
    public string DisplayName { get; set; }
    public string ResvStatus { get; set; }
    public string ComputedResvStatus { get; set; }
    public string ResStatus { get; set; }
    public string RateCode { get; set; }
    public string Products { get; set; }
    public string ProductId { get; set; }
    public string PosNextDayYn { get; set; }
    public string GuaranteeCode { get; set; }
    public string ReserveInventoryYn { get; set; }
    public string PkgForcastGroup { get; set; }
    public string GroupSellSeq { get; set; }
    public decimal? RoomsOccupied { get; set; }
    public decimal? AdultsInHouse { get; set; }
    public decimal? ChildrenInHouse { get; set; }
    public decimal? ArrivalPersons { get; set; }
    public decimal? DeparturePersons { get; set; }
    public string ConfirmationNo { get; set; }
    public string RowType { get; set; }
    public string ProductDesc { get; set; }
    public string DataType { get; set; }
    public string BookedRoomCategory { get; set; }
    public string BookedRoomCategoryLabel { get; set; }
    public string ForecastNextDayYn { get; set; }
    public decimal? Children1 { get; set; }
    public decimal? Children2 { get; set; }
    public decimal? Children3 { get; set; }
    public decimal? Children4 { get; set; }
    public decimal? Children5 { get; set; }
    public decimal? ArrivalRooms { get; set; }
    public decimal? DepartureRooms { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepPkgForcastTmpview>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_PKG_FORCAST_TMPVIEW");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdultsInHouse)
                .HasColumnName("ADULTS_IN_HOUSE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDayYn)
                .HasColumnName("ARRIVAL_DAY_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalPersons)
                .HasColumnName("ARRIVAL_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalRooms)
                .HasColumnName("ARRIVAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookedRoomCategory)
                .HasColumnName("BOOKED_ROOM_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BookedRoomCategoryLabel)
                .HasColumnName("BOOKED_ROOM_CATEGORY_LABEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CalculationRule)
                .HasColumnName("CALCULATION_RULE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children1)
                .HasColumnName("CHILDREN1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children2)
                .HasColumnName("CHILDREN2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children3)
                .HasColumnName("CHILDREN3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children4)
                .HasColumnName("CHILDREN4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children5)
                .HasColumnName("CHILDREN5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildrenInHouse)
                .HasColumnName("CHILDREN_IN_HOUSE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DataType)
                .HasColumnName("DATA_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DeparturePersons)
                .HasColumnName("DEPARTURE_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartureRooms)
                .HasColumnName("DEPARTURE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ForecastNextDayYn)
                .HasColumnName("FORECAST_NEXT_DAY_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GroupSellSeq)
                .HasColumnName("GROUP_SELL_SEQ")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InForcastGrpList)
                .HasColumnName("IN_FORCAST_GRP_LIST")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InFromDate)
                .HasColumnName("IN_FROM_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InInclBlocksYn)
                .HasColumnName("IN_INCL_BLOCKS_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InInclResvDetails)
                .HasColumnName("IN_INCL_RESV_DETAILS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InProductList)
                .HasColumnName("IN_PRODUCT_LIST")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InRepType)
                .HasColumnName("IN_REP_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InResort)
                .HasColumnName("IN_RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InResvType)
                .HasColumnName("IN_RESV_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InRoomClassList)
                .HasColumnName("IN_ROOM_CLASS_LIST")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InToDate)
                .HasColumnName("IN_TO_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Number1)
                .HasColumnName("NUMBER1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Persons)
                .HasColumnName("PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgForcastGroup)
                .HasColumnName("PKG_FORCAST_GROUP")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PkgQty)
                .HasColumnName("PKG_QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PosNextDayYn)
                .HasColumnName("POS_NEXT_DAY_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ProductDesc)
                .HasColumnName("PRODUCT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ProductId)
                .HasColumnName("PRODUCT_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Products)
                .HasColumnName("PRODUCTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResStatus)
                .HasColumnName("RES_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReserveInventoryYn)
                .HasColumnName("RESERVE_INVENTORY_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomsOccupied)
                .HasColumnName("ROOMS_OCCUPIED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowType)
                .HasColumnName("ROW_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StayDateChar)
                .HasColumnName("STAY_DATE_CHAR")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StayDay)
                .HasColumnName("STAY_DAY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TotalPkgs)
                .HasColumnName("TOTAL_PKGS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");
        });
	}
}
