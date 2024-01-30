namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsCompetitorRatecodes
{
    public string? Resort { get; set; }
    public string? ShopperCode { get; set; }
    public string? CompetitorResort { get; set; }
    public string? TravelsiteCode { get; set; }
    public string? TravelsiteRateCode { get; set; }
    public string? TravelsiteRateDesc { get; set; }
    public string? OperaRateCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual OrmsCompetitorTravelsites OrmsCompetitorTravelsites { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsCompetitorRatecodes>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ShopperCode, e.CompetitorResort, e.TravelsiteCode, e.TravelsiteRateCode })
                .HasName("ORMS_COMP_TRVLRATES_PK");

            entity.ToTable("ORMS_COMPETITOR_RATECODES");

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

            entity.Property(e => e.TravelsiteCode)
                .HasColumnName("TRAVELSITE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TravelsiteRateCode)
                .HasColumnName("TRAVELSITE_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OperaRateCode)
                .HasColumnName("OPERA_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TravelsiteRateDesc)
                .IsRequired()
                .HasColumnName("TRAVELSITE_RATE_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(OrmsCompetitorTravelsites)))
				entity.Ignore(e => e.OrmsCompetitorTravelsites);
			else
	            entity.HasOne(d => d.OrmsCompetitorTravelsites)
	                .WithMany(p => p.OrmsCompetitorRatecodes)
	                .HasForeignKey(d => new { d.Resort, d.ShopperCode, d.CompetitorResort, d.TravelsiteCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ORMS_COMP_TRVRATES_PK");
        });
	}
}
