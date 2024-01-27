namespace Bridge.Opera.Domain.Entities.Tables;

public partial class HurdleRates
{
    public string Resort { get; set; }
    public DateTime HurdleDate { get; set; }
    public string RoomCategory { get; set; }
    public string YieldCategory { get; set; }
    public decimal Los { get; set; }
    public string RoomCategoryLabel { get; set; }
    public decimal? Delta { get; set; }
    public decimal? Hurdle { get; set; }
    public string Override { get; set; }
    public decimal? Upsolds { get; set; }
    public decimal? Ceiling { get; set; }
    public decimal? Maxsolds { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string YmCode { get; set; }
    public decimal? OrmsPriceRoomDelta { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HurdleRates>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("HURDLE_RATES");

            entity.HasIndex(e => new { e.Resort, e.RoomCategory, e.Override, e.HurdleDate })
                .HasName("HURDLE_RATES_OVERRIDE_IDX");

            entity.HasIndex(e => new { e.Resort, e.HurdleDate, e.RoomCategory, e.YieldCategory, e.Los, e.YmCode })
                .HasName("HURDLE_RATES_UK")
                .IsUnique();

            entity.Property(e => e.Ceiling)
                .HasColumnName("CEILING")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Delta)
                .HasColumnName("DELTA")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Hurdle)
                .HasColumnName("HURDLE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HurdleDate)
                .HasColumnName("HURDLE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los)
                .HasColumnName("LOS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Maxsolds)
                .HasColumnName("MAXSOLDS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrmsPriceRoomDelta)
                .HasColumnName("ORMS_PRICE_ROOM_DELTA")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Override)
                .HasColumnName("OVERRIDE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Upsolds)
                .HasColumnName("UPSOLDS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YieldCategory)
                .IsRequired()
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YmCode)
                .HasColumnName("YM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
