namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsHurdleSchedules
{
    public string Resort { get; set; }
    public string ScheduleCode { get; set; }
    public string Description { get; set; }
    public string SeasonCode { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? ScopeFrom { get; set; }
    public decimal? ScopeTo { get; set; }
    public string Day1 { get; set; }
    public string Day2 { get; set; }
    public string Day3 { get; set; }
    public string Day4 { get; set; }
    public string Day5 { get; set; }
    public string Day6 { get; set; }
    public string Day7 { get; set; }
    public string PrevailingYn { get; set; }
    public string DailyYn { get; set; }
    public string BarYn { get; set; }
    public string SchType { get; set; }
    public decimal? SchFrequency { get; set; }
    public string SchFrequencyType { get; set; }
    public decimal? SchDetailId { get; set; }
    public DateTime? LastRunDate { get; set; }
    public DateTime? NextRunDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsHurdleSchedules>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ScheduleCode })
                .HasName("ORMS_HURDLE_SCH_PK");

            entity.ToTable("ORMS_HURDLE_SCHEDULES");

            entity.HasIndex(e => new { e.Resort, e.NextRunDate })
                .HasName("ORMS_HURDLE_SCH_IDX1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScheduleCode)
                .HasColumnName("SCHEDULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BarYn)
                .IsRequired()
                .HasColumnName("BAR_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DailyYn)
                .IsRequired()
                .HasColumnName("DAILY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

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

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LastRunDate)
                .HasColumnName("LAST_RUN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NextRunDate)
                .HasColumnName("NEXT_RUN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PrevailingYn)
                .IsRequired()
                .HasColumnName("PREVAILING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.SchDetailId)
                .HasColumnName("SCH_DETAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SchFrequency)
                .HasColumnName("SCH_FREQUENCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SchFrequencyType)
                .HasColumnName("SCH_FREQUENCY_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'M'");

            entity.Property(e => e.SchType)
                .IsRequired()
                .HasColumnName("SCH_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'F'");

            entity.Property(e => e.ScopeFrom)
                .HasColumnName("SCOPE_FROM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ScopeTo)
                .HasColumnName("SCOPE_TO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SeasonCode)
                .HasColumnName("SEASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
