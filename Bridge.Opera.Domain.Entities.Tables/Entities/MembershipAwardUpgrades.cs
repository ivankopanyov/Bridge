namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipAwardUpgrades
{
    public decimal MembershipAwardId { get; set; }
    public string Resort { get; set; }
    public string MembershipType { get; set; }
    public string AwardType { get; set; }
    public string FromRoom { get; set; }
    public string ToRoom { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal PointsRequired { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string ChainCode { get; set; }

    public virtual MembershipAwards MembershipAwards { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipAwardUpgrades>(entity =>
        {
            entity.HasKey(e => e.MembershipAwardId)
                .HasName("MEMBERSHIP_AWARD_UPGRADES_PK");

            entity.ToTable("MEMBERSHIP_AWARD_UPGRADES");

            entity.HasIndex(e => new { e.ChainCode, e.MembershipType, e.AwardType })
                .HasName("MEMBERSHIP_AWARD_UPGRADES_IND2");

            entity.HasIndex(e => new { e.Resort, e.FromRoom, e.BeginDate, e.EndDate })
                .HasName("MEMBERSHIP_AWARD_UPGRADES_IND1");

            entity.Property(e => e.MembershipAwardId)
                .HasColumnName("MEMBERSHIP_AWARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardType)
                .IsRequired()
                .HasColumnName("AWARD_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FromRoom)
                .IsRequired()
                .HasColumnName("FROM_ROOM")
                .HasMaxLength(20)
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

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PointsRequired)
                .HasColumnName("POINTS_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToRoom)
                .IsRequired()
                .HasColumnName("TO_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(MembershipAwards)))
				entity.Ignore(e => e.MembershipAwards);
			else
	            entity.HasOne(d => d.MembershipAwards)
	                .WithMany(p => p.MembershipAwardUpgrades)
	                .HasForeignKey(d => new { d.ChainCode, d.MembershipType, d.AwardType })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEMBERSHIP_AWARD_UPGRADE_FK1");
        });
	}
}
