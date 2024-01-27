namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CentralLeadHistory
{
    public decimal? ProfileId { get; set; }
    public string Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? ActualRoomNights { get; set; }
    public decimal? ActualRoomRevenue { get; set; }
    public decimal? ActualAvgrate { get; set; }
    public decimal? ActualFbRevenue { get; set; }
    public decimal? ActualOtherRevenue { get; set; }
    public decimal? OriginalRoomNights { get; set; }
    public decimal? ContractRoomNights { get; set; }
    public string MarketingRegion { get; set; }
    public string MarketingCity { get; set; }
    public string EventsYn { get; set; }
    public string AllotmentCode { get; set; }
    public string BookedResort { get; set; }
    public decimal? CurrentRoomNights { get; set; }
    public decimal? CurrentAvgRate { get; set; }
    public decimal? ProfileRevenueId { get; set; }
    public string Destination { get; set; }
    public string LostToDestination { get; set; }
    public string LostToProperty { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CentralLeadHistory>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CENTRAL_LEAD_HISTORY");

            entity.Property(e => e.ActualAvgrate)
                .HasColumnName("ACTUAL_AVGRATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualFbRevenue)
                .HasColumnName("ACTUAL_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualOtherRevenue)
                .HasColumnName("ACTUAL_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRoomNights)
                .HasColumnName("ACTUAL_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRoomRevenue)
                .HasColumnName("ACTUAL_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentCode)
                .HasColumnName("ALLOTMENT_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookedResort)
                .HasColumnName("BOOKED_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContractRoomNights)
                .HasColumnName("CONTRACT_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrentAvgRate)
                .HasColumnName("CURRENT_AVG_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrentRoomNights)
                .HasColumnName("CURRENT_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Destination)
                .HasColumnName("DESTINATION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventsYn)
                .HasColumnName("EVENTS_YN")
                .IsUnicode(false);

            entity.Property(e => e.LostToDestination)
                .HasColumnName("LOST_TO_DESTINATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LostToProperty)
                .HasColumnName("LOST_TO_PROPERTY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketingCity)
                .HasColumnName("MARKETING_CITY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MarketingRegion)
                .HasColumnName("MARKETING_REGION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OriginalRoomNights)
                .HasColumnName("ORIGINAL_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileId)
                .HasColumnName("PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileRevenueId)
                .HasColumnName("PROFILE_REVENUE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");
        });
	}
}
