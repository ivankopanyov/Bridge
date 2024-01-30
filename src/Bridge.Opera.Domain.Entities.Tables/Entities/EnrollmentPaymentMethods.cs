namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EnrollmentPaymentMethods
{
    public decimal? EnrollPaymentId { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }
    public string? PmtMethod { get; set; }
    public string? Mpcode { get; set; }
    public string? Description { get; set; }
    public decimal? PmtAmount { get; set; }
    public string? PmtDesc { get; set; }
    public string? SourceCode { get; set; }
    public decimal? PointFactor { get; set; }
    public string? AllowEnrollYn { get; set; }
    public decimal? EnrollmentFee { get; set; }
    public string? ChainCode { get; set; }

    public virtual MembershipLevels MembershipLevels { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EnrollmentPaymentMethods>(entity =>
        {
            entity.HasKey(e => e.EnrollPaymentId)
                .HasName("ENROLL_PAYMENT_PK");

            entity.ToTable("ENROLLMENT_PAYMENT_METHODS");

            entity.HasIndex(e => new { e.ChainCode, e.MembershipType, e.MembershipLevel, e.PmtMethod, e.Mpcode })
                .HasName("ENROLL_PAYMENT_UK")
                .IsUnique();

            entity.Property(e => e.EnrollPaymentId)
                .HasColumnName("ENROLL_PAYMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllowEnrollYn)
                .HasColumnName("ALLOW_ENROLL_YN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EnrollmentFee)
                .HasColumnName("ENROLLMENT_FEE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Mpcode)
                .HasColumnName("MPCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmtAmount)
                .HasColumnName("PMT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmtDesc)
                .HasColumnName("PMT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PmtMethod)
                .HasColumnName("PMT_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PointFactor)
                .HasColumnName("POINT_FACTOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(MembershipLevels)))
				entity.Ignore(e => e.MembershipLevels);
			else
	            entity.HasOne(d => d.MembershipLevels)
	                .WithMany(p => p.EnrollmentPaymentMethods)
	                .HasForeignKey(d => new { d.ChainCode, d.MembershipType, d.MembershipLevel })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ENROLL_PAYMENT_FK");
        });
	}
}
