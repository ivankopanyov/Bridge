namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NoshowRevenueRules
{
    public string? Resort { get; set; }
    public string? GuaranteeCode { get; set; }
    public string? SourceCode { get; set; }
    public string? Rule { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NoshowRevenueRules>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("NOSHOW_REVENUE_RULES");

            entity.HasIndex(e => new { e.Resort, e.GuaranteeCode, e.SourceCode })
                .HasName("NOSHOW_REVENUE_RULES_UK")
                .IsUnique();

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Rule)
                .IsRequired()
                .HasColumnName("RULE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
