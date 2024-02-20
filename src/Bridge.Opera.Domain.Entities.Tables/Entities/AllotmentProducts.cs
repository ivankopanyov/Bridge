namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AllotmentProducts
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
    public string? OffsetType { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }
    public virtual ResortProducts ResortProducts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentProducts>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AllotmentProductId })
                .HasName("ALLOTMENT_PRODUCTS_PK");

            entity.ToTable("ALLOTMENT$PRODUCTS");

            entity.HasIndex(e => new { e.Resort, e.ProductId })
                .HasName("ALLOTMENT_PRODUCTS_PROD_IDX");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort, e.OffsetType })
                .HasName("ALLOTMENT_PRODUCTS_AH_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AllotmentProductId)
                .HasColumnName("ALLOTMENT_PRODUCT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DmlSeqNo)
                .HasColumnName("DML_SEQ_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OffsetType)
                .IsRequired()
                .HasColumnName("OFFSET_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProductGroup)
                .HasColumnName("PRODUCT_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProductId)
                .IsRequired()
                .HasColumnName("PRODUCT_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProductSource)
                .HasColumnName("PRODUCT_SOURCE")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.QtyExcluded)
                .HasColumnName("QTY_EXCLUDED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.AllotmentProducts)
	                .HasForeignKey(d => new { d.AllotmentHeaderId, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ALLOTMENT_PRODUCTS_FK2");

			if (!types.Contains(typeof(ResortProducts)))
				entity.Ignore(e => e.ResortProducts);
			else
	            entity.HasOne(d => d.ResortProducts)
	                .WithMany(p => p.AllotmentProducts)
	                .HasForeignKey(d => new { d.Resort, d.ProductId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ALLOTMENT_PRODUCTS_FK1");
        });
	}
}
