namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AllotmentRestrictions
{
    public decimal AllotmentRestrictionId { get; set; }
    public string Resort { get; set; }
    public decimal AllotmentHeaderId { get; set; }
    public string RoomCategory { get; set; }
    public string RestrictionType { get; set; }
    public string RateCode { get; set; }
    public string RateClass { get; set; }
    public string RateTier { get; set; }
    public decimal? LosUnits { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Day1 { get; set; }
    public string Day2 { get; set; }
    public string Day3 { get; set; }
    public string Day4 { get; set; }
    public string Day5 { get; set; }
    public string Day6 { get; set; }
    public string Day7 { get; set; }
    public string SeasonCode { get; set; }
    public string RoomClass { get; set; }
    public string YieldCreatedYn { get; set; }
    public string Los1Yn { get; set; }
    public string Los2Yn { get; set; }
    public string Los3Yn { get; set; }
    public string Los4Yn { get; set; }
    public string Los5Yn { get; set; }
    public string Los6Yn { get; set; }
    public string Los7Yn { get; set; }
    public string ClearPreviousYn { get; set; }
    public DateTime? BusinessDateApplied { get; set; }
    public decimal DaySeq { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }
    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentRestrictions>(entity =>
        {
            entity.HasKey(e => new { e.AllotmentRestrictionId, e.DaySeq })
                .HasName("ALLOTMENT_RESTRICTIONS_PK");

            entity.ToTable("ALLOTMENT_RESTRICTIONS");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort })
                .HasName("ALLOTMENT_HEADER_ID_FKI");

            entity.HasIndex(e => new { e.Resort, e.AllotmentHeaderId, e.RestrictionType, e.BeginDate })
                .HasName("ALLOTMENT_RESTRICTIONS_IND1");

            entity.Property(e => e.AllotmentRestrictionId)
                .HasColumnName("ALLOTMENT_RESTRICTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DaySeq)
                .HasColumnName("DAY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessDateApplied)
                .HasColumnName("BUSINESS_DATE_APPLIED")
                .HasColumnType("DATE");

            entity.Property(e => e.ClearPreviousYn)
                .HasColumnName("CLEAR_PREVIOUS_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Day1)
                .IsRequired()
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day2)
                .IsRequired()
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day3)
                .IsRequired()
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day4)
                .IsRequired()
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day5)
                .IsRequired()
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day6)
                .IsRequired()
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day7)
                .IsRequired()
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
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

            entity.Property(e => e.Los1Yn)
                .HasColumnName("LOS1_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Los2Yn)
                .HasColumnName("LOS2_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Los3Yn)
                .HasColumnName("LOS3_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Los4Yn)
                .HasColumnName("LOS4_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Los5Yn)
                .HasColumnName("LOS5_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Los6Yn)
                .HasColumnName("LOS6_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Los7Yn)
                .HasColumnName("LOS7_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.LosUnits)
                .HasColumnName("LOS_UNITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateClass)
                .HasColumnName("RATE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateTier)
                .HasColumnName("RATE_TIER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RestrictionType)
                .IsRequired()
                .HasColumnName("RESTRICTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SeasonCode)
                .HasColumnName("SEASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YieldCreatedYn)
                .HasColumnName("YIELD_CREATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.AllotmentRestrictions)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ALLOTMENT_REST_RESORT_FK");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.AllotmentRestrictions)
	                .HasForeignKey(d => new { d.AllotmentHeaderId, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ALLOTMENT_HEADER_ID_FK");
        });
	}
}
