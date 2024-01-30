namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GuestEnrollmentPref
{
    public decimal? EnrollmentSeqId { get; set; }
    public string? Preference { get; set; }
    public string? PreferenceType { get; set; }
    public string? Description { get; set; }

    public virtual GuestEnrollment EnrollmentSeq { get; set; }
    public virtual SpgPreferences PreferenceNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestEnrollmentPref>(entity =>
        {
            entity.HasKey(e => new { e.EnrollmentSeqId, e.Preference, e.PreferenceType })
                .HasName("GUEST_PREFERENCES_PK");

            entity.ToTable("GUEST_ENROLLMENT_PREF");

            entity.HasIndex(e => new { e.Preference, e.PreferenceType })
                .HasName("GUEST_PREFERENCES_FKI");

            entity.Property(e => e.EnrollmentSeqId)
                .HasColumnName("ENROLLMENT_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Preference)
                .HasColumnName("PREFERENCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceType)
                .HasColumnName("PREFERENCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

			if (!types.Contains(typeof(GuestEnrollment)))
				entity.Ignore(e => e.EnrollmentSeq);
			else
	            entity.HasOne(d => d.EnrollmentSeq)
	                .WithMany(p => p.GuestEnrollmentPref)
	                .HasForeignKey(d => d.EnrollmentSeqId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("GUEST_ENROLLMENT_PREF_FK");

			if (!types.Contains(typeof(SpgPreferences)))
				entity.Ignore(e => e.PreferenceNavigation);
			else
	            entity.HasOne(d => d.PreferenceNavigation)
	                .WithMany(p => p.GuestEnrollmentPref)
	                .HasForeignKey(d => new { d.Preference, d.PreferenceType })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("GUEST_PREFERENCES_FK");
        });
	}
}
