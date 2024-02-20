namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpGbeGroupHeader
{
    public decimal? ExportId { get; set; }
    public string? GbeType { get; set; }
    public string? PropertyCode { get; set; }
    public string? PostingMasterType { get; set; }
    public decimal? GroupBookingNumber { get; set; }
    public string? PostingMasterNumber { get; set; }
    public string? FolioNumber { get; set; }
    public decimal? CustomerPoNumber { get; set; }
    public string? InvoiceNumber { get; set; }
    public DateTime? InvoiceDate { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? BlockId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpGbeGroupHeader>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_GBE_GROUP_HEADER");

            entity.Property(e => e.BlockId)
                .HasColumnName("BLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CustomerPoNumber)
                .HasColumnName("CUSTOMER_PO_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNumber)
                .HasColumnName("FOLIO_NUMBER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GbeType)
                .HasColumnName("GBE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GroupBookingNumber)
                .HasColumnName("GROUP_BOOKING_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceDate)
                .HasColumnName("INVOICE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvoiceNumber)
                .HasColumnName("INVOICE_NUMBER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PostingMasterNumber)
                .HasColumnName("POSTING_MASTER_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PostingMasterType)
                .HasColumnName("POSTING_MASTER_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
