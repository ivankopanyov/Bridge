namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ShResortProducts
{
    public string Resort { get; set; }
    public string Product { get; set; }
    public string CrsPkgCode { get; set; }
    public string CrsDefaultYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ShResortProducts>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Product })
                .HasName("SH_RESORT_PRODUCTS_PK");

            entity.ToTable("SH_RESORT_PRODUCTS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CrsDefaultYn)
                .HasColumnName("CRS_DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CrsPkgCode)
                .IsRequired()
                .HasColumnName("CRS_PKG_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
