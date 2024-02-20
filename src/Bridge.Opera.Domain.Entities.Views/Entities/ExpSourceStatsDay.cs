namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSourceStatsDay
{
    public DateTime? BusinessDate { get; set; }
    public string? SourceCode { get; set; }
    public string? Description { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? NoOfGuests { get; set; }
    public decimal? NoOfRooms { get; set; }
    public decimal? DayUseRooms { get; set; }
    public decimal? DayUsePersons { get; set; }
    public decimal? CancelationRooms { get; set; }
    public decimal? NoShowRooms { get; set; }
    public decimal? NoShowPersons { get; set; }
    public decimal? SingleOccupancy { get; set; }
    public decimal? MultipleOccupancy { get; set; }
    public decimal? TotalRoomRevenue { get; set; }
    public decimal? TotalFbRevenue { get; set; }
    public decimal? TotalOtherRevenue { get; set; }
    public decimal? TotalRoomTax { get; set; }
    public decimal? TotalFbTax { get; set; }
    public decimal? TotalOtherTax { get; set; }
    public decimal? PackageRoomRevenue { get; set; }
    public decimal? PackageFBRevenue { get; set; }
    public decimal? PackageOtherRevenue { get; set; }
    public decimal? TotalRevenueMtd { get; set; }
    public decimal? NoOfGuestsMtd { get; set; }
    public decimal? NoOfRoomsMtd { get; set; }
    public decimal? DayUseRoomsMtd { get; set; }
    public decimal? DayUsePersonsMtd { get; set; }
    public decimal? CancelationRoomsMtd { get; set; }
    public decimal? NoShowRoomsMtd { get; set; }
    public decimal? NoShowPersonsMtd { get; set; }
    public decimal? SingleOccupancyMtd { get; set; }
    public decimal? MultipleOccupancyMtd { get; set; }
    public decimal? TotalRoomRevenueMtd { get; set; }
    public decimal? TotalFbRevenueMtd { get; set; }
    public decimal? TotalOtherRevenueMtd { get; set; }
    public decimal? TotalRoomTaxMtd { get; set; }
    public decimal? TotalFbTaxMtd { get; set; }
    public decimal? TotalOtherTaxMtd { get; set; }
    public decimal? PackageRoomRevenueMtd { get; set; }
    public decimal? PackageFBRevenueMtd { get; set; }
    public decimal? PackageOtherRevenueMtd { get; set; }
    public decimal? TotalRevenueYtd { get; set; }
    public decimal? NoOfGuestsYtd { get; set; }
    public decimal? NoOfRoomsYtd { get; set; }
    public decimal? DayUseRoomsYtd { get; set; }
    public decimal? DayUsePersonsYtd { get; set; }
    public decimal? CancelationRoomsYtd { get; set; }
    public decimal? NoShowRoomsYtd { get; set; }
    public decimal? NoShowPersonsYtd { get; set; }
    public decimal? SingleOccupancyYtd { get; set; }
    public decimal? MultipleOccupancyYtd { get; set; }
    public decimal? TotalRoomRevenueYtd { get; set; }
    public decimal? TotalFbRevenueYtd { get; set; }
    public decimal? TotalOtherRevenueYtd { get; set; }
    public decimal? TotalRoomTaxYtd { get; set; }
    public decimal? TotalFbTaxYtd { get; set; }
    public decimal? TotalOtherTaxYtd { get; set; }
    public decimal? PackageRoomRevenueYtd { get; set; }
    public decimal? PackageFBRevenueYtd { get; set; }
    public decimal? PackageOtherRevenueYtd { get; set; }
    public decimal? Sequence { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSourceStatsDay>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SOURCE_STATS_DAY");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancelationRooms)
                .HasColumnName("CANCELATION_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelationRoomsMtd)
                .HasColumnName("CANCELATION_ROOMS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelationRoomsYtd)
                .HasColumnName("CANCELATION_ROOMS_YTD")
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

            entity.Property(e => e.DayUseRooms)
                .HasColumnName("DAY_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseRoomsMtd)
                .HasColumnName("DAY_USE_ROOMS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseRoomsYtd)
                .HasColumnName("DAY_USE_ROOMS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MultipleOccupancy)
                .HasColumnName("MULTIPLE_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultipleOccupancyMtd)
                .HasColumnName("MULTIPLE_OCCUPANCY_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultipleOccupancyYtd)
                .HasColumnName("MULTIPLE_OCCUPANCY_YTD")
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

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfRoomsMtd)
                .HasColumnName("NO_OF_ROOMS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfRoomsYtd)
                .HasColumnName("NO_OF_ROOMS_YTD")
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

            entity.Property(e => e.NoShowRooms)
                .HasColumnName("NO_SHOW_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRoomsMtd)
                .HasColumnName("NO_SHOW_ROOMS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRoomsYtd)
                .HasColumnName("NO_SHOW_ROOMS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageFBRevenue)
                .HasColumnName("PACKAGE_F_B_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageFBRevenueMtd)
                .HasColumnName("PACKAGE_F_B_REVENUE_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageFBRevenueYtd)
                .HasColumnName("PACKAGE_F_B_REVENUE_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageOtherRevenue)
                .HasColumnName("PACKAGE_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageOtherRevenueMtd)
                .HasColumnName("PACKAGE_OTHER_REVENUE_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageOtherRevenueYtd)
                .HasColumnName("PACKAGE_OTHER_REVENUE_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageRoomRevenue)
                .HasColumnName("PACKAGE_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageRoomRevenueMtd)
                .HasColumnName("PACKAGE_ROOM_REVENUE_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageRoomRevenueYtd)
                .HasColumnName("PACKAGE_ROOM_REVENUE_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sequence)
                .HasColumnName("SEQUENCE")
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

            entity.Property(e => e.SourceCode)
                .IsRequired()
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalFbRevenue)
                .HasColumnName("TOTAL_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFbRevenueMtd)
                .HasColumnName("TOTAL_FB_REVENUE_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFbRevenueYtd)
                .HasColumnName("TOTAL_FB_REVENUE_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFbTax)
                .HasColumnName("TOTAL_FB_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFbTaxMtd)
                .HasColumnName("TOTAL_FB_TAX_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFbTaxYtd)
                .HasColumnName("TOTAL_FB_TAX_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOtherRevenue)
                .HasColumnName("TOTAL_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOtherRevenueMtd)
                .HasColumnName("TOTAL_OTHER_REVENUE_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOtherRevenueYtd)
                .HasColumnName("TOTAL_OTHER_REVENUE_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOtherTax)
                .HasColumnName("TOTAL_OTHER_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOtherTaxMtd)
                .HasColumnName("TOTAL_OTHER_TAX_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOtherTaxYtd)
                .HasColumnName("TOTAL_OTHER_TAX_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueMtd)
                .HasColumnName("TOTAL_REVENUE_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueYtd)
                .HasColumnName("TOTAL_REVENUE_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomRevenue)
                .HasColumnName("TOTAL_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomRevenueMtd)
                .HasColumnName("TOTAL_ROOM_REVENUE_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomRevenueYtd)
                .HasColumnName("TOTAL_ROOM_REVENUE_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomTax)
                .HasColumnName("TOTAL_ROOM_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomTaxMtd)
                .HasColumnName("TOTAL_ROOM_TAX_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomTaxYtd)
                .HasColumnName("TOTAL_ROOM_TAX_YTD")
                .HasColumnType("NUMBER");
        });
	}
}
