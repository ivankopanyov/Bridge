namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MobileAudioKeyRules
{
    public string? Resort { get; set; }
    public string? PaymentMethods { get; set; }
    public string? GuaranteeCodes { get; set; }
    public string? MembershipTypes { get; set; }
    public string? VipStatus { get; set; }
    public string? MobilePhoneType { get; set; }
    public string? MobileNumberYn { get; set; }
    public string? EmailYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MobileAudioKeyRules>(entity =>
        {
            entity.HasKey(e => e.Resort)
                .HasName("MOBILE_AUDIO_KEY_RULES_PK");

            entity.ToTable("MOBILE_AUDIO_KEY_RULES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EmailYn)
                .HasColumnName("EMAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCodes)
                .HasColumnName("GUARANTEE_CODES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MembershipTypes)
                .HasColumnName("MEMBERSHIP_TYPES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MobileNumberYn)
                .HasColumnName("MOBILE_NUMBER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MobilePhoneType)
                .HasColumnName("MOBILE_PHONE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethods)
                .HasColumnName("PAYMENT_METHODS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
