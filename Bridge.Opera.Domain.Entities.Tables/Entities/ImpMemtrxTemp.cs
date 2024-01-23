namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ImpMemtrxTemp
{
    public decimal BatchId { get; set; }
    public decimal SeqNo { get; set; }
    public DateTime ImportDate { get; set; }
    public string ImportStatus { get; set; }
    public string ImportMsg { get; set; }
    public string InterfaceId { get; set; }
    public decimal? MembershipTrxId { get; set; }
    public DateTime? MembershipTrxDate { get; set; }
    public string RecordType { get; set; }
    public string Resort { get; set; }
    public string ExtResort { get; set; }
    public decimal? NameId { get; set; }
    public decimal? MembershipId { get; set; }
    public string MembershipType { get; set; }
    public string MembershipCardNo { get; set; }
    public string MembershipLevel { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string PmsNameId { get; set; }
    public string PmsResvNo { get; set; }
    public string PmsResvNameId { get; set; }
    public decimal? StayRecordId { get; set; }
    public string PopulationMethod { get; set; }
    public decimal? Stay { get; set; }
    public decimal? Nights { get; set; }
    public string CurrencyCode { get; set; }
    public string PromotionCode1 { get; set; }
    public string PromotionCode2 { get; set; }
    public string PromotionCode3 { get; set; }
    public decimal? TotalPoints { get; set; }
    public decimal? TotalBasePoints { get; set; }
    public decimal? TotalBonusPoints { get; set; }
    public decimal? TotalMiscPoints { get; set; }
    public decimal? MembershipBaseNights { get; set; }
    public decimal? MembershipBaseRevenue { get; set; }
    public decimal? MembershipBonusNights { get; set; }
    public decimal? MembershipBonusRevenue { get; set; }
    public decimal? PointsCost { get; set; }
    public DateTime? PointsCreditDate { get; set; }
    public string PointsCalculatedYn { get; set; }
    public string ProcessingMessages { get; set; }
    public string DataExportedYn { get; set; }
    public DateTime? DataExportedDate { get; set; }
    public string AdjustmentYn { get; set; }
    public decimal? ParentMembershipTrxId { get; set; }
    public string CrsBookNo { get; set; }
    public decimal? MembershipBaseStay { get; set; }
    public decimal? MembershipBonusStay { get; set; }
    public string PointsRejectedReason { get; set; }
    public DateTime? PointsExpirationDate { get; set; }
    public decimal? MembershipTrxLinkId { get; set; }
    public string UserNotes { get; set; }
    public string RoomLabel { get; set; }
    public string PosCode { get; set; }
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
    public string RateCode { get; set; }
    public decimal? RateAmount { get; set; }
    public string MarketCode { get; set; }
    public string BillingGroup { get; set; }
    public string BaseBillingGroup { get; set; }
    public string BonusBillingGroup { get; set; }
    public string BookedRoomLabel { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ImpMemtrxTemp>(entity =>
        {
            entity.HasKey(e => new { e.BatchId, e.SeqNo })
                .HasName("IMP_PK");

            entity.ToTable("IMP_MEMTRX_TEMP");

            entity.HasIndex(e => new { e.ImportStatus, e.BatchId })
                .HasName("IMP_MEMTRX_TEMP_IDX1");

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdjustmentYn)
                .IsRequired()
                .HasColumnName("ADJUSTMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.BaseBillingGroup)
                .HasColumnName("BASE_BILLING_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillingGroup)
                .HasColumnName("BILLING_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BonusBillingGroup)
                .HasColumnName("BONUS_BILLING_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookedRoomLabel)
                .HasColumnName("BOOKED_ROOM_LABEL")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CrsBookNo)
                .HasColumnName("CRS_BOOK_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DataExportedDate)
                .HasColumnName("DATA_EXPORTED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DataExportedYn)
                .HasColumnName("DATA_EXPORTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExtResort)
                .HasColumnName("EXT_RESORT")
                .HasMaxLength(80)
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
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipBaseNights)
                .HasColumnName("MEMBERSHIP_BASE_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBaseRevenue)
                .HasColumnName("MEMBERSHIP_BASE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBaseStay)
                .HasColumnName("MEMBERSHIP_BASE_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBonusNights)
                .HasColumnName("MEMBERSHIP_BONUS_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBonusRevenue)
                .HasColumnName("MEMBERSHIP_BONUS_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBonusStay)
                .HasColumnName("MEMBERSHIP_BONUS_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipTrxDate)
                .HasColumnName("MEMBERSHIP_TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MembershipTrxId)
                .HasColumnName("MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipTrxLinkId)
                .HasColumnName("MEMBERSHIP_TRX_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentMembershipTrxId)
                .HasColumnName("PARENT_MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.PointsCalculatedYn)
                .IsRequired()
                .HasColumnName("POINTS_CALCULATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.PointsCost)
                .HasColumnName("POINTS_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsCreditDate)
                .HasColumnName("POINTS_CREDIT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PointsExpirationDate)
                .HasColumnName("POINTS_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PointsRejectedReason)
                .HasColumnName("POINTS_REJECTED_REASON")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PopulationMethod)
                .HasColumnName("POPULATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PosCode)
                .HasColumnName("POS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PosNegRevAmount)
                .HasColumnName("POS_NEG_REV_AMOUNT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProcessingMessages)
                .HasColumnName("PROCESSING_MESSAGES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode1)
                .HasColumnName("PROMOTION_CODE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode2)
                .HasColumnName("PROMOTION_CODE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode3)
                .HasColumnName("PROMOTION_CODE3")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .IsRequired()
                .HasColumnName("RECORD_TYPE")
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
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueType2)
                .HasColumnName("REVENUE_TYPE_2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueType3)
                .HasColumnName("REVENUE_TYPE_3")
                .HasMaxLength(20)
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

            entity.Property(e => e.Stay)
                .HasColumnName("STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRecordId)
                .HasColumnName("STAY_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalBasePoints)
                .HasColumnName("TOTAL_BASE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalBonusPoints)
                .HasColumnName("TOTAL_BONUS_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalMiscPoints)
                .HasColumnName("TOTAL_MISC_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPoints)
                .HasColumnName("TOTAL_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserNotes)
                .HasColumnName("USER_NOTES")
                .IsUnicode(false);
        });
	}
}
