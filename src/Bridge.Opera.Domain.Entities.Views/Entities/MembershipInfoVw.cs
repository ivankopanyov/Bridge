namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MembershipInfoVw
{
    public decimal MembershipId { get; set; }
    public decimal NameId { get; set; }
    public string MembershipType { get; set; }
    public string MembershipCardNo { get; set; }
    public string AwardGenerationMethod { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string ColName { get; set; }
    public string PromptText { get; set; }
    public string ColValue { get; set; }
    public string IsRangeFieldYn { get; set; }
    public string IsResortFieldYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipInfoVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBERSHIP_INFO_VW");

            entity.Property(e => e.AwardGenerationMethod)
                .HasColumnName("AWARD_GENERATION_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ColName)
                .IsRequired()
                .HasColumnName("COL_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ColValue)
                .HasColumnName("COL_VALUE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IsRangeFieldYn)
                .HasColumnName("IS_RANGE_FIELD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IsResortFieldYn)
                .HasColumnName("IS_RESORT_FIELD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MembershipCardNo)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PromptText)
                .HasColumnName("PROMPT_TEXT")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
