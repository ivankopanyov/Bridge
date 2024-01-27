namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipClaimsHistory
{
    public decimal MembershipClaimId { get; set; }
    public decimal Sequence { get; set; }
    public DateTime ClaimDate { get; set; }
    public string ClaimActivity { get; set; }
    public string Comments { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipClaimsHistory>(entity =>
        {
            entity.HasKey(e => new { e.MembershipClaimId, e.Sequence })
                .HasName("MEMBERSHIP_CLAIMS_HISTORY_PK");

            entity.ToTable("MEMBERSHIP_CLAIMS_HISTORY");

            entity.Property(e => e.MembershipClaimId)
                .HasColumnName("MEMBERSHIP_CLAIM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sequence)
                .HasColumnName("SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClaimActivity)
                .HasColumnName("CLAIM_ACTIVITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClaimDate)
                .HasColumnName("CLAIM_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");
        });
	}
}
