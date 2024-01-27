namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AgencyTemp
{
    public string Iata { get; set; }
    public string Address { get; set; }
    public string Address2 { get; set; }
    public string Address3 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string StateCode { get; set; }
    public string Country { get; set; }
    public string ZipCode { get; set; }
    public string MailingAddress { get; set; }
    public string MailingCity { get; set; }
    public string MailingState { get; set; }
    public string MailingStateCode { get; set; }
    public string MailingCountry { get; set; }
    public string MailingZipcode { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public string Telex { get; set; }
    public string TrxCode { get; set; }
    public string OldIata { get; set; }
    public string LastChange { get; set; }
    public string PhonePrefix1 { get; set; }
    public string PhonePrefix2 { get; set; }
    public string FaxPrefix1 { get; set; }
    public string FaxPrefix2 { get; set; }
    public string MailingAddress2 { get; set; }
    public string TapeType { get; set; }
    public string IataCheck { get; set; }
    public string Legal1 { get; set; }
    public string Legal2 { get; set; }
    public string Legal3 { get; set; }
    public string Dba1 { get; set; }
    public string Dba2 { get; set; }
    public string Email { get; set; }
    public string MailYn { get; set; }
    public string Udfc01 { get; set; }
    public string Udfc02 { get; set; }
    public DateTime? Udfd01 { get; set; }
    public DateTime? Udfd02 { get; set; }
    public decimal? Udfn01 { get; set; }
    public decimal? Udfn02 { get; set; }
    public string TypeOf1099 { get; set; }
    public string Tax1No { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AgencyTemp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("AGENCY_TEMP");

            entity.Property(e => e.Address)
                .HasColumnName("ADDRESS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address3)
                .HasColumnName("ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Dba1)
                .HasColumnName("DBA1")
                .HasMaxLength(96)
                .IsUnicode(false);

            entity.Property(e => e.Dba2)
                .HasColumnName("DBA2")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Fax)
                .HasColumnName("FAX")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FaxPrefix1)
                .HasColumnName("FAX_PREFIX1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FaxPrefix2)
                .HasColumnName("FAX_PREFIX2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Iata)
                .HasColumnName("IATA")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IataCheck)
                .HasColumnName("IATA_CHECK")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LastChange)
                .HasColumnName("LAST_CHANGE")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Legal1)
                .HasColumnName("LEGAL1")
                .HasMaxLength(96)
                .IsUnicode(false);

            entity.Property(e => e.Legal2)
                .HasColumnName("LEGAL2")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.Legal3)
                .HasColumnName("LEGAL3")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.MailYn)
                .HasColumnName("MAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MailingAddress)
                .HasColumnName("MAILING_ADDRESS")
                .HasMaxLength(96)
                .IsUnicode(false);

            entity.Property(e => e.MailingAddress2)
                .HasColumnName("MAILING_ADDRESS2")
                .HasMaxLength(96)
                .IsUnicode(false);

            entity.Property(e => e.MailingCity)
                .HasColumnName("MAILING_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MailingCountry)
                .HasColumnName("MAILING_COUNTRY")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.MailingState)
                .HasColumnName("MAILING_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MailingStateCode)
                .HasColumnName("MAILING_STATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MailingZipcode)
                .HasColumnName("MAILING_ZIPCODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.OldIata)
                .HasColumnName("OLD_IATA")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.Phone)
                .HasColumnName("PHONE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PhonePrefix1)
                .HasColumnName("PHONE_PREFIX1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PhonePrefix2)
                .HasColumnName("PHONE_PREFIX2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.StateCode)
                .HasColumnName("STATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TapeType)
                .HasColumnName("TAPE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax1No)
                .HasColumnName("TAX1_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Telex)
                .HasColumnName("TELEX")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TypeOf1099)
                .HasColumnName("TYPE_OF_1099")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfd01)
                .HasColumnName("UDFD01")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd02)
                .HasColumnName("UDFD02")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfn01)
                .HasColumnName("UDFN01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn02)
                .HasColumnName("UDFN02")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
