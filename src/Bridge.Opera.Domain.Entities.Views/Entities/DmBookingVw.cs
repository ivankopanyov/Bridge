namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DmBookingVw
{
    public decimal? PrimaryCompanyId { get; set; }
    public string PrimaryCompanyName { get; set; }
    public decimal? CompanyContactId { get; set; }
    public string CompanyContactName { get; set; }
    public decimal? PrimarySourceId { get; set; }
    public string PrimarySourceName { get; set; }
    public decimal? PrimaryAgentId { get; set; }
    public string PrimaryAgentName { get; set; }
    public decimal? AgentContactId { get; set; }
    public string AgentContactName { get; set; }
    public decimal BookingId { get; set; }
    public string Property { get; set; }
    public string PropertyName { get; set; }
    public string PropertyRegion { get; set; }
    public string PropertyRegionDesc { get; set; }
    public string PropertyCountry { get; set; }
    public string PropertyCountryDesc { get; set; }
    public string PropertyChain { get; set; }
    public string PropertyChainDesc { get; set; }
    public string MarketSegment { get; set; }
    public string MarketSegmentDesc { get; set; }
    public string MarketGroup { get; set; }
    public string MarketGroupDesc { get; set; }
    public string CompanyIndustry { get; set; }
    public string CompanyPriority { get; set; }
    public decimal? BlockOverallOwnerId { get; set; }
    public string BlockOverallOwner { get; set; }
    public decimal? BlockRoomsOwnerId { get; set; }
    public string BlockRoomsOwner { get; set; }
    public decimal? BlockCateringOwnerId { get; set; }
    public string BlockCateringOwner { get; set; }
    public string BlockOrigin { get; set; }
    public string ChangeCurrentStatus { get; set; }
    public DateTime? StatusChangeDate { get; set; }
    public DateTime BlockCreationDate { get; set; }
    public DateTime BlockStartDate { get; set; }
    public DateTime BlockEndDate { get; set; }
    public DateTime? BlockShoulderBeginDate { get; set; }
    public DateTime? BlockShoulderEndDate { get; set; }
    public string BookingType { get; set; }
    public string AccountType { get; set; }
    public string RevenueGroup1 { get; set; }
    public string RevenueGroupDesc1 { get; set; }
    public string RevenueGroup2 { get; set; }
    public string RevenueGroupDesc2 { get; set; }
    public string RevenueGroup3 { get; set; }
    public string RevenueGroupDesc3 { get; set; }
    public string RevenueGroup4 { get; set; }
    public string RevenueGroupDesc4 { get; set; }
    public string RevenueGroup5 { get; set; }
    public string RevenueGroupDesc5 { get; set; }
    public string RevenueGroup6 { get; set; }
    public string RevenueGroupDesc6 { get; set; }
    public decimal? InitialTotalRoomNights { get; set; }
    public decimal? InitialTotalRoomRevenue { get; set; }
    public decimal? CurrBlockedTotalRmNights { get; set; }
    public decimal? CurrBlockedTotalRmRev { get; set; }
    public decimal? PickedUpTotalRmNights { get; set; }
    public decimal? PickedUpTotalRmRev { get; set; }
    public decimal? BlockedPeakRmNights { get; set; }
    public decimal? ForecastRevenueGroup1 { get; set; }
    public decimal? ForecastRevenueGroup2 { get; set; }
    public decimal? ForecastRevenueGroup3 { get; set; }
    public decimal? ForecastRevenueGroup4 { get; set; }
    public decimal? ForecastRevenueGroup5 { get; set; }
    public decimal? ForecastRevenueGroup6 { get; set; }
    public decimal? ExpectedRevenueGroup1 { get; set; }
    public decimal? ExpectedRevenueGroup2 { get; set; }
    public decimal? ExpectedRevenueGroup3 { get; set; }
    public decimal? ExpectedRevenueGroup4 { get; set; }
    public decimal? ExpectedRevenueGroup5 { get; set; }
    public decimal? ExpectedRevenueGroup6 { get; set; }
    public decimal? BilledRevenueGroup1 { get; set; }
    public decimal? BilledRevenueGroup2 { get; set; }
    public decimal? BilledRevenueGroup3 { get; set; }
    public decimal? BilledRevenueGroup4 { get; set; }
    public decimal? BilledRevenueGroup5 { get; set; }
    public decimal? BilledRevenueGroup6 { get; set; }
    public decimal? ActualRevenueGroup1 { get; set; }
    public decimal? ActualRevenueGroup2 { get; set; }
    public decimal? ActualRevenueGroup3 { get; set; }
    public decimal? ActualRevenueGroup4 { get; set; }
    public decimal? ActualRevenueGroup5 { get; set; }
    public decimal? ActualRevenueGroup6 { get; set; }
    public decimal? CExchangeRate { get; set; }
    public decimal? CInitialTotalRoomRevenue { get; set; }
    public decimal? CCurrBlockedTotalRmRev { get; set; }
    public decimal? CPickedUpTotalRmRev { get; set; }
    public decimal? CForecastRevenueGroup1 { get; set; }
    public decimal? CForecastRevenueGroup2 { get; set; }
    public decimal? CForecastRevenueGroup3 { get; set; }
    public decimal? CForecastRevenueGroup4 { get; set; }
    public decimal? CForecastRevenueGroup5 { get; set; }
    public decimal? CForecastRevenueGroup6 { get; set; }
    public decimal? CExpectedRevenueGroup1 { get; set; }
    public decimal? CExpectedRevenueGroup2 { get; set; }
    public decimal? CExpectedRevenueGroup3 { get; set; }
    public decimal? CExpectedRevenueGroup4 { get; set; }
    public decimal? CExpectedRevenueGroup5 { get; set; }
    public decimal? CExpectedRevenueGroup6 { get; set; }
    public decimal? CBilledRevenueGroup1 { get; set; }
    public decimal? CBilledRevenueGroup2 { get; set; }
    public decimal? CBilledRevenueGroup3 { get; set; }
    public decimal? CBilledRevenueGroup4 { get; set; }
    public decimal? CBilledRevenueGroup5 { get; set; }
    public decimal? CBilledRevenueGroup6 { get; set; }
    public decimal? CActualRevenueGroup1 { get; set; }
    public decimal? CActualRevenueGroup2 { get; set; }
    public decimal? CActualRevenueGroup3 { get; set; }
    public decimal? CActualRevenueGroup4 { get; set; }
    public decimal? CActualRevenueGroup5 { get; set; }
    public decimal? CActualRevenueGroup6 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DmBookingVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DM_BOOKING_VW");

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActualRevenueGroup1)
                .HasColumnName("ACTUAL_REVENUE_GROUP_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenueGroup2)
                .HasColumnName("ACTUAL_REVENUE_GROUP_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenueGroup3)
                .HasColumnName("ACTUAL_REVENUE_GROUP_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenueGroup4)
                .HasColumnName("ACTUAL_REVENUE_GROUP_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenueGroup5)
                .HasColumnName("ACTUAL_REVENUE_GROUP_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenueGroup6)
                .HasColumnName("ACTUAL_REVENUE_GROUP_6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentContactId)
                .HasColumnName("AGENT_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentContactName)
                .HasColumnName("AGENT_CONTACT_NAME")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.BilledRevenueGroup1)
                .HasColumnName("BILLED_REVENUE_GROUP_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledRevenueGroup2)
                .HasColumnName("BILLED_REVENUE_GROUP_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledRevenueGroup3)
                .HasColumnName("BILLED_REVENUE_GROUP_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledRevenueGroup4)
                .HasColumnName("BILLED_REVENUE_GROUP_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledRevenueGroup5)
                .HasColumnName("BILLED_REVENUE_GROUP_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledRevenueGroup6)
                .HasColumnName("BILLED_REVENUE_GROUP_6")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.BlockedPeakRmNights)
                .HasColumnName("BLOCKED_PEAK_RM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingId)
                .HasColumnName("BOOKING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingType)
                .IsRequired()
                .HasColumnName("BOOKING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CActualRevenueGroup1)
                .HasColumnName("C_ACTUAL_REVENUE_GROUP_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CActualRevenueGroup2)
                .HasColumnName("C_ACTUAL_REVENUE_GROUP_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CActualRevenueGroup3)
                .HasColumnName("C_ACTUAL_REVENUE_GROUP_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CActualRevenueGroup4)
                .HasColumnName("C_ACTUAL_REVENUE_GROUP_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CActualRevenueGroup5)
                .HasColumnName("C_ACTUAL_REVENUE_GROUP_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CActualRevenueGroup6)
                .HasColumnName("C_ACTUAL_REVENUE_GROUP_6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CBilledRevenueGroup1)
                .HasColumnName("C_BILLED_REVENUE_GROUP_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CBilledRevenueGroup2)
                .HasColumnName("C_BILLED_REVENUE_GROUP_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CBilledRevenueGroup3)
                .HasColumnName("C_BILLED_REVENUE_GROUP_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CBilledRevenueGroup4)
                .HasColumnName("C_BILLED_REVENUE_GROUP_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CBilledRevenueGroup5)
                .HasColumnName("C_BILLED_REVENUE_GROUP_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CBilledRevenueGroup6)
                .HasColumnName("C_BILLED_REVENUE_GROUP_6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CCurrBlockedTotalRmRev)
                .HasColumnName("C_CURR_BLOCKED_TOTAL_RM_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CExchangeRate)
                .HasColumnName("C_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CExpectedRevenueGroup1)
                .HasColumnName("C_EXPECTED_REVENUE_GROUP_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CExpectedRevenueGroup2)
                .HasColumnName("C_EXPECTED_REVENUE_GROUP_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CExpectedRevenueGroup3)
                .HasColumnName("C_EXPECTED_REVENUE_GROUP_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CExpectedRevenueGroup4)
                .HasColumnName("C_EXPECTED_REVENUE_GROUP_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CExpectedRevenueGroup5)
                .HasColumnName("C_EXPECTED_REVENUE_GROUP_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CExpectedRevenueGroup6)
                .HasColumnName("C_EXPECTED_REVENUE_GROUP_6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CForecastRevenueGroup1)
                .HasColumnName("C_FORECAST_REVENUE_GROUP_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CForecastRevenueGroup2)
                .HasColumnName("C_FORECAST_REVENUE_GROUP_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CForecastRevenueGroup3)
                .HasColumnName("C_FORECAST_REVENUE_GROUP_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CForecastRevenueGroup4)
                .HasColumnName("C_FORECAST_REVENUE_GROUP_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CForecastRevenueGroup5)
                .HasColumnName("C_FORECAST_REVENUE_GROUP_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CForecastRevenueGroup6)
                .HasColumnName("C_FORECAST_REVENUE_GROUP_6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CInitialTotalRoomRevenue)
                .HasColumnName("C_INITIAL_TOTAL_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CPickedUpTotalRmRev)
                .HasColumnName("C_PICKED_UP_TOTAL_RM_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangeCurrentStatus)
                .IsRequired()
                .HasColumnName("CHANGE_CURRENT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CompanyContactId)
                .HasColumnName("COMPANY_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyContactName)
                .HasColumnName("COMPANY_CONTACT_NAME")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.CompanyIndustry)
                .HasColumnName("COMPANY_INDUSTRY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CompanyPriority)
                .HasColumnName("COMPANY_PRIORITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrBlockedTotalRmNights)
                .HasColumnName("CURR_BLOCKED_TOTAL_RM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrBlockedTotalRmRev)
                .HasColumnName("CURR_BLOCKED_TOTAL_RM_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenueGroup1)
                .HasColumnName("EXPECTED_REVENUE_GROUP_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenueGroup2)
                .HasColumnName("EXPECTED_REVENUE_GROUP_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenueGroup3)
                .HasColumnName("EXPECTED_REVENUE_GROUP_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenueGroup4)
                .HasColumnName("EXPECTED_REVENUE_GROUP_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenueGroup5)
                .HasColumnName("EXPECTED_REVENUE_GROUP_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenueGroup6)
                .HasColumnName("EXPECTED_REVENUE_GROUP_6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevenueGroup1)
                .HasColumnName("FORECAST_REVENUE_GROUP_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevenueGroup2)
                .HasColumnName("FORECAST_REVENUE_GROUP_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevenueGroup3)
                .HasColumnName("FORECAST_REVENUE_GROUP_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevenueGroup4)
                .HasColumnName("FORECAST_REVENUE_GROUP_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevenueGroup5)
                .HasColumnName("FORECAST_REVENUE_GROUP_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevenueGroup6)
                .HasColumnName("FORECAST_REVENUE_GROUP_6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InitialTotalRoomNights)
                .HasColumnName("INITIAL_TOTAL_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InitialTotalRoomRevenue)
                .HasColumnName("INITIAL_TOTAL_ROOM_REVENUE")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.PickedUpTotalRmNights)
                .HasColumnName("PICKED_UP_TOTAL_RM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickedUpTotalRmRev)
                .HasColumnName("PICKED_UP_TOTAL_RM_REV")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.RevenueGroup1)
                .HasColumnName("REVENUE_GROUP_1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueGroup2)
                .HasColumnName("REVENUE_GROUP_2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueGroup3)
                .HasColumnName("REVENUE_GROUP_3")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueGroup4)
                .HasColumnName("REVENUE_GROUP_4")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueGroup5)
                .HasColumnName("REVENUE_GROUP_5")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueGroup6)
                .HasColumnName("REVENUE_GROUP_6")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueGroupDesc1)
                .HasColumnName("REVENUE_GROUP_DESC_1")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RevenueGroupDesc2)
                .HasColumnName("REVENUE_GROUP_DESC_2")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RevenueGroupDesc3)
                .HasColumnName("REVENUE_GROUP_DESC_3")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RevenueGroupDesc4)
                .HasColumnName("REVENUE_GROUP_DESC_4")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RevenueGroupDesc5)
                .HasColumnName("REVENUE_GROUP_DESC_5")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RevenueGroupDesc6)
                .HasColumnName("REVENUE_GROUP_DESC_6")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.StatusChangeDate)
                .HasColumnName("STATUS_CHANGE_DATE")
                .HasColumnType("DATE");
        });
	}
}
