namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScPkgItem
{
    public decimal? PkgEvLink { get; set; }
    public string? Resort { get; set; }
    public decimal? ItemId { get; set; }
    public string? Name { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? ItmaId { get; set; }
    public decimal? ItemrateId { get; set; }
    public decimal? Price { get; set; }

    public virtual ScPkgEvent PkgEvLinkNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScPkgItem>(entity =>
        {
            entity.HasKey(e => new { e.PkgEvLink, e.Resort, e.ItemId })
                .HasName("PKGITM_PK");

            entity.ToTable("SC$PKG_ITEM");

            entity.Property(e => e.PkgEvLink)
                .HasColumnName("PKG_EV_LINK")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
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

			if (!types.Contains(typeof(ScPkgEvent)))
				entity.Ignore(e => e.PkgEvLinkNavigation);
			else
	            entity.HasOne(d => d.PkgEvLinkNavigation)
	                .WithMany(p => p.ScPkgItem)
	                .HasForeignKey(d => d.PkgEvLink)
	                .HasConstraintName("PKGITM_PKGEV_FK");
        });
	}
}
