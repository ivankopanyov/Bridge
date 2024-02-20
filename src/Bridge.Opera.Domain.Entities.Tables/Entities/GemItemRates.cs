namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemRates
{
    public GemItemRates()
    {
        EventItem = new HashSet<EventItem>();
        GemItemrTranslation = new HashSet<GemItemrTranslation>();
    }

    public decimal? ItemrateId { get; set; }
    public string? Resort { get; set; }
    public decimal? ItemId { get; set; }
    public string? Name { get; set; }
    public string? HourlyYn { get; set; }
    public decimal? Price { get; set; }
    public string? PriceCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? DefaultYn { get; set; }
    public DateTime? InactiveDate { get; set; }

    public virtual GemItem GemItem { get; set; }
    public virtual ICollection<EventItem> EventItem { get; set; }
    public virtual ICollection<GemItemrTranslation> GemItemrTranslation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemRates>(entity =>
        {
            entity.HasKey(e => e.ItemrateId)
                .HasName("ITMR_PK");

            entity.ToTable("GEM$ITEM_RATES");

            entity.HasIndex(e => new { e.Resort, e.ItemId })
                .HasName("ITEMR_ITM_IDX");

            entity.Property(e => e.ItemrateId)
                .HasColumnName("ITEMRATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HourlyYn)
                .HasColumnName("HOURLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriceCode)
                .HasColumnName("PRICE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

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
	                .WithMany(p => p.GemItemRates)
	                .HasForeignKey(d => new { d.Resort, d.ItemId })
	                .HasConstraintName("ITMR_ITM_FK");
        
			if (!types.Contains(typeof(EventItem)))
				entity.Ignore(e => e.EventItem);

			if (!types.Contains(typeof(GemItemrTranslation)))
				entity.Ignore(e => e.GemItemrTranslation);
		});
	}
}
