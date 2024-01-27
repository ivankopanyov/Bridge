namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProfileStatDaily
{
    public string Resort { get; set; }
    public decimal? NoOfDefinitieRooms { get; set; }
    public decimal? NoOfGuests { get; set; }
    public decimal? SingleOccupancy { get; set; }
    public decimal? MultipleOccupancy { get; set; }
    public decimal? PercentageOccupancy { get; set; }
    public decimal? PercentageMultipleOccupancy { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? TotalRoomRevenue { get; set; }
    public decimal? TotalFBRevenue { get; set; }
    public decimal? TotalOtherRevenue { get; set; }
    public decimal? AverageDayRate { get; set; }
    public decimal? TotalPackageRevenue { get; set; }
    public decimal? TotalPackageRoomRevenue { get; set; }
    public decimal? TotalPackageFBRevenue { get; set; }
    public decimal? TotalPackageOtherRevenue { get; set; }
    public decimal? AveragePackageDayRate { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? TotalRoomTax { get; set; }
    public decimal? TotalFBTax { get; set; }
    public decimal? TotalOtherTax { get; set; }
    public DateTime BusinessDate { get; set; }
    public string RoomType { get; set; }
    public decimal NameId { get; set; }
    public decimal? DayUseRooms { get; set; }
    public decimal? NoShowRooms { get; set; }
    public decimal? CancelRomms { get; set; }
    public decimal? NoShowPersons { get; set; }
    public decimal? DayUsePersons { get; set; }
    public decimal? NoOfDefiniteRoomsMtd { get; set; }
    public decimal? NoOfGuestsMtd { get; set; }
    public decimal? SingleOccupancyMtd { get; set; }
    public decimal? MultipleOccupancyMtd { get; set; }
    public decimal? PercentageOccupancyMtd { get; set; }
    public decimal? PercentageMultOccupancyMtd { get; set; }
    public decimal? TotalRevenueMtd { get; set; }
    public decimal? TotalFBRevenueMtd { get; set; }
    public decimal? TotalRoomRevenueMtd { get; set; }
    public decimal? TotalOtherRevenueMtd { get; set; }
    public decimal? TotalPackageRevenueMtd { get; set; }
    public decimal? TotalPackageRoomRevenueMtd { get; set; }
    public decimal? TotalPackageFBRevenueMtd { get; set; }
    public decimal? TotalPackageOtherRevMtd { get; set; }
    public decimal? TotalTaxMtd { get; set; }
    public decimal? TotalRoomTaxMtd { get; set; }
    public decimal? TotalFBTaxMtd { get; set; }
    public decimal? TotalOtherTaxMtd { get; set; }
    public decimal? AverageDayRateMtd { get; set; }
    public decimal? AveragePackageDayRateMtd { get; set; }
    public decimal? DayUseRoomsMtd { get; set; }
    public decimal? NoShowRoomsMtd { get; set; }
    public decimal? CancelRommsMtd { get; set; }
    public decimal? NoShowPersonsMtd { get; set; }
    public decimal? DayUsePersonsMtd { get; set; }
    public decimal? NoOfDefiniteRoomsYtd { get; set; }
    public decimal? NoOfGuestsYtd { get; set; }
    public decimal? SingleOccupancyYtd { get; set; }
    public decimal? MultipleOccupancyYtd { get; set; }
    public decimal? PercentageOccupancyYtd { get; set; }
    public decimal? PercentageMultOccupancyYtd { get; set; }
    public decimal? TotalRevenueYtd { get; set; }
    public decimal? TotalFBRevenueYtd { get; set; }
    public decimal? TotalRoomRevenueYtd { get; set; }
    public decimal? TotalOtherRevenueYtd { get; set; }
    public decimal? TotalPackageRevenueYtd { get; set; }
    public decimal? TotalPackageRoomRevenueYtd { get; set; }
    public decimal? TotalPackageFBRevenueYtd { get; set; }
    public decimal? TotalPackageOtherRevYtd { get; set; }
    public decimal? TotalTaxYtd { get; set; }
    public decimal? TotalRoomTaxYtd { get; set; }
    public decimal? TotalFBTaxYtd { get; set; }
    public decimal? TotalOtherTaxYtd { get; set; }
    public decimal? AverageDayRateYtd { get; set; }
    public decimal? AveragePackageDayRateYtd { get; set; }
    public decimal? DayUseRoomsYtd { get; set; }
    public decimal? NoShowRoomsYtd { get; set; }
    public decimal? CancelRommsYtd { get; set; }
    public decimal? NoShowPersonsYtd { get; set; }
    public decimal? DayUsePersonsYtd { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? Nights { get; set; }
    public decimal? Arrivals { get; set; }
    public decimal? NoOfStays { get; set; }
    public decimal? Cribs { get; set; }
    public decimal? ExtraBeds { get; set; }
    public decimal? TotalNonRevenue { get; set; }
    public decimal? TotalPackageNonRevenue { get; set; }
    public decimal? TotalNonRevenueTax { get; set; }
    public decimal? ReservationNights { get; set; }
    public decimal? ReservationArrivals { get; set; }
    public decimal? ReservationNoOfStays { get; set; }
    public decimal? DayUseReservations { get; set; }
    public decimal? CancelledReservations { get; set; }
    public decimal? NoShowReservations { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileStatDaily>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.BusinessDate, e.NameId, e.RoomType })
                .HasName("PROFILE_STAT_DAILY_PK");

            entity.ToTable("PROFILE_STAT_DAILY");

            entity.HasIndex(e => new { e.NameId, e.Resort, e.RoomType, e.BusinessDate })
                .HasName("PROFILE_STAT_DAILY_IND1")
                .IsUnique();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrivals)
                .HasColumnName("ARRIVALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AverageDayRate)
                .HasColumnName("AVERAGE_DAY_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.AverageDayRateMtd)
                .HasColumnName("AVERAGE_DAY_RATE_MTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.AverageDayRateYtd)
                .HasColumnName("AVERAGE_DAY_RATE_YTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.AveragePackageDayRate)
                .HasColumnName("AVERAGE_PACKAGE_DAY_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.AveragePackageDayRateMtd)
                .HasColumnName("AVERAGE_PACKAGE_DAY_RATE_MTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.AveragePackageDayRateYtd)
                .HasColumnName("AVERAGE_PACKAGE_DAY_RATE_YTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.CancelRomms)
                .HasColumnName("CANCEL_ROMMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelRommsMtd)
                .HasColumnName("CANCEL_ROMMS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelRommsYtd)
                .HasColumnName("CANCEL_ROMMS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelledReservations)
                .HasColumnName("CANCELLED_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cribs)
                .HasColumnName("CRIBS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUsePersons)
                .HasColumnName("DAY_USE_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUsePersonsMtd)
                .HasColumnName("DAY_USE_PERSONS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUsePersonsYtd)
                .HasColumnName("DAY_USE_PERSONS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseReservations)
                .HasColumnName("DAY_USE_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseRooms)
                .HasColumnName("DAY_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseRoomsMtd)
                .HasColumnName("DAY_USE_ROOMS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseRoomsYtd)
                .HasColumnName("DAY_USE_ROOMS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtraBeds)
                .HasColumnName("EXTRA_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultipleOccupancy)
                .HasColumnName("MULTIPLE_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultipleOccupancyMtd)
                .HasColumnName("MULTIPLE_OCCUPANCY_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultipleOccupancyYtd)
                .HasColumnName("MULTIPLE_OCCUPANCY_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfDefiniteRoomsMtd)
                .HasColumnName("NO_OF_DEFINITE_ROOMS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfDefiniteRoomsYtd)
                .HasColumnName("NO_OF_DEFINITE_ROOMS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfDefinitieRooms)
                .HasColumnName("NO_OF_DEFINITIE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfGuests)
                .HasColumnName("NO_OF_GUESTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfGuestsMtd)
                .HasColumnName("NO_OF_GUESTS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfGuestsYtd)
                .HasColumnName("NO_OF_GUESTS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfStays)
                .HasColumnName("NO_OF_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowPersons)
                .HasColumnName("NO_SHOW_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowPersonsMtd)
                .HasColumnName("NO_SHOW_PERSONS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowPersonsYtd)
                .HasColumnName("NO_SHOW_PERSONS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowReservations)
                .HasColumnName("NO_SHOW_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRooms)
                .HasColumnName("NO_SHOW_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRoomsMtd)
                .HasColumnName("NO_SHOW_ROOMS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRoomsYtd)
                .HasColumnName("NO_SHOW_ROOMS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PercentageMultOccupancyMtd)
                .HasColumnName("PERCENTAGE_MULT_OCCUPANCY_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PercentageMultOccupancyYtd)
                .HasColumnName("PERCENTAGE_MULT_OCCUPANCY_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PercentageMultipleOccupancy)
                .HasColumnName("PERCENTAGE_MULTIPLE_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PercentageOccupancy)
                .HasColumnName("PERCENTAGE_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PercentageOccupancyMtd)
                .HasColumnName("PERCENTAGE_OCCUPANCY_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PercentageOccupancyYtd)
                .HasColumnName("PERCENTAGE_OCCUPANCY_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationArrivals)
                .HasColumnName("RESERVATION_ARRIVALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationNights)
                .HasColumnName("RESERVATION_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationNoOfStays)
                .HasColumnName("RESERVATION_NO_OF_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SingleOccupancy)
                .HasColumnName("SINGLE_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SingleOccupancyMtd)
                .HasColumnName("SINGLE_OCCUPANCY_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SingleOccupancyYtd)
                .HasColumnName("SINGLE_OCCUPANCY_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFBRevenue)
                .HasColumnName("TOTAL_F_B_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalFBRevenueMtd)
                .HasColumnName("TOTAL_F_B_REVENUE_MTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalFBRevenueYtd)
                .HasColumnName("TOTAL_F_B_REVENUE_YTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalFBTax)
                .HasColumnName("TOTAL_F_B_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalFBTaxMtd)
                .HasColumnName("TOTAL_F_B_TAX_MTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalFBTaxYtd)
                .HasColumnName("TOTAL_F_B_TAX_YTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalNonRevenue)
                .HasColumnName("TOTAL_NON_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalNonRevenueTax)
                .HasColumnName("TOTAL_NON_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalOtherRevenue)
                .HasColumnName("TOTAL_OTHER_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalOtherRevenueMtd)
                .HasColumnName("TOTAL_OTHER_REVENUE_MTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalOtherRevenueYtd)
                .HasColumnName("TOTAL_OTHER_REVENUE_YTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalOtherTax)
                .HasColumnName("TOTAL_OTHER_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalOtherTaxMtd)
                .HasColumnName("TOTAL_OTHER_TAX_MTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalOtherTaxYtd)
                .HasColumnName("TOTAL_OTHER_TAX_YTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageFBRevenue)
                .HasColumnName("TOTAL_PACKAGE_F_B_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageFBRevenueMtd)
                .HasColumnName("TOTAL_PACKAGE_F_B_REVENUE_MTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageFBRevenueYtd)
                .HasColumnName("TOTAL_PACKAGE_F_B_REVENUE_YTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageNonRevenue)
                .HasColumnName("TOTAL_PACKAGE_NON_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageOtherRevMtd)
                .HasColumnName("TOTAL_PACKAGE_OTHER_REV_MTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageOtherRevYtd)
                .HasColumnName("TOTAL_PACKAGE_OTHER_REV_YTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageOtherRevenue)
                .HasColumnName("TOTAL_PACKAGE_OTHER_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageRevenue)
                .HasColumnName("TOTAL_PACKAGE_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageRevenueMtd)
                .HasColumnName("TOTAL_PACKAGE_REVENUE_MTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageRevenueYtd)
                .HasColumnName("TOTAL_PACKAGE_REVENUE_YTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageRoomRevenue)
                .HasColumnName("TOTAL_PACKAGE_ROOM_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageRoomRevenueMtd)
                .HasColumnName("TOTAL_PACKAGE_ROOM_REVENUE_MTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageRoomRevenueYtd)
                .HasColumnName("TOTAL_PACKAGE_ROOM_REVENUE_YTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRevenueMtd)
                .HasColumnName("TOTAL_REVENUE_MTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRevenueYtd)
                .HasColumnName("TOTAL_REVENUE_YTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRoomRevenue)
                .HasColumnName("TOTAL_ROOM_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRoomRevenueMtd)
                .HasColumnName("TOTAL_ROOM_REVENUE_MTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRoomRevenueYtd)
                .HasColumnName("TOTAL_ROOM_REVENUE_YTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRoomTax)
                .HasColumnName("TOTAL_ROOM_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRoomTaxMtd)
                .HasColumnName("TOTAL_ROOM_TAX_MTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRoomTaxYtd)
                .HasColumnName("TOTAL_ROOM_TAX_YTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalTax)
                .HasColumnName("TOTAL_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalTaxMtd)
                .HasColumnName("TOTAL_TAX_MTD")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalTaxYtd)
                .HasColumnName("TOTAL_TAX_YTD")
                .HasColumnType("NUMBER(38,12)");
        });
	}
}
