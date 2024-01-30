namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpDrkbBase
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? RecordNumber { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? HdrArrivalsToday { get; set; }
    public decimal? HdrUpsellArrivals { get; set; }
    public decimal? HdrDeparturesToday { get; set; }
    public decimal? HdrInHouseToday { get; set; }
    public decimal? HdrRoomRevenue { get; set; }
    public decimal? HdrRoomRevenueUpsell { get; set; }
    public decimal? RoomNights { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? RateAmount { get; set; }
    public decimal? TotalRoomRevenue { get; set; }
    public decimal? TotalAdjRoomRevenue { get; set; }
    public decimal? UpgradeUserId { get; set; }
    public decimal? ResvInsertUserId { get; set; }
    public string? RecordType { get; set; }
    public string? BusinessDateChar { get; set; }
    public string? CurrencyCode { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? RateWhy { get; set; }
    public string? UpgradeUser { get; set; }
    public string? UpgradeUserLastName { get; set; }
    public string? UpgradeUserFirstName { get; set; }
    public string? UpgradeBy { get; set; }
    public string? UpgradeWhy { get; set; }
    public string? ConfirmationNo { get; set; }
    public string? ExternalReference { get; set; }
    public string? ResvStatus { get; set; }
    public string? RoomNumber { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomType { get; set; }
    public string? BookedRoomCategory { get; set; }
    public string? Rtc { get; set; }
    public string? RateCode { get; set; }
    public string? RateCurrency { get; set; }
    public DateTime? BusinessDate { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public DateTime? StayDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpDrkbBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_DRKB_BASE");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BookedRoomCategory)
                .HasColumnName("BOOKED_ROOM_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BusinessDateChar)
                .HasColumnName("BUSINESS_DATE_CHAR")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExternalReference)
                .HasColumnName("EXTERNAL_REFERENCE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HdrArrivalsToday)
                .HasColumnName("HDR_ARRIVALS_TODAY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HdrDeparturesToday)
                .HasColumnName("HDR_DEPARTURES_TODAY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HdrInHouseToday)
                .HasColumnName("HDR_IN_HOUSE_TODAY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HdrRoomRevenue)
                .HasColumnName("HDR_ROOM_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HdrRoomRevenueUpsell)
                .HasColumnName("HDR_ROOM_REVENUE_UPSELL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HdrUpsellArrivals)
                .HasColumnName("HDR_UPSELL_ARRIVALS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCurrency)
                .HasColumnName("RATE_CURRENCY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateWhy)
                .HasColumnName("RATE_WHY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RecordNumber)
                .HasColumnName("RECORD_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvInsertUserId)
                .HasColumnName("RESV_INSERT_USER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomNights)
                .HasColumnName("ROOM_NIGHTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomNumber)
                .HasColumnName("ROOM_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Rtc)
                .HasColumnName("RTC")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalAdjRoomRevenue)
                .HasColumnName("TOTAL_ADJ_ROOM_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalRoomRevenue)
                .HasColumnName("TOTAL_ROOM_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpgradeBy)
                .HasColumnName("UPGRADE_BY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpgradeUser)
                .HasColumnName("UPGRADE_USER")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpgradeUserFirstName)
                .HasColumnName("UPGRADE_USER_FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpgradeUserId)
                .HasColumnName("UPGRADE_USER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpgradeUserLastName)
                .HasColumnName("UPGRADE_USER_LAST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpgradeWhy)
                .HasColumnName("UPGRADE_WHY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
