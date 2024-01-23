namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResvStatistics
{
    public string Resort { get; set; }
    public string MasterType { get; set; }
    public string RoomType { get; set; }
    public string MasterValue { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? NoOfDefRoomsToday { get; set; }
    public decimal? NoOfGuestsToday { get; set; }
    public decimal? SingleOccupancyToday { get; set; }
    public decimal? MultipleOccupancyToday { get; set; }
    public decimal? TotalRevToday { get; set; }
    public decimal? TotalRoomRevToday { get; set; }
    public decimal? TotalFBRevToday { get; set; }
    public decimal? TotalOtherRevToday { get; set; }
    public decimal? TotalPkgRevToday { get; set; }
    public decimal? TotalPkgRoomRevToday { get; set; }
    public decimal? TotalPkgFBRevToday { get; set; }
    public decimal? TotalPkgOtherRevToday { get; set; }
    public decimal? TotalTaxToday { get; set; }
    public decimal? TotalRoomTaxToday { get; set; }
    public decimal? TotalFBTaxToday { get; set; }
    public decimal? TotalOtherTaxToday { get; set; }
    public decimal? NoOfDefRoomsMtd { get; set; }
    public decimal? NoOfGuestsMtd { get; set; }
    public decimal? SingleOccupancyMtd { get; set; }
    public decimal? MultipleOccupancyMtd { get; set; }
    public decimal? TotalRevMtd { get; set; }
    public decimal? TotalRoomRevMtd { get; set; }
    public decimal? TotalFBRevMtd { get; set; }
    public decimal? TotalOtherRevMtd { get; set; }
    public decimal? TotalPkgRevMtd { get; set; }
    public decimal? TotalPkgRoomRevMtd { get; set; }
    public decimal? TotalPkgFBRevMtd { get; set; }
    public decimal? TotalPkgOtherRevMtd { get; set; }
    public decimal? TotalTaxMtd { get; set; }
    public decimal? TotalRoomTaxMtd { get; set; }
    public decimal? TotalFBTaxMtd { get; set; }
    public decimal? TotalOtherTaxMtd { get; set; }
    public decimal? NoOfDefRoomsYtd { get; set; }
    public decimal? NoOfGuestsYtd { get; set; }
    public decimal? SingleOccupancyYtd { get; set; }
    public decimal? MultipleOccupancyYtd { get; set; }
    public decimal? TotalRevYtd { get; set; }
    public decimal? TotalRoomRevYtd { get; set; }
    public decimal? TotalFBRevYtd { get; set; }
    public decimal? TotalOtherRevYtd { get; set; }
    public decimal? TotalPkgRevYtd { get; set; }
    public decimal? TotalPkgRoomRevYtd { get; set; }
    public decimal? TotalPkgFBRevYtd { get; set; }
    public decimal? TotalPkgOtherRevYtd { get; set; }
    public decimal? TotalTaxYtd { get; set; }
    public decimal? TotalRoomTaxYtd { get; set; }
    public decimal? TotalFBTaxYtd { get; set; }
    public decimal? TotalOtherTaxYtd { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResvStatistics>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESV_STATISTICS");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MasterType)
                .HasColumnName("MASTER_TYPE")
                .HasColumnType("CHAR(2)");

            entity.Property(e => e.MasterValue)
                .HasColumnName("MASTER_VALUE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MultipleOccupancyMtd)
                .HasColumnName("MULTIPLE_OCCUPANCY_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultipleOccupancyToday)
                .HasColumnName("MULTIPLE_OCCUPANCY_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultipleOccupancyYtd)
                .HasColumnName("MULTIPLE_OCCUPANCY_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfDefRoomsMtd)
                .HasColumnName("NO_OF_DEF_ROOMS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfDefRoomsToday)
                .HasColumnName("NO_OF_DEF_ROOMS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfDefRoomsYtd)
                .HasColumnName("NO_OF_DEF_ROOMS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfGuestsMtd)
                .HasColumnName("NO_OF_GUESTS_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfGuestsToday)
                .HasColumnName("NO_OF_GUESTS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfGuestsYtd)
                .HasColumnName("NO_OF_GUESTS_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.SingleOccupancyMtd)
                .HasColumnName("SINGLE_OCCUPANCY_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SingleOccupancyToday)
                .HasColumnName("SINGLE_OCCUPANCY_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SingleOccupancyYtd)
                .HasColumnName("SINGLE_OCCUPANCY_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFBRevMtd)
                .HasColumnName("TOTAL_F_B_REV_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFBRevToday)
                .HasColumnName("TOTAL_F_B_REV_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFBRevYtd)
                .HasColumnName("TOTAL_F_B_REV_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFBTaxMtd)
                .HasColumnName("TOTAL_F_B_TAX_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFBTaxToday)
                .HasColumnName("TOTAL_F_B_TAX_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFBTaxYtd)
                .HasColumnName("TOTAL_F_B_TAX_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOtherRevMtd)
                .HasColumnName("TOTAL_OTHER_REV_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOtherRevToday)
                .HasColumnName("TOTAL_OTHER_REV_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOtherRevYtd)
                .HasColumnName("TOTAL_OTHER_REV_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOtherTaxMtd)
                .HasColumnName("TOTAL_OTHER_TAX_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOtherTaxToday)
                .HasColumnName("TOTAL_OTHER_TAX_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOtherTaxYtd)
                .HasColumnName("TOTAL_OTHER_TAX_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgFBRevMtd)
                .HasColumnName("TOTAL_PKG_F_B_REV_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgFBRevToday)
                .HasColumnName("TOTAL_PKG_F_B_REV_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgFBRevYtd)
                .HasColumnName("TOTAL_PKG_F_B_REV_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgOtherRevMtd)
                .HasColumnName("TOTAL_PKG_OTHER_REV_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgOtherRevToday)
                .HasColumnName("TOTAL_PKG_OTHER_REV_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgOtherRevYtd)
                .HasColumnName("TOTAL_PKG_OTHER_REV_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgRevMtd)
                .HasColumnName("TOTAL_PKG_REV_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgRevToday)
                .HasColumnName("TOTAL_PKG_REV_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgRevYtd)
                .HasColumnName("TOTAL_PKG_REV_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgRoomRevMtd)
                .HasColumnName("TOTAL_PKG_ROOM_REV_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgRoomRevToday)
                .HasColumnName("TOTAL_PKG_ROOM_REV_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgRoomRevYtd)
                .HasColumnName("TOTAL_PKG_ROOM_REV_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevMtd)
                .HasColumnName("TOTAL_REV_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevToday)
                .HasColumnName("TOTAL_REV_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevYtd)
                .HasColumnName("TOTAL_REV_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomRevMtd)
                .HasColumnName("TOTAL_ROOM_REV_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomRevToday)
                .HasColumnName("TOTAL_ROOM_REV_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomRevYtd)
                .HasColumnName("TOTAL_ROOM_REV_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomTaxMtd)
                .HasColumnName("TOTAL_ROOM_TAX_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomTaxToday)
                .HasColumnName("TOTAL_ROOM_TAX_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomTaxYtd)
                .HasColumnName("TOTAL_ROOM_TAX_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTaxMtd)
                .HasColumnName("TOTAL_TAX_MTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTaxToday)
                .HasColumnName("TOTAL_TAX_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTaxYtd)
                .HasColumnName("TOTAL_TAX_YTD")
                .HasColumnType("NUMBER");
        });
	}
}
