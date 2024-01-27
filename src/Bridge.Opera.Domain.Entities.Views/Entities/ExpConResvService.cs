namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConResvService
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? GenerateInclusive { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? TcNetAmount { get; set; }
    public decimal? TcGrossAmount { get; set; }
    public decimal? TaxAmount { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public string PostingRhythm { get; set; }
    public string PackageCode { get; set; }
    public string CurrencyCode { get; set; }
    public string TaxType { get; set; }
    public string TaxCode { get; set; }
    public string TaxCurrencyCode { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConResvService>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_RESV_SERVICE");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GenerateInclusive)
                .HasColumnName("GENERATE_INCLUSIVE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageCode)
                .HasColumnName("PACKAGE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PostingRhythm)
                .HasColumnName("POSTING_RHYTHM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxAmount)
                .HasColumnName("TAX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxCode)
                .HasColumnName("TAX_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxCurrencyCode)
                .HasColumnName("TAX_CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxType)
                .HasColumnName("TAX_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TcGrossAmount)
                .HasColumnName("TC_GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TcNetAmount)
                .HasColumnName("TC_NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
