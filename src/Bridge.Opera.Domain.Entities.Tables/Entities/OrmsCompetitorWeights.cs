namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsCompetitorWeights
{
    public string Resort { get; set; }
    public string ShopperCode { get; set; }
    public string CompetitorResort { get; set; }
    public string WeightCode { get; set; }
    public string WeightDesc { get; set; }
    public string SeasonCode { get; set; }
    public string Day1 { get; set; }
    public string Day2 { get; set; }
    public string Day3 { get; set; }
    public string Day4 { get; set; }
    public string Day5 { get; set; }
    public string Day6 { get; set; }
    public string Day7 { get; set; }
    public decimal Weights { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual OrmsResortCompetitors OrmsResortCompetitors { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsCompetitorWeights>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ShopperCode, e.CompetitorResort, e.WeightCode })
                .HasName("ORMS_COMP_WEIGHTS_PK");

            entity.ToTable("ORMS_COMPETITOR_WEIGHTS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShopperCode)
                .HasColumnName("SHOPPER_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompetitorResort)
                .HasColumnName("COMPETITOR_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WeightCode)
                .HasColumnName("WEIGHT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Day1)
                .IsRequired()
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day2)
                .IsRequired()
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day3)
                .IsRequired()
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day4)
                .IsRequired()
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day5)
                .IsRequired()
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day6)
                .IsRequired()
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Day7)
                .IsRequired()
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SeasonCode)
                .IsRequired()
                .HasColumnName("SEASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WeightDesc)
                .IsRequired()
                .HasColumnName("WEIGHT_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Weights)
                .HasColumnName("WEIGHTS")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(OrmsResortCompetitors)))
				entity.Ignore(e => e.OrmsResortCompetitors);
			else
	            entity.HasOne(d => d.OrmsResortCompetitors)
	                .WithMany(p => p.OrmsCompetitorWeights)
	                .HasForeignKey(d => new { d.CompetitorResort, d.ShopperCode, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ORMS_RESCOMPWEIGHTS_FK");
        });
	}
}
