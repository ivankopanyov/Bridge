namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OcrmProfBudgetProjectedVw
{
    public decimal? NameId { get; set; }
    public string DisplayName { get; set; }
    public decimal? TotalArrivals { get; set; }
    public decimal? TotalStays { get; set; }
    public decimal? AvgRoomRate { get; set; }
    public decimal? TotalNights { get; set; }
    public decimal? TotalCancellations { get; set; }
    public decimal? TotalNoShows { get; set; }
    public decimal? DayUseRooms { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FBRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? NonRevenue { get; set; }
    public DateTime? CampaignBeginDate { get; set; }
    public DateTime? CampaignEndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmProfBudgetProjectedVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OCRM_PROF_BUDGET_PROJECTED_VW");

            entity.Property(e => e.AvgRoomRate)
                .HasColumnName("AVG_ROOM_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CampaignBeginDate)
                .HasColumnName("CAMPAIGN_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CampaignEndDate)
                .HasColumnName("CAMPAIGN_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DayUseRooms)
                .HasColumnName("DAY_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.FBRevenue)
                .HasColumnName("F_B_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalArrivals)
                .HasColumnName("TOTAL_ARRIVALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCancellations)
                .HasColumnName("TOTAL_CANCELLATIONS")
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
