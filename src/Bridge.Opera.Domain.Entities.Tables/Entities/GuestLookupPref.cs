namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GuestLookupPref
{
    public decimal? LookupSeqId { get; set; }
    public string? Preference { get; set; }
    public string? PreferenceType { get; set; }
    public string? Description { get; set; }

    public virtual GuestLookup LookupSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestLookupPref>(entity =>
        {
            entity.HasKey(e => new { e.LookupSeqId, e.PreferenceType, e.Preference })
                .HasName("GUEST_LOOKUP_PREF_PK");

            entity.ToTable("GUEST_LOOKUP_PREF");

            entity.Property(e => e.LookupSeqId)
                .HasColumnName("LOOKUP_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PreferenceType)
                .HasColumnName("PREFERENCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Preference)
                .HasColumnName("PREFERENCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

			if (!types.Contains(typeof(GuestLookup)))
				entity.Ignore(e => e.LookupSeq);
			else
	            entity.HasOne(d => d.LookupSeq)
	                .WithMany(p => p.GuestLookupPref)
	                .HasForeignKey(d => d.LookupSeqId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("GUEST_LOOKUP_PREF_FK");
        });
	}
}
