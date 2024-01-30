namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GemItemgroupDetails1
{
    public decimal? ItemgroupId { get; set; }
    public decimal? ItemId { get; set; }
    public string? Name { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? OrderBy { get; set; }
    public string? Resort { get; set; }
    public decimal? ItmaId { get; set; }
    public decimal? ItemrateId { get; set; }
    public decimal? ItemClassOrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemgroupDetails1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEM_ITEMGROUP_DETAILS");

            entity.Property(e => e.ItemClassOrderBy)
                .HasColumnName("ITEM_CLASS_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemgroupId)
                .HasColumnName("ITEMGROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemrateId)
                .HasColumnName("ITEMRATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItmaId)
                .HasColumnName("ITMA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
