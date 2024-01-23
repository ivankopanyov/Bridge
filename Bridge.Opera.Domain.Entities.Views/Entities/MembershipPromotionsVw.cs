namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MembershipPromotionsVw
{
    public decimal MembershipId { get; set; }
    public string PromotionCode { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string Mpcode { get; set; }
    public string PromoName { get; set; }
    public DateTime? StayStartdate { get; set; }
    public DateTime? StayEnddate { get; set; }
    public string Category { get; set; }
    public string CategoryDesc { get; set; }
    public string PromoInstructions { get; set; }
    public string PromoInformation { get; set; }
    public string IssueType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipPromotionsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBERSHIP_PROMOTIONS_VW");

            entity.Property(e => e.Category)
                .HasColumnName("CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CategoryDesc)
                .HasColumnName("CATEGORY_DESC")
                .HasMaxLength(2000)
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

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Mpcode)
                .HasColumnName("MPCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromoInformation)
                .HasColumnName("PROMO_INFORMATION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PromoInstructions)
                .HasColumnName("PROMO_INSTRUCTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PromoName)
                .HasColumnName("PROMO_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode)
                .IsRequired()
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StayEnddate)
                .HasColumnName("STAY_ENDDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StayStartdate)
                .HasColumnName("STAY_STARTDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
