namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsResortVw
{
    public string Resort { get; set; }
    public string ResortName { get; set; }
    public string LegalOwner { get; set; }
    public string Street { get; set; }
    public string PostCode { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string CountryCode { get; set; }
    public string Telephone { get; set; }
    public string Fax { get; set; }
    public string Webaddress { get; set; }
    public string Tollfree { get; set; }
    public string Email { get; set; }
    public decimal? MaxLos { get; set; }
    public decimal? ForeMaxSlices { get; set; }
    public decimal? OptMaxSlices { get; set; }
    public string ConfigStatus { get; set; }
    public string CurrencyCode { get; set; }
    public decimal? CurrencyDecimal { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsResortVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_RESORT_VW");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConfigStatus)
                .HasColumnName("CONFIG_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyDecimal)
                .HasColumnName("CURRENCY_DECIMAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Fax)
                .HasColumnName("FAX")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ForeMaxSlices)
                .HasColumnName("FORE_MAX_SLICES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LegalOwner)
                .HasColumnName("LEGAL_OWNER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MaxLos)
                .HasColumnName("MAX_LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OptMaxSlices)
                .HasColumnName("OPT_MAX_SLICES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostCode)
                .HasColumnName("POST_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortName)
                .HasColumnName("RESORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Street)
                .HasColumnName("STREET")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Telephone)
                .HasColumnName("TELEPHONE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Tollfree)
                .HasColumnName("TOLLFREE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Webaddress)
                .HasColumnName("WEBADDRESS")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
