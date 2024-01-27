namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpCountrystatMonth
{
    public string ResortName { get; set; }
    public string PropertyCode { get; set; }
    public decimal? PropertyCurrencyDecimals { get; set; }
    public string PropertyCurrencyCode { get; set; }
    public string StatisticCode { get; set; }
    public string MonthYear { get; set; }
    public string NumberOfDays { get; set; }
    public decimal? StayRooms { get; set; }
    public decimal? StayPersons { get; set; }
    public decimal? ArrPersons { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? TStayRooms { get; set; }
    public decimal? TStayPersons { get; set; }
    public decimal? TRoomRevenue { get; set; }
    public decimal? TStayPersonsK { get; set; }
    public decimal? TStayPersonsY { get; set; }
    public decimal? TStayPersonsF { get; set; }
    public decimal? TLocalArrPersons { get; set; }
    public decimal? TForeignArrPersons { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpCountrystatMonth>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_COUNTRYSTAT_MONTH");

            entity.Property(e => e.ArrPersons)
                .HasColumnName("ARR_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MonthYear)
                .HasColumnName("MONTH_YEAR")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.NumberOfDays)
                .HasColumnName("NUMBER_OF_DAYS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCurrencyCode)
                .HasColumnName("PROPERTY_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCurrencyDecimals)
                .HasColumnName("PROPERTY_CURRENCY_DECIMALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResortName)
                .HasColumnName("RESORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatisticCode)
                .HasColumnName("STATISTIC_CODE")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.StayPersons)
                .HasColumnName("STAY_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRooms)
                .HasColumnName("STAY_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TForeignArrPersons)
                .HasColumnName("T_FOREIGN_ARR_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TLocalArrPersons)
                .HasColumnName("T_LOCAL_ARR_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TRoomRevenue)
                .HasColumnName("T_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TStayPersons)
                .HasColumnName("T_STAY_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TStayPersonsF)
                .HasColumnName("T_STAY_PERSONS_F")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TStayPersonsK)
                .HasColumnName("T_STAY_PERSONS_K")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TStayPersonsY)
                .HasColumnName("T_STAY_PERSONS_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TStayRooms)
                .HasColumnName("T_STAY_ROOMS")
                .HasColumnType("NUMBER");
        });
	}
}
