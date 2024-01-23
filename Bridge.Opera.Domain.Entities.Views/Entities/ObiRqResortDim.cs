namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiRqResortDim
{
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string ChainCode { get; set; }
    public string ChainDesc { get; set; }
    public string RegionCode { get; set; }
    public string Region { get; set; }
    public string RegionDesc { get; set; }
    public string CountryCode { get; set; }
    public string Country { get; set; }
    public string CountryDesc { get; set; }
    public string State { get; set; }
    public string StateDesc { get; set; }
    public string City { get; set; }
    public string CityDesc { get; set; }
    public string Resort { get; set; }
    public string ResortDesc { get; set; }
    public string ResortLongDesc { get; set; }
    public string PostCode { get; set; }
    public string ResortType { get; set; }
    public string Ownership { get; set; }
    public string CurrencyCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiRqResortDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_RQ_RESORT_DIM");

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

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Ownership)
                .HasColumnName("OWNERSHIP")
                .IsUnicode(false);

            entity.Property(e => e.PostCode)
                .HasColumnName("POST_CODE")
                .IsUnicode(false);

            entity.Property(e => e.Region)
                .HasColumnName("REGION")
                .IsUnicode(false);

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RegionDesc)
                .HasColumnName("REGION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortDesc)
                .HasColumnName("RESORT_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ResortLongDesc)
                .HasColumnName("RESORT_LONG_DESC")
                .HasMaxLength(123)
                .IsUnicode(false);

            entity.Property(e => e.ResortType)
                .HasColumnName("RESORT_TYPE")
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
