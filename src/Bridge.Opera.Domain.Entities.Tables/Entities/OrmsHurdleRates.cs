namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsHurdleRates
{
    public string Resort { get; set; }
    public string YieldCategory { get; set; }
    public DateTime HurdleDate { get; set; }
    public decimal Los { get; set; }
    public decimal? Hurdle { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? OverrideHurdle { get; set; }
    public string ApprovedYn { get; set; }
    public decimal? ApprovedBy { get; set; }
    public DateTime? ApprovedDate { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public decimal? OverrideBy { get; set; }
    public DateTime? OverrideDate { get; set; }
    public decimal? HurdleCeiling { get; set; }
    public decimal? RuleHurdle { get; set; }
    public string ScheduledYn { get; set; }
    public decimal? AlertId { get; set; }
    public string AlertKey { get; set; }
    public decimal? AppliedHurdle { get; set; }
    public decimal? PricesliceId { get; set; }
    public decimal? PriceConfigHeaderId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsHurdleRates>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.YieldCategory, e.HurdleDate, e.Los })
                .HasName("ORMS_HURDLE_RATES_PK");

            entity.ToTable("ORMS_HURDLE_RATES");

            entity.HasIndex(e => new { e.Resort, e.HurdleDate, e.YieldCategory, e.ScheduledYn })
                .HasName("ORMS_HURDLE_RATES_IDX1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HurdleDate)
                .HasColumnName("HURDLE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Los)
                .HasColumnName("LOS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AlertId)
                .HasColumnName("ALERT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AlertKey)
                .HasColumnName("ALERT_KEY")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AppliedHurdle)
                .HasColumnName("APPLIED_HURDLE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ApprovedBy)
                .HasColumnName("APPROVED_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ApprovedDate)
                .HasColumnName("APPROVED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ApprovedYn)
                .IsRequired()
                .HasColumnName("APPROVED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.ExpiryDate)
                .HasColumnName("EXPIRY_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Hurdle)
                .HasColumnName("HURDLE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HurdleCeiling)
                .HasColumnName("HURDLE_CEILING")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OverrideBy)
                .HasColumnName("OVERRIDE_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OverrideDate)
                .HasColumnName("OVERRIDE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OverrideHurdle)
                .HasColumnName("OVERRIDE_HURDLE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PriceConfigHeaderId)
                .HasColumnName("PRICE_CONFIG_HEADER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PricesliceId)
                .HasColumnName("PRICESLICE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RuleHurdle)
                .HasColumnName("RULE_HURDLE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ScheduledYn)
                .HasColumnName("SCHEDULED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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
