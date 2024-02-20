namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateStrategy
{
    public decimal? RateStrategyId { get; set; }
    public string? Resort { get; set; }
    public string? RateClass { get; set; }
    public string? RateCategory { get; set; }
    public string? RateCode { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomCategory { get; set; }
    public decimal? ConditionValue { get; set; }
    public string? ConditionType { get; set; }
    public string? ConditionValueType { get; set; }
    public string? RestrictionType { get; set; }
    public decimal? LosUnits { get; set; }
    public DateTime? RestrStartDate { get; set; }
    public DateTime? RestrEndDate { get; set; }
    public string? Day1 { get; set; }
    public string? Day2 { get; set; }
    public string? Day3 { get; set; }
    public string? Day4 { get; set; }
    public string? Day5 { get; set; }
    public string? Day6 { get; set; }
    public string? Day7 { get; set; }
    public DateTime? ControlStartDatetime { get; set; }
    public DateTime? ControlEndDatetime { get; set; }
    public decimal? DaysInAdvanceFrom { get; set; }
    public decimal? DaysInAdvanceTo { get; set; }
    public decimal? ApplySequence { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? Physical { get; set; }
    public string? ApplyYn { get; set; }
    public string? AutoCounterConditionYn { get; set; }
    public string? IncludeOverbookingYn { get; set; }
    public string? GdsHost { get; set; }
    public string? IncludeOutOfOrderYn { get; set; }
    public decimal? ThresholdValue { get; set; }
    public string? ThrsholdReachedEmailSentYn { get; set; }
    public decimal? OrigRateStrategyId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateStrategy>(entity =>
        {
            entity.ToTable("RATE_STRATEGY");

            entity.HasIndex(e => new { e.Resort, e.ControlEndDatetime })
                .HasName("RS_RESORT_ENDDATE_IDX");

            entity.HasIndex(e => new { e.Resort, e.ConditionType, e.RestrStartDate, e.RestrEndDate, e.ControlStartDatetime, e.ControlEndDatetime })
                .HasName("RS_RES_CONDITION_IDX");

            entity.HasIndex(e => new { e.Resort, e.RateCode, e.ConditionType, e.ApplyYn, e.RestrEndDate, e.RestrStartDate, e.ConditionValue, e.ConditionValueType })
                .HasName("RS_APPLY_IDX");

            entity.Property(e => e.RateStrategyId)
                .HasColumnName("RATE_STRATEGY_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ApplySequence)
                .HasColumnName("APPLY_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ApplyYn)
                .HasColumnName("APPLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AutoCounterConditionYn)
                .HasColumnName("AUTO_COUNTER_CONDITION_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConditionType)
                .HasColumnName("CONDITION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConditionValue)
                .HasColumnName("CONDITION_VALUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConditionValueType)
                .HasColumnName("CONDITION_VALUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ControlEndDatetime)
                .HasColumnName("CONTROL_END_DATETIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ControlStartDatetime)
                .HasColumnName("CONTROL_START_DATETIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day1)
                .IsRequired()
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day2)
                .IsRequired()
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day3)
                .IsRequired()
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day4)
                .IsRequired()
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day5)
                .IsRequired()
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day6)
                .IsRequired()
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day7)
                .IsRequired()
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.DaysInAdvanceFrom)
                .HasColumnName("DAYS_IN_ADVANCE_FROM")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DaysInAdvanceTo)
                .HasColumnName("DAYS_IN_ADVANCE_TO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IncludeOutOfOrderYn)
                .HasColumnName("INCLUDE_OUT_OF_ORDER_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IncludeOverbookingYn)
                .HasColumnName("INCLUDE_OVERBOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LosUnits)
                .HasColumnName("LOS_UNITS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrigRateStrategyId)
                .HasColumnName("ORIG_RATE_STRATEGY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Physical)
                .HasColumnName("PHYSICAL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateClass)
                .HasColumnName("RATE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RestrEndDate)
                .HasColumnName("RESTR_END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RestrStartDate)
                .HasColumnName("RESTR_START_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RestrictionType)
                .HasColumnName("RESTRICTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ThresholdValue)
                .HasColumnName("THRESHOLD_VALUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ThrsholdReachedEmailSentYn)
                .HasColumnName("THRSHOLD_REACHED_EMAIL_SENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
