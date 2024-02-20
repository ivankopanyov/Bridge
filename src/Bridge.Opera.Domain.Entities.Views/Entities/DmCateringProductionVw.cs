namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DmCateringProductionVw
{
    public decimal? BookingId { get; set; }
    public decimal? PrimaryCompanyId { get; set; }
    public string? PrimaryCompanyName { get; set; }
    public decimal? CompanyContactId { get; set; }
    public string? CompanyContactName { get; set; }
    public decimal? PrimarySourceId { get; set; }
    public string? PrimarySourceName { get; set; }
    public decimal? PrimaryAgentId { get; set; }
    public string? PrimaryAgentName { get; set; }
    public decimal? AgentContactId { get; set; }
    public string? AgentContactName { get; set; }
    public string? Property { get; set; }
    public string? PropertyName { get; set; }
    public string? PropertyRegion { get; set; }
    public string? PropertyRegionDesc { get; set; }
    public string? PropertyCountry { get; set; }
    public string? PropertyCountryDesc { get; set; }
    public string? PropertyChain { get; set; }
    public string? PropertyChainDesc { get; set; }
    public string? MarketSegment { get; set; }
    public string? MarketSegmentDesc { get; set; }
    public string? MarketGroup { get; set; }
    public string? MarketGroupDesc { get; set; }
    public string? CompanyPriority { get; set; }
    public decimal? BlockOverallOwnerId { get; set; }
    public string? BlockOverallOwner { get; set; }
    public decimal? BlockRoomsOwnerId { get; set; }
    public string? BlockRoomsOwner { get; set; }
    public decimal? BlockCateringOwnerId { get; set; }
    public string? BlockCateringOwner { get; set; }
    public string? BlockOrigin { get; set; }
    public string? CateringOnlyYn { get; set; }
    public string? BlockCurrentStatus { get; set; }
    public DateTime? BlockCreationDate { get; set; }
    public DateTime? BlockStartDate { get; set; }
    public DateTime? BlockEndDate { get; set; }
    public DateTime? BlockShoulderBeginDate { get; set; }
    public DateTime? BlockShoulderEndDate { get; set; }
    public string? AccountType { get; set; }
    public string? BookingType { get; set; }
    public decimal? EventId { get; set; }
    public string? EventType { get; set; }
    public string? EventSpace { get; set; }
    public string? EventStatus { get; set; }
    public DateTime? EventStartDate { get; set; }
    public DateTime? EventEndDate { get; set; }
    public string? CoverableYn { get; set; }
    public string? EventStartTime { get; set; }
    public string? EventEndTime { get; set; }
    public decimal? ChangeId { get; set; }
    public decimal? ChangeEventAttendees { get; set; }
    public DateTime? ChangeDate { get; set; }
    public string? ChangeRevenueType { get; set; }
    public string? ChangeEventStatus { get; set; }
    public decimal? ChangeCateringOwnerId { get; set; }
    public string? ChangeCateringOwner { get; set; }
    public decimal? ChangeRevenue { get; set; }
    public string? CateringCurrency { get; set; }
    public string? HotelCurrency { get; set; }
    public decimal? ExchangeRateCatToHotel { get; set; }
    public decimal? CExchangeRate { get; set; }
    public decimal? CChangeRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DmCateringProductionVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DM_CATERING_PRODUCTION_VW");

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentContactId)
                .HasColumnName("AGENT_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentContactName)
                .HasColumnName("AGENT_CONTACT_NAME")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.BlockCateringOwner)
                .HasColumnName("BLOCK_CATERING_OWNER")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.BlockCateringOwnerId)
                .HasColumnName("BLOCK_CATERING_OWNER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockCreationDate)
                .HasColumnName("BLOCK_CREATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCurrentStatus)
                .IsRequired()
                .HasColumnName("BLOCK_CURRENT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.BlockEndDate)
                .HasColumnName("BLOCK_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockOrigin)
                .HasColumnName("BLOCK_ORIGIN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BlockOverallOwner)
                .HasColumnName("BLOCK_OVERALL_OWNER")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.BlockOverallOwnerId)
                .HasColumnName("BLOCK_OVERALL_OWNER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockRoomsOwner)
                .HasColumnName("BLOCK_ROOMS_OWNER")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.BlockRoomsOwnerId)
                .HasColumnName("BLOCK_ROOMS_OWNER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockShoulderBeginDate)
                .HasColumnName("BLOCK_SHOULDER_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockShoulderEndDate)
                .HasColumnName("BLOCK_SHOULDER_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockStartDate)
                .HasColumnName("BLOCK_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookingId)
                .HasColumnName("BOOKING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingType)
                .IsRequired()
                .HasColumnName("BOOKING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CChangeRevenue)
                .HasColumnName("C_CHANGE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CExchangeRate)
                .HasColumnName("C_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CateringCurrency)
                .HasColumnName("CATERING_CURRENCY")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CateringOnlyYn)
                .HasColumnName("CATERING_ONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChangeCateringOwner)
                .HasColumnName("CHANGE_CATERING_OWNER")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.ChangeCateringOwnerId)
                .HasColumnName("CHANGE_CATERING_OWNER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangeDate)
                .HasColumnName("CHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChangeEventAttendees)
                .HasColumnName("CHANGE_EVENT_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangeEventStatus)
                .HasColumnName("CHANGE_EVENT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ChangeId)
                .HasColumnName("CHANGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangeRevenue)
                .HasColumnName("CHANGE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangeRevenueType)
                .IsRequired()
                .HasColumnName("CHANGE_REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompanyContactId)
                .HasColumnName("COMPANY_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyContactName)
                .HasColumnName("COMPANY_CONTACT_NAME")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.CompanyPriority)
                .HasColumnName("COMPANY_PRIORITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CoverableYn)
                .HasColumnName("COVERABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EventEndDate)
                .HasColumnName("EVENT_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventEndTime)
                .HasColumnName("EVENT_END_TIME")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventSpace)
                .HasColumnName("EVENT_SPACE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventStartDate)
                .HasColumnName("EVENT_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventStartTime)
                .HasColumnName("EVENT_START_TIME")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.EventStatus)
                .HasColumnName("EVENT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.EventType)
                .IsRequired()
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRateCatToHotel)
                .HasColumnName("EXCHANGE_RATE_CAT_TO_HOTEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HotelCurrency)
                .HasColumnName("HOTEL_CURRENCY")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.MarketGroup)
                .HasColumnName("MARKET_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketGroupDesc)
                .HasColumnName("MARKET_GROUP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MarketSegment)
                .HasColumnName("MARKET_SEGMENT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketSegmentDesc)
                .HasColumnName("MARKET_SEGMENT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryAgentId)
                .HasColumnName("PRIMARY_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryAgentName)
                .HasColumnName("PRIMARY_AGENT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryCompanyId)
                .HasColumnName("PRIMARY_COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryCompanyName)
                .HasColumnName("PRIMARY_COMPANY_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PrimarySourceId)
                .HasColumnName("PRIMARY_SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimarySourceName)
                .HasColumnName("PRIMARY_SOURCE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Property)
                .IsRequired()
                .HasColumnName("PROPERTY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropertyChain)
                .HasColumnName("PROPERTY_CHAIN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropertyChainDesc)
                .HasColumnName("PROPERTY_CHAIN_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCountry)
                .HasColumnName("PROPERTY_COUNTRY")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCountryDesc)
                .HasColumnName("PROPERTY_COUNTRY_DESC")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.PropertyName)
                .HasColumnName("PROPERTY_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PropertyRegion)
                .HasColumnName("PROPERTY_REGION")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.PropertyRegionDesc)
                .HasColumnName("PROPERTY_REGION_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
