namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExportGroupBookings
{
    public string RecordType { get; set; }
    public string SourceSystem { get; set; }
    public string PropertyCode { get; set; }
    public string TransactionType { get; set; }
    public decimal AllotmentHeaderId { get; set; }
    public decimal? CompanyNameId { get; set; }
    public string BookingStatus { get; set; }
    public string Description { get; set; }
    public DateTime InsertDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public DateTime? StatusDate { get; set; }
    public string OwnerCode { get; set; }
    public string RmsOwnerCode { get; set; }
    public string CatOwnerCode { get; set; }
    public string MarketCode { get; set; }
    public string Source { get; set; }
    public decimal? CommissionRev { get; set; }
    public decimal? Commission { get; set; }
    public string AgentName { get; set; }
    public string IataCompType { get; set; }
    public decimal? AgentNameId { get; set; }
    public string CancellationCode { get; set; }
    public string CancellationDesc { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string BookingType { get; set; }
    public string RmsCurrencyCode { get; set; }
    public string CateringCurrencyCode { get; set; }
    public decimal? SuperBlockId { get; set; }
    public string SuperBlockResort { get; set; }
    public string Udfc02 { get; set; }
    public string Udfc04 { get; set; }
    public decimal? PeakAttendees { get; set; }
    public DateTime? DateOpen { get; set; }
    public string CompanyName { get; set; }
    public decimal? SourceNameId { get; set; }
    public string SourceName { get; set; }
    public decimal? CompanyContactId { get; set; }
    public decimal? AgentContactId { get; set; }
    public decimal? SourceContactId { get; set; }
    public string Udfc14 { get; set; }
    public string Udfc05Code { get; set; }
    public string OverallOwnerResort { get; set; }
    public string RmsOwnerResort { get; set; }
    public string CatOwnerResort { get; set; }
    public string SecRmsOwnerCode { get; set; }
    public string SecRmsOwnerResort { get; set; }
    public string SecCatOwnerCode { get; set; }
    public string SecCatOwnerResort { get; set; }
    public string SfawebCompanyId { get; set; }
    public string SfawebAgentId { get; set; }
    public string SfawebSourceId { get; set; }
    public decimal? ServiceCharge { get; set; }
    public string Udfc06 { get; set; }
    public string CatCanxCode { get; set; }
    public string CatCanxDesc { get; set; }
    public string DestinationCode { get; set; }
    public string DestinationDescription { get; set; }
    public string CatStatus { get; set; }
    public DateTime? CutoffDate { get; set; }
    public string PaymentMethod { get; set; }
    public string Udfc10Description { get; set; }
    public string Udfc10Code { get; set; }
    public string Udfc09Description { get; set; }
    public string Udfc09Code { get; set; }
    public DateTime? AltStartDate1 { get; set; }
    public string Bookingtype1 { get; set; }
    public string Origin { get; set; }
    public decimal? TotalDepositReq { get; set; }
    public decimal? Udfn02Code { get; set; }
    public decimal? Udfn01Code { get; set; }
    public string Udfc08Description { get; set; }
    public string Udfc08Code { get; set; }
    public DateTime? RmsDecision { get; set; }
    public DateTime? StatusDateTime { get; set; }
    public decimal InsertUserId { get; set; }
    public string InsertUser { get; set; }
    public decimal UpdateUserId { get; set; }
    public string UpdateUser { get; set; }
    public string Udfc03Code { get; set; }
    public string CateringonlyYn { get; set; }
    public string BlockCode { get; set; }
    public string Bookingmethod { get; set; }
    public string GuaranteeCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExportGroupBookings>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXPORT_GROUP_BOOKINGS");

            entity.Property(e => e.AgentContactId)
                .HasColumnName("AGENT_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentName)
                .HasColumnName("AGENT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentNameId)
                .HasColumnName("AGENT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AltStartDate1)
                .HasColumnName("ALT_START_DATE1")
                .HasColumnType("DATE");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCode)
                .IsRequired()
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookingStatus)
                .IsRequired()
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.BookingType)
                .HasColumnName("BOOKING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Bookingmethod)
                .HasColumnName("BOOKINGMETHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Bookingtype1)
                .HasColumnName("BOOKINGTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancellationCode)
                .HasColumnName("CANCELLATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancellationDesc)
                .HasColumnName("CANCELLATION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CatCanxCode)
                .HasColumnName("CAT_CANX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatCanxDesc)
                .HasColumnName("CAT_CANX_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CatOwnerCode)
                .HasColumnName("CAT_OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CatOwnerResort)
                .HasColumnName("CAT_OWNER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatStatus)
                .HasColumnName("CAT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CateringCurrencyCode)
                .HasColumnName("CATERING_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CateringonlyYn)
                .HasColumnName("CATERINGONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Commission)
                .HasColumnName("COMMISSION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionRev)
                .HasColumnName("COMMISSION_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyContactId)
                .HasColumnName("COMPANY_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.CompanyNameId)
                .HasColumnName("COMPANY_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CutoffDate)
                .HasColumnName("CUTOFF_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DateOpen)
                .HasColumnName("DATE_OPEN")
                .HasColumnType("DATE");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DestinationCode)
                .HasColumnName("DESTINATION_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DestinationDescription)
                .HasColumnName("DESTINATION_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IataCompType)
                .HasColumnName("IATA_COMP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .IsUnicode(false);

            entity.Property(e => e.InsertUserId)
                .HasColumnName("INSERT_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Origin)
                .HasColumnName("ORIGIN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OverallOwnerResort)
                .HasColumnName("OVERALL_OWNER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OwnerCode)
                .IsRequired()
                .HasColumnName("OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PeakAttendees)
                .HasColumnName("PEAK_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropertyCode)
                .IsRequired()
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.RmsCurrencyCode)
                .HasColumnName("RMS_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsDecision)
                .HasColumnName("RMS_DECISION")
                .HasColumnType("DATE");

            entity.Property(e => e.RmsOwnerCode)
                .HasColumnName("RMS_OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerResort)
                .HasColumnName("RMS_OWNER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SecCatOwnerCode)
                .HasColumnName("SEC_CAT_OWNER_CODE")
                .IsUnicode(false);

            entity.Property(e => e.SecCatOwnerResort)
                .HasColumnName("SEC_CAT_OWNER_RESORT")
                .IsUnicode(false);

            entity.Property(e => e.SecRmsOwnerCode)
                .HasColumnName("SEC_RMS_OWNER_CODE")
                .IsUnicode(false);

            entity.Property(e => e.SecRmsOwnerResort)
                .HasColumnName("SEC_RMS_OWNER_RESORT")
                .IsUnicode(false);

            entity.Property(e => e.ServiceCharge)
                .HasColumnName("SERVICE_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SfawebAgentId)
                .HasColumnName("SFAWEB_AGENT_ID")
                .IsUnicode(false);

            entity.Property(e => e.SfawebCompanyId)
                .HasColumnName("SFAWEB_COMPANY_ID")
                .IsUnicode(false);

            entity.Property(e => e.SfawebSourceId)
                .HasColumnName("SFAWEB_SOURCE_ID")
                .IsUnicode(false);

            entity.Property(e => e.Source)
                .HasColumnName("SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceContactId)
                .HasColumnName("SOURCE_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.SourceNameId)
                .HasColumnName("SOURCE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.StatusDate)
                .HasColumnName("STATUS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StatusDateTime)
                .HasColumnName("STATUS_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.SuperBlockId)
                .HasColumnName("SUPER_BLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SuperBlockResort)
                .HasColumnName("SUPER_BLOCK_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalDepositReq)
                .HasColumnName("TOTAL_DEPOSIT_REQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransactionType)
                .HasColumnName("TRANSACTION_TYPE")
                .HasColumnType("CHAR(3)");

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc03Code)
                .HasColumnName("UDFC03_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc04)
                .HasColumnName("UDFC04")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc05Code)
                .HasColumnName("UDFC05_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc08Code)
                .HasColumnName("UDFC08_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc08Description)
                .HasColumnName("UDFC08_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.Udfc09Code)
                .HasColumnName("UDFC09_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc09Description)
                .HasColumnName("UDFC09_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.Udfc10Code)
                .HasColumnName("UDFC10_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc10Description)
                .HasColumnName("UDFC10_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.Udfc14)
                .HasColumnName("UDFC14")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfn01Code)
                .HasColumnName("UDFN01_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn02Code)
                .HasColumnName("UDFN02_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .IsUnicode(false);

            entity.Property(e => e.UpdateUserId)
                .HasColumnName("UPDATE_USER_ID")
                .HasColumnType("NUMBER");
        });
	}
}
