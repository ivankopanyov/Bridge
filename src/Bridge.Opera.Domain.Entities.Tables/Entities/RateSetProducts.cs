namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateSetProducts
{
    public decimal RateSetId { get; set; }
    public string Resort { get; set; }
    public string Product { get; set; }
    public string GroupProduct { get; set; }

    public virtual RateSet RateSet { get; set; }
    public virtual ResortProducts ResortProducts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateSetProducts>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Product, e.RateSetId })
                .HasName("RATE_SET_PROD_PK");

            entity.ToTable("RATE_SET_PRODUCTS");

            entity.HasIndex(e => e.RateSetId)
                .HasName("RATE_SET_PRODUCTS_IND2");

            entity.HasIndex(e => new { e.Resort, e.RateSetId })
                .HasName("RATE_SET_PRODUCTS_IND1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateSetId)
                .HasColumnName("RATE_SET_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GroupProduct)
                .HasColumnName("GROUP_PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(RateSet)))
				entity.Ignore(e => e.RateSet);
			else
	            entity.HasOne(d => d.RateSet)
	                .WithMany(p => p.RateSetProducts)
	                .HasForeignKey(d => d.RateSetId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RSP_RATE_SET_FK");

			if (!types.Contains(typeof(ResortProducts)))
				entity.Ignore(e => e.ResortProducts);
			else
	            entity.HasOne(d => d.ResortProducts)
	                .WithMany(p => p.RateSetProducts)
	                .HasForeignKey(d => new { d.Resort, d.Product })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RSP_RESORT_PRODUCTS_FK");
        });
	}
}
