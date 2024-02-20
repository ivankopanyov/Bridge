namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidResortProductsGroup
{
    public string? Resort { get; set; }
    public string? ProductGroup { get; set; }
    public string? ProductMember { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidResortProductsGroup>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_RESORT_PRODUCTS_GROUP");

            entity.Property(e => e.ProductGroup)
                .IsRequired()
                .HasColumnName("PRODUCT_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProductMember)
                .IsRequired()
                .HasColumnName("PRODUCT_MEMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
