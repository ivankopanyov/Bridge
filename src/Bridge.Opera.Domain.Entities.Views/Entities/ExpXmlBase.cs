namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpXmlBase
{
    public string? Resort { get; set; }
    public string? ResortName { get; set; }
    public string? ResortOwner { get; set; }
    public string? ResortCountryCode { get; set; }
    public string? ResortStreet { get; set; }
    public string? ResortPostCode { get; set; }
    public string? ResortCity { get; set; }
    public string? ResortState { get; set; }
    public string? ResortTelephone { get; set; }
    public string? ResortFax { get; set; }
    public string? ResortWebaddress { get; set; }
    public string? ResortTollfree { get; set; }
    public string? ResortEmail { get; set; }
    public string? ResortRegion { get; set; }
    public string? ResortType { get; set; }
    public string? ResortHotelType { get; set; }
    public string? HotelCode { get; set; }
    public string? ResortCurrencyCode { get; set; }
    public decimal? ResortCurrencyDecimals { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpXmlBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_XML_BASE");

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortCity)
                .HasColumnName("RESORT_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ResortCountryCode)
                .HasColumnName("RESORT_COUNTRY_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.ResortCurrencyCode)
                .HasColumnName("RESORT_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortCurrencyDecimals)
                .HasColumnName("RESORT_CURRENCY_DECIMALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResortEmail)
                .HasColumnName("RESORT_EMAIL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResortFax)
                .HasColumnName("RESORT_FAX")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ResortHotelType)
                .HasColumnName("RESORT_HOTEL_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortName)
                .HasColumnName("RESORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ResortOwner)
                .HasColumnName("RESORT_OWNER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ResortPostCode)
                .HasColumnName("RESORT_POST_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortRegion)
                .HasColumnName("RESORT_REGION")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.ResortState)
                .HasColumnName("RESORT_STATE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.ResortStreet)
                .HasColumnName("RESORT_STREET")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResortTelephone)
                .HasColumnName("RESORT_TELEPHONE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ResortTollfree)
                .HasColumnName("RESORT_TOLLFREE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ResortType)
                .HasColumnName("RESORT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortWebaddress)
                .HasColumnName("RESORT_WEBADDRESS")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
