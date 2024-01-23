namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DmStayextendedVw
{
    public string Resort { get; set; }
    public decimal? ReservationId { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string RegionCode { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public DateTime? DateOfReservation { get; set; }
    public DateTime? DateOfCancellation { get; set; }
    public string ReservationStatus { get; set; }
    public string OccupancyType { get; set; }
    public string MarketGroup { get; set; }
    public string MarketGroupDesc { get; set; }
    public string MarketCode { get; set; }
    public string MarketCodeDesc { get; set; }
    public string SourceGroup { get; set; }
    public string SourceGroupDesc { get; set; }
    public string SourceCode { get; set; }
    public string SourceCodeDesc { get; set; }
    public string Channel { get; set; }
    public string ChannelDesc { get; set; }
    public string RateClass { get; set; }
    public string RateClassDesc { get; set; }
    public string RateCategory { get; set; }
    public string RateCategoryDesc { get; set; }
    public string RateCode { get; set; }
    public string RateCodeDesc { get; set; }
    public string RoomCategoryId { get; set; }
    public string RoomCategoryCode { get; set; }
    public string RoomCategoryDesc { get; set; }
    public string RoomClass { get; set; }
    public string RoomClassDesc { get; set; }
    public string PromotionCode { get; set; }
    public string PromotionCodeDesc { get; set; }
    public string VipCode { get; set; }
    public string VipCodeDesc { get; set; }
    public string NationalityCountryCode { get; set; }
    public string NationalityCountryDesc { get; set; }
    public string NationalityRegionCode { get; set; }
    public string NationalityRegionDesc { get; set; }
    public string ResidenceRegionCode { get; set; }
    public string ResidenceRegionDesc { get; set; }
    public string ResidenceCountryCode { get; set; }
    public string ResidenceCountryDesc { get; set; }
    public string ResidenceCity { get; set; }
    public string ResidenceState { get; set; }
    public string ResidenceStateDesc { get; set; }
    public string ResidenceZipCode { get; set; }
    public string Gender { get; set; }
    public string WalkinYn { get; set; }
    public string UpgradeReasonCode { get; set; }
    public string UpgradeReasonDesc { get; set; }
    public string DiscountReasonCode { get; set; }
    public string DiscountReasonDesc { get; set; }
    public string GroupReservationYn { get; set; }
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
    public decimal? Nights { get; set; }
    public decimal? NoShowRooms { get; set; }
    public decimal? NoShowPersons { get; set; }
    public decimal? NoShowReservations { get; set; }
    public decimal? CancelledRooms { get; set; }
    public decimal? CancelledPersons { get; set; }
    public decimal? CancelledReservations { get; set; }
    public decimal? DayUseRooms { get; set; }
    public decimal? DayUsePersons { get; set; }
    public decimal? Cribs { get; set; }
    public decimal? ExtraBeds { get; set; }
    public decimal? ArrivalRooms { get; set; }
    public decimal? ArrivalPersons { get; set; }
    public decimal? DepartureRooms { get; set; }
    public decimal? DeparturePersons { get; set; }
    public DateTime? Timestamp { get; set; }
    public string FgMembershipNumber { get; set; }
    public string FgMembershipClass { get; set; }
    public string FgMembershipClassDesc { get; set; }
    public string FgMembershipType { get; set; }
    public string FgMembershipTypeDesc { get; set; }
    public string FgMembershipLevel { get; set; }
    public string FgMembershipLevelDesc { get; set; }
    public string FfMembershipNumber { get; set; }
    public string FfMembershipClass { get; set; }
    public string FfMembershipClassDesc { get; set; }
    public string FfMembershipType { get; set; }
    public string FfMembershipTypeDesc { get; set; }
    public string FfMembershipLevel { get; set; }
    public string FfMembershipLevelDesc { get; set; }
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
		modelBuilder.Entity<DmStayextendedVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DM_STAYEXTENDED_VW");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
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

            entity.Property(e => e.CancelledPersons)
                .HasColumnName("CANCELLED_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelledReservations)
                .HasColumnName("CANCELLED_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelledRooms)
                .HasColumnName("CANCELLED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ChannelDesc)
                .HasColumnName("CHANNEL_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cribs)
                .HasColumnName("CRIBS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DateOfCancellation)
                .HasColumnName("DATE_OF_CANCELLATION")
                .HasColumnType("DATE");

            entity.Property(e => e.DateOfReservation)
                .HasColumnName("DATE_OF_RESERVATION")
                .HasColumnType("DATE");

            entity.Property(e => e.DayUsePersons)
                .HasColumnName("DAY_USE_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseRooms)
                .HasColumnName("DAY_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DeparturePersons)
                .HasColumnName("DEPARTURE_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartureRooms)
                .HasColumnName("DEPARTURE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountReasonCode)
                .HasColumnName("DISCOUNT_REASON_CODE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.DiscountReasonDesc)
                .HasColumnName("DISCOUNT_REASON_DESC")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.ExtraBeds)
                .HasColumnName("EXTRA_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FBRevenueGross)
                .HasColumnName("F_B_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FBRevenueNet)
                .HasColumnName("F_B_REVENUE_NET")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FfMembershipClass)
                .HasColumnName("FF_MEMBERSHIP_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FfMembershipClassDesc)
                .HasColumnName("FF_MEMBERSHIP_CLASS_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FfMembershipLevel)
                .HasColumnName("FF_MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FfMembershipLevelDesc)
                .HasColumnName("FF_MEMBERSHIP_LEVEL_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FfMembershipNumber)
                .HasColumnName("FF_MEMBERSHIP_NUMBER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FfMembershipType)
                .HasColumnName("FF_MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FfMembershipTypeDesc)
                .HasColumnName("FF_MEMBERSHIP_TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FgMembershipClass)
                .HasColumnName("FG_MEMBERSHIP_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FgMembershipClassDesc)
                .HasColumnName("FG_MEMBERSHIP_CLASS_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FgMembershipLevel)
                .HasColumnName("FG_MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FgMembershipLevelDesc)
                .HasColumnName("FG_MEMBERSHIP_LEVEL_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FgMembershipNumber)
                .HasColumnName("FG_MEMBERSHIP_NUMBER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FgMembershipType)
                .HasColumnName("FG_MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FgMembershipTypeDesc)
                .HasColumnName("FG_MEMBERSHIP_TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Gender)
                .HasColumnName("GENDER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GroupReservationYn)
                .HasColumnName("GROUP_RESERVATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketCodeDesc)
                .HasColumnName("MARKET_CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MarketGroup)
                .HasColumnName("MARKET_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketGroupDesc)
                .HasColumnName("MARKET_GROUP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NationalityCountryCode)
                .HasColumnName("NATIONALITY_COUNTRY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NationalityCountryDesc)
                .HasColumnName("NATIONALITY_COUNTRY_DESC")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.NationalityRegionCode)
                .HasColumnName("NATIONALITY_REGION_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.NationalityRegionDesc)
                .HasColumnName("NATIONALITY_REGION_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowPersons)
                .HasColumnName("NO_SHOW_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowReservations)
                .HasColumnName("NO_SHOW_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRooms)
                .HasColumnName("NO_SHOW_ROOMS")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.PromotionCodeDesc)
                .HasColumnName("PROMOTION_CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCategoryDesc)
                .HasColumnName("RATE_CATEGORY_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateClass)
                .HasColumnName("RATE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateClassDesc)
                .HasColumnName("RATE_CLASS_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCodeDesc)
                .HasColumnName("RATE_CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.ReservationId)
                .HasColumnName("RESERVATION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationStatus)
                .HasColumnName("RESERVATION_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResidenceCity)
                .HasColumnName("RESIDENCE_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ResidenceCountryCode)
                .HasColumnName("RESIDENCE_COUNTRY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResidenceCountryDesc)
                .HasColumnName("RESIDENCE_COUNTRY_DESC")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.ResidenceRegionCode)
                .HasColumnName("RESIDENCE_REGION_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.ResidenceRegionDesc)
                .HasColumnName("RESIDENCE_REGION_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResidenceState)
                .HasColumnName("RESIDENCE_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ResidenceStateDesc)
                .HasColumnName("RESIDENCE_STATE_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ResidenceZipCode)
                .HasColumnName("RESIDENCE_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
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

            entity.Property(e => e.RoomCategoryId)
                .HasColumnName("ROOM_CATEGORY_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
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

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCodeDesc)
                .HasColumnName("SOURCE_CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SourceGroup)
                .HasColumnName("SOURCE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceGroupDesc)
                .HasColumnName("SOURCE_GROUP_DESC")
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

            entity.Property(e => e.UpgradeReasonCode)
                .HasColumnName("UPGRADE_REASON_CODE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.UpgradeReasonDesc)
                .HasColumnName("UPGRADE_REASON_DESC")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.VipCode)
                .HasColumnName("VIP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VipCodeDesc)
                .HasColumnName("VIP_CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.WalkinYn)
                .HasColumnName("WALKIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
