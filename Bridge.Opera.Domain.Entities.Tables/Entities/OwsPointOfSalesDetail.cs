namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OwsPointOfSalesDetail
{
    public decimal PointOfSaleId { get; set; }
    public string Language { get; set; }
    public string Country { get; set; }
    public string Currency { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string Status { get; set; }
    public DateTime? InactiveDate { get; set; }

    public virtual OwsPointOfSales PointOfSale { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OwsPointOfSalesDetail>(entity =>
        {
            entity.HasKey(e => new { e.PointOfSaleId, e.Language, e.Country, e.Currency })
                .HasName("OWS_POSD_PK");

            entity.ToTable("OWS_POINT_OF_SALES_DETAIL");

            entity.Property(e => e.PointOfSaleId)
                .HasColumnName("POINT_OF_SALE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(40)
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

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(OwsPointOfSales)))
				entity.Ignore(e => e.PointOfSale);
			else
	            entity.HasOne(d => d.PointOfSale)
	                .WithMany(p => p.OwsPointOfSalesDetail)
	                .HasForeignKey(d => d.PointOfSaleId)
	                .HasConstraintName("OWS_POS_FK");
        });
	}
}
