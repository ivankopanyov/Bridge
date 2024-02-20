namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpLuxStatecResv
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? Children { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public DateTime? BirthDate { get; set; }
    public DateTime? AccompBirthDate { get; set; }
    public string? Room { get; set; }
    public string? PurposeOfStay { get; set; }
    public string? Passport { get; set; }
    public string? Nationality { get; set; }
    public string? BirthPlace { get; set; }
    public string? GuestFirstName { get; set; }
    public string? GuestName { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? StreetNumber { get; set; }
    public string? StreetAddress { get; set; }
    public string? LicensePlate { get; set; }
    public string? LicenseCntry { get; set; }
    public string? AccompBirthPlace { get; set; }
    public string? AccompFirstName { get; set; }
    public string? AccompGuestName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpLuxStatecResv>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_LUX_STATEC_RESV");

            entity.Property(e => e.AccompBirthDate)
                .HasColumnName("ACCOMP_BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AccompBirthPlace)
                .HasColumnName("ACCOMP_BIRTH_PLACE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccompFirstName)
                .HasColumnName("ACCOMP_FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccompGuestName)
                .HasColumnName("ACCOMP_GUEST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BirthDate)
                .HasColumnName("BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BirthPlace)
                .HasColumnName("BIRTH_PLACE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LicenseCntry)
                .HasColumnName("LICENSE_CNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LicensePlate)
                .HasColumnName("LICENSE_PLATE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Passport)
                .HasColumnName("PASSPORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PurposeOfStay)
                .HasColumnName("PURPOSE_OF_STAY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StreetAddress)
                .HasColumnName("STREET_ADDRESS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StreetNumber)
                .HasColumnName("STREET_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
