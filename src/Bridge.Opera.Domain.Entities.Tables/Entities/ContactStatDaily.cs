namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ContactStatDaily
{
    public string? Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? NameId { get; set; }
    public string? RoomType { get; set; }
    public decimal? NoOfDefinitieRooms { get; set; }
    public decimal? NoOfGuests { get; set; }
    public decimal? SingleOccupancy { get; set; }
    public decimal? MultipleOccupancy { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? TotalRoomRevenue { get; set; }
    public decimal? TotalFBRevenue { get; set; }
    public decimal? TotalOtherRevenue { get; set; }
    public decimal? TotalPackageRevenue { get; set; }
    public decimal? TotalPackageRoomRevenue { get; set; }
    public decimal? TotalPackageFBRevenue { get; set; }
    public decimal? TotalPackageOtherRevenue { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? TotalRoomTax { get; set; }
    public decimal? TotalFBTax { get; set; }
    public decimal? TotalOtherTax { get; set; }
    public decimal? DayUseRooms { get; set; }
    public decimal? DayUsePersons { get; set; }
    public decimal? NoShowRooms { get; set; }
    public decimal? NoShowPersons { get; set; }
    public decimal? CancelRomms { get; set; }
    public decimal? Cribs { get; set; }
    public decimal? ExtraBeds { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? Nights { get; set; }
    public decimal? Arrivals { get; set; }
    public decimal? NoOfStays { get; set; }
    public decimal? TotalNonRevenue { get; set; }
    public decimal? TotalPackageNonRevenue { get; set; }
    public decimal? TotalNonRevenueTax { get; set; }
    public decimal? ReservationNights { get; set; }
    public decimal? ReservationArrivals { get; set; }
    public decimal? ReservationNoOfStays { get; set; }
    public decimal? DayUseReservations { get; set; }
    public decimal? CancelledReservations { get; set; }
    public decimal? NoShowReservations { get; set; }
    public string? BlockYn { get; set; }
    public string? CentralCurrencyCode { get; set; }
    public decimal? CentralExchangeRate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ContactStatDaily>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CONTACT_STAT_DAILY");

            entity.HasIndex(e => new { e.NameId, e.Resort, e.RoomType, e.BusinessDate, e.BlockYn })
                .HasName("CONTACT_STAT_DAILY_IND1")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.BusinessDate, e.NameId, e.RoomType, e.BlockYn })
                .HasName("CONTACT_STAT_DAILY_UK")
                .IsUnique();

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrivals)
                .HasColumnName("ARRIVALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockYn)
                .HasColumnName("BLOCK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancelRomms)
                .HasColumnName("CANCEL_ROMMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelledReservations)
                .HasColumnName("CANCELLED_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CentralCurrencyCode)
                .HasColumnName("CENTRAL_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CentralExchangeRate)
                .HasColumnName("CENTRAL_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cribs)
                .HasColumnName("CRIBS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUsePersons)
                .HasColumnName("DAY_USE_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseReservations)
                .HasColumnName("DAY_USE_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseRooms)
                .HasColumnName("DAY_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtraBeds)
                .HasColumnName("EXTRA_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultipleOccupancy)
                .HasColumnName("MULTIPLE_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfDefinitieRooms)
                .HasColumnName("NO_OF_DEFINITIE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfGuests)
                .HasColumnName("NO_OF_GUESTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfStays)
                .HasColumnName("NO_OF_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowPersons)
                .HasColumnName("NO_SHOW_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowReservations)
                .HasColumnName("NO_SHOW_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRooms)
                .HasColumnName("NO_SHOW_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationArrivals)
                .HasColumnName("RESERVATION_ARRIVALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationNights)
                .HasColumnName("RESERVATION_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationNoOfStays)
                .HasColumnName("RESERVATION_NO_OF_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .IsRequired()
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.SingleOccupancy)
                .HasColumnName("SINGLE_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFBRevenue)
                .HasColumnName("TOTAL_F_B_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalFBTax)
                .HasColumnName("TOTAL_F_B_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalNonRevenue)
                .HasColumnName("TOTAL_NON_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalNonRevenueTax)
                .HasColumnName("TOTAL_NON_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalOtherRevenue)
                .HasColumnName("TOTAL_OTHER_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalOtherTax)
                .HasColumnName("TOTAL_OTHER_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageFBRevenue)
                .HasColumnName("TOTAL_PACKAGE_F_B_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageNonRevenue)
                .HasColumnName("TOTAL_PACKAGE_NON_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageOtherRevenue)
                .HasColumnName("TOTAL_PACKAGE_OTHER_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageRevenue)
                .HasColumnName("TOTAL_PACKAGE_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageRoomRevenue)
                .HasColumnName("TOTAL_PACKAGE_ROOM_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRoomRevenue)
                .HasColumnName("TOTAL_ROOM_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRoomTax)
                .HasColumnName("TOTAL_ROOM_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalTax)
                .HasColumnName("TOTAL_TAX")
                .HasColumnType("NUMBER(38,12)");
        });
	}
}
