namespace Bridge.Opera.Domain.Entities.Tables;

public partial class YieldCategories
{
    public YieldCategories()
    {
        OrmsBookingClass = new HashSet<OrmsBookingClass>();
        OrmsPriceSlices = new HashSet<OrmsPriceSlices>();
        OrmsYieldCatDaily = new HashSet<OrmsYieldCatDaily>();
        ResortRoomCategory = new HashSet<ResortRoomCategory>();
    }

    public string Resort { get; set; }
    public string YieldCategory { get; set; }
    public string Description { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public byte? Rank { get; set; }
    public decimal? MinHurdle { get; set; }
    public decimal? MaxTransfer { get; set; }
    public string RefRoomCategory { get; set; }
    public string RefRateCode { get; set; }
    public decimal? MaxDemandTransfer { get; set; }
    public decimal? MinOccCost { get; set; }
    public decimal? YWalkCost { get; set; }
    public decimal? NyWalkCost { get; set; }
    public decimal? NumSteps { get; set; }
    public string DisplayDefault { get; set; }

    public virtual ICollection<OrmsBookingClass> OrmsBookingClass { get; set; }
    public virtual ICollection<OrmsPriceSlices> OrmsPriceSlices { get; set; }
    public virtual ICollection<OrmsYieldCatDaily> OrmsYieldCatDaily { get; set; }
    public virtual ICollection<ResortRoomCategory> ResortRoomCategory { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<YieldCategories>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.YieldCategory })
                .HasName("YIELD_CATEGORIES_PK");

            entity.ToTable("YIELD_CATEGORIES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(25)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplayDefault)
                .HasColumnName("DISPLAY_DEFAULT")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxDemandTransfer)
                .HasColumnName("MAX_DEMAND_TRANSFER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxTransfer)
                .HasColumnName("MAX_TRANSFER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MinHurdle)
                .HasColumnName("MIN_HURDLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinOccCost)
                .HasColumnName("MIN_OCC_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NumSteps)
                .HasColumnName("NUM_STEPS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NyWalkCost)
                .HasColumnName("NY_WALK_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Rank)
                .HasColumnName("RANK")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RefRateCode)
                .HasColumnName("REF_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RefRoomCategory)
                .HasColumnName("REF_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YWalkCost)
                .HasColumnName("Y_WALK_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(OrmsBookingClass)))
				entity.Ignore(e => e.OrmsBookingClass);

			if (!types.Contains(typeof(OrmsPriceSlices)))
				entity.Ignore(e => e.OrmsPriceSlices);

			if (!types.Contains(typeof(OrmsYieldCatDaily)))
				entity.Ignore(e => e.OrmsYieldCatDaily);

			if (!types.Contains(typeof(ResortRoomCategory)))
				entity.Ignore(e => e.ResortRoomCategory);
		});
	}
}
