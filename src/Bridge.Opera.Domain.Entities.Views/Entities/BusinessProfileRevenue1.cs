namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BusinessProfileRevenue1
{
    public decimal? ProfileRevenueId { get; set; }
    public decimal? ProfileId { get; set; }
    public string? Resort { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? ActualRoomNights { get; set; }
    public decimal? ActualRoomRevenue { get; set; }
    public decimal? ActualAvgrate { get; set; }
    public decimal? ActualFbRevenue { get; set; }
    public decimal? ActualOtherRevenue { get; set; }
    public decimal? RoomNightsSun { get; set; }
    public decimal? RoomNightsMon { get; set; }
    public decimal? RoomNightsTue { get; set; }
    public decimal? RoomNightsWed { get; set; }
    public decimal? RoomNightsThu { get; set; }
    public decimal? RoomNightsFri { get; set; }
    public decimal? RoomNightsSat { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public byte? LaptopChange { get; set; }
    public string? PeriodCode { get; set; }
    public string? MarketingRegion { get; set; }
    public string? MarketingCity { get; set; }
    public string? EventsYn { get; set; }
    public string? CompetitorYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BusinessProfileRevenue1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BUSINESS_PROFILE_REVENUE");

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

            entity.Property(e => e.CompetitorYn)
                .HasColumnName("COMPETITOR_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventsYn)
                .HasColumnName("EVENTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.MarketingCity)
                .HasColumnName("MARKETING_CITY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MarketingRegion)
                .HasColumnName("MARKETING_REGION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PeriodCode)
                .HasColumnName("PERIOD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProfileId)
                .HasColumnName("PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileRevenueId)
                .HasColumnName("PROFILE_REVENUE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomNightsFri)
                .HasColumnName("ROOM_NIGHTS_FRI")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNightsMon)
                .HasColumnName("ROOM_NIGHTS_MON")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNightsSat)
                .HasColumnName("ROOM_NIGHTS_SAT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNightsSun)
                .HasColumnName("ROOM_NIGHTS_SUN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNightsThu)
                .HasColumnName("ROOM_NIGHTS_THU")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNightsTue)
                .HasColumnName("ROOM_NIGHTS_TUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNightsWed)
                .HasColumnName("ROOM_NIGHTS_WED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
