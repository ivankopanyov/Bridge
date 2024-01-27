namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipRejectComments
{
    public decimal MembershipTrxId { get; set; }
    public decimal MembershipPointsSeqno { get; set; }
    public string MembershipType { get; set; }
    public string Comments { get; set; }

    public virtual MembershipTransactions MembershipTrx { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipRejectComments>(entity =>
        {
            entity.HasKey(e => new { e.MembershipTrxId, e.MembershipType, e.MembershipPointsSeqno })
                .HasName("MEMBERSHIP_REJECT_COMMENTS_PK");

            entity.ToTable("MEMBERSHIP_REJECT_COMMENTS");

            entity.HasIndex(e => e.MembershipTrxId)
                .HasName("MEMBERSHIP_REJECT_COMMENT_IND1");

            entity.Property(e => e.MembershipTrxId)
                .HasColumnName("MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipPointsSeqno)
                .HasColumnName("MEMBERSHIP_POINTS_SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(200)
                .IsUnicode(false);

			if (!types.Contains(typeof(MembershipTransactions)))
				entity.Ignore(e => e.MembershipTrx);
			else
	            entity.HasOne(d => d.MembershipTrx)
	                .WithMany(p => p.MembershipRejectComments)
	                .HasForeignKey(d => d.MembershipTrxId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEMBERSHIP_REJECT_COMMENTS_FK1");
        });
	}
}
