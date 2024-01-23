namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsPriceHeader
{
    public OrmsPriceHeader()
    {
        OrmsPriceDetails = new HashSet<OrmsPriceDetails>();
    }

    public string Resort { get; set; }
    public decimal HeaderId { get; set; }
    public string YieldCategory { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Day1 { get; set; }
    public string Day2 { get; set; }
    public string Day3 { get; set; }
    public string Day4 { get; set; }
    public string Day5 { get; set; }
    public string Day6 { get; set; }
    public string Day7 { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }

    public virtual ICollection<OrmsPriceDetails> OrmsPriceDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsPriceHeader>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.HeaderId })
                .HasName("ORMS_PRICE_HEADER_PK");

            entity.ToTable("ORMS_PRICE_HEADER");

            entity.HasIndex(e => new { e.Resort, e.YieldCategory, e.BeginDate, e.EndDate, e.Day1, e.Day2, e.Day3, e.Day4, e.Day5, e.Day6, e.Day7, e.HeaderId })
                .HasName("ORMS_PRICE_HEADER_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HeaderId)
                .HasColumnName("HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Day1)
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day2)
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day3)
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day4)
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day5)
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day6)
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day7)
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YieldCategory)
                .IsRequired()
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(OrmsPriceDetails)))
				entity.Ignore(e => e.OrmsPriceDetails);
		});
	}
}
