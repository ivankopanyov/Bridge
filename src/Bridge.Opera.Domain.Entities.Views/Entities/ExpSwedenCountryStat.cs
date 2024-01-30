namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSwedenCountryStat
{
    public string? Resort { get; set; }
    public string? ResortName { get; set; }
    public string? HotelCode { get; set; }
    public DateTime? BusinessDate { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? CountryCode { get; set; }
    public decimal? ArrRooms { get; set; }
    public decimal? StayRooms { get; set; }
    public decimal? StayBeds { get; set; }
    public decimal? StayPersons { get; set; }
    public decimal? DayUsePersons { get; set; }
    public decimal? Mkt1Rooms { get; set; }
    public decimal? Mkt2Rooms { get; set; }
    public decimal? Mkt3Rooms { get; set; }
    public decimal? Mkt4Rooms { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? PhysicalRoom { get; set; }
    public decimal? PhysicalBeds { get; set; }
    public decimal? TotalAvailRooms { get; set; }
    public decimal? TotalAvailBeds { get; set; }
    public decimal? OooRooms { get; set; }
    public decimal? OooBeds { get; set; }
    public decimal? OsRooms { get; set; }
    public decimal? OsBeds { get; set; }
    public decimal? CompRoom { get; set; }
    public decimal? CompBeds { get; set; }
    public decimal? CompPersons { get; set; }
    public decimal? HouseUseRoom { get; set; }
    public decimal? HouseUseBeds { get; set; }
    public decimal? HouseUsePersons { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSwedenCountryStat>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SWEDEN_COUNTRY_STAT");

            entity.Property(e => e.ArrRooms)
                .HasColumnName("ARR_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CompBeds)
                .HasColumnName("COMP_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompPersons)
                .HasColumnName("COMP_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompRoom)
                .HasColumnName("COMP_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.DayUsePersons)
                .HasColumnName("DAY_USE_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.HouseUseBeds)
                .HasColumnName("HOUSE_USE_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HouseUsePersons)
                .HasColumnName("HOUSE_USE_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HouseUseRoom)
                .HasColumnName("HOUSE_USE_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Mkt1Rooms)
                .HasColumnName("MKT_1_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Mkt2Rooms)
                .HasColumnName("MKT_2_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Mkt3Rooms)
                .HasColumnName("MKT_3_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Mkt4Rooms)
                .HasColumnName("MKT_4_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OooBeds)
                .HasColumnName("OOO_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OooRooms)
                .HasColumnName("OOO_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OsBeds)
                .HasColumnName("OS_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OsRooms)
                .HasColumnName("OS_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhysicalBeds)
                .HasColumnName("PHYSICAL_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhysicalRoom)
                .HasColumnName("PHYSICAL_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortName)
                .HasColumnName("RESORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StayBeds)
                .HasColumnName("STAY_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayPersons)
                .HasColumnName("STAY_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRooms)
                .HasColumnName("STAY_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalAvailBeds)
                .HasColumnName("TOTAL_AVAIL_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalAvailRooms)
                .HasColumnName("TOTAL_AVAIL_ROOMS")
                .HasColumnType("NUMBER");
        });
	}
}
