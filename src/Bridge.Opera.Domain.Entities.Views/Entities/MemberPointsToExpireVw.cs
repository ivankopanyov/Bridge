namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemberPointsToExpireVw
{
    public decimal? MembershipId { get; set; }
    public DateTime? PointsExpirationDate { get; set; }
    public decimal? PointsToExpire { get; set; }
    public decimal? PreviousPointsToExpire { get; set; }
    public string? PtsThatCanBeExtndExistYn { get; set; }
    public string? AwardGenerationMethod { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberPointsToExpireVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBER_POINTS_TO_EXPIRE_VW");

            entity.Property(e => e.AwardGenerationMethod)
                .HasColumnName("AWARD_GENERATION_METHOD")
                .HasColumnType("CHAR(8)");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsExpirationDate)
                .HasColumnName("POINTS_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PointsToExpire)
                .HasColumnName("POINTS_TO_EXPIRE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PreviousPointsToExpire)
                .HasColumnName("PREVIOUS_POINTS_TO_EXPIRE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PtsThatCanBeExtndExistYn)
                .HasColumnName("PTS_THAT_CAN_BE_EXTND_EXIST_YN")
                .IsUnicode(false);
        });
	}
}
