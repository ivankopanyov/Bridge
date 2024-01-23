namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiProductViewUnionAll
{
    public decimal? NameId { get; set; }
    public string ProdMonth { get; set; }
    public DateTime? FirstOfMonth { get; set; }
    public decimal? RoomNights { get; set; }
    public decimal? RoomRevenueNet { get; set; }
    public decimal? FoodRevenueNet { get; set; }
    public decimal? TotalRevenueNet { get; set; }
    public decimal? OtherRevenueNet { get; set; }
    public decimal? RoomRevenueGross { get; set; }
    public decimal? FoodRevenueGross { get; set; }
    public decimal? TotalRevenueGross { get; set; }
    public decimal? OtherRevenueGross { get; set; }
    public decimal? Persons { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? Children1 { get; set; }
    public decimal? Children2 { get; set; }
    public decimal? Children3 { get; set; }
    public decimal? Children4 { get; set; }
    public decimal? Children5 { get; set; }
    public decimal? Arrivals { get; set; }
    public decimal? Cancels { get; set; }
    public decimal? NoShows { get; set; }
    public decimal? DayUse { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? NonRevenueNet { get; set; }
    public decimal? NonRevenueGross { get; set; }
    public decimal? ReservationNights { get; set; }
    public decimal? CancelledReservations { get; set; }
    public decimal? NoShowReservations { get; set; }
    public decimal? DayUseReservations { get; set; }
    public decimal? ReservationArrivals { get; set; }
    public decimal? ReservationNoOfStays { get; set; }
    public decimal? IndRoomNights { get; set; }
    public decimal? IndRoomRevenueGross { get; set; }
    public decimal? IndRoomRevenueNet { get; set; }
    public decimal? BlkRoomNights { get; set; }
    public decimal? BlkRoomRevenueGross { get; set; }
    public decimal? IndFoodRevenueGross { get; set; }
    public decimal? BlkFoodRevenueGross { get; set; }
    public decimal? IndOtherRevenueGross { get; set; }
    public decimal? BlkOtherRevenueGross { get; set; }
    public decimal? BlkRoomRevenueNet { get; set; }
    public decimal? IndFoodRevenueNet { get; set; }
    public decimal? BlkFoodRevenueNet { get; set; }
    public decimal? IndOtherRevenueNet { get; set; }
    public decimal? BlkOtherRevenueNet { get; set; }
    public string Resort { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public string CurrencyCode { get; set; }
    public string PseudoYn { get; set; }
    public string NameType { get; set; }
    public decimal? MasterNameId { get; set; }
    public decimal? NameIdStayed { get; set; }
    public decimal? NameIdBooked { get; set; }
    public string MarketCode { get; set; }
    public string Channel { get; set; }
    public string SourceCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiProductViewUnionAll>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_PRODUCT_VIEW_UNION_ALL");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrivals)
                .HasColumnName("ARRIVALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkFoodRevenueGross)
                .HasColumnName("BLK_FOOD_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkFoodRevenueNet)
                .HasColumnName("BLK_FOOD_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkOtherRevenueGross)
                .HasColumnName("BLK_OTHER_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkOtherRevenueNet)
                .HasColumnName("BLK_OTHER_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkRoomNights)
                .HasColumnName("BLK_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkRoomRevenueGross)
                .HasColumnName("BLK_ROOM_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkRoomRevenueNet)
                .HasColumnName("BLK_ROOM_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelledReservations)
                .HasColumnName("CANCELLED_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cancels)
                .HasColumnName("CANCELS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children1)
                .HasColumnName("CHILDREN1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children2)
                .HasColumnName("CHILDREN2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children3)
                .HasColumnName("CHILDREN3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children4)
                .HasColumnName("CHILDREN4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children5)
                .HasColumnName("CHILDREN5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.DayUse)
                .HasColumnName("DAY_USE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseReservations)
                .HasColumnName("DAY_USE_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstOfMonth)
                .HasColumnName("FIRST_OF_MONTH")
                .HasColumnType("DATE");

            entity.Property(e => e.FoodRevenueGross)
                .HasColumnName("FOOD_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodRevenueNet)
                .HasColumnName("FOOD_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndFoodRevenueGross)
                .HasColumnName("IND_FOOD_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndFoodRevenueNet)
                .HasColumnName("IND_FOOD_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndOtherRevenueGross)
                .HasColumnName("IND_OTHER_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndOtherRevenueNet)
                .HasColumnName("IND_OTHER_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndRoomNights)
                .HasColumnName("IND_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndRoomRevenueGross)
                .HasColumnName("IND_ROOM_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndRoomRevenueNet)
                .HasColumnName("IND_ROOM_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .IsUnicode(false);

            entity.Property(e => e.MasterNameId)
                .HasColumnName("MASTER_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameIdBooked)
                .HasColumnName("NAME_ID_BOOKED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameIdStayed)
                .HasColumnName("NAME_ID_STAYED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.NoShowReservations)
                .HasColumnName("NO_SHOW_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShows)
                .HasColumnName("NO_SHOWS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenueGross)
                .HasColumnName("NON_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenueNet)
                .HasColumnName("NON_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenueGross)
                .HasColumnName("OTHER_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenueNet)
                .HasColumnName("OTHER_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Persons)
                .HasColumnName("PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProdMonth)
                .HasColumnName("PROD_MONTH")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.PseudoYn)
                .HasColumnName("PSEUDO_YN")
                .HasColumnType("CHAR(1)");

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
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomNights)
                .HasColumnName("ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueGross)
                .HasColumnName("ROOM_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueNet)
                .HasColumnName("ROOM_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.TotalRevenueGross)
                .HasColumnName("TOTAL_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueNet)
                .HasColumnName("TOTAL_REVENUE_NET")
                .HasColumnType("NUMBER");
        });
	}
}
