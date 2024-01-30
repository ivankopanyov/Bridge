namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GdsAlternateResortView
{
    public string? ChainCode { get; set; }
    public string? ResortName { get; set; }
    public string? ResortId { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? CityCode { get; set; }
    public string? Country { get; set; }
    public string? State { get; set; }
    public decimal? Distance { get; set; }
    public string? DistType { get; set; }
    public string? Direction { get; set; }
    public string? AlternateResort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsAlternateResortView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GDS_ALTERNATE_RESORT_VIEW");

            entity.Property(e => e.Address)
                .HasColumnName("ADDRESS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AlternateResort)
                .HasColumnName("ALTERNATE_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CityCode)
                .HasColumnName("CITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Direction)
                .HasColumnName("DIRECTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DistType)
                .HasColumnName("DIST_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Distance)
                .HasColumnName("DISTANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortName)
                .HasColumnName("RESORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
