namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationSummaryLogSync
{
    public decimal? Id { get; set; }
    public DateTime? ChangeDate { get; set; }
    public DateTime? EndChangeDate { get; set; }
    public string Resort { get; set; }
    public string EventType { get; set; }
    public string EventId { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public string RoomCategory { get; set; }
    public string RoomClass { get; set; }
    public string MarketCode { get; set; }
    public string SourceCode { get; set; }
    public string RateCode { get; set; }
    public string RegionCode { get; set; }
    public decimal? GroupId { get; set; }
    public string ResvType { get; set; }
    public string ResvInvType { get; set; }
    public string PsuedoRoomYn { get; set; }
    public decimal? ArrRooms { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? DepRooms { get; set; }
    public decimal? NoRooms { get; set; }
    public decimal? GrossRate { get; set; }
    public decimal? NetRoomRevenue { get; set; }
    public decimal? ExtraRevenue { get; set; }
    public decimal? OoRooms { get; set; }
    public decimal? OsRooms { get; set; }
    public decimal? RemainingBlockRooms { get; set; }
    public decimal? PickedupBlockRooms { get; set; }
    public decimal? SingleOccupancy { get; set; }
    public decimal? MultipleOccupancy { get; set; }
    public string BlockStatus { get; set; }
    public decimal? ArrPersons { get; set; }
    public decimal? DepPersons { get; set; }
    public decimal? WlRooms { get; set; }
    public decimal? WlPersons { get; set; }
    public decimal? DayUseRooms { get; set; }
    public decimal? DayUsePersons { get; set; }
    public string BookingStatus { get; set; }
    public string ResvStatus { get; set; }
    public string DayUseYn { get; set; }
    public string Channel { get; set; }
    public string Country { get; set; }
    public string Nationality { get; set; }
    public decimal? Cribs { get; set; }
    public decimal? ExtraBeds { get; set; }
    public decimal? AdultsTaxFree { get; set; }
    public decimal? ChildrenTaxFree { get; set; }
    public string RateCategory { get; set; }
    public string RateClass { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? NonRevenue { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? RoomRevenueTax { get; set; }
    public decimal? FoodRevenueTax { get; set; }
    public decimal? OtherRevenueTax { get; set; }
    public decimal? TotalRevenueTax { get; set; }
    public decimal? NonRevenueTax { get; set; }
    public string City { get; set; }
    public string ZipCode { get; set; }
    public string District { get; set; }
    public string State { get; set; }
    public decimal? Children1 { get; set; }
    public decimal? Children2 { get; set; }
    public decimal? Children3 { get; set; }
    public decimal? Children4 { get; set; }
    public decimal? Children5 { get; set; }
    public string OwnerFfFlag { get; set; }
    public string OwnerRentalFlag { get; set; }
    public decimal? FcGrossRate { get; set; }
    public decimal? FcNetRoomRevenue { get; set; }
    public decimal? FcExtraRevenue { get; set; }
    public decimal? FcRoomRevenue { get; set; }
    public decimal? FcFoodRevenue { get; set; }
    public decimal? FcOtherRevenue { get; set; }
    public decimal? FcTotalRevenue { get; set; }
    public decimal? FcNonRevenue { get; set; }
    public decimal? FcRoomRevenueTax { get; set; }
    public decimal? FcFoodRevenueTax { get; set; }
    public decimal? FcOtherRevenueTax { get; set; }
    public decimal? FcTotalRevenueTax { get; set; }
    public decimal? FcNonRevenueTax { get; set; }
    public string CurrencyCode { get; set; }
    public DateTime? ExchangeDate { get; set; }
    public DateTime? UpdateBusinessDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string CentralCurrencyCode { get; set; }
    public decimal? CentralExchangeRate { get; set; }
    public string ChangeType { get; set; }
    public string Gender { get; set; }
    public decimal? CompRoomNts { get; set; }
    public string VipStatus { get; set; }
    public decimal? Quantity { get; set; }
    public DateTime? TruncBeginDate { get; set; }
    public DateTime? TruncEndDate { get; set; }
    public DateTime? BusinessDateCreated { get; set; }
    public string ResInsertSource { get; set; }
    public decimal? ParentCompanyId { get; set; }
    public decimal? AgentId { get; set; }
    public string BookedRoomCategory { get; set; }
    public DateTime? PrevUpdateDate { get; set; }
    public string SyncChangeType { get; set; }
    public string OperaRowid { get; set; }
    public string ProcessedYn { get; set; }
    public DateTime? SyncInsertDate { get; set; }
    public decimal? InsertRowSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationSummaryLogSync>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESERVATION_SUMMARY_LOG_SYNC");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdultsTaxFree)
                .HasColumnName("ADULTS_TAX_FREE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentId)
                .HasColumnName("AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrPersons)
                .HasColumnName("ARR_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrRooms)
                .HasColumnName("ARR_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockStatus)
                .HasColumnName("BLOCK_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookedRoomCategory)
                .HasColumnName("BOOKED_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookingStatus)
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.CentralCurrencyCode)
                .HasColumnName("CENTRAL_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CentralExchangeRate)
                .HasColumnName("CENTRAL_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangeDate)
                .HasColumnName("CHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChangeType)
                .HasColumnName("CHANGE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(40)
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

            entity.Property(e => e.ChildrenTaxFree)
                .HasColumnName("CHILDREN_TAX_FREE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CompRoomNts)
                .HasColumnName("COMP_ROOM_NTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Cribs)
                .HasColumnName("CRIBS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DayUsePersons)
                .HasColumnName("DAY_USE_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseRooms)
                .HasColumnName("DAY_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseYn)
                .HasColumnName("DAY_USE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepPersons)
                .HasColumnName("DEP_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepRooms)
                .HasColumnName("DEP_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.District)
                .HasColumnName("DISTRICT")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.EndChangeDate)
                .HasColumnName("END_CHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventType)
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeDate)
                .HasColumnName("EXCHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExtraBeds)
                .HasColumnName("EXTRA_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtraRevenue)
                .HasColumnName("EXTRA_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FcExtraRevenue)
                .HasColumnName("FC_EXTRA_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcFoodRevenue)
                .HasColumnName("FC_FOOD_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcFoodRevenueTax)
                .HasColumnName("FC_FOOD_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcGrossRate)
                .HasColumnName("FC_GROSS_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcNetRoomRevenue)
                .HasColumnName("FC_NET_ROOM_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcNonRevenue)
                .HasColumnName("FC_NON_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcNonRevenueTax)
                .HasColumnName("FC_NON_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcOtherRevenue)
                .HasColumnName("FC_OTHER_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcOtherRevenueTax)
                .HasColumnName("FC_OTHER_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcRoomRevenue)
                .HasColumnName("FC_ROOM_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcRoomRevenueTax)
                .HasColumnName("FC_ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcTotalRevenue)
                .HasColumnName("FC_TOTAL_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FcTotalRevenueTax)
                .HasColumnName("FC_TOTAL_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FoodRevenueTax)
                .HasColumnName("FOOD_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Gender)
                .HasColumnName("GENDER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GrossRate)
                .HasColumnName("GROSS_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertRowSeq)
                .HasColumnName("INSERT_ROW_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MultipleOccupancy)
                .HasColumnName("MULTIPLE_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NetRoomRevenue)
                .HasColumnName("NET_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoRooms)
                .HasColumnName("NO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.NonRevenueTax)
                .HasColumnName("NON_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OoRooms)
                .HasColumnName("OO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperaRowid)
                .HasColumnName("OPERA_ROWID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OsRooms)
                .HasColumnName("OS_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.OtherRevenueTax)
                .HasColumnName("OTHER_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerFfFlag)
                .HasColumnName("OWNER_FF_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OwnerRentalFlag)
                .HasColumnName("OWNER_RENTAL_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ParentCompanyId)
                .HasColumnName("PARENT_COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickedupBlockRooms)
                .HasColumnName("PICKEDUP_BLOCK_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrevUpdateDate)
                .HasColumnName("PREV_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProcessedYn)
                .HasColumnName("PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PsuedoRoomYn)
                .HasColumnName("PSUEDO_ROOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateClass)
                .HasColumnName("RATE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RemainingBlockRooms)
                .HasColumnName("REMAINING_BLOCK_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResInsertSource)
                .HasColumnName("RES_INSERT_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvInvType)
                .HasColumnName("RESV_INV_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvType)
                .HasColumnName("RESV_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RoomRevenueTax)
                .HasColumnName("ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SingleOccupancy)
                .HasColumnName("SINGLE_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SyncChangeType)
                .HasColumnName("SYNC_CHANGE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SyncInsertDate)
                .HasColumnName("SYNC_INSERT_DATE")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRevenueTax)
                .HasColumnName("TOTAL_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TruncBeginDate)
                .HasColumnName("TRUNC_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncEndDate)
                .HasColumnName("TRUNC_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateBusinessDate)
                .HasColumnName("UPDATE_BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WlPersons)
                .HasColumnName("WL_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WlRooms)
                .HasColumnName("WL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
