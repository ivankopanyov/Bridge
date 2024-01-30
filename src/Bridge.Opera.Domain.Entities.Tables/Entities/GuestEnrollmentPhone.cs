namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GuestEnrollmentPhone
{
    public decimal? EnrollmentSeqId { get; set; }
    public string? PhoneType { get; set; }
    public string? PhoneRole { get; set; }
    public string? PhoneNumber { get; set; }
    public decimal? CountryDialingCode { get; set; }
    public string? EmailPrefCodes { get; set; }
    public string? PhoneCountryCode { get; set; }
    public string? PrimaryYn { get; set; }
    public decimal? OrderBy { get; set; }

    public virtual GuestEnrollment EnrollmentSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestEnrollmentPhone>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GUEST_ENROLLMENT_PHONE");

            entity.HasIndex(e => e.EnrollmentSeqId)
                .HasName("GUEST_ENROLLMENT_PHONE_FKI");

            entity.Property(e => e.CountryDialingCode)
                .HasColumnName("COUNTRY_DIALING_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmailPrefCodes)
                .HasColumnName("EMAIL_PREF_CODES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EnrollmentSeqId)
                .HasColumnName("ENROLLMENT_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneCountryCode)
                .HasColumnName("PHONE_COUNTRY_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasColumnName("PHONE_NUMBER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PhoneRole)
                .IsRequired()
                .HasColumnName("PHONE_ROLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PhoneType)
                .IsRequired()
                .HasColumnName("PHONE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(GuestEnrollment)))
				entity.Ignore(e => e.EnrollmentSeq);
			else
	            entity.HasOne(d => d.EnrollmentSeq)
	                .WithMany()
	                .HasForeignKey(d => d.EnrollmentSeqId)
	                .HasConstraintName("GUEST_ENROLLMENT_PHONE_FK");
        });
	}
}
