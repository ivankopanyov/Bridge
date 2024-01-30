namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsResvData
{
    public OrmsResvData()
    {
        OrmsRateDist = new HashSet<OrmsRateDist>();
        OrmsResvcnclDist = new HashSet<OrmsResvcnclDist>();
    }

    public string? Resort { get; set; }
    public DateTime? TruncArrivalDate { get; set; }
    public string? Dowseason { get; set; }
    public decimal? UnconstDemandPct { get; set; }
    public string? ReoptimizeYn { get; set; }
    public decimal? MinVariance { get; set; }
    public decimal? MaxVariance { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ICollection<OrmsRateDist> OrmsRateDist { get; set; }
    public virtual ICollection<OrmsResvcnclDist> OrmsResvcnclDist { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsResvData>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TruncArrivalDate })
                .HasName("ORMS_RESV_DATA_PK");

            entity.ToTable("ORMS_RESV_DATA");

            entity.HasIndex(e => new { e.Resort, e.Dowseason, e.TruncArrivalDate })
                .HasName("ORMS_RESV_DATA_DOW");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TruncArrivalDate)
                .HasColumnName("TRUNC_ARRIVAL_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Dowseason)
                .IsRequired()
                .HasColumnName("DOWSEASON")
                .HasMaxLength(30)
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

            entity.Property(e => e.MaxVariance)
                .HasColumnName("MAX_VARIANCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MinVariance)
                .HasColumnName("MIN_VARIANCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReoptimizeYn)
                .HasColumnName("REOPTIMIZE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UnconstDemandPct)
                .HasColumnName("UNCONST_DEMAND_PCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(OrmsRateDist)))
				entity.Ignore(e => e.OrmsRateDist);

			if (!types.Contains(typeof(OrmsResvcnclDist)))
				entity.Ignore(e => e.OrmsResvcnclDist);
		});
	}
}
