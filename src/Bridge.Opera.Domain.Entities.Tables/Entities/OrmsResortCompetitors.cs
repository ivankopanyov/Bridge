namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsResortCompetitors
{
    public OrmsResortCompetitors()
    {
        OrmsCompetitorTravelsites = new HashSet<OrmsCompetitorTravelsites>();
        OrmsCompetitorWeights = new HashSet<OrmsCompetitorWeights>();
    }

    public string? Resort { get; set; }
    public string? ShopperCode { get; set; }
    public string? CompetitorResort { get; set; }
    public string? CompetitorResortName { get; set; }
    public string? RstResort { get; set; }
    public decimal? OrderSeq { get; set; }
    public string? OperaResort { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ICollection<OrmsCompetitorTravelsites> OrmsCompetitorTravelsites { get; set; }
    public virtual ICollection<OrmsCompetitorWeights> OrmsCompetitorWeights { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsResortCompetitors>(entity =>
        {
            entity.HasKey(e => new { e.CompetitorResort, e.ShopperCode, e.Resort })
                .HasName("ORMS_RES_COMPETITOR_PK");

            entity.ToTable("ORMS_RESORT_COMPETITORS");

            entity.Property(e => e.CompetitorResort)
                .HasColumnName("COMPETITOR_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShopperCode)
                .HasColumnName("SHOPPER_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompetitorResortName)
                .IsRequired()
                .HasColumnName("COMPETITOR_RESORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OperaResort)
                .HasColumnName("OPERA_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderSeq)
                .HasColumnName("ORDER_SEQ")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.RstResort)
                .HasColumnName("RST_RESORT")
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

			if (!types.Contains(typeof(OrmsCompetitorWeights)))
				entity.Ignore(e => e.OrmsCompetitorWeights);
		});
	}
}
