namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AccConBookingInfo
{
    public decimal? BookingId { get; set; }
    public string? Description { get; set; }
    public string? RmsOwner { get; set; }
    public decimal? RmsOwnerId { get; set; }
    public string? CatOwner { get; set; }
    public decimal? CatOwnerId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? BookingType { get; set; }
    public decimal? TotalRoomNights { get; set; }
    public decimal? AverageRate { get; set; }
    public decimal? TotalRoomRevenue { get; set; }
    public decimal? TotalActualRoomNights { get; set; }
    public decimal? ActualAverageRate { get; set; }
    public decimal? TotalActualRoomRevenue { get; set; }
    public DateTime? BookedDate { get; set; }
    public string? Source { get; set; }
    public string? MarketCode { get; set; }
    public string? IndustryCode { get; set; }
    public string? CateringonlyYn { get; set; }
    public decimal? TotalFoodRevenue { get; set; }
    public decimal? TotalBeverageRevenue { get; set; }
    public decimal? TotalRentalRevenue { get; set; }
    public decimal? TotalMiscRevenue { get; set; }
    public decimal? TotalActualFoodRevenue { get; set; }
    public decimal? TotalActualBeverageRevenue { get; set; }
    public decimal? TotalActualRentalRevenue { get; set; }
    public decimal? TotalActualMiscRevenue { get; set; }
    public string? AccountName { get; set; }
    public string? AgentName { get; set; }
    public string? ContactName { get; set; }
    public string? ContactPosition { get; set; }
    public string? ContactGreeting { get; set; }
    public string? ContactAddress1 { get; set; }
    public string? ContactCity { get; set; }
    public string? ContactState { get; set; }
    public string? ContactZipCode { get; set; }
    public string? ContactPrimaryPhone { get; set; }
    public string? ContactRelationship { get; set; }
    public string? ContactFirst { get; set; }
    public string? ContactLast { get; set; }
    public string? BookingStatus { get; set; }
    public string? CatStatus { get; set; }
    public decimal? ActualCovers { get; set; }
    public string? RoomsManager { get; set; }
    public string? CateringManager { get; set; }
    public string? BlockCode { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? BookedCovers { get; set; }
    public decimal? GuaranteedAttendees { get; set; }
    public decimal? AccountId { get; set; }
    public string? ContactName2 { get; set; }
    public string? ContactPosition2 { get; set; }
    public string? ContactGreeting2 { get; set; }
    public string? ContactAddress12 { get; set; }
    public string? ContactCity2 { get; set; }
    public string? ContactState2 { get; set; }
    public string? ContactZipCode2 { get; set; }
    public string? ContactPrimaryPhoneNo2 { get; set; }
    public string? ContactFirst2 { get; set; }
    public string? ContactLast2 { get; set; }
    public string? XaccountName { get; set; }
    public string? XcontactFullName { get; set; }
    public string? XcontactFullName2 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AccConBookingInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ACC_CON_BOOKING_INFO");

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ActualAverageRate)
                .HasColumnName("ACTUAL_AVERAGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualCovers)
                .HasColumnName("ACTUAL_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentName)
                .HasColumnName("AGENT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AverageRate)
                .HasColumnName("AVERAGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCode)
                .IsRequired()
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookedCovers)
                .HasColumnName("BOOKED_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookedDate)
                .HasColumnName("BOOKED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookingId)
                .HasColumnName("BOOKING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingStatus)
                .IsRequired()
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.BookingType)
                .HasColumnName("BOOKING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatOwner)
                .HasColumnName("CAT_OWNER")
                .IsUnicode(false);

            entity.Property(e => e.CatOwnerId)
                .HasColumnName("CAT_OWNER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatStatus)
                .HasColumnName("CAT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CateringManager)
                .HasColumnName("CATERING_MANAGER")
                .IsUnicode(false);

            entity.Property(e => e.CateringonlyYn)
                .HasColumnName("CATERINGONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ContactAddress1)
                .HasColumnName("CONTACT_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactAddress12)
                .HasColumnName("CONTACT_ADDRESS1_2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactCity)
                .HasColumnName("CONTACT_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactCity2)
                .HasColumnName("CONTACT_CITY_2")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactFirst)
                .HasColumnName("CONTACT_FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactFirst2)
                .HasColumnName("CONTACT_FIRST_2")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactGreeting)
                .HasColumnName("CONTACT_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.ContactGreeting2)
                .HasColumnName("CONTACT_GREETING_2")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.ContactLast)
                .HasColumnName("CONTACT_LAST")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactLast2)
                .HasColumnName("CONTACT_LAST_2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactName)
                .HasColumnName("CONTACT_NAME")
                .HasMaxLength(121)
                .IsUnicode(false);

            entity.Property(e => e.ContactName2)
                .HasColumnName("CONTACT_NAME_2")
                .HasMaxLength(121)
                .IsUnicode(false);

            entity.Property(e => e.ContactPosition)
                .HasColumnName("CONTACT_POSITION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactPosition2)
                .HasColumnName("CONTACT_POSITION_2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactPrimaryPhone)
                .HasColumnName("CONTACT_PRIMARY_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.ContactPrimaryPhoneNo2)
                .HasColumnName("CONTACT_PRIMARY_PHONE_NO_2")
                .IsUnicode(false);

            entity.Property(e => e.ContactRelationship)
                .HasColumnName("CONTACT_RELATIONSHIP")
                .IsUnicode(false);

            entity.Property(e => e.ContactState)
                .HasColumnName("CONTACT_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactState2)
                .HasColumnName("CONTACT_STATE_2")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactZipCode)
                .HasColumnName("CONTACT_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.ContactZipCode2)
                .HasColumnName("CONTACT_ZIP_CODE_2")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GuaranteedAttendees)
                .HasColumnName("GUARANTEED_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IndustryCode)
                .HasColumnName("INDUSTRY_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsOwner)
                .HasColumnName("RMS_OWNER")
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerId)
                .HasColumnName("RMS_OWNER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsManager)
                .HasColumnName("ROOMS_MANAGER")
                .IsUnicode(false);

            entity.Property(e => e.Source)
                .HasColumnName("SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalActualBeverageRevenue)
                .HasColumnName("TOTAL_ACTUAL_BEVERAGE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalActualFoodRevenue)
                .HasColumnName("TOTAL_ACTUAL_FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalActualMiscRevenue)
                .HasColumnName("TOTAL_ACTUAL_MISC_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalActualRentalRevenue)
                .HasColumnName("TOTAL_ACTUAL_RENTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalActualRoomNights)
                .HasColumnName("TOTAL_ACTUAL_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalActualRoomRevenue)
                .HasColumnName("TOTAL_ACTUAL_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalBeverageRevenue)
                .HasColumnName("TOTAL_BEVERAGE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFoodRevenue)
                .HasColumnName("TOTAL_FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalMiscRevenue)
                .HasColumnName("TOTAL_MISC_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRentalRevenue)
                .HasColumnName("TOTAL_RENTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomNights)
                .HasColumnName("TOTAL_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomRevenue)
                .HasColumnName("TOTAL_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.XaccountName)
                .HasColumnName("XACCOUNT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.XcontactFullName)
                .HasColumnName("XCONTACT_FULL_NAME")
                .HasMaxLength(121)
                .IsUnicode(false);

            entity.Property(e => e.XcontactFullName2)
                .HasColumnName("XCONTACT_FULL_NAME_2")
                .HasMaxLength(121)
                .IsUnicode(false);
        });
	}
}
