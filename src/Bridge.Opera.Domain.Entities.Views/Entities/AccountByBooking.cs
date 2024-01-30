namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AccountByBooking
{
    public string? Resort { get; set; }
    public decimal? BookingId { get; set; }
    public decimal? AccountId { get; set; }
    public string? AccountName { get; set; }
    public string? AccountName2 { get; set; }
    public string? AccountName3 { get; set; }
    public string? AccountBusinessGreeting { get; set; }
    public string? AccountAddress1 { get; set; }
    public string? AccountAddress2 { get; set; }
    public string? AccountZipCode { get; set; }
    public string? AccountState { get; set; }
    public string? AccountCountry { get; set; }
    public string? AccountCity { get; set; }
    public string? AccountCityExt { get; set; }
    public string? XaccountName { get; set; }
    public string? AccountFaxNo { get; set; }
    public string? AccountPhoneNo { get; set; }
    public string? AccountEmailId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AccountByBooking>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ACCOUNT_BY_BOOKING");

            entity.Property(e => e.AccountAddress1)
                .HasColumnName("ACCOUNT_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountAddress2)
                .HasColumnName("ACCOUNT_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountBusinessGreeting)
                .HasColumnName("ACCOUNT_BUSINESS_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.AccountCity)
                .HasColumnName("ACCOUNT_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccountCityExt)
                .HasColumnName("ACCOUNT_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountCountry)
                .HasColumnName("ACCOUNT_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountEmailId)
                .HasColumnName("ACCOUNT_EMAIL_ID")
                .IsUnicode(false);

            entity.Property(e => e.AccountFaxNo)
                .HasColumnName("ACCOUNT_FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountName2)
                .HasColumnName("ACCOUNT_NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountName3)
                .HasColumnName("ACCOUNT_NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountPhoneNo)
                .HasColumnName("ACCOUNT_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.AccountState)
                .HasColumnName("ACCOUNT_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccountZipCode)
                .HasColumnName("ACCOUNT_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.BookingId)
                .HasColumnName("BOOKING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XaccountName)
                .HasColumnName("XACCOUNT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
