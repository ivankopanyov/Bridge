namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DmStayVw
{
    public string Resort { get; set; }
    public string RegionCode { get; set; }
    public string ReservationId { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public string ReservationStatus { get; set; }
    public string OccupancyType { get; set; }
    public string MarketCode { get; set; }
    public string MarketCodeDesc { get; set; }
    public string MarketGroup { get; set; }
    public string MarketGroupDesc { get; set; }
    public string SourceGroup { get; set; }
    public string SourceGroupDesc { get; set; }
    public string SourceCode { get; set; }
    public string SourceCodeDesc { get; set; }
    public string Channel { get; set; }
    public string ChannelDesc { get; set; }
    public string RateClass { get; set; }
    public string RateClassDesc { get; set; }
    public string RateCategory { get; set; }
    public string RateCategoryDesc { get; set; }
    public string RateCode { get; set; }
    public string RateCodeDesc { get; set; }
    public string RoomCategoryCode { get; set; }
    public string RoomCategoryDesc { get; set; }
    public string RoomClass { get; set; }
    public string RoomClassDesc { get; set; }
    public string PromotionCode { get; set; }
    public string PromotionCodeDesc { get; set; }
    public string VipCode { get; set; }
    public string VipCodeDesc { get; set; }
    public decimal? TotalRevenueNet { get; set; }
    public decimal? RoomRevenueNet { get; set; }
    public decimal? FBRevenueNet { get; set; }
    public decimal? OtherRevenueNet { get; set; }
    public decimal? NonRevenueNet { get; set; }
    public decimal? TotalRevenueGross { get; set; }
    public decimal? RoomRevenueGross { get; set; }
    public decimal? FBRevenueGross { get; set; }
    public decimal? OtherRevenueGross { get; set; }
    public decimal? NonRevenueGross { get; set; }
    public decimal? RoomsOccupied { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? Nights { get; set; }
    public DateTime Timestamp { get; set; }
    public decimal? CExchangeRate { get; set; }
    public decimal? CTotalRevenueNet { get; set; }
    public decimal? CRoomRevenueNet { get; set; }
    public decimal? CFBRevenueNet { get; set; }
    public decimal? COtherRevenueNet { get; set; }
    public decimal? CNonRevenueNet { get; set; }
    public decimal? CTotalRevenueGross { get; set; }
    public decimal? CRoomRevenueGross { get; set; }
    public decimal? CFBRevenueGross { get; set; }
    public decimal? COtherRevenueGross { get; set; }
    public decimal? CNonRevenueGross { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DmStayVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DM_STAY_VW");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CExchangeRate)
                .HasColumnName("C_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CFBRevenueGross)
                .HasColumnName("C_F_B_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CFBRevenueNet)
                .HasColumnName("C_F_B_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CNonRevenueGross)
                .HasColumnName("C_NON_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CNonRevenueNet)
                .HasColumnName("C_NON_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.COtherRevenueGross)
                .HasColumnName("C_OTHER_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.COtherRevenueNet)
                .HasColumnName("C_OTHER_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRoomRevenueGross)
                .HasColumnName("C_ROOM_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRoomRevenueNet)
                .HasColumnName("C_ROOM_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTotalRevenueGross)
                .HasColumnName("C_TOTAL_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTotalRevenueNet)
                .HasColumnName("C_TOTAL_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChannelDesc)
                .HasColumnName("CHANNEL_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FBRevenueGross)
                .HasColumnName("F_B_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FBRevenueNet)
                .HasColumnName("F_B_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketCodeDesc)
                .HasColumnName("MARKET_CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MarketGroup)
                .HasColumnName("MARKET_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketGroupDesc)
                .HasColumnName("MARKET_GROUP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenueGross)
                .HasColumnName("NON_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenueNet)
                .HasColumnName("NON_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccupancyType)
                .HasColumnName("OCCUPANCY_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OtherRevenueGross)
                .HasColumnName("OTHER_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenueNet)
                .HasColumnName("OTHER_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PromotionCode)
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCodeDesc)
                .HasColumnName("PROMOTION_CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCategoryDesc)
                .HasColumnName("RATE_CATEGORY_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateClass)
                .HasColumnName("RATE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateClassDesc)
                .HasColumnName("RATE_CLASS_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCodeDesc)
                .HasColumnName("RATE_CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.ReservationId)
                .HasColumnName("RESERVATION_ID")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ReservationStatus)
                .HasColumnName("RESERVATION_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryCode)
                .HasColumnName("ROOM_CATEGORY_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryDesc)
                .HasColumnName("ROOM_CATEGORY_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClassDesc)
                .HasColumnName("ROOM_CLASS_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenueGross)
                .HasColumnName("ROOM_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueNet)
                .HasColumnName("ROOM_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsOccupied)
                .HasColumnName("ROOMS_OCCUPIED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCodeDesc)
                .HasColumnName("SOURCE_CODE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SourceGroup)
                .HasColumnName("SOURCE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceGroupDesc)
                .HasColumnName("SOURCE_GROUP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Timestamp)
                .HasColumnName("TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.TotalRevenueGross)
                .HasColumnName("TOTAL_REVENUE_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenueNet)
                .HasColumnName("TOTAL_REVENUE_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VipCode)
                .HasColumnName("VIP_CODE")
                .IsUnicode(false);

            entity.Property(e => e.VipCodeDesc)
                .HasColumnName("VIP_CODE_DESC")
                .IsUnicode(false);
        });
	}
}
