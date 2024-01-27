namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpCountry
{
    public string RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public string Resort { get; set; }
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string RegionCode { get; set; }
    public string RegionDesc { get; set; }
    public string Country { get; set; }
    public string CountryDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public string ResortId { get; set; }
    public string CountryCodeKey { get; set; }
    public string RegionCodeKey { get; set; }
    public string AllKey { get; set; }
    public string CountryMainGroup { get; set; }
    public string GuestAddressFormat { get; set; }
    public string IsoCode { get; set; }
    public string IsoName { get; set; }
    public string StatisticCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpCountry>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXP_COUNTRY");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.CountryCodeKey)
                .HasColumnName("COUNTRY_CODE_KEY")
                .HasMaxLength(23)
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.CountryMainGroup)
                .HasColumnName("COUNTRY_MAIN_GROUP")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestAddressFormat)
                .HasColumnName("GUEST_ADDRESS_FORMAT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IsoCode)
                .HasColumnName("ISO_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IsoName)
                .HasColumnName("ISO_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.RegionCodeKey)
                .HasColumnName("REGION_CODE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.RegionDesc)
                .HasColumnName("REGION_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .IsRequired()
                .HasColumnName("RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(24)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.StatisticCode)
                .HasColumnName("STATISTIC_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);
        });
	}
}
