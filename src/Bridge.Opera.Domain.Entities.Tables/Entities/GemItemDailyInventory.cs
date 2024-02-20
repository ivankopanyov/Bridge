namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemDailyInventory
{
    public string? Resort { get; set; }
    public decimal? ItemId { get; set; }
    public DateTime? InventoryDate { get; set; }
    public decimal? Quantity { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual GemItem GemItem { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemDailyInventory>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ItemId, e.InventoryDate })
                .HasName("GITMDAYINV_PK");

            entity.ToTable("GEM$ITEM_DAILY_INVENTORY");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InventoryDate)
                .HasColumnName("INVENTORY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GemItem)))
				entity.Ignore(e => e.GemItem);
			else
	            entity.HasOne(d => d.GemItem)
	                .WithMany(p => p.GemItemDailyInventory)
	                .HasForeignKey(d => new { d.Resort, d.ItemId })
	                .HasConstraintName("GITMDAYINV_ITM_FK");
        });
	}
}
