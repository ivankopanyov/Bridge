namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsAlertHurdleVw
{
    public decimal AlertId { get; set; }
    public string Resort { get; set; }
    public string AlertName { get; set; }
    public string Code { get; set; }
    public string AlertText { get; set; }
    public string AlertOnlyYn { get; set; }
    public string AlertColor { get; set; }
    public string SeasonCode { get; set; }
    public string Day1 { get; set; }
    public string Day2 { get; set; }
    public string Day3 { get; set; }
    public string Day4 { get; set; }
    public string Day5 { get; set; }
    public string Day6 { get; set; }
    public string Day7 { get; set; }
    public decimal? LeaddayFrom { get; set; }
    public decimal? LeaddayTo { get; set; }
    public decimal? Los { get; set; }
    public decimal? LowerHurdle { get; set; }
    public decimal? OverrideValue { get; set; }
    public decimal? UpperHurdle { get; set; }
    public string YieldCategory { get; set; }
    public decimal? LowerForecast { get; set; }
    public decimal? LowerOtb { get; set; }
    public decimal? UpperForecast { get; set; }
    public decimal? UpperOtb { get; set; }
    public decimal? Priority { get; set; }
    public string ShowOnHome { get; set; }
    public string ShowOnForecast { get; set; }
    public string ShowOnBlock { get; set; }
    public string ShowOnRateshopper { get; set; }
    public string EventCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsAlertHurdleVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_ALERT_HURDLE_VW");

            entity.Property(e => e.AlertColor)
                .HasColumnName("ALERT_COLOR")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AlertId)
                .HasColumnName("ALERT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AlertName)
                .IsRequired()
                .HasColumnName("ALERT_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AlertOnlyYn)
                .HasColumnName("ALERT_ONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AlertText)
                .IsRequired()
                .HasColumnName("ALERT_TEXT")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Code)
                .IsRequired()
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day1)
                .IsRequired()
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day2)
                .IsRequired()
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day3)
                .IsRequired()
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day4)
                .IsRequired()
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day5)
                .IsRequired()
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day6)
                .IsRequired()
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day7)
                .IsRequired()
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventCodes)
                .HasColumnName("EVENT_CODES")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LeaddayFrom)
                .HasColumnName("LEADDAY_FROM")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LeaddayTo)
                .HasColumnName("LEADDAY_TO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Los)
                .HasColumnName("LOS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LowerForecast)
                .HasColumnName("LOWER_FORECAST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LowerHurdle)
                .HasColumnName("LOWER_HURDLE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LowerOtb)
                .HasColumnName("LOWER_OTB")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OverrideValue)
                .HasColumnName("OVERRIDE_VALUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SeasonCode)
                .HasColumnName("SEASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShowOnBlock)
                .HasColumnName("SHOW_ON_BLOCK")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShowOnForecast)
                .HasColumnName("SHOW_ON_FORECAST")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShowOnHome)
                .HasColumnName("SHOW_ON_HOME")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShowOnRateshopper)
                .HasColumnName("SHOW_ON_RATESHOPPER")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpperForecast)
                .HasColumnName("UPPER_FORECAST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpperHurdle)
                .HasColumnName("UPPER_HURDLE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpperOtb)
                .HasColumnName("UPPER_OTB")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
