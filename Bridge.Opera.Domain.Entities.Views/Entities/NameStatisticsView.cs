namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NameStatisticsView
{
    public decimal? NameId { get; set; }
    public decimal? Arrivals { get; set; }
    public decimal? TotalCancellation { get; set; }
    public decimal? TotalNoShows { get; set; }
    public decimal? AvgRoomRate { get; set; }
    public decimal? TotalNights { get; set; }
    public decimal? DayUseRooms { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FBRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public DateTime? LastStay { get; set; }
    public string LastRoom { get; set; }
    public string LastGroup { get; set; }
    public string LastSource { get; set; }
    public decimal? LastRate { get; set; }
    public decimal? TotalStays { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameStatisticsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NAME_STATISTICS_VIEW");

            entity.Property(e => e.Arrivals)
                .HasColumnName("ARRIVALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgRoomRate)
                .HasColumnName("AVG_ROOM_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseRooms)
                .HasColumnName("DAY_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FBRevenue)
                .HasColumnName("F_B_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastGroup)
                .HasColumnName("LAST_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.LastRate)
                .HasColumnName("LAST_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastRoom)
                .HasColumnName("LAST_ROOM")
                .IsUnicode(false);

            entity.Property(e => e.LastSource)
                .HasColumnName("LAST_SOURCE")
                .IsUnicode(false);

            entity.Property(e => e.LastStay)
                .HasColumnName("LAST_STAY")
                .HasColumnType("DATE");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCancellation)
                .HasColumnName("TOTAL_CANCELLATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNights)
                .HasColumnName("TOTAL_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNoShows)
                .HasColumnName("TOTAL_NO_SHOWS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalStays)
                .HasColumnName("TOTAL_STAYS")
                .HasColumnType("NUMBER");
        });
	}
}
