namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipMultiplePoints
{
    public decimal? MembershipTrxId { get; set; }
    public decimal? MembershipPointsSeqno { get; set; }
    public string? MembershipType { get; set; }
    public decimal? MembershipId { get; set; }
    public decimal? Points { get; set; }
    public string? AppliedYn { get; set; }

    public virtual MembershipTransactions MembershipTrx { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipMultiplePoints>(entity =>
        {
            entity.HasKey(e => new { e.MembershipTrxId, e.MembershipPointsSeqno })
                .HasName("MEMBERSHIP_MULTIPLE_POINTS_PK");

            entity.ToTable("MEMBERSHIP_MULTIPLE_POINTS");

            entity.Property(e => e.MembershipTrxId)
                .HasColumnName("MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipPointsSeqno)
                .HasColumnName("MEMBERSHIP_POINTS_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppliedYn)
                .HasColumnName("APPLIED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Points)
                .HasColumnName("POINTS")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(MembershipTransactions)))
				entity.Ignore(e => e.MembershipTrx);
			else
	            entity.HasOne(d => d.MembershipTrx)
	                .WithMany(p => p.MembershipMultiplePoints)
	                .HasForeignKey(d => d.MembershipTrxId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEMBERSHIP_MULTIPLE_POINTS_FK");
        });
	}
}
