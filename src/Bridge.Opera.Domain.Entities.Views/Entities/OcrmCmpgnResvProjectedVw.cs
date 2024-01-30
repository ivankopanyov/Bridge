namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OcrmCmpgnResvProjectedVw
{
    public decimal? NameId { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? ConfirmationNo { get; set; }
    public decimal? LegNo { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public DateTime? BookedDate { get; set; }
    public string? PromotionCode { get; set; }
    public string? CampaignCode { get; set; }
    public decimal? Arrivals { get; set; }
    public decimal? Stays { get; set; }
    public decimal? AvgRoomRate { get; set; }
    public decimal? Nights { get; set; }
    public decimal? CancelledRooms { get; set; }
    public decimal? NoShowRooms { get; set; }
    public decimal? DayUseRooms { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FBRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? NonRevenue { get; set; }
    public DateTime? TransactionDate { get; set; }
    public DateTime? CampaignBeginDate { get; set; }
    public DateTime? CampaignEndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmCmpgnResvProjectedVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OCRM_CMPGN_RESV_PROJECTED_VW");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Arrivals)
                .HasColumnName("ARRIVALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgRoomRate)
                .HasColumnName("AVG_ROOM_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookedDate)
                .HasColumnName("BOOKED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CampaignBeginDate)
                .HasColumnName("CAMPAIGN_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CampaignCode)
                .IsRequired()
                .HasColumnName("CAMPAIGN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CampaignEndDate)
                .HasColumnName("CAMPAIGN_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancelledRooms)
                .HasColumnName("CANCELLED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DayUseRooms)
                .HasColumnName("DAY_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FBRevenue)
                .HasColumnName("F_B_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.LegNo)
                .HasColumnName("LEG_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRooms)
                .HasColumnName("NO_SHOW_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PromotionCode)
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Stays)
                .HasColumnName("STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TransactionDate)
                .HasColumnName("TRANSACTION_DATE")
                .HasColumnType("DATE");
        });
	}
}
