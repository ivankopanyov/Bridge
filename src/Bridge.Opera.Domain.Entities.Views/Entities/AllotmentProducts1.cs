namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AllotmentProducts1
{
    public decimal? AllotmentHeaderId { get; set; }
    public string? Resort { get; set; }
    public decimal? AllotmentProductId { get; set; }
    public string? ProductId { get; set; }
    public decimal? Quantity { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? ActionId { get; set; }
    public decimal? DmlSeqNo { get; set; }
    public string? RateCode { get; set; }
    public byte? LaptopChange { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ProductSource { get; set; }
    public decimal? QtyExcluded { get; set; }
    public string? ProductGroup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentProducts1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ALLOTMENT_PRODUCTS");

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentProductId)
                .HasColumnName("ALLOTMENT_PRODUCT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DmlSeqNo)
                .HasColumnName("DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.ProductGroup)
                .HasColumnName("PRODUCT_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProductId)
                .IsRequired()
                .HasColumnName("PRODUCT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProductSource)
                .HasColumnName("PRODUCT_SOURCE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.QtyExcluded)
                .HasColumnName("QTY_EXCLUDED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
