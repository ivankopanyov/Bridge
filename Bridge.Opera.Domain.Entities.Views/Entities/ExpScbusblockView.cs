namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpScbusblockView
{
    public decimal BusblockId { get; set; }
    public decimal? Owner { get; set; }
    public string OwnerCode { get; set; }
    public string OwnerCodeSrepname { get; set; }
    public string AllOwners { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Description { get; set; }
    public string GuaranteeCode { get; set; }
    public string BookingStatus { get; set; }
    public string CatStatus { get; set; }
    public decimal? RmsBlocked { get; set; }
    public decimal? RevBlocked { get; set; }
    public decimal? AvgRate { get; set; }
    public string Status { get; set; }
    public string AllotmentCode { get; set; }
    public DateTime? RmsDecision { get; set; }
    public DateTime? CatDecision { get; set; }
    public DateTime? RmsFollowup { get; set; }
    public DateTime? CatFollowup { get; set; }
    public DateTime? CatCutoff { get; set; }
    public DateTime? InvCutoffDate { get; set; }
    public string CateringonlyYn { get; set; }
    public decimal? RmsOwner { get; set; }
    public string RmsOwnerCode { get; set; }
    public string RmsOwnerSrepname { get; set; }
    public string RmsOwners { get; set; }
    public decimal? CatOwner { get; set; }
    public string CatOwnerCode { get; set; }
    public string CatOwnerSrepname { get; set; }
    public string CatOwners { get; set; }
    public decimal? CatRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public string RateCode { get; set; }
    public decimal? ActualRooms { get; set; }
    public decimal? ActualRevenue { get; set; }
    public decimal? ActualAvgRate { get; set; }
    public decimal? ProfileId { get; set; }
    public string ProfileDesc { get; set; }
    public decimal? AvailableRooms { get; set; }
    public decimal? AvailableRevenue { get; set; }
    public string ResortBooked { get; set; }
    public string AllotmentOrigion { get; set; }
    public string AllotmentType { get; set; }
    public string CurrencyCode { get; set; }
    public string RmsQuoteCurr { get; set; }
    public string CatQuoteCurr { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal? InvCutoffDays { get; set; }
    public string BookingStatusType { get; set; }
    public string CatStatusType { get; set; }
    public string Source { get; set; }
    public DateTime? CancellationDate { get; set; }
    public string CancellationCode { get; set; }
    public string Destination { get; set; }
    public string SuperBlockResort { get; set; }
    public int? SuperBlockId { get; set; }
    public string RelatedResorts { get; set; }
    public string CompRoomsFixedYn { get; set; }
    public decimal? CompRooms { get; set; }
    public string CompPerStayYn { get; set; }
    public decimal? CompRoomValue { get; set; }
    public DateTime? ArrivalTime { get; set; }
    public DateTime? DepartureTime { get; set; }
    public string Bookingtype { get; set; }
    public string MarketCode { get; set; }
    public decimal? Attendees { get; set; }
    public string BfstDesc { get; set; }
    public decimal? BfstPrice { get; set; }
    public string BfstYn { get; set; }
    public string Bookingmethod { get; set; }
    public decimal? CancellationNo { get; set; }
    public string CancellationDescription { get; set; }
    public string CatCanxCode { get; set; }
    public DateTime? CatCanxDate { get; set; }
    public string CatCanxDesc { get; set; }
    public decimal? CatCanxNo { get; set; }
    public string Channel { get; set; }
    public string Commission { get; set; }
    public string ContractNr { get; set; }
    public string CreditCardType { get; set; }
    public string CreditCardNumber { get; set; }
    public DateTime? CreditCardExpDate { get; set; }
    public string DetailsOkYn { get; set; }
    public string DistributedYn { get; set; }
    public decimal? Elastic { get; set; }
    public string EventsGuaranteedYn { get; set; }
    public string Infoboard { get; set; }
    public DateTime? MethodDue { get; set; }
    public string Functiontype { get; set; }
    public string PaymentMethod { get; set; }
    public decimal? PorteragePrice { get; set; }
    public string PorterageYn { get; set; }
    public string Representative { get; set; }
    public decimal? ServiceCharge { get; set; }
    public decimal? TaxAmount { get; set; }
    public string Tracecode { get; set; }
    public string CancelRule { get; set; }
    public decimal? AvgPeoplePerRoom { get; set; }
    public decimal? ActionId { get; set; }
    public string CatCurrency { get; set; }
    public decimal? CatExchange { get; set; }
    public string CatOwnerResort { get; set; }
    public decimal? CompanyNameId { get; set; }
    public DateTime? DateOpenedForPickup { get; set; }
    public decimal? DefaultPmResvNameId { get; set; }
    public decimal? ContactNameId { get; set; }
    public string ExchangePostingType { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string Info { get; set; }
    public string Mainmarket { get; set; }
    public decimal? MasterNameId { get; set; }
    public string OriginalRateCode { get; set; }
    public string OwnerResort { get; set; }
    public string ReserveInventoryYn { get; set; }
    public string RivMarketSegment { get; set; }
    public string RmsCurrency { get; set; }
    public decimal? RmsExchange { get; set; }
    public string RmsOwnerResort { get; set; }
    public decimal? RoomsPerDay { get; set; }
    public string SalesId { get; set; }
    public decimal? SourceNameId { get; set; }
    public decimal? TentativeLevel { get; set; }
    public decimal? AgentNameId { get; set; }
    public decimal? TotalComplimentaryRooms { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public string OwnerTitle { get; set; }
    public string OwnerPhone { get; set; }
    public string OwnerEmail { get; set; }
    public string OwnerFax { get; set; }
    public string RmsOwnerTitle { get; set; }
    public string RmsOwnerPhone { get; set; }
    public string RmsOwnerEmail { get; set; }
    public string RmsOwnerFax { get; set; }
    public string CatOwnerTitle { get; set; }
    public string CatOwnerPhone { get; set; }
    public string CatOwnerEmail { get; set; }
    public string CatOwnerFax { get; set; }
    public string Udfc01 { get; set; }
    public string Udfc02 { get; set; }
    public string Udfc03 { get; set; }
    public string Udfc04 { get; set; }
    public string Udfc05 { get; set; }
    public string Udfc06 { get; set; }
    public string Udfc07 { get; set; }
    public string Udfc08 { get; set; }
    public string Udfc09 { get; set; }
    public string Udfc10 { get; set; }
    public string Udfc11 { get; set; }
    public string Udfc12 { get; set; }
    public string Udfc13 { get; set; }
    public string Udfc14 { get; set; }
    public string Udfc15 { get; set; }
    public string Udfc16 { get; set; }
    public string Udfc17 { get; set; }
    public string Udfc18 { get; set; }
    public string Udfc19 { get; set; }
    public string Udfc20 { get; set; }
    public string Udfc21 { get; set; }
    public string Udfc22 { get; set; }
    public string Udfc23 { get; set; }
    public string Udfc24 { get; set; }
    public string Udfc25 { get; set; }
    public string Udfc26 { get; set; }
    public string Udfc27 { get; set; }
    public string Udfc28 { get; set; }
    public string Udfc29 { get; set; }
    public string Udfc30 { get; set; }
    public string Udfc31 { get; set; }
    public string Udfc32 { get; set; }
    public string Udfc33 { get; set; }
    public string Udfc34 { get; set; }
    public string Udfc35 { get; set; }
    public string Udfc36 { get; set; }
    public string Udfc37 { get; set; }
    public string Udfc38 { get; set; }
    public string Udfc39 { get; set; }
    public string Udfc40 { get; set; }
    public decimal? Udfn01 { get; set; }
    public decimal? Udfn02 { get; set; }
    public decimal? Udfn03 { get; set; }
    public decimal? Udfn04 { get; set; }
    public decimal? Udfn05 { get; set; }
    public decimal? Udfn06 { get; set; }
    public decimal? Udfn07 { get; set; }
    public decimal? Udfn08 { get; set; }
    public decimal? Udfn09 { get; set; }
    public decimal? Udfn10 { get; set; }
    public decimal? Udfn11 { get; set; }
    public decimal? Udfn12 { get; set; }
    public decimal? Udfn13 { get; set; }
    public decimal? Udfn14 { get; set; }
    public decimal? Udfn15 { get; set; }
    public decimal? Udfn16 { get; set; }
    public decimal? Udfn17 { get; set; }
    public decimal? Udfn18 { get; set; }
    public decimal? Udfn19 { get; set; }
    public decimal? Udfn20 { get; set; }
    public decimal? Udfn21 { get; set; }
    public decimal? Udfn22 { get; set; }
    public decimal? Udfn23 { get; set; }
    public decimal? Udfn24 { get; set; }
    public decimal? Udfn25 { get; set; }
    public decimal? Udfn26 { get; set; }
    public decimal? Udfn27 { get; set; }
    public decimal? Udfn28 { get; set; }
    public decimal? Udfn29 { get; set; }
    public decimal? Udfn30 { get; set; }
    public decimal? Udfn31 { get; set; }
    public decimal? Udfn32 { get; set; }
    public decimal? Udfn33 { get; set; }
    public decimal? Udfn34 { get; set; }
    public decimal? Udfn35 { get; set; }
    public decimal? Udfn36 { get; set; }
    public decimal? Udfn37 { get; set; }
    public decimal? Udfn38 { get; set; }
    public decimal? Udfn39 { get; set; }
    public decimal? Udfn40 { get; set; }
    public DateTime? Udfd01 { get; set; }
    public DateTime? Udfd02 { get; set; }
    public DateTime? Udfd03 { get; set; }
    public DateTime? Udfd04 { get; set; }
    public DateTime? Udfd05 { get; set; }
    public DateTime? Udfd06 { get; set; }
    public DateTime? Udfd07 { get; set; }
    public DateTime? Udfd08 { get; set; }
    public DateTime? Udfd09 { get; set; }
    public DateTime? Udfd10 { get; set; }
    public DateTime? Udfd11 { get; set; }
    public DateTime? Udfd12 { get; set; }
    public DateTime? Udfd13 { get; set; }
    public DateTime? Udfd14 { get; set; }
    public DateTime? Udfd15 { get; set; }
    public DateTime? Udfd16 { get; set; }
    public DateTime? Udfd17 { get; set; }
    public DateTime? Udfd18 { get; set; }
    public DateTime? Udfd19 { get; set; }
    public DateTime? Udfd20 { get; set; }
    public string Bookingmethoddesc { get; set; }
    public string AccRelationship { get; set; }
    public string AccRelationshipDesc { get; set; }
    public decimal? AccId { get; set; }
    public string AccName { get; set; }
    public string AccName2 { get; set; }
    public string AccName3 { get; set; }
    public string AccAddress1 { get; set; }
    public string AccAddress2 { get; set; }
    public string AccZipcode { get; set; }
    public string AccState { get; set; }
    public string AccCountry { get; set; }
    public string AccCity { get; set; }
    public string AccCityExt { get; set; }
    public string AccPhone { get; set; }
    public string AccFax { get; set; }
    public string AccEmail { get; set; }
    public string ConRelationship { get; set; }
    public string ConRelationshipDesc { get; set; }
    public decimal? ConId { get; set; }
    public string ConName { get; set; }
    public string ConLast { get; set; }
    public string ConFirst { get; set; }
    public string ConMiddle { get; set; }
    public string ConAddress1 { get; set; }
    public string ConAddress2 { get; set; }
    public string ConAddress3 { get; set; }
    public string ConAddress4 { get; set; }
    public string ConState { get; set; }
    public string ConCountry { get; set; }
    public string ConCity { get; set; }
    public string ConCityExt { get; set; }
    public string ContactZipcode { get; set; }
    public string ContactPhone { get; set; }
    public string ContactFax { get; set; }
    public string ContactEmail { get; set; }
    public string ConBusinessGreeting { get; set; }
    public string ConLetterGreeting { get; set; }
    public string ConPosition { get; set; }
    public string ConDepartment { get; set; }
    public string AgentRelationship { get; set; }
    public string AgentRelationshipDesc { get; set; }
    public decimal? AgentId { get; set; }
    public string AgentName { get; set; }
    public string AgentName2 { get; set; }
    public string AgentName3 { get; set; }
    public string AgentAddress1 { get; set; }
    public string AgentAddress2 { get; set; }
    public string AgentState { get; set; }
    public string AgentCountry { get; set; }
    public string AgentCity { get; set; }
    public string AgentCityExt { get; set; }
    public string AgentZipcode { get; set; }
    public string AgentPhone { get; set; }
    public string AgentFax { get; set; }
    public string AgentEmail { get; set; }
    public string IataCorpNo { get; set; }
    public string SourceRelationship { get; set; }
    public string SourceRelationshipDesc { get; set; }
    public decimal? SourceId { get; set; }
    public string SourceName { get; set; }
    public string SourceName2 { get; set; }
    public string SourceName3 { get; set; }
    public string SourceBusinessGreeting { get; set; }
    public string SourceAddress1 { get; set; }
    public string SourceAddress2 { get; set; }
    public string SourceState { get; set; }
    public string SourceCountry { get; set; }
    public string SourceCity { get; set; }
    public string SourceCityExt { get; set; }
    public string SourceZipcode { get; set; }
    public string SourcePhone { get; set; }
    public string SourceFax { get; set; }
    public string SourceEmail { get; set; }
    public decimal? PeakRooms { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpScbusblockView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SCBUSBLOCK_VIEW");

            entity.Property(e => e.AccAddress1)
                .HasColumnName("ACC_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccAddress2)
                .HasColumnName("ACC_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccCity)
                .HasColumnName("ACC_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccCityExt)
                .HasColumnName("ACC_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccCountry)
                .HasColumnName("ACC_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccEmail)
                .HasColumnName("ACC_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.AccFax)
                .HasColumnName("ACC_FAX")
                .IsUnicode(false);

            entity.Property(e => e.AccId)
                .HasColumnName("ACC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccName)
                .HasColumnName("ACC_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccName2)
                .HasColumnName("ACC_NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccName3)
                .HasColumnName("ACC_NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccPhone)
                .HasColumnName("ACC_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.AccRelationship)
                .HasColumnName("ACC_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccRelationshipDesc)
                .HasColumnName("ACC_RELATIONSHIP_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AccState)
                .HasColumnName("ACC_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccZipcode)
                .HasColumnName("ACC_ZIPCODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualAvgRate)
                .HasColumnName("ACTUAL_AVG_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenue)
                .HasColumnName("ACTUAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRooms)
                .HasColumnName("ACTUAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentAddress1)
                .HasColumnName("AGENT_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentAddress2)
                .HasColumnName("AGENT_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentCity)
                .HasColumnName("AGENT_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentCityExt)
                .HasColumnName("AGENT_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentCountry)
                .HasColumnName("AGENT_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentEmail)
                .HasColumnName("AGENT_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.AgentFax)
                .HasColumnName("AGENT_FAX")
                .IsUnicode(false);

            entity.Property(e => e.AgentId)
                .HasColumnName("AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentName)
                .HasColumnName("AGENT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentName2)
                .HasColumnName("AGENT_NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentName3)
                .HasColumnName("AGENT_NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentNameId)
                .HasColumnName("AGENT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentPhone)
                .HasColumnName("AGENT_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.AgentRelationship)
                .HasColumnName("AGENT_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentRelationshipDesc)
                .HasColumnName("AGENT_RELATIONSHIP_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AgentState)
                .HasColumnName("AGENT_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentZipcode)
                .HasColumnName("AGENT_ZIPCODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.AllOwners)
                .HasColumnName("ALL_OWNERS")
                .IsUnicode(false);

            entity.Property(e => e.AllotmentCode)
                .IsRequired()
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentOrigion)
                .HasColumnName("ALLOTMENT_ORIGION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentType)
                .IsRequired()
                .HasColumnName("ALLOTMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalTime)
                .HasColumnName("ARRIVAL_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvailableRevenue)
                .HasColumnName("AVAILABLE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvailableRooms)
                .HasColumnName("AVAILABLE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgPeoplePerRoom)
                .HasColumnName("AVG_PEOPLE_PER_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgRate)
                .HasColumnName("AVG_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BfstDesc)
                .HasColumnName("BFST_DESC")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BfstPrice)
                .HasColumnName("BFST_PRICE")
                .HasColumnType("NUMBER(9,2)");

            entity.Property(e => e.BfstYn)
                .HasColumnName("BFST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BookingStatus)
                .IsRequired()
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.BookingStatusType)
                .HasColumnName("BOOKING_STATUS_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Bookingmethod)
                .HasColumnName("BOOKINGMETHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Bookingmethoddesc)
                .HasColumnName("BOOKINGMETHODDESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Bookingtype)
                .HasColumnName("BOOKINGTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BusblockId)
                .HasColumnName("BUSBLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelRule)
                .HasColumnName("CANCEL_RULE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancellationCode)
                .HasColumnName("CANCELLATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancellationDescription)
                .HasColumnName("CANCELLATION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CancellationNo)
                .HasColumnName("CANCELLATION_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatCanxCode)
                .HasColumnName("CAT_CANX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatCanxDate)
                .HasColumnName("CAT_CANX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CatCanxDesc)
                .HasColumnName("CAT_CANX_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CatCanxNo)
                .HasColumnName("CAT_CANX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatCurrency)
                .HasColumnName("CAT_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatCutoff)
                .HasColumnName("CAT_CUTOFF")
                .HasColumnType("DATE");

            entity.Property(e => e.CatDecision)
                .HasColumnName("CAT_DECISION")
                .HasColumnType("DATE");

            entity.Property(e => e.CatExchange)
                .HasColumnName("CAT_EXCHANGE")
                .HasColumnType("NUMBER(9,2)");

            entity.Property(e => e.CatFollowup)
                .HasColumnName("CAT_FOLLOWUP")
                .HasColumnType("DATE");

            entity.Property(e => e.CatOwner)
                .HasColumnName("CAT_OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatOwnerCode)
                .HasColumnName("CAT_OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CatOwnerEmail)
                .HasColumnName("CAT_OWNER_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.CatOwnerFax)
                .HasColumnName("CAT_OWNER_FAX")
                .IsUnicode(false);

            entity.Property(e => e.CatOwnerPhone)
                .HasColumnName("CAT_OWNER_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.CatOwnerResort)
                .HasColumnName("CAT_OWNER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatOwnerSrepname)
                .HasColumnName("CAT_OWNER_SREPNAME")
                .IsUnicode(false);

            entity.Property(e => e.CatOwnerTitle)
                .HasColumnName("CAT_OWNER_TITLE")
                .IsUnicode(false);

            entity.Property(e => e.CatOwners)
                .HasColumnName("CAT_OWNERS")
                .IsUnicode(false);

            entity.Property(e => e.CatQuoteCurr)
                .HasColumnName("CAT_QUOTE_CURR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatRevenue)
                .HasColumnName("CAT_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatStatus)
                .HasColumnName("CAT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatStatusType)
                .HasColumnName("CAT_STATUS_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.CateringonlyYn)
                .HasColumnName("CATERINGONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Commission)
                .HasColumnName("COMMISSION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompPerStayYn)
                .HasColumnName("COMP_PER_STAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CompRoomValue)
                .HasColumnName("COMP_ROOM_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompRooms)
                .HasColumnName("COMP_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompRoomsFixedYn)
                .HasColumnName("COMP_ROOMS_FIXED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CompanyNameId)
                .HasColumnName("COMPANY_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConAddress1)
                .HasColumnName("CON_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConAddress2)
                .HasColumnName("CON_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConAddress3)
                .HasColumnName("CON_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConAddress4)
                .HasColumnName("CON_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConBusinessGreeting)
                .HasColumnName("CON_BUSINESS_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConCity)
                .HasColumnName("CON_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConCityExt)
                .HasColumnName("CON_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConCountry)
                .HasColumnName("CON_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConDepartment)
                .HasColumnName("CON_DEPARTMENT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ConFirst)
                .HasColumnName("CON_FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConId)
                .HasColumnName("CON_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConLast)
                .HasColumnName("CON_LAST")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConLetterGreeting)
                .HasColumnName("CON_LETTER_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.ConMiddle)
                .HasColumnName("CON_MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConName)
                .HasColumnName("CON_NAME")
                .HasMaxLength(162)
                .IsUnicode(false);

            entity.Property(e => e.ConPosition)
                .HasColumnName("CON_POSITION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConRelationship)
                .HasColumnName("CON_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConRelationshipDesc)
                .HasColumnName("CON_RELATIONSHIP_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ConState)
                .HasColumnName("CON_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactEmail)
                .HasColumnName("CONTACT_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.ContactFax)
                .HasColumnName("CONTACT_FAX")
                .IsUnicode(false);

            entity.Property(e => e.ContactNameId)
                .HasColumnName("CONTACT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContactPhone)
                .HasColumnName("CONTACT_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.ContactZipcode)
                .HasColumnName("CONTACT_ZIPCODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.ContractNr)
                .HasColumnName("CONTRACT_NR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardExpDate)
                .HasColumnName("CREDIT_CARD_EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreditCardNumber)
                .HasColumnName("CREDIT_CARD_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardType)
                .HasColumnName("CREDIT_CARD_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DateOpenedForPickup)
                .HasColumnName("DATE_OPENED_FOR_PICKUP")
                .HasColumnType("DATE");

            entity.Property(e => e.DefaultPmResvNameId)
                .HasColumnName("DEFAULT_PM_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartureTime)
                .HasColumnName("DEPARTURE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Destination)
                .HasColumnName("DESTINATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DetailsOkYn)
                .HasColumnName("DETAILS_OK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DistributedYn)
                .HasColumnName("DISTRIBUTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Elastic)
                .HasColumnName("ELASTIC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventsGuaranteedYn)
                .HasColumnName("EVENTS_GUARANTEED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExchangePostingType)
                .HasColumnName("EXCHANGE_POSTING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Functiontype)
                .HasColumnName("FUNCTIONTYPE")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IataCorpNo)
                .HasColumnName("IATA_CORP_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Info)
                .HasColumnName("INFO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Infoboard)
                .HasColumnName("INFOBOARD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvCutoffDate)
                .HasColumnName("INV_CUTOFF_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvCutoffDays)
                .HasColumnName("INV_CUTOFF_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Mainmarket)
                .HasColumnName("MAINMARKET")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MasterNameId)
                .HasColumnName("MASTER_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MethodDue)
                .HasColumnName("METHOD_DUE")
                .HasColumnType("DATE");

            entity.Property(e => e.OriginalRateCode)
                .HasColumnName("ORIGINAL_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Owner)
                .HasColumnName("OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerCode)
                .IsRequired()
                .HasColumnName("OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.OwnerCodeSrepname)
                .HasColumnName("OWNER_CODE_SREPNAME")
                .IsUnicode(false);

            entity.Property(e => e.OwnerEmail)
                .HasColumnName("OWNER_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.OwnerFax)
                .HasColumnName("OWNER_FAX")
                .IsUnicode(false);

            entity.Property(e => e.OwnerPhone)
                .HasColumnName("OWNER_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.OwnerResort)
                .HasColumnName("OWNER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OwnerTitle)
                .HasColumnName("OWNER_TITLE")
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PeakRooms)
                .HasColumnName("PEAK_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PorteragePrice)
                .HasColumnName("PORTERAGE_PRICE")
                .HasColumnType("NUMBER(9,2)");

            entity.Property(e => e.PorterageYn)
                .HasColumnName("PORTERAGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProfileDesc)
                .HasColumnName("PROFILE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ProfileId)
                .HasColumnName("PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RelatedResorts)
                .HasColumnName("RELATED_RESORTS")
                .IsUnicode(false);

            entity.Property(e => e.Representative)
                .HasColumnName("REPRESENTATIVE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReserveInventoryYn)
                .HasColumnName("RESERVE_INVENTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResortBooked)
                .HasColumnName("RESORT_BOOKED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevBlocked)
                .HasColumnName("REV_BLOCKED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RivMarketSegment)
                .HasColumnName("RIV_MARKET_SEGMENT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsBlocked)
                .HasColumnName("RMS_BLOCKED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmsCurrency)
                .HasColumnName("RMS_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsDecision)
                .HasColumnName("RMS_DECISION")
                .HasColumnType("DATE");

            entity.Property(e => e.RmsExchange)
                .HasColumnName("RMS_EXCHANGE")
                .HasColumnType("NUMBER(9,2)");

            entity.Property(e => e.RmsFollowup)
                .HasColumnName("RMS_FOLLOWUP")
                .HasColumnType("DATE");

            entity.Property(e => e.RmsOwner)
                .HasColumnName("RMS_OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmsOwnerCode)
                .HasColumnName("RMS_OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerEmail)
                .HasColumnName("RMS_OWNER_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerFax)
                .HasColumnName("RMS_OWNER_FAX")
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerPhone)
                .HasColumnName("RMS_OWNER_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerResort)
                .HasColumnName("RMS_OWNER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerSrepname)
                .HasColumnName("RMS_OWNER_SREPNAME")
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerTitle)
                .HasColumnName("RMS_OWNER_TITLE")
                .IsUnicode(false);

            entity.Property(e => e.RmsOwners)
                .HasColumnName("RMS_OWNERS")
                .IsUnicode(false);

            entity.Property(e => e.RmsQuoteCurr)
                .HasColumnName("RMS_QUOTE_CURR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomsPerDay)
                .HasColumnName("ROOMS_PER_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SalesId)
                .HasColumnName("SALES_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ServiceCharge)
                .HasColumnName("SERVICE_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Source)
                .HasColumnName("SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceAddress1)
                .HasColumnName("SOURCE_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceAddress2)
                .HasColumnName("SOURCE_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceBusinessGreeting)
                .HasColumnName("SOURCE_BUSINESS_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.SourceCity)
                .HasColumnName("SOURCE_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceCityExt)
                .HasColumnName("SOURCE_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCountry)
                .HasColumnName("SOURCE_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceEmail)
                .HasColumnName("SOURCE_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.SourceFax)
                .HasColumnName("SOURCE_FAX")
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceName2)
                .HasColumnName("SOURCE_NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceName3)
                .HasColumnName("SOURCE_NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceNameId)
                .HasColumnName("SOURCE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourcePhone)
                .HasColumnName("SOURCE_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.SourceRelationship)
                .HasColumnName("SOURCE_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceRelationshipDesc)
                .HasColumnName("SOURCE_RELATIONSHIP_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SourceState)
                .HasColumnName("SOURCE_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceZipcode)
                .HasColumnName("SOURCE_ZIPCODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SuperBlockId).HasColumnName("SUPER_BLOCK_ID");

            entity.Property(e => e.SuperBlockResort)
                .HasColumnName("SUPER_BLOCK_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxAmount)
                .HasColumnName("TAX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TentativeLevel)
                .HasColumnName("TENTATIVE_LEVEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalComplimentaryRooms)
                .HasColumnName("TOTAL_COMPLIMENTARY_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tracecode)
                .HasColumnName("TRACECODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc03)
                .HasColumnName("UDFC03")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc04)
                .HasColumnName("UDFC04")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc05)
                .HasColumnName("UDFC05")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc07)
                .HasColumnName("UDFC07")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc08)
                .HasColumnName("UDFC08")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc09)
                .HasColumnName("UDFC09")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc10)
                .HasColumnName("UDFC10")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc11)
                .HasColumnName("UDFC11")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc12)
                .HasColumnName("UDFC12")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc13)
                .HasColumnName("UDFC13")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc14)
                .HasColumnName("UDFC14")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc15)
                .HasColumnName("UDFC15")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc16)
                .HasColumnName("UDFC16")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc17)
                .HasColumnName("UDFC17")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc18)
                .HasColumnName("UDFC18")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc19)
                .HasColumnName("UDFC19")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc20)
                .HasColumnName("UDFC20")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc21)
                .HasColumnName("UDFC21")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc22)
                .HasColumnName("UDFC22")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc23)
                .HasColumnName("UDFC23")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc24)
                .HasColumnName("UDFC24")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc25)
                .HasColumnName("UDFC25")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc26)
                .HasColumnName("UDFC26")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc27)
                .HasColumnName("UDFC27")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc28)
                .HasColumnName("UDFC28")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc29)
                .HasColumnName("UDFC29")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc30)
                .HasColumnName("UDFC30")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc31)
                .HasColumnName("UDFC31")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc32)
                .HasColumnName("UDFC32")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc33)
                .HasColumnName("UDFC33")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc34)
                .HasColumnName("UDFC34")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc35)
                .HasColumnName("UDFC35")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc36)
                .HasColumnName("UDFC36")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc37)
                .HasColumnName("UDFC37")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc38)
                .HasColumnName("UDFC38")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc39)
                .HasColumnName("UDFC39")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc40)
                .HasColumnName("UDFC40")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfd01)
                .HasColumnName("UDFD01")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd02)
                .HasColumnName("UDFD02")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd03)
                .HasColumnName("UDFD03")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd04)
                .HasColumnName("UDFD04")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd05)
                .HasColumnName("UDFD05")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd06)
                .HasColumnName("UDFD06")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd07)
                .HasColumnName("UDFD07")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd08)
                .HasColumnName("UDFD08")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd09)
                .HasColumnName("UDFD09")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd10)
                .HasColumnName("UDFD10")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd11)
                .HasColumnName("UDFD11")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd12)
                .HasColumnName("UDFD12")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd13)
                .HasColumnName("UDFD13")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd14)
                .HasColumnName("UDFD14")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd15)
                .HasColumnName("UDFD15")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd16)
                .HasColumnName("UDFD16")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd17)
                .HasColumnName("UDFD17")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd18)
                .HasColumnName("UDFD18")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd19)
                .HasColumnName("UDFD19")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd20)
                .HasColumnName("UDFD20")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfn01)
                .HasColumnName("UDFN01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn02)
                .HasColumnName("UDFN02")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn03)
                .HasColumnName("UDFN03")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn04)
                .HasColumnName("UDFN04")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn05)
                .HasColumnName("UDFN05")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn06)
                .HasColumnName("UDFN06")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn07)
                .HasColumnName("UDFN07")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn08)
                .HasColumnName("UDFN08")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn09)
                .HasColumnName("UDFN09")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn10)
                .HasColumnName("UDFN10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn11)
                .HasColumnName("UDFN11")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn12)
                .HasColumnName("UDFN12")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn13)
                .HasColumnName("UDFN13")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn14)
                .HasColumnName("UDFN14")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn15)
                .HasColumnName("UDFN15")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn16)
                .HasColumnName("UDFN16")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn17)
                .HasColumnName("UDFN17")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn18)
                .HasColumnName("UDFN18")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn19)
                .HasColumnName("UDFN19")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn20)
                .HasColumnName("UDFN20")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn21)
                .HasColumnName("UDFN21")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn22)
                .HasColumnName("UDFN22")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn23)
                .HasColumnName("UDFN23")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn24)
                .HasColumnName("UDFN24")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn25)
                .HasColumnName("UDFN25")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn26)
                .HasColumnName("UDFN26")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn27)
                .HasColumnName("UDFN27")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn28)
                .HasColumnName("UDFN28")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn29)
                .HasColumnName("UDFN29")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn30)
                .HasColumnName("UDFN30")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn31)
                .HasColumnName("UDFN31")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn32)
                .HasColumnName("UDFN32")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn33)
                .HasColumnName("UDFN33")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn34)
                .HasColumnName("UDFN34")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn35)
                .HasColumnName("UDFN35")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn36)
                .HasColumnName("UDFN36")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn37)
                .HasColumnName("UDFN37")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn38)
                .HasColumnName("UDFN38")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn39)
                .HasColumnName("UDFN39")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn40)
                .HasColumnName("UDFN40")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
