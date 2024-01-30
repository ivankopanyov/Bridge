namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OcrmCmpgnBudgetActualVw
{
    public string? CampaignCode { get; set; }
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
    public decimal? NoShowRes { get; set; }
    public decimal? CancelRes { get; set; }
    public decimal? ResNights { get; set; }
    public decimal? ResArrivals { get; set; }
    public decimal? ResDayUse { get; set; }
    public decimal? ResStays { get; set; }
    public DateTime? CampaignBeginDate { get; set; }
    public DateTime? CampaignEndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmCmpgnBudgetActualVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OCRM_CMPGN_BUDGET_ACTUAL_VW");

            entity.Property(e => e.AvgRoomRate)
                .HasColumnName("AVG_ROOM_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CampaignBeginDate)
                .HasColumnName("CAMPAIGN_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CampaignCode)
                .HasColumnName("CAMPAIGN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CampaignEndDate)
                .HasColumnName("CAMPAIGN_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancelRes)
                .HasColumnName("CANCEL_RES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseRooms)
                .HasColumnName("DAY_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FBRevenue)
                .HasColumnName("F_B_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRes)
                .HasColumnName("NO_SHOW_RES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResArrivals)
                .HasColumnName("RES_ARRIVALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResDayUse)
                .HasColumnName("RES_DAY_USE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResNights)
                .HasColumnName("RES_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResStays)
                .HasColumnName("RES_STAYS")
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
