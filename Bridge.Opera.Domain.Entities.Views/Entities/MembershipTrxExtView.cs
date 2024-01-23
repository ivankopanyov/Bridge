namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MembershipTrxExtView
{
    public decimal MembershipTrxId { get; set; }
    public decimal? AccTotalPoints { get; set; }
    public decimal? AccTotalBasePoints { get; set; }
    public decimal? AccTotalBonusPoints { get; set; }
    public decimal? AccMembershipBaseNights { get; set; }
    public decimal? AccMembershipBaseRevenue { get; set; }
    public decimal? AccMembershipBonusNights { get; set; }
    public decimal? AccMembershipBonusRevenue { get; set; }
    public decimal? AccMembershipBaseStay { get; set; }
    public decimal? AccMembershipBonusStay { get; set; }
    public decimal? AccPointsCost { get; set; }
    public decimal? AppTotalPoints { get; set; }
    public decimal? AppTotalBasePoints { get; set; }
    public decimal? AppTotalBonusPoints { get; set; }
    public decimal? AppMembershipBaseNights { get; set; }
    public decimal? AppMembershipBaseRevenue { get; set; }
    public decimal? AppMembershipBonusNights { get; set; }
    public decimal? AppMembershipBonusRevenue { get; set; }
    public decimal? AppMembershipBaseStay { get; set; }
    public decimal? AppMembershipBonusStay { get; set; }
    public decimal? AppPointsCost { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipTrxExtView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBERSHIP_TRX_EXT_VIEW");

            entity.Property(e => e.AccMembershipBaseNights)
                .HasColumnName("ACC_MEMBERSHIP_BASE_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccMembershipBaseRevenue)
                .HasColumnName("ACC_MEMBERSHIP_BASE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccMembershipBaseStay)
                .HasColumnName("ACC_MEMBERSHIP_BASE_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccMembershipBonusNights)
                .HasColumnName("ACC_MEMBERSHIP_BONUS_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccMembershipBonusRevenue)
                .HasColumnName("ACC_MEMBERSHIP_BONUS_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccMembershipBonusStay)
                .HasColumnName("ACC_MEMBERSHIP_BONUS_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccPointsCost)
                .HasColumnName("ACC_POINTS_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccTotalBasePoints)
                .HasColumnName("ACC_TOTAL_BASE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccTotalBonusPoints)
                .HasColumnName("ACC_TOTAL_BONUS_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccTotalPoints)
                .HasColumnName("ACC_TOTAL_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppMembershipBaseNights)
                .HasColumnName("APP_MEMBERSHIP_BASE_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppMembershipBaseRevenue)
                .HasColumnName("APP_MEMBERSHIP_BASE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppMembershipBaseStay)
                .HasColumnName("APP_MEMBERSHIP_BASE_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppMembershipBonusNights)
                .HasColumnName("APP_MEMBERSHIP_BONUS_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppMembershipBonusRevenue)
                .HasColumnName("APP_MEMBERSHIP_BONUS_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppMembershipBonusStay)
                .HasColumnName("APP_MEMBERSHIP_BONUS_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppPointsCost)
                .HasColumnName("APP_POINTS_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppTotalBasePoints)
                .HasColumnName("APP_TOTAL_BASE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppTotalBonusPoints)
                .HasColumnName("APP_TOTAL_BONUS_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppTotalPoints)
                .HasColumnName("APP_TOTAL_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipTrxId)
                .HasColumnName("MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");
        });
	}
}
