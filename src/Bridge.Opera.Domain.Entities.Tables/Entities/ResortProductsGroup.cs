namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortProductsGroup
{
    public string? Resort { get; set; }
    public string? ProductGroup { get; set; }
    public string? ProductMember { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortProductsGroup>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ProductGroup, e.ProductMember })
                .HasName("RPG_PK");

            entity.ToTable("RESORT_PRODUCTS_GROUP");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProductGroup)
                .HasColumnName("PRODUCT_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProductMember)
                .HasColumnName("PRODUCT_MEMBER")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
