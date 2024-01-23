namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConRateDtlPrices
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? RateSetId { get; set; }
    public decimal? AgeQfCode { get; set; }
    public decimal? NumOfGuests { get; set; }
    public decimal? AmtAfterTax { get; set; }
    public decimal? ExtraAdult { get; set; }
    public string RateCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConRateDtlPrices>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_RATE_DTL_PRICES");

            entity.Property(e => e.AgeQfCode)
                .HasColumnName("AGE_QF_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmtAfterTax)
                .HasColumnName("AMT_AFTER_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtraAdult)
                .HasColumnName("EXTRA_ADULT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumOfGuests)
                .HasColumnName("NUM_OF_GUESTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateSetId)
                .HasColumnName("RATE_SET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
