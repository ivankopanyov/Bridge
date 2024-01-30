namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiPdCountryDimVw
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? RegionCode { get; set; }
    public string? RegionDesc { get; set; }
    public string? Country { get; set; }
    public string? CountryDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public string? ResortId { get; set; }
    public string? CountryCodeKey { get; set; }
    public string? RegionCodeKey { get; set; }
    public string? AllKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiPdCountryDimVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_PD_COUNTRY_DIM_VW");

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
                .IsUnicode(false);

            entity.Property(e => e.CountryCodeKey)
                .HasColumnName("COUNTRY_CODE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RegionCodeKey)
                .HasColumnName("REGION_CODE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.RegionDesc)
                .HasColumnName("REGION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .IsUnicode(false);
        });
	}
}
