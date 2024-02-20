namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OperaEcertTypes
{
    public string? CertCode { get; set; }
    public string? ChainCode { get; set; }
    public string? MembershipType { get; set; }
    public string? AwardType { get; set; }
    public string? PromotionCode { get; set; }
    public string? Resort { get; set; }
    public string? ShortDescription { get; set; }
    public string? LongDescription { get; set; }
    public decimal? ExpiryMonths { get; set; }
    public string? ReservationCertYn { get; set; }
    public decimal? Value { get; set; }
    public decimal? Cost { get; set; }
    public string? CertLabel { get; set; }
    public string? OwsConsumedYn { get; set; }
    public string? PmsConsumedYn { get; set; }
    public string? CertificateNoGenFormat { get; set; }
    public string? CertificateNoPrefix { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Scope { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? VerifyCertNoYn { get; set; }
    public string? WebAllowedYn { get; set; }
    public string? GroupCode { get; set; }
    public string? CancelAllowedYn { get; set; }
    public string? GenInLieuCertYn { get; set; }
    public decimal? ExtendNoOfTimes { get; set; }
    public string? VoucherBenefitCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaEcertTypes>(entity =>
        {
            entity.HasKey(e => new { e.CertCode, e.ChainCode })
                .HasName("OEE_PK");

            entity.ToTable("OPERA_ECERT_TYPES");

            entity.HasIndex(e => new { e.Scope, e.BeginDate, e.EndDate })
                .HasName("OPERA_ECERT_TYPES_IDX1");

            entity.Property(e => e.CertCode)
                .HasColumnName("CERT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardType)
                .HasColumnName("AWARD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancelAllowedYn)
                .HasColumnName("CANCEL_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CertLabel)
                .HasColumnName("CERT_LABEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CertificateNoGenFormat)
                .HasColumnName("CERTIFICATE_NO_GEN_FORMAT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CertificateNoPrefix)
                .HasColumnName("CERTIFICATE_NO_PREFIX")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Cost)
                .HasColumnName("COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExpiryMonths)
                .HasColumnName("EXPIRY_MONTHS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtendNoOfTimes)
                .HasColumnName("EXTEND_NO_OF_TIMES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GenInLieuCertYn)
                .HasColumnName("GEN_IN_LIEU_CERT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GroupCode)
                .HasColumnName("GROUP_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LongDescription)
                .HasColumnName("LONG_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OwsConsumedYn)
                .HasColumnName("OWS_CONSUMED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PmsConsumedYn)
                .HasColumnName("PMS_CONSUMED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode)
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservationCertYn)
                .HasColumnName("RESERVATION_CERT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Scope)
                .HasColumnName("SCOPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Value)
                .HasColumnName("VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VerifyCertNoYn)
                .HasColumnName("VERIFY_CERT_NO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.VoucherBenefitCode)
                .HasColumnName("VOUCHER_BENEFIT_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.WebAllowedYn)
                .HasColumnName("WEB_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
