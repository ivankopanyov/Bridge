namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsPriceDetails
{
    public OrmsPriceDetails()
    {
        OrmsPriceRoomDelta = new HashSet<OrmsPriceRoomDelta>();
    }

    public string Resort { get; set; }
    public decimal HeaderId { get; set; }
    public decimal PricesliceId { get; set; }
    public decimal PriceFrom { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual OrmsPriceHeader OrmsPriceHeader { get; set; }
    public virtual OrmsPriceSlices Priceslice { get; set; }
    public virtual ICollection<OrmsPriceRoomDelta> OrmsPriceRoomDelta { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsPriceDetails>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.HeaderId, e.PricesliceId })
                .HasName("ORMS_PRICE_DETAILS_PK");

            entity.ToTable("ORMS_PRICE_DETAILS");

            entity.HasIndex(e => e.PricesliceId)
                .HasName("ORMS_PRICE_DETAILS_PS_FK_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HeaderId)
                .HasColumnName("HEADER_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.PriceFrom)
                .HasColumnName("PRICE_FROM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(OrmsPriceSlices)))
				entity.Ignore(e => e.Priceslice);
			else
	            entity.HasOne(d => d.Priceslice)
	                .WithMany(p => p.OrmsPriceDetails)
	                .HasForeignKey(d => d.PricesliceId)
	                .HasConstraintName("ORMS_PRICE_DETAILS_PS_FK");

			if (!types.Contains(typeof(OrmsPriceHeader)))
				entity.Ignore(e => e.OrmsPriceHeader);
			else
	            entity.HasOne(d => d.OrmsPriceHeader)
	                .WithMany(p => p.OrmsPriceDetails)
	                .HasForeignKey(d => new { d.Resort, d.HeaderId })
	                .HasConstraintName("ORMS_PRICE_DETAILS_PH_FK");
        
			if (!types.Contains(typeof(OrmsPriceRoomDelta)))
				entity.Ignore(e => e.OrmsPriceRoomDelta);
		});
	}
}
