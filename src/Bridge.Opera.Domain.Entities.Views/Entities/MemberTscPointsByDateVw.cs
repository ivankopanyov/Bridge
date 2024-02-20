namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemberTscPointsByDateVw
{
    public decimal? MembershipId { get; set; }
    public string? MembershipType { get; set; }
    public decimal? NameId { get; set; }
    public string? MembershipCardNo { get; set; }
    public string? TscDateFlag { get; set; }
    public DateTime? TscDate { get; set; }
    public decimal? TotalStayPoints { get; set; }
    public decimal? TotalNightPoints { get; set; }
    public decimal? TotalRevenuePoints { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberTscPointsByDateVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBER_TSC_POINTS_BY_DATE_VW");

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

            entity.Property(e => e.TotalNightPoints)
                .HasColumnName("TOTAL_NIGHT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenuePoints)
                .HasColumnName("TOTAL_REVENUE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalStayPoints)
                .HasColumnName("TOTAL_STAY_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TscDate)
                .HasColumnName("TSC_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TscDateFlag)
                .HasColumnName("TSC_DATE_FLAG")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
