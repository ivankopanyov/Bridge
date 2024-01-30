namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUpeResvProducts
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? ProductSource { get; set; }
    public string? ProductId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? ProductDescription { get; set; }
    public decimal? Quantity { get; set; }
    public string? PostingRhythm { get; set; }
    public decimal? Price { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUpeResvProducts>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_UPE_RESV_PRODUCTS");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostingRhythm)
                .HasColumnName("POSTING_RHYTHM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProductDescription)
                .HasColumnName("PRODUCT_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ProductId)
                .HasColumnName("PRODUCT_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ProductSource)
                .HasColumnName("PRODUCT_SOURCE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
