namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AwardProfileRequests
{
    public string? Resort { get; set; }
    public string? CertificateNumber { get; set; }
    public decimal? NameId { get; set; }
    public string? MembershipNo { get; set; }
    public string? Status { get; set; }
    public string? AwardCode { get; set; }
    public DateTime? ExpireDate { get; set; }
    public string? IsGift { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? HotelCategory { get; set; }
    public string? IsCategoryValid { get; set; }
    public string? SourceType { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? AwardType { get; set; }
    public string? Description { get; set; }
    public decimal? Nights { get; set; }
    public string? MasterCertificateNumber { get; set; }
    public string? InstantRedemptionYn { get; set; }
    public string? ReservationCertificateType { get; set; }
    public string? RewardCertificateType { get; set; }
    public string? CertificateNumberChar { get; set; }
    public string? CrsHotelCode { get; set; }
    public string? CrsConfirmationNumber { get; set; }
    public decimal? PointsCost { get; set; }
    public string? FbaYn { get; set; }
    public string? FbaStatus { get; set; }
    public decimal? FbaMonetaryValue { get; set; }
    public decimal? FbaAmount { get; set; }
    public decimal? FbaPostedAmount { get; set; }
    public decimal? FbaReimbursedAmount { get; set; }
    public DateTime? FbaPostingDateTime { get; set; }
    public DateTime? FbaSettlementDateTime { get; set; }
    public DateTime? FbaReimbursementDateTime { get; set; }
    public string? PaidUpgradeYn { get; set; }
    public DateTime? FbaPostingBusinessDate { get; set; }
    public DateTime? FbaSettlementBusinessDate { get; set; }
    public DateTime? FbaReimburseBusinessDate { get; set; }
    public decimal? FbaPostingTrxNo { get; set; }
    public DateTime? FbaBillGenerationDate { get; set; }
    public decimal? FbaBillNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AwardProfileRequests>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("AWARD_PROFILE_REQUESTS");

            entity.HasIndex(e => e.NameId)
                .HasName("AWARD_PR_REQ_NAME_IDX");

            entity.HasIndex(e => new { e.Resort, e.FbaBillGenerationDate })
                .HasName("AWARD_PR_REQ_BILL_GEN_DATE");

            entity.HasIndex(e => new { e.Resort, e.FbaBillNo })
                .HasName("AWARD_PR_REQ_BILL_NO");

            entity.HasIndex(e => new { e.Resort, e.FbaPostingBusinessDate })
                .HasName("AWARD_PR_REQ_FBA_POST_IDX");

            entity.HasIndex(e => new { e.Resort, e.FbaReimburseBusinessDate })
                .HasName("AWARD_PR_REQ_REIMBURSE_IDX");

            entity.HasIndex(e => new { e.Resort, e.FbaSettlementBusinessDate })
                .HasName("AWARD_PR_REQ_FBA_SETTLE_IDX");

            entity.HasIndex(e => new { e.Resort, e.MasterCertificateNumber })
                .HasName("AWARD_PR_REQ_MASTER_CERT_IDX");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("AWARD_PR_REQ_RESV_NAME_IDX");

            entity.HasIndex(e => new { e.Resort, e.CertificateNumber, e.NameId, e.ResvNameId })
                .HasName("AWARD_PROFILE_REQUESTS_UK")
                .IsUnique();

            entity.Property(e => e.AwardCode)
                .HasColumnName("AWARD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardType)
                .HasColumnName("AWARD_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CertificateNumber)
                .HasColumnName("CERTIFICATE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CertificateNumberChar)
                .HasColumnName("CERTIFICATE_NUMBER_CHAR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CrsConfirmationNumber)
                .HasColumnName("CRS_CONFIRMATION_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CrsHotelCode)
                .HasColumnName("CRS_HOTEL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExpireDate)
                .HasColumnName("EXPIRE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FbaAmount)
                .HasColumnName("FBA_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FbaBillGenerationDate)
                .HasColumnName("FBA_BILL_GENERATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FbaBillNo)
                .HasColumnName("FBA_BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbaMonetaryValue)
                .HasColumnName("FBA_MONETARY_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbaPostedAmount)
                .HasColumnName("FBA_POSTED_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FbaPostingBusinessDate)
                .HasColumnName("FBA_POSTING_BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FbaPostingDateTime)
                .HasColumnName("FBA_POSTING_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.FbaPostingTrxNo)
                .HasColumnName("FBA_POSTING_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbaReimburseBusinessDate)
                .HasColumnName("FBA_REIMBURSE_BUSINESS_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FbaReimbursedAmount)
                .HasColumnName("FBA_REIMBURSED_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FbaReimbursementDateTime)
                .HasColumnName("FBA_REIMBURSEMENT_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.FbaSettlementBusinessDate)
                .HasColumnName("FBA_SETTLEMENT_BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FbaSettlementDateTime)
                .HasColumnName("FBA_SETTLEMENT_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.FbaStatus)
                .HasColumnName("FBA_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FbaYn)
                .HasColumnName("FBA_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HotelCategory)
                .HasColumnName("HOTEL_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InstantRedemptionYn)
                .HasColumnName("INSTANT_REDEMPTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IsCategoryValid)
                .HasColumnName("IS_CATEGORY_VALID")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IsGift)
                .IsRequired()
                .HasColumnName("IS_GIFT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MasterCertificateNumber)
                .HasColumnName("MASTER_CERTIFICATE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipNo)
                .HasColumnName("MEMBERSHIP_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaidUpgradeYn)
                .HasColumnName("PAID_UPGRADE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PointsCost)
                .HasColumnName("POINTS_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationCertificateType)
                .HasColumnName("RESERVATION_CERTIFICATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RewardCertificateType)
                .HasColumnName("REWARD_CERTIFICATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceType)
                .HasColumnName("SOURCE_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
