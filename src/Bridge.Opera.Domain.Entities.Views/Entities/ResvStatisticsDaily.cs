namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResvStatisticsDaily
{
    public string? Resort { get; set; }
    public string? MasterType { get; set; }
    public string? RoomType { get; set; }
    public string? MasterValue { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? NoOfDefRoomsToday { get; set; }
    public decimal? NoOfGuestsToday { get; set; }
    public decimal? NoArrPersonsToday { get; set; }
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

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResvStatisticsDaily>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESV_STATISTICS_DAILY");

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

            entity.Property(e => e.MultipleOccupancyToday)
                .HasColumnName("MULTIPLE_OCCUPANCY_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoArrPersonsToday)
                .HasColumnName("NO_ARR_PERSONS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfDefRoomsToday)
                .HasColumnName("NO_OF_DEF_ROOMS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfGuestsToday)
                .HasColumnName("NO_OF_GUESTS_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.SingleOccupancyToday)
                .HasColumnName("SINGLE_OCCUPANCY_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFBRevToday)
                .HasColumnName("TOTAL_F_B_REV_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFBTaxToday)
                .HasColumnName("TOTAL_F_B_TAX_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOtherRevToday)
                .HasColumnName("TOTAL_OTHER_REV_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOtherTaxToday)
                .HasColumnName("TOTAL_OTHER_TAX_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgFBRevToday)
                .HasColumnName("TOTAL_PKG_F_B_REV_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgOtherRevToday)
                .HasColumnName("TOTAL_PKG_OTHER_REV_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgRevToday)
                .HasColumnName("TOTAL_PKG_REV_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPkgRoomRevToday)
                .HasColumnName("TOTAL_PKG_ROOM_REV_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevToday)
                .HasColumnName("TOTAL_REV_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomRevToday)
                .HasColumnName("TOTAL_ROOM_REV_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomTaxToday)
                .HasColumnName("TOTAL_ROOM_TAX_TODAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTaxToday)
                .HasColumnName("TOTAL_TAX_TODAY")
                .HasColumnType("NUMBER");
        });
	}
}
