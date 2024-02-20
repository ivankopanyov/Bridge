namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepCountryStat
{
    public string? CountryName { get; set; }
    public decimal? DayRoomRevenue { get; set; }
    public decimal? DayRooms { get; set; }
    public decimal? DayPersons { get; set; }
    public decimal? MtdRoomRevenue { get; set; }
    public decimal? MtdRooms { get; set; }
    public decimal? MtdPersons { get; set; }
    public decimal? YtdRoomRevenue { get; set; }
    public decimal? YtdRooms { get; set; }
    public decimal? YtdPersons { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepCountryStat>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_COUNTRY_STAT");

            entity.Property(e => e.CountryName)
                .HasColumnName("COUNTRY_NAME")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.DayPersons)
                .HasColumnName("DAY_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayRoomRevenue)
                .HasColumnName("DAY_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayRooms)
                .HasColumnName("DAY_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MtdPersons)
                .HasColumnName("MTD_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MtdRoomRevenue)
                .HasColumnName("MTD_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MtdRooms)
                .HasColumnName("MTD_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.YtdPersons)
                .HasColumnName("YTD_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdRoomRevenue)
                .HasColumnName("YTD_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdRooms)
                .HasColumnName("YTD_ROOMS")
                .HasColumnType("NUMBER");
        });
	}
}
