namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MembershipBenefitsVw
{
    public decimal? MembershipId { get; set; }
    public string? MembershipType { get; set; }
    public string? BenefitCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ProcessingMsg { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? ProgBeginDate { get; set; }
    public DateTime? ProgEndDate { get; set; }
    public string? MinMembershipLevel { get; set; }
    public DateTime? ProgInactiveDate { get; set; }
    public string? ActiveYn { get; set; }
    public string? Description { get; set; }
    public string? ProgActiveYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipBenefitsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBERSHIP_BENEFITS_VW");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.BenefitCode)
                .IsRequired()
                .HasColumnName("BENEFIT_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MinMembershipLevel)
                .HasColumnName("MIN_MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProcessingMsg)
                .HasColumnName("PROCESSING_MSG")
                .IsUnicode(false);

            entity.Property(e => e.ProgActiveYn)
                .HasColumnName("PROG_ACTIVE_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.ProgBeginDate)
                .HasColumnName("PROG_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProgEndDate)
                .HasColumnName("PROG_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProgInactiveDate)
                .HasColumnName("PROG_INACTIVE_DATE")
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
