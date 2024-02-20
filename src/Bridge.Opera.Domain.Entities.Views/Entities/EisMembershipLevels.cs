namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EisMembershipLevels
{
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }
    public string? Label { get; set; }
    public string? Description { get; set; }
    public decimal? MembershipLevelRank { get; set; }
    public string? UpgradePoints { get; set; }
    public string? UpgradeMonths { get; set; }
    public string? DowngradePoints { get; set; }
    public string? DowngradeMonths { get; set; }
    public string? MonthsEffective { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? MaxDowngradeLevel { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EisMembershipLevels>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EIS_MEMBERSHIP_LEVELS");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DowngradeMonths)
                .HasColumnName("DOWNGRADE_MONTHS")
                .IsUnicode(false);

            entity.Property(e => e.DowngradePoints)
                .HasColumnName("DOWNGRADE_POINTS")
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

            entity.Property(e => e.Label)
                .HasColumnName("LABEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MaxDowngradeLevel)
                .HasColumnName("MAX_DOWNGRADE_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevel)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevelRank)
                .HasColumnName("MEMBERSHIP_LEVEL_RANK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MonthsEffective)
                .HasColumnName("MONTHS_EFFECTIVE")
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpgradeMonths)
                .HasColumnName("UPGRADE_MONTHS")
                .IsUnicode(false);

            entity.Property(e => e.UpgradePoints)
                .HasColumnName("UPGRADE_POINTS")
                .IsUnicode(false);
        });
	}
}
