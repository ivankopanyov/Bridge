namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OwsPointOfSales
{
    public OwsPointOfSales()
    {
        OwsPointOfSalesDetail = new HashSet<OwsPointOfSalesDetail>();
    }

    public decimal PointOfSaleId { get; set; }
    public string PointOfSaleName { get; set; }
    public string PointOfSaleUrl { get; set; }
    public string Resort { get; set; }
    public string GdsHost { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal? DisplaySeq { get; set; }
    public DateTime? InactiveDate { get; set; }

    public virtual ICollection<OwsPointOfSalesDetail> OwsPointOfSalesDetail { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OwsPointOfSales>(entity =>
        {
            entity.HasKey(e => e.PointOfSaleId)
                .HasName("OWS_POINT_OF_SALES_PK");

            entity.ToTable("OWS_POINT_OF_SALES");

            entity.Property(e => e.PointOfSaleId)
                .HasColumnName("POINT_OF_SALE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DisplaySeq)
                .HasColumnName("DISPLAY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointOfSaleName)
                .IsRequired()
                .HasColumnName("POINT_OF_SALE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PointOfSaleUrl)
                .HasColumnName("POINT_OF_SALE_URL")
                .HasMaxLength(2000)
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
        
			if (!types.Contains(typeof(OwsPointOfSalesDetail)))
				entity.Ignore(e => e.OwsPointOfSalesDetail);
		});
	}
}
