namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MaldivesTaxView
{
    public string? Resort { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public decimal? TaxRegistrationNo { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? GuestNameId { get; set; }
    public DateTime? TaxArrivalDate { get; set; }
    public DateTime? TaxDepartureDate { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string? ArrivalCarrierCode { get; set; }
    public string? DepartureCarrierCode { get; set; }
    public decimal? TaxDays { get; set; }
    public decimal? TaxNoOfStays { get; set; }
    public string? GuestLastName { get; set; }
    public string? GuestFirstName { get; set; }
    public string? Passport { get; set; }
    public string? Nationality { get; set; }
    public string? GuestCountry { get; set; }
    public decimal? GuestAge { get; set; }
    public string? Profession { get; set; }
    public string? VisaNumber { get; set; }
    public DateTime? VisaIssueDate { get; set; }
    public DateTime? VisaExpirationDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MaldivesTaxView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MALDIVES_TAX_VIEW");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.ArrivalCarrierCode)
                .HasColumnName("ARRIVAL_CARRIER_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureCarrierCode)
                .HasColumnName("DEPARTURE_CARRIER_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestAge)
                .HasColumnName("GUEST_AGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestCountry)
                .HasColumnName("GUEST_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestLastName)
                .HasColumnName("GUEST_LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Passport)
                .HasColumnName("PASSPORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Profession)
                .HasColumnName("PROFESSION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxArrivalDate)
                .HasColumnName("TAX_ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaxDays)
                .HasColumnName("TAX_DAYS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.TaxDepartureDate)
                .HasColumnName("TAX_DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaxNoOfStays)
                .HasColumnName("TAX_NO_OF_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxRegistrationNo)
                .HasColumnName("TAX_REGISTRATION_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.VisaExpirationDate)
                .HasColumnName("VISA_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.VisaIssueDate)
                .HasColumnName("VISA_ISSUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.VisaNumber)
                .HasColumnName("VISA_NUMBER")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
