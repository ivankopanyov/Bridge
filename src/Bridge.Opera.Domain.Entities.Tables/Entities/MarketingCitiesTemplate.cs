namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MarketingCitiesTemplate
{
    public string? RegionCode { get; set; }
    public string? MarketingCity { get; set; }
    public string? DistanceType { get; set; }
    public string? Direction { get; set; }
    public string? DrivingTime { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? Distance { get; set; }
    public string? CityDescription { get; set; }
    public string? ChainCode { get; set; }
    public decimal? DisplaySeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MarketingCitiesTemplate>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.RegionCode, e.MarketingCity })
                .HasName("MARKETING_CITIES_TEMPLATE_PK");

            entity.ToTable("MARKETING_CITIES_TEMPLATE");

            entity.HasIndex(e => e.MarketingCity)
                .HasName("MARKETING_CITIES_TEMPLATE_IDX1");

            entity.HasIndex(e => e.RegionCode)
                .HasName("MARKETING_CITIES_TEMPLATE_IDX2");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MarketingCity)
                .HasColumnName("MARKETING_CITY")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CityDescription)
                .HasColumnName("CITY_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Direction)
                .HasColumnName("DIRECTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DisplaySeq)
                .HasColumnName("DISPLAY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Distance)
                .HasColumnName("DISTANCE")
                .HasColumnType("NUMBER(10,2)");

            entity.Property(e => e.DistanceType)
                .HasColumnName("DISTANCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DrivingTime)
                .HasColumnName("DRIVING_TIME")
                .HasColumnType("CHAR(100)");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
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
        });
	}
}
