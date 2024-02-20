namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class YmRateAdj
{
    public string? AdjOverriden { get; set; }
    public string? Resort { get; set; }
    public decimal? RateSetId { get; set; }
    public string? AdjustmentCode { get; set; }
    public string? AdjustmentType { get; set; }
    public decimal? AdjustmentAmount { get; set; }
    public string? CurrencyCode { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<YmRateAdj>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("YM_RATE_ADJ");

            entity.Property(e => e.AdjOverriden)
                .HasColumnName("ADJ_OVERRIDEN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AdjustmentAmount)
                .HasColumnName("ADJUSTMENT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdjustmentCode)
                .IsRequired()
                .HasColumnName("ADJUSTMENT_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.AdjustmentType)
                .IsRequired()
                .HasColumnName("ADJUSTMENT_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .IsRequired()
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.RateSetId)
                .HasColumnName("RATE_SET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
