namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEfolioDetails3
{
    public decimal? ExportId { get; set; }
    public decimal? RowSequence { get; set; }
    public decimal? PartySequence { get; set; }
    public decimal? DetailSequence { get; set; }
    public decimal? DetailCountSequence { get; set; }
    public string ExportType { get; set; }
    public string TrxCode { get; set; }
    public string TrxDesc { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? Gad { get; set; }
    public decimal? TaxAmount { get; set; }
    public decimal? PricePerUnit { get; set; }
    public DateTime? InvoiceDate { get; set; }
    public DateTime? PostingDate { get; set; }
    public string MapValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEfolioDetails3>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_EFOLIO_DETAILS_3");

            entity.Property(e => e.DetailCountSequence)
                .HasColumnName("DETAIL_COUNT_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DetailSequence)
                .HasColumnName("DETAIL_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportType)
                .HasColumnName("EXPORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Gad)
                .HasColumnName("GAD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InvoiceDate)
                .HasColumnName("INVOICE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MapValue)
                .HasColumnName("MAP_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PartySequence)
                .HasColumnName("PARTY_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostingDate)
                .HasColumnName("POSTING_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PricePerUnit)
                .HasColumnName("PRICE_PER_UNIT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RowSequence)
                .HasColumnName("ROW_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaxAmount)
                .HasColumnName("TAX_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxDesc)
                .HasColumnName("TRX_DESC")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
