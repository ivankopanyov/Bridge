namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateStrategyDaily
{
    public decimal? RateStrategyId { get; set; }
    public string Resort { get; set; }
    public DateTime? StrategyDate { get; set; }
    public string RoomClass { get; set; }
    public string RoomCategory { get; set; }
    public string RateClass { get; set; }
    public string RateCategory { get; set; }
    public string RateCode { get; set; }
    public DateTime? ControlStartDate { get; set; }
    public DateTime? ControlEndDate { get; set; }
    public decimal? ApplySequence { get; set; }
    public decimal? MaxCanSellRoom { get; set; }
    public string ConditionType { get; set; }
    public string RestrictionType { get; set; }
    public decimal? LosUnit { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateStrategyDaily>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RATE_STRATEGY_DAILY");

            entity.HasIndex(e => new { e.RateStrategyId, e.Resort })
                .HasName("RATE_STRATEGY_RESORT_ID_IDX");

            entity.HasIndex(e => new { e.Resort, e.StrategyDate, e.ControlStartDate, e.ControlEndDate })
                .HasName("RATE_STRATEGY_DAILY_IDX");

            entity.HasIndex(e => new { e.Resort, e.StrategyDate, e.RateCode, e.RateCategory, e.RateClass, e.RoomCategory, e.RoomClass })
                .HasName("RATE_STRATEGY_DAILY_UK")
                .IsUnique();

            entity.Property(e => e.ApplySequence)
                .HasColumnName("APPLY_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConditionType)
                .HasColumnName("CONDITION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ControlEndDate)
                .HasColumnName("CONTROL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ControlStartDate)
                .HasColumnName("CONTROL_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LosUnit)
                .HasColumnName("LOS_UNIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxCanSellRoom)
                .HasColumnName("MAX_CAN_SELL_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateClass)
                .HasColumnName("RATE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateStrategyId)
                .HasColumnName("RATE_STRATEGY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestrictionType)
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

            entity.Property(e => e.StrategyDate)
                .HasColumnName("STRATEGY_DATE")
                .HasColumnType("DATE");
        });
	}
}
