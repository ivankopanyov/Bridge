namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class StayHistoryVw
{
    public string? ViewMode { get; set; }
    public decimal? StayRecordId { get; set; }
    public string? Resort { get; set; }
    public string? PmsResvNo { get; set; }
    public string? RecordType { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public DateTime? BookDate { get; set; }
    public DateTime? BookedArrivalDate { get; set; }
    public DateTime? BookedDepartureDate { get; set; }
    public string? ShareNo { get; set; }
    public string? PrimarySharer { get; set; }
    public DateTime? CancellationDate { get; set; }
    public decimal? CancelledRoomNights { get; set; }
    public decimal? NoshowRoomNights { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public string? CrsBookNo { get; set; }
    public string? RoomLabel { get; set; }
    public string? RoomNumber { get; set; }
    public string? PmsCurrencyCode { get; set; }
    public string? SourceCode { get; set; }
    public string? Channel { get; set; }
    public string? PaymentMethod { get; set; }
    public string? CompYn { get; set; }
    public decimal? GuestNameId { get; set; }
    public decimal? CompanyNameId { get; set; }
    public decimal? TravelNameId { get; set; }
    public decimal? WholesalerNameId { get; set; }
    public decimal? GroupNameId { get; set; }
    public decimal? MiscNameId { get; set; }
    public string? PmsNameId { get; set; }
    public string? PmsCompanyId { get; set; }
    public string? PmsTravelId { get; set; }
    public string? PmsWholesalerId { get; set; }
    public string? PmsGroupId { get; set; }
    public string? PmsMiscId { get; set; }
    public string? ResInsertSource { get; set; }
    public string? ResInsertSourceType { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? MiscRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string? AllotmentCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? Udfc01 { get; set; }
    public string? Udfc02 { get; set; }
    public string? Udfc03 { get; set; }
    public string? Udfc04 { get; set; }
    public string? Udfc05 { get; set; }
    public string? Udfc06 { get; set; }
    public string? Udfc07 { get; set; }
    public string? Udfc08 { get; set; }
    public string? Udfc09 { get; set; }
    public string? Udfc10 { get; set; }
    public decimal? Udfn01 { get; set; }
    public decimal? Udfn02 { get; set; }
    public decimal? Udfn03 { get; set; }
    public decimal? Udfn04 { get; set; }
    public decimal? Udfn05 { get; set; }
    public DateTime? Udfd01 { get; set; }
    public DateTime? Udfd02 { get; set; }
    public DateTime? Udfd03 { get; set; }
    public DateTime? Udfd04 { get; set; }
    public DateTime? Udfd05 { get; set; }
    public string? PmsResvNameId { get; set; }
    public decimal? MembershipTrxLinkId { get; set; }
    public string? PointsYn { get; set; }
    public decimal? NumberStay { get; set; }
    public decimal? NumberNights { get; set; }
    public string? PseudoYn { get; set; }
    public decimal? Pseudo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StayHistoryVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("STAY_HISTORY_VW");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentCode)
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookDate)
                .HasColumnName("BOOK_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookedArrivalDate)
                .HasColumnName("BOOKED_ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookedDepartureDate)
                .HasColumnName("BOOKED_DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancelledRoomNights)
                .HasColumnName("CANCELLED_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompYn)
                .HasColumnName("COMP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CompanyNameId)
                .HasColumnName("COMPANY_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CrsBookNo)
                .HasColumnName("CRS_BOOK_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupNameId)
                .HasColumnName("GROUP_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipTrxLinkId)
                .HasColumnName("MEMBERSHIP_TRX_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MiscNameId)
                .HasColumnName("MISC_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MiscRevenue)
                .HasColumnName("MISC_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoshowRoomNights)
                .HasColumnName("NOSHOW_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberNights)
                .HasColumnName("NUMBER_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberStay)
                .HasColumnName("NUMBER_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.PmsCompanyId)
                .HasColumnName("PMS_COMPANY_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsCurrencyCode)
                .HasColumnName("PMS_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsGroupId)
                .HasColumnName("PMS_GROUP_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsMiscId)
                .HasColumnName("PMS_MISC_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsNameId)
                .HasColumnName("PMS_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsResvNameId)
                .HasColumnName("PMS_RESV_NAME_ID")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PmsResvNo)
                .HasColumnName("PMS_RESV_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PmsTravelId)
                .HasColumnName("PMS_TRAVEL_ID")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.PmsWholesalerId)
                .HasColumnName("PMS_WHOLESALER_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PointsYn)
                .HasColumnName("POINTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrimarySharer)
                .HasColumnName("PRIMARY_SHARER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Pseudo)
                .HasColumnName("PSEUDO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PseudoYn)
                .HasColumnName("PSEUDO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResInsertSource)
                .HasColumnName("RES_INSERT_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResInsertSourceType)
                .HasColumnName("RES_INSERT_SOURCE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomLabel)
                .HasColumnName("ROOM_LABEL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RoomNumber)
                .HasColumnName("ROOM_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareNo)
                .HasColumnName("SHARE_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StayRecordId)
                .HasColumnName("STAY_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelNameId)
                .HasColumnName("TRAVEL_NAME_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.ViewMode)
                .HasColumnName("VIEW_MODE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.WholesalerNameId)
                .HasColumnName("WHOLESALER_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
