namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpMhglExport
{
    public decimal? ExportId { get; set; }
    public decimal? OrderBy { get; set; }
    public string RecordType { get; set; }
    public decimal? RecordTypeSeq { get; set; }
    public decimal? LedgerSeq { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string CurrencyCode { get; set; }
    public string HotelCode { get; set; }
    public decimal? Product { get; set; }
    public decimal? LedgerAmount { get; set; }
    public decimal? StatisticsAmount { get; set; }
    public string LineReference { get; set; }
    public string LineDescription { get; set; }
    public string Country { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpMhglExport>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_MHGL_EXPORT");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LedgerAmount)
                .HasColumnName("LEDGER_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LedgerSeq)
                .HasColumnName("LEDGER_SEQ")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LineDescription)
                .HasColumnName("LINE_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LineReference)
                .HasColumnName("LINE_REFERENCE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RecordTypeSeq)
                .HasColumnName("RECORD_TYPE_SEQ")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StatisticsAmount)
                .HasColumnName("STATISTICS_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
