namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConResvPkgRate
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? Amount { get; set; }
    public decimal? PkgDetSeq { get; set; }
    public string? IsTaxYn { get; set; }
    public string? IsPkgYn { get; set; }
    public string? Product { get; set; }
    public string? PkgRateDescription { get; set; }
    public string? TaxInclusiveYn { get; set; }
    public string? CurrencyCode { get; set; }
    public string? Resort { get; set; }
    public string? Code { get; set; }
    public string? InDate { get; set; }
    public string? AddonYn { get; set; }
    public string? IncludePkgYn { get; set; }
    public string? PkgTaxYn { get; set; }
    public string? PkgTrxCode { get; set; }
    public string? PkgCode { get; set; }
    public DateTime? PostingDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConResvPkgRate>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_RESV_PKG_RATE");

            entity.Property(e => e.AddonYn)
                .HasColumnName("ADDON_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InDate)
                .HasColumnName("IN_DATE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IncludePkgYn)
                .HasColumnName("INCLUDE_PKG_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IsPkgYn)
                .HasColumnName("IS_PKG_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IsTaxYn)
                .HasColumnName("IS_TAX_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PkgCode)
                .HasColumnName("PKG_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PkgDetSeq)
                .HasColumnName("PKG_DET_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgRateDescription)
                .HasColumnName("PKG_RATE_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PkgTaxYn)
                .HasColumnName("PKG_TAX_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PkgTrxCode)
                .HasColumnName("PKG_TRX_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PostingDate)
                .HasColumnName("POSTING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxInclusiveYn)
                .HasColumnName("TAX_INCLUSIVE_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
