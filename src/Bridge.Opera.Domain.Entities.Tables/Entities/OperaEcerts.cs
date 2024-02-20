namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OperaEcerts
{
    public decimal? CertId { get; set; }
    public string? VoucherNo { get; set; }
    public string? CertCode { get; set; }
    public string? ChainCode { get; set; }
    public string? CertificateNo { get; set; }
    public string? MembershipType { get; set; }
    public string? AwardType { get; set; }
    public string? PromotionCode { get; set; }
    public string? Resort { get; set; }
    public string? ShortDescription { get; set; }
    public string? LongDescription { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string? ReservationCertYn { get; set; }
    public decimal? Value { get; set; }
    public decimal? Cost { get; set; }
    public string? CertLabel { get; set; }
    public decimal? NameId { get; set; }
    public string? ResortConsumed { get; set; }
    public string? ConsumedAt { get; set; }
    public string? ConsumerLastName { get; set; }
    public string? ConsumerFirstName { get; set; }
    public string? ConsumerMiddleName { get; set; }
    public string? ConsumerEmail { get; set; }
    public DateTime? ConsumptionDate { get; set; }
    public string? ConsumptionUserName { get; set; }
    public string? UserNotes { get; set; }
    public string? OcisCurrencyCode { get; set; }
    public string? Status { get; set; }
    public string? PrintStatus { get; set; }
    public string? ConsumptionRefNo { get; set; }
    public string? OwsConsumedYn { get; set; }
    public string? PmsConsumedYn { get; set; }
    public string? ForChainCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? MembershipAwardId { get; set; }
    public string? ConsumptionRefType { get; set; }
    public string? ConsumptionLegNo { get; set; }
    public string? IssuedDatabaseId { get; set; }
    public string? IssueSource { get; set; }
    public string? VerifyCertNoYn { get; set; }
    public string? IssueType { get; set; }
    public decimal? AwardPoints { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? AuthCode { get; set; }
    public decimal? GenRuleId { get; set; }
    public string? GenRuleValue { get; set; }
    public string? GenRuleValueType { get; set; }
    public string? OriginalVoucherNo { get; set; }
    public string? OriginalCertificateNo { get; set; }
    public decimal? CertificateSeqNo { get; set; }
    public DateTime? IssueDate { get; set; }
    public DateTime? ServiceDate { get; set; }
    public DateTime? CancelRequestDate { get; set; }
    public string? CancelAllowedYn { get; set; }
    public string? GenInLieuCertYn { get; set; }
    public string? Scope { get; set; }
    public decimal? ExtendNoOfTimes { get; set; }
    public decimal? TotalExtendApplied { get; set; }
    public string? VoucherBenefitCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaEcerts>(entity =>
        {
            entity.HasKey(e => e.CertId)
                .HasName("OET_PK");

            entity.ToTable("OPERA_ECERTS");

            entity.HasIndex(e => e.CertificateNo)
                .HasName("OET_CERTCD_UK")
                .IsUnique();

            entity.HasIndex(e => e.ConsumptionDate)
                .HasName("OPERA_ECERT_IND6");

            entity.HasIndex(e => e.ExpiryDate)
                .HasName("OPERA_ECERT_IND5");

            entity.HasIndex(e => e.InsertDate)
                .HasName("OPERA_ECERT_IND7");

            entity.HasIndex(e => e.MembershipAwardId)
                .HasName("OPERA_ECERT_IND3");

            entity.HasIndex(e => e.NameId)
                .HasName("OPERA_ECERT_IND2");

            entity.HasIndex(e => e.VoucherBenefitCode)
                .HasName("OPERA_ECERT_IND9");

            entity.HasIndex(e => e.VoucherNo)
                .HasName("OET_VOUCHER_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.CertCode, e.ChainCode })
                .HasName("OPERA_ECERT_IND1");

            entity.HasIndex(e => new { e.ResortConsumed, e.ResvNameId })
                .HasName("OPERA_ECERT_IND8");

            entity.HasIndex(e => new { e.ConsumptionRefNo, e.ConsumptionRefType, e.ConsumptionLegNo })
                .HasName("OPERA_ECERT_IND4");

            entity.Property(e => e.CertId)
                .HasColumnName("CERT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AuthCode)
                .HasColumnName("AUTH_CODE")
                .HasMaxLength(120)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardPoints)
                .HasColumnName("AWARD_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardType)
                .HasColumnName("AWARD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CancelAllowedYn)
                .HasColumnName("CANCEL_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CancelRequestDate)
                .HasColumnName("CANCEL_REQUEST_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CertCode)
                .IsRequired()
                .HasColumnName("CERT_CODE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CertLabel)
                .HasColumnName("CERT_LABEL")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CertificateNo)
                .HasColumnName("CERTIFICATE_NO")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CertificateSeqNo)
                .HasColumnName("CERTIFICATE_SEQ_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsumedAt)
                .HasColumnName("CONSUMED_AT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsumerEmail)
                .HasColumnName("CONSUMER_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsumerFirstName)
                .HasColumnName("CONSUMER_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsumerLastName)
                .HasColumnName("CONSUMER_LAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsumerMiddleName)
                .HasColumnName("CONSUMER_MIDDLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsumptionDate)
                .HasColumnName("CONSUMPTION_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsumptionLegNo)
                .HasColumnName("CONSUMPTION_LEG_NO")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsumptionRefNo)
                .HasColumnName("CONSUMPTION_REF_NO")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsumptionRefType)
                .HasColumnName("CONSUMPTION_REF_TYPE")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsumptionUserName)
                .HasColumnName("CONSUMPTION_USER_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Cost)
                .HasColumnName("COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpiryDate)
                .HasColumnName("EXPIRY_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExtendNoOfTimes)
                .HasColumnName("EXTEND_NO_OF_TIMES")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ForChainCode)
                .HasColumnName("FOR_CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GenInLieuCertYn)
                .HasColumnName("GEN_IN_LIEU_CERT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GenRuleId)
                .HasColumnName("GEN_RULE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GenRuleValue)
                .HasColumnName("GEN_RULE_VALUE")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GenRuleValueType)
                .HasColumnName("GEN_RULE_VALUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IssueDate)
                .HasColumnName("ISSUE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IssueSource)
                .HasColumnName("ISSUE_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IssueType)
                .HasColumnName("ISSUE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IssuedDatabaseId)
                .HasColumnName("ISSUED_DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LongDescription)
                .HasColumnName("LONG_DESCRIPTION")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipAwardId)
                .HasColumnName("MEMBERSHIP_AWARD_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OcisCurrencyCode)
                .HasColumnName("OCIS_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OriginalCertificateNo)
                .HasColumnName("ORIGINAL_CERTIFICATE_NO")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OriginalVoucherNo)
                .HasColumnName("ORIGINAL_VOUCHER_NO")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwsConsumedYn)
                .HasColumnName("OWS_CONSUMED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PmsConsumedYn)
                .HasColumnName("PMS_CONSUMED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrintStatus)
                .HasColumnName("PRINT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PromotionCode)
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReservationCertYn)
                .HasColumnName("RESERVATION_CERT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResortConsumed)
                .HasColumnName("RESORT_CONSUMED")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Scope)
                .HasColumnName("SCOPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ServiceDate)
                .HasColumnName("SERVICE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalExtendApplied)
                .HasColumnName("TOTAL_EXTEND_APPLIED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UserNotes)
                .HasColumnName("USER_NOTES")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Value)
                .HasColumnName("VALUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VerifyCertNoYn)
                .HasColumnName("VERIFY_CERT_NO_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VoucherBenefitCode)
                .HasColumnName("VOUCHER_BENEFIT_CODE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VoucherNo)
                .IsRequired()
                .HasColumnName("VOUCHER_NO")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
