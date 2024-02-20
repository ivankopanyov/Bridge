namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsYieldCatDaily
{
    public string? Resort { get; set; }
    public string? YieldCategory { get; set; }
    public DateTime? RecordDate { get; set; }
    public decimal? GroupTobe { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual YieldCategories YieldCategories { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsYieldCatDaily>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.YieldCategory, e.RecordDate })
                .HasName("ORMS_YIELD_CAT_DAILY_PK");

            entity.ToTable("ORMS_YIELD_CAT_DAILY");

            entity.HasIndex(e => new { e.Resort, e.RecordDate })
                .HasName("ORMS_YIELD_CAT_DAILY_IND1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordDate)
                .HasColumnName("RECORD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GroupTobe)
                .HasColumnName("GROUP_TOBE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(YieldCategories)))
				entity.Ignore(e => e.YieldCategories);
			else
	            entity.HasOne(d => d.YieldCategories)
	                .WithMany(p => p.OrmsYieldCatDaily)
	                .HasForeignKey(d => new { d.Resort, d.YieldCategory })
	                .HasConstraintName("ORMS_YIELD_CAT_DAILY_FK1");
        });
	}
}
