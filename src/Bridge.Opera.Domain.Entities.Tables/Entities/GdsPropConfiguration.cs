namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsPropConfiguration
{
    public string? Resort { get; set; }
    public string? UnitType { get; set; }
    public decimal? YearBuilt { get; set; }
    public string? TaxId { get; set; }
    public string? Hotelshortname { get; set; }
    public string? Brandcode { get; set; }
    public string? Hotelsegment { get; set; }
    public string? Hotellanguages { get; set; }
    public string? CountryAccessCode { get; set; }
    public string? Hotelcategory { get; set; }
    public string? Hotelstatus { get; set; }
    public string? Hotelstatuscode { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? YearRenovated { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? TimezoneOffset { get; set; }
    public string? AmenityType { get; set; }
    public string? InitialUploadYn { get; set; }
    public string? AreaCode { get; set; }
    public string? PhoneNumber { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsPropConfiguration>(entity =>
        {
            entity.HasKey(e => e.Resort)
                .HasName("GDS_PROP_CONFIGURATION_PK");

            entity.ToTable("GDS_PROP_CONFIGURATION");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AmenityType)
                .HasColumnName("AMENITY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AreaCode)
                .HasColumnName("AREA_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Brandcode)
                .HasColumnName("BRANDCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryAccessCode)
                .HasColumnName("COUNTRY_ACCESS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Hotelcategory)
                .HasColumnName("HOTELCATEGORY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Hotellanguages)
                .HasColumnName("HOTELLANGUAGES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Hotelsegment)
                .HasColumnName("HOTELSEGMENT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Hotelshortname)
                .HasColumnName("HOTELSHORTNAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Hotelstatus)
                .HasColumnName("HOTELSTATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Hotelstatuscode)
                .HasColumnName("HOTELSTATUSCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InitialUploadYn)
                .HasColumnName("INITIAL_UPLOAD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneNumber)
                .HasColumnName("PHONE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaxId)
                .HasColumnName("TAX_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TimezoneOffset)
                .HasColumnName("TIMEZONE_OFFSET")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UnitType)
                .HasColumnName("UNIT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearBuilt)
                .HasColumnName("YEAR_BUILT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearRenovated)
                .HasColumnName("YEAR_RENOVATED")
                .HasColumnType("NUMBER");
        });
	}
}
