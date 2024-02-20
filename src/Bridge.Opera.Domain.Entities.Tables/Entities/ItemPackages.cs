namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ItemPackages
{
    public decimal? ItemProdId { get; set; }
    public string? Resort { get; set; }
    public string? Product { get; set; }
    public decimal? ItemId { get; set; }
    public decimal? Quantity { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ItemPackages>(entity =>
        {
            entity.HasKey(e => e.ItemProdId)
                .HasName("ITM_PKG_PK");

            entity.ToTable("ITEM$PACKAGES");

            entity.HasIndex(e => new { e.Resort, e.ItemId })
                .HasName("ITEM_PKG_IDX");

            entity.HasIndex(e => new { e.Resort, e.Product, e.ItemId })
                .HasName("ITM_PKG_UK")
                .IsUnique();

            entity.Property(e => e.ItemProdId)
                .HasColumnName("ITEM_PROD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Product)
                .IsRequired()
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
