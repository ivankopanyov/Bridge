namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipLevels
{
    public MembershipLevels()
    {
        EnrollmentPaymentMethods = new HashSet<EnrollmentPaymentMethods>();
        MembershipLevelRules = new HashSet<MembershipLevelRules>();
    }

    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }
    public string? Label { get; set; }
    public string? Description { get; set; }
    public decimal? MembershipLevelRank { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? MaxDowngradeLevel { get; set; }
    public string? FulfillmentYn { get; set; }
    public decimal? CardValidYears { get; set; }
    public decimal? NoOfTrx { get; set; }
    public string? ChainCode { get; set; }
    public string? DisplayColor { get; set; }
    public string? VipStatus { get; set; }
    public string? ChangesRestrictedYn { get; set; }

    public virtual MembershipTypes MembershipTypes { get; set; }
    public virtual ICollection<EnrollmentPaymentMethods> EnrollmentPaymentMethods { get; set; }
    public virtual ICollection<MembershipLevelRules> MembershipLevelRules { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipLevels>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MembershipType, e.MembershipLevel })
                .HasName("MEMBERSHIP_LEVELS_PK");

            entity.ToTable("MEMBERSHIP_LEVELS");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CardValidYears)
                .HasColumnName("CARD_VALID_YEARS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChangesRestrictedYn)
                .HasColumnName("CHANGES_RESTRICTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplayColor)
                .HasColumnName("DISPLAY_COLOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FulfillmentYn)
                .HasColumnName("FULFILLMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Label)
                .HasColumnName("LABEL")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxDowngradeLevel)
                .HasColumnName("MAX_DOWNGRADE_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipLevelRank)
                .HasColumnName("MEMBERSHIP_LEVEL_RANK")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoOfTrx)
                .HasColumnName("NO_OF_TRX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(MembershipTypes)))
				entity.Ignore(e => e.MembershipTypes);
			else
	            entity.HasOne(d => d.MembershipTypes)
	                .WithMany(p => p.MembershipLevels)
	                .HasForeignKey(d => new { d.ChainCode, d.MembershipType })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEMBERSHIP_LEVEL_TYPE_FK");
        
			if (!types.Contains(typeof(EnrollmentPaymentMethods)))
				entity.Ignore(e => e.EnrollmentPaymentMethods);

			if (!types.Contains(typeof(MembershipLevelRules)))
				entity.Ignore(e => e.MembershipLevelRules);
		});
	}
}
