namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UpsellRuleDetail
{
    public decimal? UpsellRuleId { get; set; }
    public decimal? LevelId { get; set; }
    public decimal? UpsellAmount { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UpsellRuleDetail>(entity =>
        {
            entity.HasKey(e => new { e.UpsellRuleId, e.LevelId })
                .HasName("UPSELL_RULE_DETAIL_PK");

            entity.ToTable("UPSELL_RULE_DETAIL");

            entity.Property(e => e.UpsellRuleId)
                .HasColumnName("UPSELL_RULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LevelId)
                .HasColumnName("LEVEL_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.UpsellAmount)
                .HasColumnName("UPSELL_AMOUNT")
                .HasColumnType("NUMBER");
        });
	}
}
