namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AgentContactByBooking
{
    public string? Resort { get; set; }
    public decimal? BookingId { get; set; }
    public decimal? ContactId { get; set; }
    public string? ContactFullName { get; set; }
    public string? ContactName { get; set; }
    public string? ContactFirstName { get; set; }
    public string? ContactMiddleName { get; set; }
    public string? ContactBusinessGreeting { get; set; }
    public string? ContactAddress1 { get; set; }
    public string? ContactAddress2 { get; set; }
    public string? ContactAddress3 { get; set; }
    public string? ContactAddress4 { get; set; }
    public string? ContactState { get; set; }
    public string? ConCountry { get; set; }
    public string? ConCity { get; set; }
    public string? ConCityExt { get; set; }
    public string? ContactZipCode { get; set; }
    public string? XcontactFullName { get; set; }
    public string? ContactFaxNo { get; set; }
    public string? ContactPhoneNo { get; set; }
    public string? ContactEmailId { get; set; }
    public string? ConRelationship { get; set; }
    public string? ConRelationDescription { get; set; }
    public string? EnvelopeGreeting { get; set; }
    public string? LetterGreeting { get; set; }
    public string? Position { get; set; }
    public string? Department { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AgentContactByBooking>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AGENT_CONTACT_BY_BOOKING");

            entity.Property(e => e.BookingId)
                .HasColumnName("BOOKING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConCity)
                .HasColumnName("CON_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConCityExt)
                .HasColumnName("CON_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConCountry)
                .HasColumnName("CON_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConRelationDescription)
                .HasColumnName("CON_RELATION_DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ConRelationship)
                .HasColumnName("CON_RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContactAddress1)
                .HasColumnName("CONTACT_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactAddress2)
                .HasColumnName("CONTACT_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactAddress3)
                .HasColumnName("CONTACT_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactAddress4)
                .HasColumnName("CONTACT_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactBusinessGreeting)
                .HasColumnName("CONTACT_BUSINESS_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactEmailId)
                .HasColumnName("CONTACT_EMAIL_ID")
                .IsUnicode(false);

            entity.Property(e => e.ContactFaxNo)
                .HasColumnName("CONTACT_FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.ContactFirstName)
                .HasColumnName("CONTACT_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactFullName)
                .HasColumnName("CONTACT_FULL_NAME")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.ContactId)
                .HasColumnName("CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContactMiddleName)
                .HasColumnName("CONTACT_MIDDLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactName)
                .HasColumnName("CONTACT_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactPhoneNo)
                .HasColumnName("CONTACT_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.ContactState)
                .HasColumnName("CONTACT_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactZipCode)
                .HasColumnName("CONTACT_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.Department)
                .HasColumnName("DEPARTMENT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EnvelopeGreeting)
                .HasColumnName("ENVELOPE_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LetterGreeting)
                .HasColumnName("LETTER_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Position)
                .HasColumnName("POSITION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XcontactFullName)
                .HasColumnName("XCONTACT_FULL_NAME")
                .HasMaxLength(81)
                .IsUnicode(false);
        });
	}
}
