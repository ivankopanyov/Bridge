namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NameAdjustmentsView
{
    public decimal? NameId { get; set; }
    public string? AdjustmentType { get; set; }
    public string? AdjustmentCode { get; set; }
    public decimal? AdjustmentAmount { get; set; }
    public string? FormattedAdjAmount { get; set; }
    public string? CurrencyCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameAdjustmentsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NAME_ADJUSTMENTS_VIEW");

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

            entity.Property(e => e.FormattedAdjAmount)
                .HasColumnName("FORMATTED_ADJ_AMOUNT")
                .HasMaxLength(41)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
