namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UpsellRuleGrnteeType
{
    public decimal? UpsellRuleId { get; set; }
    public string? GuaranteeType { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UpsellRuleGrnteeType>(entity =>
        {
            entity.HasKey(e => new { e.UpsellRuleId, e.GuaranteeType })
                .HasName("UPSELL_RULE_GRNTEE_TYPE_PK");

            entity.ToTable("UPSELL_RULE_GRNTEE_TYPE");

            entity.Property(e => e.UpsellRuleId)
                .HasColumnName("UPSELL_RULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteeType)
                .HasColumnName("GUARANTEE_TYPE")
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
