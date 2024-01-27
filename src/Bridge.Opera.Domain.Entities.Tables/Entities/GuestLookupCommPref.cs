namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GuestLookupCommPref
{
    public decimal LookupSeqId { get; set; }
    public string PhoneNumber { get; set; }
    public decimal TopicId { get; set; }
    public string OptInYn { get; set; }

    public virtual GuestLookup LookupSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestLookupCommPref>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GUEST_LOOKUP_COMM_PREF");

            entity.HasIndex(e => e.LookupSeqId)
                .HasName("GUEST_LOOKUP_COMM_PREF_FKI");

            entity.Property(e => e.LookupSeqId)
                .HasColumnName("LOOKUP_SEQ_ID")
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

			if (!types.Contains(typeof(GuestLookup)))
				entity.Ignore(e => e.LookupSeq);
			else
	            entity.HasOne(d => d.LookupSeq)
	                .WithMany()
	                .HasForeignKey(d => d.LookupSeqId)
	                .HasConstraintName("GUEST_LOOKUP_COMM_PREF_FK");
        });
	}
}
