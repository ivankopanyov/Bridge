namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UpsellRule
{
    public decimal? UpsellRuleId { get; set; }
    public string? Resort { get; set; }
    public string? FromRoomCategory { get; set; }
    public string? ToRoomCategory { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? UpsellAmount { get; set; }
    public string? RoundingRule { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Formula { get; set; }
    public string? RateSourceType { get; set; }
    public string? OccupLevelsYn { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
    public string? FromRoomClass { get; set; }
    public string? ToRoomClass { get; set; }
    public decimal? DaysInAdvance { get; set; }
    public string? CurrencyCode { get; set; }
    public string? TrxCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UpsellRule>(entity =>
        {
            entity.ToTable("UPSELL_RULE");

            entity.HasIndex(e => new { e.Resort, e.BeginDate, e.EndDate, e.FromRoomCategory, e.ToRoomCategory, e.FromRoomClass, e.ToRoomClass })
                .HasName("UPSELL_RULE_IDX1");

            entity.Property(e => e.UpsellRuleId)
                .HasColumnName("UPSELL_RULE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DaysInAdvance)
                .HasColumnName("DAYS_IN_ADVANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Formula)
                .HasColumnName("FORMULA")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FromRoomCategory)
                .HasColumnName("FROM_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FromRoomClass)
                .HasColumnName("FROM_ROOM_CLASS")
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

            entity.Property(e => e.OccupLevelsYn)
                .HasColumnName("OCCUP_LEVELS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateSourceType)
                .HasColumnName("RATE_SOURCE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoundingRule)
                .HasColumnName("ROUNDING_RULE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ToRoomCategory)
                .HasColumnName("TO_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToRoomClass)
                .HasColumnName("TO_ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpsellAmount)
                .HasColumnName("UPSELL_AMOUNT")
                .HasColumnType("NUMBER");
        });
	}
}
