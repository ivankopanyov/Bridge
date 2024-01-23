namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConResvRate
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? UnitMultiplier { get; set; }
    public decimal? RtAmtNoIncTax { get; set; }
    public decimal? RtAmtIncTax { get; set; }
    public string RtCurrencyCode { get; set; }
    public string RtTimeUnit { get; set; }
    public DateTime? RtEffectiveDt { get; set; }
    public DateTime? RtExpireDt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConResvRate>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_RESV_RATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RtAmtIncTax)
                .HasColumnName("RT_AMT_INC_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RtAmtNoIncTax)
                .HasColumnName("RT_AMT_NO_INC_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RtCurrencyCode)
                .HasColumnName("RT_CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RtEffectiveDt)
                .HasColumnName("RT_EFFECTIVE_DT")
                .HasColumnType("DATE");

            entity.Property(e => e.RtExpireDt)
                .HasColumnName("RT_EXPIRE_DT")
                .HasColumnType("DATE");

            entity.Property(e => e.RtTimeUnit)
                .HasColumnName("RT_TIME_UNIT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UnitMultiplier)
                .HasColumnName("UNIT_MULTIPLIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
