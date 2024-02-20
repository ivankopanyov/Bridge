namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemPool
{
    public GemItemPool()
    {
        GemItem = new HashSet<GemItem>();
    }

    public decimal? ItemPoolId { get; set; }
    public string? ItemPoolCode { get; set; }
    public string? Resort { get; set; }
    public string? Description { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertTs { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateTs { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ICollection<GemItem> GemItem { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemPool>(entity =>
        {
            entity.HasKey(e => e.ItemPoolId)
                .HasName("ITMPOOL_PK");

            entity.ToTable("GEM$ITEM_POOL");

            entity.HasIndex(e => new { e.Resort, e.ItemPoolCode })
                .HasName("ITMPOOL_UK")
                .IsUnique();

            entity.Property(e => e.ItemPoolId)
                .HasColumnName("ITEM_POOL_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertTs)
                .HasColumnName("INSERT_TS")
                .HasColumnType("TIMESTAMP(6)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemPoolCode)
                .IsRequired()
                .HasColumnName("ITEM_POOL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateTs)
                .HasColumnName("UPDATE_TS")
                .HasColumnType("TIMESTAMP(6)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(GemItem)))
				entity.Ignore(e => e.GemItem);
		});
	}
}
