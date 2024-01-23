namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ImpstayTemp
{
    public decimal BatchId { get; set; }
    public decimal SeqNo { get; set; }
    public DateTime ImportDate { get; set; }
    public string ImportStatus { get; set; }
    public string ImportMsg { get; set; }
    public string InterfaceId { get; set; }
    public string Resort { get; set; }
    public string ExternalResortId { get; set; }
    public string PmsResvNo { get; set; }
    public string PmsResvNameId { get; set; }
    public string RecordType { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public decimal? NoOfNights { get; set; }
    public DateTime? BookDate { get; set; }
    public DateTime? BookedArrivalDate { get; set; }
    public DateTime? BookedDepartureDate { get; set; }
    public string ShareNo { get; set; }
    public DateTime? CancellationDate { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public string OrsBookNo { get; set; }
    public string RoomLabel { get; set; }
    public string RoomNumber { get; set; }
    public string PmsCurrencyCode { get; set; }
    public string SourceCode { get; set; }
    public string Channel { get; set; }
    public string PaymentMethod { get; set; }
    public string CompYn { get; set; }
    public string PmsNameId { get; set; }
    public string PmsCompanyId { get; set; }
    public string PmsTravelId { get; set; }
    public string PmsWholesalerId { get; set; }
    public string PmsGroupId { get; set; }
    public string PmsMiscId { get; set; }
    public string ResInsertSource { get; set; }
    public string ResInsertSourceType { get; set; }
    public string ExchangeRate { get; set; }
    public string AllotmentCode { get; set; }
    public string PrimarySharerFlag { get; set; }
    public string PointsYn { get; set; }
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
    public string PMembershipType { get; set; }
    public string PMembershipNumber { get; set; }
    public string FfMembershipType { get; set; }
    public string FfMembershipNumber { get; set; }
    public string RateCode { get; set; }
    public decimal? RateAmount { get; set; }
    public string MarketCode { get; set; }
    public string PosNegRevAmount { get; set; }
    public string RevenueType1 { get; set; }
    public decimal? RevenueAmount1 { get; set; }
    public string RevenueType2 { get; set; }
    public decimal? RevenueAmount2 { get; set; }
    public string RevenueType3 { get; set; }
    public decimal? RevenueAmount3 { get; set; }
    public string RevenueType4 { get; set; }
    public decimal? RevenueAmount4 { get; set; }
    public string RevenueType5 { get; set; }
    public decimal? RevenueAmount5 { get; set; }
    public string PosCode { get; set; }
    public string BaseRateCode { get; set; }
    public decimal? LocalBaseRateAmount { get; set; }
    public string BaseRateCurrencyCode { get; set; }
    public string BookedRoomLabel { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ImpstayTemp>(entity =>
        {
            entity.HasKey(e => new { e.BatchId, e.SeqNo })
                .HasName("IT_PK");

            entity.ToTable("IMPSTAY_TEMP");

            entity.HasIndex(e => new { e.ImportStatus, e.BatchId })
                .HasName("IMPSTAY_TEMP_STATUS");

            entity.HasIndex(e => new { e.Resort, e.PmsResvNameId, e.PosCode })
                .HasName("IMPSTAY_TEMP_IDX1");

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.BaseRateCode)
                .HasColumnName("BASE_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BaseRateCurrencyCode)
                .HasColumnName("BASE_RATE_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookDate)
                .HasColumnName("BOOK_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookedArrivalDate)
                .HasColumnName("BOOKED_ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookedDepartureDate)
                .HasColumnName("BOOKED_DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookedRoomLabel)
                .HasColumnName("BOOKED_ROOM_LABEL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE");

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

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExternalResortId)
                .HasColumnName("EXTERNAL_RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FfMembershipNumber)
                .HasColumnName("FF_MEMBERSHIP_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FfMembershipType)
                .HasColumnName("FF_MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ImportDate)
                .HasColumnName("IMPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ImportMsg)
                .HasColumnName("IMPORT_MSG")
                .IsUnicode(false);

            entity.Property(e => e.ImportStatus)
                .IsRequired()
                .HasColumnName("IMPORT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LocalBaseRateAmount)
                .HasColumnName("LOCAL_BASE_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NoOfNights)
                .HasColumnName("NO_OF_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrsBookNo)
                .HasColumnName("ORS_BOOK_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PMembershipNumber)
                .HasColumnName("P_MEMBERSHIP_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PMembershipType)
                .HasColumnName("P_MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

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
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsResvNo)
                .HasColumnName("PMS_RESV_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsTravelId)
                .HasColumnName("PMS_TRAVEL_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsWholesalerId)
                .HasColumnName("PMS_WHOLESALER_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PointsYn)
                .HasColumnName("POINTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PosCode)
                .HasColumnName("POS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PosNegRevAmount)
                .HasColumnName("POS_NEG_REV_AMOUNT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrimarySharerFlag)
                .HasColumnName("PRIMARY_SHARER_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
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
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueAmount1)
                .HasColumnName("REVENUE_AMOUNT_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueAmount2)
                .HasColumnName("REVENUE_AMOUNT_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueAmount3)
                .HasColumnName("REVENUE_AMOUNT_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueAmount4)
                .HasColumnName("REVENUE_AMOUNT_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueAmount5)
                .HasColumnName("REVENUE_AMOUNT_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueType1)
                .HasColumnName("REVENUE_TYPE_1")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.RevenueType2)
                .HasColumnName("REVENUE_TYPE_2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueType3)
                .HasColumnName("REVENUE_TYPE_3")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.RevenueType4)
                .HasColumnName("REVENUE_TYPE_4")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueType5)
                .HasColumnName("REVENUE_TYPE_5")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomLabel)
                .HasColumnName("ROOM_LABEL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RoomNumber)
                .HasColumnName("ROOM_NUMBER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ShareNo)
                .HasColumnName("SHARE_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Udfc03)
                .HasColumnName("UDFC03")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Udfc04)
                .HasColumnName("UDFC04")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Udfc05)
                .HasColumnName("UDFC05")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Udfc07)
                .HasColumnName("UDFC07")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Udfc08)
                .HasColumnName("UDFC08")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Udfc09)
                .HasColumnName("UDFC09")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Udfc10)
                .HasColumnName("UDFC10")
                .HasMaxLength(240)
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
        });
	}
}
