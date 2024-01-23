namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DmReservationVw
{
    public string RecordType { get; set; }
    public string Resort { get; set; }
    public string RegionCode { get; set; }
    public string ChainCode { get; set; }
    public string ReservationId { get; set; }
    public decimal? ResvNameId { get; set; }
    public DateTime? BusinessDate { get; set; }
    public DateTime? SnapshotDate { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string ReservationStatus { get; set; }
    public string OccupancyType { get; set; }
    public string DeductNondeductReservation { get; set; }
    public string GroupResYn { get; set; }
    public string MarketGroup { get; set; }
    public string MarketGroupDescription { get; set; }
    public string MarketCode { get; set; }
    public string MarketCodeDescription { get; set; }
    public string SourceGroup { get; set; }
    public string SourceGroupDescription { get; set; }
    public string SourceCode { get; set; }
    public string SourceCodeDescription { get; set; }
    public string Channel { get; set; }
    public string ChannelDescription { get; set; }
    public string RateClass { get; set; }
    public string RateClassDescription { get; set; }
    public string RateCategory { get; set; }
    public string RateCategoryDescription { get; set; }
    public string RateCode { get; set; }
    public string RateCodeDescription { get; set; }
    public string PromotionCode { get; set; }
    public string PromotionCodeDescription { get; set; }
    public string VipCode { get; set; }
    public string VipCodeDescription { get; set; }
    public string ResInsertSource { get; set; }
    public string ResInsertSourceType { get; set; }
    public decimal? TotalRevenueNet { get; set; }
    public decimal? RoomsRevenueNet { get; set; }
    public decimal? FBRevenueNet { get; set; }
    public decimal? OtherRevenueNet { get; set; }
    public decimal? NonRevenueNet { get; set; }
    public decimal? TotalRevenueGross { get; set; }
    public decimal? RoomsRevenueGross { get; set; }
    public decimal? FBRevenueGross { get; set; }
    public decimal? OtherRevenueGross { get; set; }
    public decimal? NonRevenueGross { get; set; }
    public decimal? RoomsOccupied { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? Stays { get; set; }
    public decimal? DayUseRooms { get; set; }
    public decimal? DayUsePersons { get; set; }
    public decimal? ArrivalRooms { get; set; }
    public decimal? ArrivalPersons { get; set; }
    public decimal? DepartureRooms { get; set; }
    public decimal? DeparturePersons { get; set; }
    public DateTime? Timestamp { get; set; }
    public string RoomCategory { get; set; }
    public string RoomCategoryCode { get; set; }
    public string RoomCategoryDesc { get; set; }
    public string RoomClassCode { get; set; }
    public string RoomClassDesc { get; set; }
    public decimal? CExchangeRate { get; set; }
    public decimal? CTotalRevenueNet { get; set; }
    public decimal? CRoomsRevenueNet { get; set; }
    public decimal? CFBRevenueNet { get; set; }
    public decimal? COtherRevenueNet { get; set; }
    public decimal? CNonRevenueNet { get; set; }
    public decimal? CTotalRevenueGross { get; set; }
    public decimal? CRoomsRevenueGross { get; set; }
    public decimal? CFBRevenueGross { get; set; }
    public decimal? COtherRevenueGross { get; set; }
    public decimal? CNonRevenueGross { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DmReservationVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DM_RESERVATION_VW");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.ArrivalPersons)
                .HasColumnName("ARRIVAL_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalRooms)
                .HasColumnName("ARRIVAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CExchangeRate)
                .HasColumnName("C_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CFBRevenueGross)
                .HasColumnName("C_F_B_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CFBRevenueNet)
                .HasColumnName("C_F_B_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CNonRevenueGross)
                .HasColumnName("C_NON_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CNonRevenueNet)
                .HasColumnName("C_NON_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.COtherRevenueGross)
                .HasColumnName("C_OTHER_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.COtherRevenueNet)
                .HasColumnName("C_OTHER_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRoomsRevenueGross)
                .HasColumnName("C_ROOMS_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRoomsRevenueNet)
                .HasColumnName("C_ROOMS_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTotalRevenueGross)
                .HasColumnName("C_TOTAL_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTotalRevenueNet)
                .HasColumnName("C_TOTAL_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ChannelDescription)
                .HasColumnName("CHANNEL_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUsePersons)
                .HasColumnName("DAY_USE_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseRooms)
                .HasColumnName("DAY_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeductNondeductReservation)
                .HasColumnName("DEDUCT_NONDEDUCT_RESERVATION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.DeparturePersons)
                .HasColumnName("DEPARTURE_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartureRooms)
                .HasColumnName("DEPARTURE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FBRevenueGross)
                .HasColumnName("F_B_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FBRevenueNet)
                .HasColumnName("F_B_REVENUE_NET")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GroupResYn)
                .HasColumnName("GROUP_RES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketCodeDescription)
                .HasColumnName("MARKET_CODE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MarketGroup)
                .HasColumnName("MARKET_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketGroupDescription)
                .HasColumnName("MARKET_GROUP_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NonRevenueGross)
                .HasColumnName("NON_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenueNet)
                .HasColumnName("NON_REVENUE_NET")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.OccupancyType)
                .HasColumnName("OCCUPANCY_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OtherRevenueGross)
                .HasColumnName("OTHER_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenueNet)
                .HasColumnName("OTHER_REVENUE_NET")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PromotionCode)
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCodeDescription)
                .HasColumnName("PROMOTION_CODE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCategoryDescription)
                .HasColumnName("RATE_CATEGORY_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateClass)
                .HasColumnName("RATE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateClassDescription)
                .HasColumnName("RATE_CLASS_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCodeDescription)
                .HasColumnName("RATE_CODE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResInsertSource)
                .HasColumnName("RES_INSERT_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResInsertSourceType)
                .HasColumnName("RES_INSERT_SOURCE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReservationId)
                .HasColumnName("RESERVATION_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReservationStatus)
                .HasColumnName("RESERVATION_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryCode)
                .HasColumnName("ROOM_CATEGORY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryDesc)
                .HasColumnName("ROOM_CATEGORY_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomClassCode)
                .HasColumnName("ROOM_CLASS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClassDesc)
                .HasColumnName("ROOM_CLASS_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomsOccupied)
                .HasColumnName("ROOMS_OCCUPIED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsRevenueGross)
                .HasColumnName("ROOMS_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsRevenueNet)
                .HasColumnName("ROOMS_REVENUE_NET")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.SnapshotDate)
                .HasColumnName("SNAPSHOT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCodeDescription)
                .HasColumnName("SOURCE_CODE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SourceGroup)
                .HasColumnName("SOURCE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceGroupDescription)
                .HasColumnName("SOURCE_GROUP_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Stays)
                .HasColumnName("STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Timestamp)
                .HasColumnName("TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.TotalRevenueGross)
                .HasColumnName("TOTAL_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueNet)
                .HasColumnName("TOTAL_REVENUE_NET")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.VipCode)
                .HasColumnName("VIP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VipCodeDescription)
                .HasColumnName("VIP_CODE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
