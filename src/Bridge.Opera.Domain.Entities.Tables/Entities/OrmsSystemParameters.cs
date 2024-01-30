namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsSystemParameters
{
    public string? Resort { get; set; }
    public string? ConfigStatus { get; set; }
    public decimal? MaxLos { get; set; }
    public decimal? HurdleSteps { get; set; }
    public string? AutoApplyYn { get; set; }
    public string? AllotmentClassType { get; set; }
    public DateTime? NextFullrunDate { get; set; }
    public string? RefRoomCategory { get; set; }
    public decimal? OptimizerInterval { get; set; }
    public string? BookingClassType { get; set; }
    public string? OrmsCro { get; set; }
    public string? LosOptimization { get; set; }
    public string? CeilingAdjustment { get; set; }
    public string? DailyRateCode { get; set; }
    public string? EventsImpact { get; set; }
    public decimal? MaxFutureDays { get; set; }
    public decimal? MaxHistoryDays { get; set; }
    public DateTime? NextSeasonsCheckDate { get; set; }
    public decimal? CalendarDefaultDays { get; set; }
    public decimal? LosHurdlesToSend { get; set; }
    public string? AutoApplyObYn { get; set; }
    public string? IgnoreHurdleCeilingYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsSystemParameters>(entity =>
        {
            entity.HasKey(e => e.Resort)
                .HasName("ORMS_SYSTEM_PARAMETERS_PK");

            entity.ToTable("ORMS_SYSTEM_PARAMETERS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AllotmentClassType)
                .HasColumnName("ALLOTMENT_CLASS_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AutoApplyObYn)
                .HasColumnName("AUTO_APPLY_OB_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"NULL");

            entity.Property(e => e.AutoApplyYn)
                .IsRequired()
                .HasColumnName("AUTO_APPLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.BookingClassType)
                .HasColumnName("BOOKING_CLASS_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CalendarDefaultDays)
                .HasColumnName("CALENDAR_DEFAULT_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CeilingAdjustment)
                .IsRequired()
                .HasColumnName("CEILING_ADJUSTMENT")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.ConfigStatus)
                .HasColumnName("CONFIG_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DailyRateCode)
                .HasColumnName("DAILY_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventsImpact)
                .HasColumnName("EVENTS_IMPACT")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HurdleSteps)
                .HasColumnName("HURDLE_STEPS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IgnoreHurdleCeilingYn)
                .HasColumnName("IGNORE_HURDLE_CEILING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LosHurdlesToSend)
                .HasColumnName("LOS_HURDLES_TO_SEND")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql(@"NULL");

            entity.Property(e => e.LosOptimization)
                .IsRequired()
                .HasColumnName("LOS_OPTIMIZATION")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.MaxFutureDays)
                .HasColumnName("MAX_FUTURE_DAYS")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql(@"365");

            entity.Property(e => e.MaxHistoryDays)
                .HasColumnName("MAX_HISTORY_DAYS")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql(@"730");

            entity.Property(e => e.MaxLos)
                .HasColumnName("MAX_LOS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NextFullrunDate)
                .HasColumnName("NEXT_FULLRUN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NextSeasonsCheckDate)
                .HasColumnName("NEXT_SEASONS_CHECK_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OptimizerInterval)
                .HasColumnName("OPTIMIZER_INTERVAL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrmsCro)
                .HasColumnName("ORMS_CRO")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'CRO'");

            entity.Property(e => e.RefRoomCategory)
                .HasColumnName("REF_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
