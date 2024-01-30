namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AccConBookingByActivity
{
    public decimal? ActId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? ActType { get; set; }
    public string? Purpose { get; set; }
    public decimal? AssignedTo { get; set; }
    public DateTime? CompletedDate { get; set; }
    public string? SrepCode { get; set; }
    public decimal? AccountId { get; set; }
    public decimal? ContactId { get; set; }
    public decimal? BookingId { get; set; }
    public string? AccName { get; set; }
    public string? AccAddress1 { get; set; }
    public string? AccAddress2 { get; set; }
    public string? AccCity { get; set; }
    public string? AccState { get; set; }
    public string? AccCountry { get; set; }
    public string? AccZipCode { get; set; }
    public string? ConName { get; set; }
    public string? ConAddress1 { get; set; }
    public string? ConAddress2 { get; set; }
    public string? ConCity { get; set; }
    public string? ConState { get; set; }
    public string? ConCountry { get; set; }
    public string? ConZipCode { get; set; }
    public string? ContactBusinessGreeting { get; set; }
    public string? ContactLetterGreeting { get; set; }
    public string? BookingName { get; set; }
    public DateTime? BookingArrival { get; set; }
    public DateTime? BookingDeparture { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AccConBookingByActivity>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ACC_CON_BOOKING_BY_ACTIVITY");

            entity.Property(e => e.AccAddress1)
                .HasColumnName("ACC_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccAddress2)
                .HasColumnName("ACC_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccCity)
                .HasColumnName("ACC_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccCountry)
                .HasColumnName("ACC_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccName)
                .HasColumnName("ACC_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccState)
                .HasColumnName("ACC_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccZipCode)
                .HasColumnName("ACC_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActId)
                .HasColumnName("ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActType)
                .HasColumnName("ACT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AssignedTo)
                .HasColumnName("ASSIGNED_TO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingArrival)
                .HasColumnName("BOOKING_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BookingDeparture)
                .HasColumnName("BOOKING_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookingId)
                .HasColumnName("BOOKING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingName)
                .HasColumnName("BOOKING_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CompletedDate)
                .HasColumnName("COMPLETED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ConAddress1)
                .HasColumnName("CON_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConAddress2)
                .HasColumnName("CON_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConCity)
                .HasColumnName("CON_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConCountry)
                .HasColumnName("CON_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConName)
                .HasColumnName("CON_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConState)
                .HasColumnName("CON_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConZipCode)
                .HasColumnName("CON_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.ContactBusinessGreeting)
                .HasColumnName("CONTACT_BUSINESS_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactId)
                .HasColumnName("CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContactLetterGreeting)
                .HasColumnName("CONTACT_LETTER_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Purpose)
                .HasColumnName("PURPOSE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SrepCode)
                .HasColumnName("SREP_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");
        });
	}
}
