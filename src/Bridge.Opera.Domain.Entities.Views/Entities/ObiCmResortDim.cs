namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiCmResortDim
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? ChainCode { get; set; }
    public string? ChainDesc { get; set; }
    public string? RegionCode { get; set; }
    public string? RegionDesc { get; set; }
    public string? CountryCode { get; set; }
    public string? CountryDesc { get; set; }
    public string? State { get; set; }
    public string? StateDesc { get; set; }
    public string? City { get; set; }
    public string? CityDesc { get; set; }
    public string? Resort { get; set; }
    public string? ResortDesc { get; set; }
    public string? ResortLongDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiCmResortDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_CM_RESORT_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .IsUnicode(false);

            entity.Property(e => e.ChainDesc)
                .HasColumnName("CHAIN_DESC")
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .IsUnicode(false);

            entity.Property(e => e.CityDesc)
                .HasColumnName("CITY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RegionDesc)
                .HasColumnName("REGION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.ResortDesc)
                .HasColumnName("RESORT_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ResortLongDesc)
                .HasColumnName("RESORT_LONG_DESC")
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .IsUnicode(false);

            entity.Property(e => e.StateDesc)
                .HasColumnName("STATE_DESC")
                .IsUnicode(false);
        });
	}
}
