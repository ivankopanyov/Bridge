namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortRateProductPrices
{
    public decimal ResortRateProductDtlId { get; set; }
    public string Resort { get; set; }
    public string Product { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string RateCode { get; set; }
    public decimal Price { get; set; }
    public string SeasonCode { get; set; }
    public decimal? AllowanceAmount { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal? PointsRequired { get; set; }
    public decimal? Bucket2Price { get; set; }
    public decimal? Bucket2AllowanceAmount { get; set; }
    public decimal? Bucket3Price { get; set; }
    public decimal? Bucket3AllowanceAmount { get; set; }
    public decimal? MinNights { get; set; }
    public decimal? MaxNights { get; set; }
    public decimal? MinPersons { get; set; }
    public decimal? MaxPersons { get; set; }
    public string Day1 { get; set; }
    public string Day2 { get; set; }
    public string Day3 { get; set; }
    public string Day4 { get; set; }
    public string Day5 { get; set; }
    public string Day6 { get; set; }
    public string Day7 { get; set; }

    public virtual RateSeason RateSeason { get; set; }
    public virtual ResortProducts ResortProducts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortRateProductPrices>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESORT_RATE_PRODUCT_PRICES");

            entity.HasIndex(e => new { e.Resort, e.SeasonCode })
                .HasName("RRPD_RATE_SEASON_FK_I");

            entity.HasIndex(e => new { e.Resort, e.Product, e.BeginDate, e.EndDate, e.RateCode })
                .HasName("RRPD_INDEX");

            entity.HasIndex(e => new { e.Resort, e.RateCode, e.Product, e.BeginDate, e.EndDate, e.MinNights, e.MaxNights, e.MinPersons, e.MaxPersons, e.Day1, e.Day2, e.Day3, e.Day4, e.Day5, e.Day6, e.Day7 })
                .HasName("RRPD_UK1")
                .IsUnique();

            entity.Property(e => e.AllowanceAmount)
                .HasColumnName("ALLOWANCE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Bucket2AllowanceAmount)
                .HasColumnName("BUCKET2_ALLOWANCE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Bucket2Price)
                .HasColumnName("BUCKET2_PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Bucket3AllowanceAmount)
                .HasColumnName("BUCKET3_ALLOWANCE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Bucket3Price)
                .HasColumnName("BUCKET3_PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day1)
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day2)
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day3)
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day4)
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day5)
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day6)
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day7)
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxNights)
                .HasColumnName("MAX_NIGHTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxPersons)
                .HasColumnName("MAX_PERSONS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MinNights)
                .HasColumnName("MIN_NIGHTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MinPersons)
                .HasColumnName("MIN_PERSONS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PointsRequired)
                .HasColumnName("POINTS_REQUIRED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Product)
                .IsRequired()
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResortRateProductDtlId)
                .HasColumnName("RESORT_RATE_PRODUCT_DTL_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SeasonCode)
                .HasColumnName("SEASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ResortProducts)))
				entity.Ignore(e => e.ResortProducts);
			else
	            entity.HasOne(d => d.ResortProducts)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.Product })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RRPD_PRODUCT_FK");

			if (!types.Contains(typeof(RateSeason)))
				entity.Ignore(e => e.RateSeason);
			else
	            entity.HasOne(d => d.RateSeason)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.SeasonCode })
	                .HasConstraintName("RRPD_RATE_SEASON_FK");
        });
	}
}
