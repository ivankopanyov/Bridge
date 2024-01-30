namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RateSetProductsDetails
{
    public string? Resort { get; set; }
    public decimal? RateSetId { get; set; }
    public string? Product { get; set; }
    public string? GroupProduct { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateSetProductsDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RATE_SET_PRODUCTS_DETAILS");

            entity.Property(e => e.GroupProduct)
                .HasColumnName("GROUP_PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateSetId)
                .HasColumnName("RATE_SET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
