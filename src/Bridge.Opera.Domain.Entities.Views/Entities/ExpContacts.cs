namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpContacts
{
    public string RecordType { get; set; }
    public string SourceSystem { get; set; }
    public string PropertyCode { get; set; }
    public string TransactionType { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal ContactId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Middle { get; set; }
    public string Title { get; set; }
    public string ConAddress1 { get; set; }
    public string ConAddress2 { get; set; }
    public string ConAddress3 { get; set; }
    public string ConAddress4 { get; set; }
    public string ConCity { get; set; }
    public string ConState { get; set; }
    public string ConZipCode { get; set; }
    public string ConRegion { get; set; }
    public string ConCountry { get; set; }
    public string ConPhoneNo { get; set; }
    public string ConPhoneExt { get; set; }
    public string Position { get; set; }
    public string ActiveYn { get; set; }
    public string EmailYn { get; set; }
    public string MailList { get; set; }
    public string Markets { get; set; }
    public string Language { get; set; }
    public string Udfc07 { get; set; }
    public string PrPreferencesSmoking { get; set; }
    public string PrPreferencesRoom { get; set; }
    public DateTime InsertDateTime { get; set; }
    public decimal InsertUser { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDateTime { get; set; }
    public decimal? AccountId { get; set; }
    public string ConZipExt { get; set; }
    public string ConPrimaryFax { get; set; }
    public string ConPrimaryEmail { get; set; }
    public string Udfc04Code { get; set; }
    public string Udfc04Desc { get; set; }
    public string Udfc05Code { get; set; }
    public string Udfc05Desc { get; set; }
    public string Udfc06Code { get; set; }
    public string Udfc06Desc { get; set; }
    public string MembershipCardNo { get; set; }
    public string MembershipType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpContacts>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CONTACTS");

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ConAddress1)
                .HasColumnName("CON_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConAddress2)
                .HasColumnName("CON_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConAddress3)
                .HasColumnName("CON_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConAddress4)
                .HasColumnName("CON_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConCity)
                .HasColumnName("CON_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConCountry)
                .HasColumnName("CON_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.ConPhoneExt)
                .HasColumnName("CON_PHONE_EXT")
                .IsUnicode(false);

            entity.Property(e => e.ConPhoneNo)
                .HasColumnName("CON_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.ConPrimaryEmail)
                .HasColumnName("CON_PRIMARY_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.ConPrimaryFax)
                .HasColumnName("CON_PRIMARY_FAX")
                .IsUnicode(false);

            entity.Property(e => e.ConRegion)
                .HasColumnName("CON_REGION")
                .IsUnicode(false);

            entity.Property(e => e.ConState)
                .HasColumnName("CON_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConZipCode)
                .HasColumnName("CON_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.ConZipExt)
                .HasColumnName("CON_ZIP_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContactId)
                .HasColumnName("CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmailYn)
                .HasColumnName("EMAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDateTime)
                .HasColumnName("INSERT_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MailList)
                .HasColumnName("MAIL_LIST")
                .IsUnicode(false);

            entity.Property(e => e.Markets)
                .HasColumnName("MARKETS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasColumnType("CHAR(2)");

            entity.Property(e => e.Middle)
                .HasColumnName("MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Position)
                .HasColumnName("POSITION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PrPreferencesRoom)
                .HasColumnName("PR_PREFERENCES_ROOM")
                .IsUnicode(false);

            entity.Property(e => e.PrPreferencesSmoking)
                .HasColumnName("PR_PREFERENCES_SMOKING")
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TransactionType)
                .HasColumnName("TRANSACTION_TYPE")
                .HasColumnType("CHAR(3)");

            entity.Property(e => e.Udfc04Code)
                .HasColumnName("UDFC04_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc04Desc)
                .HasColumnName("UDFC04_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Udfc05Code)
                .HasColumnName("UDFC05_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc05Desc)
                .HasColumnName("UDFC05_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Udfc06Code)
                .HasColumnName("UDFC06_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc06Desc)
                .HasColumnName("UDFC06_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Udfc07)
                .HasColumnName("UDFC07")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDateTime)
                .HasColumnName("UPDATE_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
