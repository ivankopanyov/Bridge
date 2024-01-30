namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArReminderHeader
{
    public decimal? AccountCode { get; set; }
    public string? AccountNumber { get; set; }
    public string? AccountName { get; set; }
    public string? XaccountName { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string? Address4 { get; set; }
    public string? Address5 { get; set; }
    public string? Address6 { get; set; }
    public string? Address7 { get; set; }
    public string? Address8 { get; set; }
    public string? State { get; set; }
    public string? FullAddress { get; set; }
    public string? City { get; set; }
    public string? Company { get; set; }
    public string? Country { get; set; }
    public decimal? NameId { get; set; }
    public string? Remarks { get; set; }
    public string? Salutation { get; set; }
    public string? Street1 { get; set; }
    public string? Street2 { get; set; }
    public string? Title { get; set; }
    public string? ZipCode { get; set; }
    public DateTime? LetterDate { get; set; }
    public string? ReminderLetter { get; set; }
    public string? CountryDesc { get; set; }
    public string? ContactName { get; set; }
    public string? StateDescription { get; set; }
    public decimal? AccountTypeId { get; set; }
    public string? StatementTypeMode { get; set; }
    public string? Barcode { get; set; }
    public string? AuxFullAddress { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArReminderHeader>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_REMINDER_HEADER");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AccountNumber)
                .HasColumnName("ACCOUNT_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeId)
                .HasColumnName("ACCOUNT_TYPE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
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

            entity.Property(e => e.Address4)
                .HasColumnName("ADDRESS4")
                .IsUnicode(false);

            entity.Property(e => e.Address5)
                .HasColumnName("ADDRESS5")
                .IsUnicode(false);

            entity.Property(e => e.Address6)
                .HasColumnName("ADDRESS6")
                .IsUnicode(false);

            entity.Property(e => e.Address7)
                .HasColumnName("ADDRESS7")
                .IsUnicode(false);

            entity.Property(e => e.Address8)
                .HasColumnName("ADDRESS8")
                .IsUnicode(false);

            entity.Property(e => e.AuxFullAddress)
                .HasColumnName("AUX_FULL_ADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.Barcode)
                .HasColumnName("BARCODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
                .IsUnicode(false);

            entity.Property(e => e.ContactName)
                .HasColumnName("CONTACT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.FullAddress)
                .HasColumnName("FULL_ADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.LetterDate)
                .HasColumnName("LETTER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Remarks)
                .HasColumnName("REMARKS")
                .IsUnicode(false);

            entity.Property(e => e.ReminderLetter)
                .HasColumnName("REMINDER_LETTER")
                .IsUnicode(false);

            entity.Property(e => e.Salutation)
                .HasColumnName("SALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.StateDescription)
                .HasColumnName("STATE_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.StatementTypeMode)
                .HasColumnName("STATEMENT_TYPE_MODE")
                .IsUnicode(false);

            entity.Property(e => e.Street1)
                .HasColumnName("STREET1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Street2)
                .HasColumnName("STREET2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.XaccountName)
                .HasColumnName("XACCOUNT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
