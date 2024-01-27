namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScSourceByBusblock
{
    public string BusblockProperty { get; set; }
    public decimal BusblockId { get; set; }
    public string SourceRelationship { get; set; }
    public string SourceRelationshipDesc { get; set; }
    public string SourcePrimaryYn { get; set; }
    public decimal SourceId { get; set; }
    public string SourceName { get; set; }
    public string SourceName2 { get; set; }
    public string SourceName3 { get; set; }
    public string SourceBusinessGreeting { get; set; }
    public string SourceAddress1 { get; set; }
    public string SourceAddress2 { get; set; }
    public string SourceState { get; set; }
    public string SourceCountry { get; set; }
    public string SourceCountryDesc { get; set; }
    public string SourceCity { get; set; }
    public string SourceCityExt { get; set; }
    public string SourceZipcode { get; set; }
    public string SourcePhone { get; set; }
    public string SourceFax { get; set; }
    public string SourceEmail { get; set; }
    public string XsourceName { get; set; }
    public string SourceXfirstName { get; set; }
    public string SourceXtitle { get; set; }
    public string SourceXsalutation { get; set; }
    public string SourceXdisplayName { get; set; }
    public string SourceXenvelopeGreeting { get; set; }
    public string SourceXlanguage { get; set; }
    public string SourceXlanguageDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScSourceByBusblock>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_SOURCE_BY_BUSBLOCK");

            entity.Property(e => e.BusblockId)
                .HasColumnName("BUSBLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusblockProperty)
                .IsRequired()
                .HasColumnName("BUSBLOCK_PROPERTY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceAddress1)
                .HasColumnName("SOURCE_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceAddress2)
                .HasColumnName("SOURCE_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceBusinessGreeting)
                .HasColumnName("SOURCE_BUSINESS_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.SourceCity)
                .HasColumnName("SOURCE_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceCityExt)
                .HasColumnName("SOURCE_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCountry)
                .HasColumnName("SOURCE_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCountryDesc)
                .HasColumnName("SOURCE_COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.SourceEmail)
                .HasColumnName("SOURCE_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.SourceFax)
                .HasColumnName("SOURCE_FAX")
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceName2)
                .HasColumnName("SOURCE_NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceName3)
                .HasColumnName("SOURCE_NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourcePhone)
                .HasColumnName("SOURCE_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.SourcePrimaryYn)
                .HasColumnName("SOURCE_PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SourceRelationship)
                .HasColumnName("SOURCE_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceRelationshipDesc)
                .HasColumnName("SOURCE_RELATIONSHIP_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SourceState)
                .HasColumnName("SOURCE_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceXdisplayName)
                .HasColumnName("SOURCE_XDISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.SourceXenvelopeGreeting)
                .HasColumnName("SOURCE_XENVELOPE_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SourceXfirstName)
                .HasColumnName("SOURCE_XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceXlanguage)
                .HasColumnName("SOURCE_XLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceXlanguageDesc)
                .HasColumnName("SOURCE_XLANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.SourceXsalutation)
                .HasColumnName("SOURCE_XSALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.SourceXtitle)
                .HasColumnName("SOURCE_XTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceZipcode)
                .HasColumnName("SOURCE_ZIPCODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.XsourceName)
                .HasColumnName("XSOURCE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
