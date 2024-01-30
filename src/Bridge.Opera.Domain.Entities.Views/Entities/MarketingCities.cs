namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MarketingCities
{
    public string? RegionRegionCode { get; set; }
    public string? City { get; set; }
    public decimal? Distance { get; set; }
    public string? Type { get; set; }
    public string? Direction { get; set; }
    public string? DrivingTime { get; set; }
    public decimal? DisplaySeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MarketingCities>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MARKETING_CITIES");

            entity.Property(e => e.City)
                .IsRequired()
                .HasColumnName("CITY")
                .HasMaxLength(40)
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

            entity.Property(e => e.DrivingTime)
                .HasColumnName("DRIVING_TIME")
                .HasColumnType("CHAR(100)");

            entity.Property(e => e.RegionRegionCode)
                .IsRequired()
                .HasColumnName("REGION_REGION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
