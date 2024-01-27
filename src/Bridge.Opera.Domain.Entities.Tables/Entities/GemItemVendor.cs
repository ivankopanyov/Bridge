namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemVendor
{
    public string Resort { get; set; }
    public decimal ItemId { get; set; }
    public decimal NameId { get; set; }
    public decimal? Priority { get; set; }
    public string LeadTime { get; set; }
    public decimal? PurchasePrice { get; set; }
    public decimal? RentalPrice { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual GemItem GemItem { get; set; }
    public virtual Name Name { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemVendor>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ItemId, e.NameId })
                .HasName("ITMV_PK");

            entity.ToTable("GEM$ITEM_VENDOR");

            entity.HasIndex(e => e.NameId)
                .HasName("ITMV_NAMEID_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadTime)
                .HasColumnName("LEAD_TIME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PurchasePrice)
                .HasColumnName("PURCHASE_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RentalPrice)
                .HasColumnName("RENTAL_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany(p => p.GemItemVendor)
	                .HasForeignKey(d => d.NameId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ITMV_NAME_FK");

			if (!types.Contains(typeof(GemItem)))
				entity.Ignore(e => e.GemItem);
			else
	            entity.HasOne(d => d.GemItem)
	                .WithMany(p => p.GemItemVendor)
	                .HasForeignKey(d => new { d.Resort, d.ItemId })
	                .HasConstraintName("ITMV_ITM_FK");
        });
	}
}
