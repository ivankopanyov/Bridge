namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AwardProfileRequestsLogVw
{
    public decimal LogId { get; set; }
    public string Resort { get; set; }
    public decimal NameId { get; set; }
    public decimal ResvNameId { get; set; }
    public string CrsConfirmationNumber { get; set; }
    public string CrsHotelCode { get; set; }
    public string CertificateNumber { get; set; }
    public string MasterCertificateNumber { get; set; }
    public string AwardCode { get; set; }
    public string InstantRedemptionYn { get; set; }
    public string FbaYn { get; set; }
    public string PaidUpgradeYn { get; set; }
    public decimal CertActionId { get; set; }
    public string ActionType { get; set; }
    public DateTime? BusinessDate { get; set; }
    public DateTime InsertTs { get; set; }
    public decimal InsertUser { get; set; }
    public string AwardType { get; set; }
    public string ActivityType { get; set; }
    public string FailureReason { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AwardProfileRequestsLogVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AWARD_PROFILE_REQUESTS_LOG_VW");

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ActivityType)
                .HasColumnName("ACTIVITY_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.AwardCode)
                .HasColumnName("AWARD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AwardType)
                .HasColumnName("AWARD_TYPE")
                .HasColumnType("CHAR(2)");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CertActionId)
                .HasColumnName("CERT_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CertificateNumber)
                .IsRequired()
                .HasColumnName("CERTIFICATE_NUMBER")
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

            entity.Property(e => e.FailureReason)
                .HasColumnName("FAILURE_REASON")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FbaYn)
                .HasColumnName("FBA_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertTs)
                .HasColumnName("INSERT_TS")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InstantRedemptionYn)
                .HasColumnName("INSTANT_REDEMPTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LogId)
                .HasColumnName("LOG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterCertificateNumber)
                .HasColumnName("MASTER_CERTIFICATE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaidUpgradeYn)
                .HasColumnName("PAID_UPGRADE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
