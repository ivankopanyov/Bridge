namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UpsellRuleRates
{
    public decimal? UpsellRuleId { get; set; }
    public string? RateSource { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UpsellRuleRates>(entity =>
        {
            entity.HasKey(e => new { e.UpsellRuleId, e.RateSource })
                .HasName("UPSELL_RULE_RATES_PK");

            entity.ToTable("UPSELL_RULE_RATES");

            entity.Property(e => e.UpsellRuleId)
                .HasColumnName("UPSELL_RULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateSource)
                .HasColumnName("RATE_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
