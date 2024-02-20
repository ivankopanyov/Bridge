namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepResSpecialsStat
{
    public string? Preference { get; set; }
    public string? Description { get; set; }
    public decimal? SpecialRequestId { get; set; }
    public decimal? RoomsDay { get; set; }
    public decimal? RoomsMonth { get; set; }
    public decimal? RoomsYear { get; set; }
    public decimal? PersonsDay { get; set; }
    public decimal? PersonsMonth { get; set; }
    public decimal? PersonsYear { get; set; }
    public decimal? ArrivalsRoomsDay { get; set; }
    public decimal? ArrivalsRoomsMonth { get; set; }
    public decimal? ArrivalsRoomsYear { get; set; }
    public decimal? ArrivalsPersonsDay { get; set; }
    public decimal? ArrivalsPersonsMonth { get; set; }
    public decimal? ArrivalsPersonsYear { get; set; }
    public decimal? NoShowRoomsDay { get; set; }
    public decimal? NoShowRoomsMonth { get; set; }
    public decimal? NoShowRoomsYear { get; set; }
    public decimal? NoShowPersonsDay { get; set; }
    public decimal? NoShowPersonsMonth { get; set; }
    public decimal? NoShowPersonsYear { get; set; }
    public decimal? CancelledRoomsDay { get; set; }
    public decimal? CancelledRoomsMonth { get; set; }
    public decimal? CancelledRoomsYear { get; set; }
    public decimal? CancelledPersonsDay { get; set; }
    public decimal? CancelledPersonsMonth { get; set; }
    public decimal? CancelledPersonsYear { get; set; }
    public decimal? RoomRevenueDay { get; set; }
    public decimal? RoomRevenueMonth { get; set; }
    public decimal? RoomRevenueYear { get; set; }
    public decimal? FoodRevenueDay { get; set; }
    public decimal? FoodRevenueMonth { get; set; }
    public decimal? FoodRevenueYear { get; set; }
    public decimal? TotalRevenueDay { get; set; }
    public decimal? TotalRevenueMonth { get; set; }
    public decimal? TotalRevenueYear { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepResSpecialsStat>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_RES_SPECIALS_STAT");

            entity.Property(e => e.ArrivalsPersonsDay)
                .HasColumnName("ARRIVALS_PERSONS_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalsPersonsMonth)
                .HasColumnName("ARRIVALS_PERSONS_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalsPersonsYear)
                .HasColumnName("ARRIVALS_PERSONS_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalsRoomsDay)
                .HasColumnName("ARRIVALS_ROOMS_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalsRoomsMonth)
                .HasColumnName("ARRIVALS_ROOMS_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalsRoomsYear)
                .HasColumnName("ARRIVALS_ROOMS_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelledPersonsDay)
                .HasColumnName("CANCELLED_PERSONS_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelledPersonsMonth)
                .HasColumnName("CANCELLED_PERSONS_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelledPersonsYear)
                .HasColumnName("CANCELLED_PERSONS_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelledRoomsDay)
                .HasColumnName("CANCELLED_ROOMS_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelledRoomsMonth)
                .HasColumnName("CANCELLED_ROOMS_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelledRoomsYear)
                .HasColumnName("CANCELLED_ROOMS_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FoodRevenueDay)
                .HasColumnName("FOOD_REVENUE_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodRevenueMonth)
                .HasColumnName("FOOD_REVENUE_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodRevenueYear)
                .HasColumnName("FOOD_REVENUE_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowPersonsDay)
                .HasColumnName("NO_SHOW_PERSONS_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowPersonsMonth)
                .HasColumnName("NO_SHOW_PERSONS_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowPersonsYear)
                .HasColumnName("NO_SHOW_PERSONS_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRoomsDay)
                .HasColumnName("NO_SHOW_ROOMS_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRoomsMonth)
                .HasColumnName("NO_SHOW_ROOMS_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRoomsYear)
                .HasColumnName("NO_SHOW_ROOMS_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PersonsDay)
                .HasColumnName("PERSONS_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PersonsMonth)
                .HasColumnName("PERSONS_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PersonsYear)
                .HasColumnName("PERSONS_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Preference)
                .IsRequired()
                .HasColumnName("PREFERENCE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenueDay)
                .HasColumnName("ROOM_REVENUE_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueMonth)
                .HasColumnName("ROOM_REVENUE_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueYear)
                .HasColumnName("ROOM_REVENUE_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsDay)
                .HasColumnName("ROOMS_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsMonth)
                .HasColumnName("ROOMS_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsYear)
                .HasColumnName("ROOMS_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SpecialRequestId)
                .HasColumnName("SPECIAL_REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueDay)
                .HasColumnName("TOTAL_REVENUE_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueMonth)
                .HasColumnName("TOTAL_REVENUE_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueYear)
                .HasColumnName("TOTAL_REVENUE_YEAR")
                .HasColumnType("NUMBER");
        });
	}
}
