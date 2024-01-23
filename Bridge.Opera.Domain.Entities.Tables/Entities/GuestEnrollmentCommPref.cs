namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GuestEnrollmentCommPref
{
    public decimal EnrollmentSeqId { get; set; }
    public string PhoneNumber { get; set; }
    public decimal TopicId { get; set; }
    public string OptInYn { get; set; }

    public virtual GuestEnrollment EnrollmentSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestEnrollmentCommPref>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GUEST_ENROLLMENT_COMM_PREF");

            entity.HasIndex(e => e.EnrollmentSeqId)
                .HasName("GUEST_ENROLLMENT_COMM_PREF_FKI");

            entity.Property(e => e.EnrollmentSeqId)
                .HasColumnName("ENROLLMENT_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OptInYn)
                .IsRequired()
                .HasColumnName("OPT_IN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasColumnName("PHONE_NUMBER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TopicId)
                .HasColumnName("TOPIC_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GuestEnrollment)))
				entity.Ignore(e => e.EnrollmentSeq);
			else
	            entity.HasOne(d => d.EnrollmentSeq)
	                .WithMany()
	                .HasForeignKey(d => d.EnrollmentSeqId)
	                .HasConstraintName("GUEST_ENROLLMENT_COMM_PREF_FK");
        });
	}
}
