namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScSecContactByBusblock
{
    public string? BusblockProperty { get; set; }
    public decimal? BusblockId { get; set; }
    public string? SecConRelationship { get; set; }
    public string? SecConRelationshipDesc { get; set; }
    public decimal? SecConId { get; set; }
    public string? SecConLastName { get; set; }
    public string? SecConFirstName { get; set; }
    public string? SecConMiddleName { get; set; }
    public string? SecConFullName { get; set; }
    public string? SecConAddress1 { get; set; }
    public string? SecConAddress2 { get; set; }
    public string? SecConAddress3 { get; set; }
    public string? SecConAddress4 { get; set; }
    public string? SecConState { get; set; }
    public string? SecConCountry { get; set; }
    public string? SecConCity { get; set; }
    public string? SecConCityExt { get; set; }
    public string? SecConZipCode { get; set; }
    public string? SecConFax { get; set; }
    public string? SecConPhone { get; set; }
    public string? SecConEmail { get; set; }
    public string? SecConBusinessGreeting { get; set; }
    public string? SecConLetterGreeting { get; set; }
    public string? SecConPosition { get; set; }
    public string? SecConDepartment { get; set; }
    public string? SecConXfirstName { get; set; }
    public string? SecConXlastName { get; set; }
    public string? SecConXfullName { get; set; }
    public string? SecConXtitle { get; set; }
    public string? SecConXsalutation { get; set; }
    public string? SecConXenvelopeGreeting { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScSecContactByBusblock>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_SEC_CONTACT_BY_BUSBLOCK");

            entity.Property(e => e.BusblockId)
                .HasColumnName("BUSBLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusblockProperty)
                .IsRequired()
                .HasColumnName("BUSBLOCK_PROPERTY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SecConAddress1)
                .HasColumnName("SEC_CON_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecConAddress2)
                .HasColumnName("SEC_CON_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecConAddress3)
                .HasColumnName("SEC_CON_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecConAddress4)
                .HasColumnName("SEC_CON_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecConBusinessGreeting)
                .HasColumnName("SEC_CON_BUSINESS_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SecConCity)
                .HasColumnName("SEC_CON_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SecConCityExt)
                .HasColumnName("SEC_CON_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SecConCountry)
                .HasColumnName("SEC_CON_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SecConDepartment)
                .HasColumnName("SEC_CON_DEPARTMENT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SecConEmail)
                .HasColumnName("SEC_CON_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.SecConFax)
                .HasColumnName("SEC_CON_FAX")
                .IsUnicode(false);

            entity.Property(e => e.SecConFirstName)
                .HasColumnName("SEC_CON_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SecConFullName)
                .HasColumnName("SEC_CON_FULL_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecConId)
                .HasColumnName("SEC_CON_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SecConLastName)
                .HasColumnName("SEC_CON_LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecConLetterGreeting)
                .HasColumnName("SEC_CON_LETTER_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.SecConMiddleName)
                .HasColumnName("SEC_CON_MIDDLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SecConPhone)
                .HasColumnName("SEC_CON_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.SecConPosition)
                .HasColumnName("SEC_CON_POSITION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecConRelationship)
                .HasColumnName("SEC_CON_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SecConRelationshipDesc)
                .HasColumnName("SEC_CON_RELATIONSHIP_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SecConState)
                .HasColumnName("SEC_CON_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SecConXenvelopeGreeting)
                .HasColumnName("SEC_CON_XENVELOPE_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SecConXfirstName)
                .HasColumnName("SEC_CON_XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SecConXfullName)
                .HasColumnName("SEC_CON_XFULL_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.SecConXlastName)
                .HasColumnName("SEC_CON_XLAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SecConXsalutation)
                .HasColumnName("SEC_CON_XSALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.SecConXtitle)
                .HasColumnName("SEC_CON_XTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SecConZipCode)
                .HasColumnName("SEC_CON_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
