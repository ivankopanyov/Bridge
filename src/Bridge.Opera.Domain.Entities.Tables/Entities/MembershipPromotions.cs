namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipPromotions
{
    public decimal? MembershipId { get; set; }
    public string? PromotionCode { get; set; }
    public DateTime? EnrollmentDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? IssueType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipPromotions>(entity =>
        {
            entity.HasKey(e => new { e.MembershipId, e.PromotionCode })
                .HasName("MPN_PK");

            entity.ToTable("MEMBERSHIP_PROMOTIONS");

            entity.HasIndex(e => e.PromotionCode)
                .HasName("MEMBERSHIP_PROMO_IDX");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PromotionCode)
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EnrollmentDate)
                .HasColumnName("ENROLLMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IssueType)
                .HasColumnName("ISSUE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
