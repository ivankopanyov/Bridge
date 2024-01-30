namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemgroupRates
{
    public GemItemgroupRates()
    {
        GemItemgrTranslation = new HashSet<GemItemgrTranslation>();
    }

    public decimal? ItmgRateId { get; set; }
    public decimal? ItemgroupId { get; set; }
    public string? Name { get; set; }
    public string? HourlyYn { get; set; }
    public decimal? Price { get; set; }
    public string? PriceCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual GemItemgroup Itemgroup { get; set; }
    public virtual ICollection<GemItemgrTranslation> GemItemgrTranslation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemgroupRates>(entity =>
        {
            entity.HasKey(e => e.ItmgRateId)
                .HasName("ITGR_PK");

            entity.ToTable("GEM$ITEMGROUP_RATES");

            entity.HasIndex(e => e.ItemgroupId)
                .HasName("ITGR_ITG_IDX");

            entity.Property(e => e.ItmgRateId)
                .HasColumnName("ITMG_RATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HourlyYn)
                .HasColumnName("HOURLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemgroupId)
                .HasColumnName("ITEMGROUP_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GemItemgroup)))
				entity.Ignore(e => e.Itemgroup);
			else
	            entity.HasOne(d => d.Itemgroup)
	                .WithMany(p => p.GemItemgroupRates)
	                .HasForeignKey(d => d.ItemgroupId)
	                .HasConstraintName("ITGR_ITG_FK");
        
			if (!types.Contains(typeof(GemItemgrTranslation)))
				entity.Ignore(e => e.GemItemgrTranslation);
		});
	}
}
