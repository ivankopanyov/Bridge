namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResortMarketingCities1
{
    public string? Resort { get; set; }
    public string? MarketingCity { get; set; }
    public string? RegionCode { get; set; }
    public decimal? Distance { get; set; }
    public string? DistanceType { get; set; }
    public string? Direction { get; set; }
    public string? DrivingTime { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? DisplaySeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortMarketingCities1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESORT_MARKETING_CITIES");

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

            entity.Property(e => e.MarketingCity)
                .IsRequired()
                .HasColumnName("MARKETING_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RegionCode)
                .IsRequired()
                .HasColumnName("REGION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
