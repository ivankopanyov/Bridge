namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemgroupDetails
{
    public decimal? ItemgroupId { get; set; }
    public string? Resort { get; set; }
    public decimal? ItemId { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? ItmaId { get; set; }
    public decimal? ItemrateId { get; set; }

    public virtual GemItem GemItem { get; set; }
    public virtual GemItemgroup Itemgroup { get; set; }
    public virtual GemItemRates Itemrate { get; set; }
    public virtual GemItemAttributes Itma { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemgroupDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GEM$ITEMGROUP_DETAILS");

            entity.HasIndex(e => e.ItemrateId)
                .HasName("ITGD_ITMR_IDX");

            entity.HasIndex(e => e.ItmaId)
                .HasName("ITGD_ITMA_IDX");

            entity.HasIndex(e => new { e.Resort, e.ItemId })
                .HasName("ITGD_ITM_IDX");

            entity.HasIndex(e => new { e.ItemgroupId, e.Resort, e.ItemId })
                .HasName("ITGD_UK")
                .IsUnique();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

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

			if (!types.Contains(typeof(GemItemgroup)))
				entity.Ignore(e => e.Itemgroup);
			else
	            entity.HasOne(d => d.Itemgroup)
	                .WithMany()
	                .HasForeignKey(d => d.ItemgroupId)
	                .HasConstraintName("ITGD_ITG_FK");

			if (!types.Contains(typeof(GemItemRates)))
				entity.Ignore(e => e.Itemrate);
			else
	            entity.HasOne(d => d.Itemrate)
	                .WithMany()
	                .HasForeignKey(d => d.ItemrateId)
	                .HasConstraintName("ITGD_ITMR_FK");

			if (!types.Contains(typeof(GemItemAttributes)))
				entity.Ignore(e => e.Itma);
			else
	            entity.HasOne(d => d.Itma)
	                .WithMany()
	                .HasForeignKey(d => d.ItmaId)
	                .HasConstraintName("ITGD_ITMA_FK");

			if (!types.Contains(typeof(GemItem)))
				entity.Ignore(e => e.GemItem);
			else
	            entity.HasOne(d => d.GemItem)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.ItemId })
	                .HasConstraintName("ITGD_ITM_FK");
        });
	}
}
