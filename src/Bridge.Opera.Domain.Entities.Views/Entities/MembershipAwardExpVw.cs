namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MembershipAwardExpVw
{
    public string MembershipType { get; set; }
    public string AwardType { get; set; }
    public DateTime? SellBeginDate { get; set; }
    public DateTime? SellEndDate { get; set; }
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public DateTime? AwardInactiveDate { get; set; }
    public string AwardBasedOn { get; set; }
    public decimal? OrderBy { get; set; }
    public string MessageLine1 { get; set; }
    public string MessageLine2 { get; set; }
    public string MessageLine3 { get; set; }
    public string MessageLine4 { get; set; }
    public string IgnoreFtTrxYn { get; set; }
    public decimal IssuedAwardId { get; set; }
    public decimal NameId { get; set; }
    public string MembershipLevel { get; set; }
    public decimal MembershipId { get; set; }
    public string MembershipCardNo { get; set; }
    public string PmsResvNo { get; set; }
    public string Resort { get; set; }
    public string CrsBookNo { get; set; }
    public DateTime? DateAwarded { get; set; }
    public string AwardSource { get; set; }
    public DateTime? ConsumptionDate { get; set; }
    public decimal? PointsRequired { get; set; }
    public decimal? AwardPoints { get; set; }
    public string RateCode { get; set; }
    public string CancellationNumber { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public string RoomLabel { get; set; }
    public string FromRoomLabel { get; set; }
    public string ToRoomLabel { get; set; }
    public string Product { get; set; }
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
    public string DeliveryFirstName { get; set; }
    public string DeliveryLastName { get; set; }
    public string DeliveryMiddleName { get; set; }
    public string DeliveryCompanyName { get; set; }
    public string DeliveryPhoneNo { get; set; }
    public string DeliveryAddress1 { get; set; }
    public string DeliveryAddress2 { get; set; }
    public string DeliveryAddress3 { get; set; }
    public string DeliveryAddress4 { get; set; }
    public string DeliveryCity { get; set; }
    public string DeliveryCountry { get; set; }
    public string DeliveryProvince { get; set; }
    public string DeliveryState { get; set; }
    public string DeliveryZip { get; set; }
    public string DeliveryCityExt { get; set; }
    public decimal? DeliveryInsertUser { get; set; }
    public DateTime? DeliveryInsertDate { get; set; }
    public decimal? DeliveryUpdateUser { get; set; }
    public DateTime? DeliveryUpdateDate { get; set; }
    public DateTime? Udfd01 { get; set; }
    public DateTime? Udfd02 { get; set; }
    public DateTime? Udfd03 { get; set; }
    public DateTime? Udfd04 { get; set; }
    public DateTime? Udfd05 { get; set; }
    public decimal? Udfn01 { get; set; }
    public decimal? Udfn02 { get; set; }
    public decimal? Udfn03 { get; set; }
    public decimal? Udfn04 { get; set; }
    public decimal? Udfn05 { get; set; }
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

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipAwardExpVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBERSHIP_AWARD_EXP_VW");

            entity.Property(e => e.ActualCancelPoints)
                .HasColumnName("ACTUAL_CANCEL_POINTS")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.ConsumptionDate)
                .HasColumnName("CONSUMPTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CrsBookNo)
                .HasColumnName("CRS_BOOK_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DateAwarded)
                .HasColumnName("DATE_AWARDED")
                .HasColumnType("DATE");

            entity.Property(e => e.DeliveryAddress1)
                .HasColumnName("DELIVERY_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddress2)
                .HasColumnName("DELIVERY_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddress3)
                .HasColumnName("DELIVERY_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryAddress4)
                .HasColumnName("DELIVERY_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryCity)
                .HasColumnName("DELIVERY_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryCityExt)
                .HasColumnName("DELIVERY_CITY_EXT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryCompanyName)
                .HasColumnName("DELIVERY_COMPANY_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryCountry)
                .HasColumnName("DELIVERY_COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryFirstName)
                .HasColumnName("DELIVERY_FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryInsertDate)
                .HasColumnName("DELIVERY_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DeliveryInsertUser)
                .HasColumnName("DELIVERY_INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeliveryLastName)
                .HasColumnName("DELIVERY_LAST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryMiddleName)
                .HasColumnName("DELIVERY_MIDDLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryPhoneNo)
                .HasColumnName("DELIVERY_PHONE_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryProvince)
                .HasColumnName("DELIVERY_PROVINCE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryState)
                .HasColumnName("DELIVERY_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryUpdateDate)
                .HasColumnName("DELIVERY_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DeliveryUpdateUser)
                .HasColumnName("DELIVERY_UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeliveryZip)
                .HasColumnName("DELIVERY_ZIP")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FromRoomLabel)
                .HasColumnName("FROM_ROOM_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IgnoreFtTrxYn)
                .HasColumnName("IGNORE_FT_TRX_YN")
                .HasMaxLength(1)
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

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.StatementId)
                .HasColumnName("STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ToRoomLabel)
                .HasColumnName("TO_ROOM_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc03)
                .HasColumnName("UDFC03")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc04)
                .HasColumnName("UDFC04")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc05)
                .HasColumnName("UDFC05")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc07)
                .HasColumnName("UDFC07")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc08)
                .HasColumnName("UDFC08")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc09)
                .HasColumnName("UDFC09")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Udfc10)
                .HasColumnName("UDFC10")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc11)
                .HasColumnName("UDFC11")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc12)
                .HasColumnName("UDFC12")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc13)
                .HasColumnName("UDFC13")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc14)
                .HasColumnName("UDFC14")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc15)
                .HasColumnName("UDFC15")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc16)
                .HasColumnName("UDFC16")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc17)
                .HasColumnName("UDFC17")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc18)
                .HasColumnName("UDFC18")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc19)
                .HasColumnName("UDFC19")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Udfc20)
                .HasColumnName("UDFC20")
                .HasMaxLength(2000)
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

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
