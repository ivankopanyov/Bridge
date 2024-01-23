namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsPriceSlices
{
    public OrmsPriceSlices()
    {
        OrmsPriceDetails = new HashSet<OrmsPriceDetails>();
        OrmsRateDist = new HashSet<OrmsRateDist>();
    }

    public decimal PricesliceId { get; set; }
    public string Resort { get; set; }
    public string YieldCategory { get; set; }
    public decimal SliceFrom { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual YieldCategories YieldCategories { get; set; }
    public virtual ICollection<OrmsPriceDetails> OrmsPriceDetails { get; set; }
    public virtual ICollection<OrmsRateDist> OrmsRateDist { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsPriceSlices>(entity =>
        {
            entity.HasKey(e => e.PricesliceId)
                .HasName("ORMS_PRICE_SLICES_PK");

            entity.ToTable("ORMS_PRICE_SLICES");

            entity.HasIndex(e => new { e.Resort, e.YieldCategory })
                .HasName("ORMS_PRICE_SLICES_IND1");

            entity.Property(e => e.PricesliceId)
                .HasColumnName("PRICESLICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SliceFrom)
                .HasColumnName("SLICE_FROM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YieldCategory)
                .IsRequired()
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(YieldCategories)))
				entity.Ignore(e => e.YieldCategories);
			else
	            entity.HasOne(d => d.YieldCategories)
	                .WithMany(p => p.OrmsPriceSlices)
	                .HasForeignKey(d => new { d.Resort, d.YieldCategory })
	                .HasConstraintName("ORMS_PRICE_SLICES_YIELD_C_FK1");
        
			if (!types.Contains(typeof(OrmsPriceDetails)))
				entity.Ignore(e => e.OrmsPriceDetails);

			if (!types.Contains(typeof(OrmsRateDist)))
				entity.Ignore(e => e.OrmsRateDist);
		});
	}
}
