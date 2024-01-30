namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PmsNameYearSummaryView1
{
    public string? Resort { get; set; }
    public decimal? NameId { get; set; }
    public string? TransactionYear { get; set; }
    public decimal? Arrivals { get; set; }
    public decimal? Stays { get; set; }
    public decimal? Cancels { get; set; }
    public decimal? NoShows { get; set; }
    public decimal? AvgRoomRate { get; set; }
    public decimal? TotalNights { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FBRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? DayUseRooms { get; set; }
    public decimal? NonRevenue { get; set; }
    public decimal? DayUse { get; set; }
    public decimal? NoShowRes { get; set; }
    public decimal? CancelRes { get; set; }
    public decimal? ArrivalRes { get; set; }
    public decimal? NightsRes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PmsNameYearSummaryView1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PMS_NAME_YEAR_SUMMARY_VIEW1");

            entity.Property(e => e.ArrivalRes)
                .HasColumnName("ARRIVAL_RES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrivals)
                .HasColumnName("ARRIVALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgRoomRate)
                .HasColumnName("AVG_ROOM_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelRes)
                .HasColumnName("CANCEL_RES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cancels)
                .HasColumnName("CANCELS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUse)
                .HasColumnName("DAY_USE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseRooms)
                .HasColumnName("DAY_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FBRevenue)
                .HasColumnName("F_B_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NightsRes)
                .HasColumnName("NIGHTS_RES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRes)
                .HasColumnName("NO_SHOW_RES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShows)
                .HasColumnName("NO_SHOWS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Stays)
                .HasColumnName("STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNights)
                .HasColumnName("TOTAL_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransactionYear)
                .HasColumnName("TRANSACTION_YEAR")
                .HasMaxLength(4)
                .IsUnicode(false);
        });
	}
}
