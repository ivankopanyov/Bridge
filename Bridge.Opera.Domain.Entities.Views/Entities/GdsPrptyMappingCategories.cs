namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GdsPrptyMappingCategories
{
    public string CategoryType { get; set; }
    public string SubcategoryType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsPrptyMappingCategories>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GDS_PRPTY_MAPPING_CATEGORIES");

            entity.Property(e => e.CategoryType)
                .HasColumnName("CATEGORY_TYPE")
                .HasMaxLength(13)
                .IsUnicode(false);

            entity.Property(e => e.SubcategoryType)
                .HasColumnName("SUBCATEGORY_TYPE")
                .HasMaxLength(18)
                .IsUnicode(false);
        });
	}
}
