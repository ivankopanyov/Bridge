namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipAwards
{
    public MembershipAwards()
    {
        MembershipAwardFinTrx = new HashSet<MembershipAwardFinTrx>();
        MembershipAwardGrpUpgrades = new HashSet<MembershipAwardGrpUpgrades>();
        MembershipAwardUpgrades = new HashSet<MembershipAwardUpgrades>();
        MembershipIssuedAwards = new HashSet<MembershipIssuedAwards>();
    }

    public string MembershipType { get; set; }
    public string AwardType { get; set; }
    public string MembershipLevel { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? AwardQuantity { get; set; }
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public decimal? CancelPenaltyDays { get; set; }
    public decimal? CancelPenaltyCharge { get; set; }
    public string CancelPenaltyType { get; set; }
    public string AutoConsumeYn { get; set; }
    public string ForceVerificationYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string AwardBasedOn { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? PointsRequired { get; set; }
    public decimal? AwardValue { get; set; }
    public string MessageLine1 { get; set; }
    public string MessageLine2 { get; set; }
    public string MessageLine3 { get; set; }
    public string MessageLine4 { get; set; }
    public string DisplaySet { get; set; }
    public string ChainCode { get; set; }
    public string ExchangeRateType { get; set; }
    public decimal? MaxPercentAllowed { get; set; }
    public string PtsSchCode { get; set; }
    public string BillingGroup { get; set; }
    public string CancelPolicyType { get; set; }
    public decimal? NumberOfNights { get; set; }
    public string RoomCategoryGrpYn { get; set; }
    public string IgnoreFtTrxYn { get; set; }

    public virtual MembershipTypes MembershipTypes { get; set; }
    public virtual ICollection<MembershipAwardFinTrx> MembershipAwardFinTrx { get; set; }
    public virtual ICollection<MembershipAwardGrpUpgrades> MembershipAwardGrpUpgrades { get; set; }
    public virtual ICollection<MembershipAwardUpgrades> MembershipAwardUpgrades { get; set; }
    public virtual ICollection<MembershipIssuedAwards> MembershipIssuedAwards { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipAwards>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MembershipType, e.AwardType })
                .HasName("MEMBERSHIP_AWARDS_PK");

            entity.ToTable("MEMBERSHIP_AWARDS");

            entity.HasIndex(e => new { e.ChainCode, e.PtsSchCode })
                .HasName("MEM_AWARD_IND1");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AwardType)
                .HasColumnName("AWARD_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AutoConsumeYn)
                .HasColumnName("AUTO_CONSUME_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.AwardBasedOn)
                .HasColumnName("AWARD_BASED_ON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AwardQuantity)
                .HasColumnName("AWARD_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardValue)
                .HasColumnName("AWARD_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillingGroup)
                .HasColumnName("BILLING_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancelPenaltyCharge)
                .HasColumnName("CANCEL_PENALTY_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPenaltyDays)
                .HasColumnName("CANCEL_PENALTY_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPenaltyType)
                .HasColumnName("CANCEL_PENALTY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancelPolicyType)
                .HasColumnName("CANCEL_POLICY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DisplaySet)
                .HasColumnName("DISPLAY_SET")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExchangeRateType)
                .HasColumnName("EXCHANGE_RATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ForceVerificationYn)
                .HasColumnName("FORCE_VERIFICATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.IgnoreFtTrxYn)
                .HasColumnName("IGNORE_FT_TRX_YN")
                .HasMaxLength(1)
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

            entity.Property(e => e.LongDescription)
                .HasColumnName("LONG_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MaxPercentAllowed)
                .HasColumnName("MAX_PERCENT_ALLOWED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MessageLine1)
                .HasColumnName("MESSAGE_LINE1")
                .IsUnicode(false);

            entity.Property(e => e.MessageLine2)
                .HasColumnName("MESSAGE_LINE2")
                .IsUnicode(false);

            entity.Property(e => e.MessageLine3)
                .HasColumnName("MESSAGE_LINE3")
                .IsUnicode(false);

            entity.Property(e => e.MessageLine4)
                .HasColumnName("MESSAGE_LINE4")
                .IsUnicode(false);

            entity.Property(e => e.NumberOfNights)
                .HasColumnName("NUMBER_OF_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsRequired)
                .HasColumnName("POINTS_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PtsSchCode)
                .HasColumnName("PTS_SCH_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryGrpYn)
                .HasColumnName("ROOM_CATEGORY_GRP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(MembershipTypes)))
				entity.Ignore(e => e.MembershipTypes);
			else
	            entity.HasOne(d => d.MembershipTypes)
	                .WithMany(p => p.MembershipAwards)
	                .HasForeignKey(d => new { d.ChainCode, d.MembershipType })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEMBERSHIP_AWARD_FK1");
        
			if (!types.Contains(typeof(MembershipAwardFinTrx)))
				entity.Ignore(e => e.MembershipAwardFinTrx);

			if (!types.Contains(typeof(MembershipAwardGrpUpgrades)))
				entity.Ignore(e => e.MembershipAwardGrpUpgrades);

			if (!types.Contains(typeof(MembershipAwardUpgrades)))
				entity.Ignore(e => e.MembershipAwardUpgrades);

			if (!types.Contains(typeof(MembershipIssuedAwards)))
				entity.Ignore(e => e.MembershipIssuedAwards);
		});
	}
}
