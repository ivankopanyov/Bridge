namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpOcrmMemberAwardsResv
{
    public decimal? KeyCampaignId { get; set; }
    public string? KeyCampaignCode { get; set; }
    public decimal? KeySegId { get; set; }
    public decimal? KeySegBatchId { get; set; }
    public string? KeyRecordLocator { get; set; }
    public decimal? KeyOcrmProfileId { get; set; }
    public string? KeyEmail { get; set; }
    public string? KeyTemplateCode { get; set; }
    public string? TemplateCode { get; set; }
    public string? MembershipType { get; set; }
    public string? AwardType { get; set; }
    public DateTime? SellBeginDate { get; set; }
    public DateTime? SellEndDate { get; set; }
    public string? ShortDescription { get; set; }
    public string? LongDescription { get; set; }
    public DateTime? AwardInactiveDate { get; set; }
    public string? AwardBasedOn { get; set; }
    public decimal? OrderBy { get; set; }
    public string? MessageLine1 { get; set; }
    public string? MessageLine2 { get; set; }
    public string? MessageLine3 { get; set; }
    public string? MessageLine4 { get; set; }
    public decimal? IssuedAwardId { get; set; }
    public decimal? NameId { get; set; }
    public string? MembershipLevel { get; set; }
    public decimal? MembershipId { get; set; }
    public string? MembershipCardNo { get; set; }
    public string? PmsResvNo { get; set; }
    public string? Resort { get; set; }
    public string? CrsBookNo { get; set; }
    public DateTime? DateAwarded { get; set; }
    public string? AwardSource { get; set; }
    public DateTime? ConsumptionDate { get; set; }
    public decimal? PointsRequired { get; set; }
    public decimal? AwardPoints { get; set; }
    public string? RateCode { get; set; }
    public string? CancellationNumber { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public string? RoomLabel { get; set; }
    public string? FromRoomLabel { get; set; }
    public string? ToRoomLabel { get; set; }
    public string? Product { get; set; }
    public decimal? ActualCancelPoints { get; set; }
    public decimal? AwardCancellationNo { get; set; }
    public DateTime? AwardCancelDate { get; set; }
    public decimal? CancelPenaltyDays { get; set; }
    public decimal? CancelPenaltyPoints { get; set; }
    public decimal? StatementId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? MemberStatementId { get; set; }
    public DateTime? StayDate { get; set; }
    public decimal? AwardValue { get; set; }
    public string? Name { get; set; }
    public string? DisplayName { get; set; }
    public string? First { get; set; }
    public string? Middle { get; set; }
    public string? Name2 { get; set; }
    public string? Name3 { get; set; }
    public string? Sname { get; set; }
    public string? AddressType { get; set; }
    public decimal? AddressId { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string? Address4 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? StateDesc { get; set; }
    public string? Country { get; set; }
    public string? CountryDesc { get; set; }
    public string? ZipCode { get; set; }
    public string? CityExt { get; set; }
    public decimal? PhoneId { get; set; }
    public string? PhoneNo { get; set; }
    public string? PhoneType { get; set; }
    public decimal? FaxId { get; set; }
    public string? FaxNo { get; set; }
    public decimal? EmailId { get; set; }
    public string? Email { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpOcrmMemberAwardsResv>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_OCRM_MEMBER_AWARDS_RESV");

            entity.Property(e => e.ActualCancelPoints)
                .HasColumnName("ACTUAL_CANCEL_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address3)
                .HasColumnName("ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address4)
                .HasColumnName("ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AddressType)
                .HasColumnName("ADDRESS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AwardBasedOn)
                .HasColumnName("AWARD_BASED_ON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AwardCancelDate)
                .HasColumnName("AWARD_CANCEL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AwardCancellationNo)
                .HasColumnName("AWARD_CANCELLATION_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardInactiveDate)
                .HasColumnName("AWARD_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AwardPoints)
                .HasColumnName("AWARD_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardSource)
                .HasColumnName("AWARD_SOURCE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AwardType)
                .IsRequired()
                .HasColumnName("AWARD_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AwardValue)
                .HasColumnName("AWARD_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPenaltyDays)
                .HasColumnName("CANCEL_PENALTY_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPenaltyPoints)
                .HasColumnName("CANCEL_PENALTY_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancellationNumber)
                .HasColumnName("CANCELLATION_NUMBER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CityExt)
                .HasColumnName("CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConsumptionDate)
                .HasColumnName("CONSUMPTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CrsBookNo)
                .HasColumnName("CRS_BOOK_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DateAwarded)
                .HasColumnName("DATE_AWARDED")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.EmailId)
                .HasColumnName("EMAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FaxId)
                .HasColumnName("FAX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FaxNo)
                .HasColumnName("FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FromRoomLabel)
                .HasColumnName("FROM_ROOM_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IssuedAwardId)
                .HasColumnName("ISSUED_AWARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyCampaignCode)
                .IsRequired()
                .HasColumnName("KEY_CAMPAIGN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.KeyCampaignId)
                .HasColumnName("KEY_CAMPAIGN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyEmail)
                .HasColumnName("KEY_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.KeyOcrmProfileId)
                .HasColumnName("KEY_OCRM_PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyRecordLocator)
                .HasColumnName("KEY_RECORD_LOCATOR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.KeySegBatchId)
                .HasColumnName("KEY_SEG_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeySegId)
                .HasColumnName("KEY_SEG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyTemplateCode)
                .HasColumnName("KEY_TEMPLATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.LongDescription)
                .HasColumnName("LONG_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MemberStatementId)
                .HasColumnName("MEMBER_STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MessageLine1)
                .HasColumnName("MESSAGE_LINE1")
                .IsUnicode(false);

            entity.Property(e => e.MessageLine2)
                .HasColumnName("MESSAGE_LINE2")
                .IsUnicode(false);

            entity.Property(e => e.MessageLine3)
                .HasColumnName("MESSAGE_LINE3")
                .IsUnicode(false);

            entity.Property(e => e.MessageLine4)
                .HasColumnName("MESSAGE_LINE4")
                .IsUnicode(false);

            entity.Property(e => e.Middle)
                .HasColumnName("MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Name2)
                .HasColumnName("NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Name3)
                .HasColumnName("NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneId)
                .HasColumnName("PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneNo)
                .HasColumnName("PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.PhoneType)
                .HasColumnName("PHONE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.PmsResvNo)
                .HasColumnName("PMS_RESV_NO")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.PointsRequired)
                .HasColumnName("POINTS_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomLabel)
                .HasColumnName("ROOM_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellBeginDate)
                .HasColumnName("SELL_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SellEndDate)
                .HasColumnName("SELL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Sname)
                .IsRequired()
                .HasColumnName("SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.StateDesc)
                .HasColumnName("STATE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.StatementId)
                .HasColumnName("STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TemplateCode)
                .HasColumnName("TEMPLATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ToRoomLabel)
                .HasColumnName("TO_ROOM_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
