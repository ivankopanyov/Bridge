namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SourceByBooking
{
    public string? Resort { get; set; }
    public decimal? BookingId { get; set; }
    public decimal? SourceId { get; set; }
    public string? SourceName { get; set; }
    public string? SourceName2 { get; set; }
    public string? SourceName3 { get; set; }
    public string? SourceBusinessGreeting { get; set; }
    public string? SourceAddress1 { get; set; }
    public string? SourceAddress2 { get; set; }
    public string? SourceZipCode { get; set; }
    public string? SourceState { get; set; }
    public string? SourceCountry { get; set; }
    public string? SourceCity { get; set; }
    public string? SourceCityExt { get; set; }
    public string? SourceFaxNo { get; set; }
    public string? SourcePhoneNo { get; set; }
    public string? SourceEmailId { get; set; }
    public string? XsourceName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SourceByBooking>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SOURCE_BY_BOOKING");

            entity.Property(e => e.BookingId)
                .HasColumnName("BOOKING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
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

            entity.Property(e => e.SourceEmailId)
                .HasColumnName("SOURCE_EMAIL_ID")
                .IsUnicode(false);

            entity.Property(e => e.SourceFaxNo)
                .HasColumnName("SOURCE_FAX_NO")
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

            entity.Property(e => e.SourcePhoneNo)
                .HasColumnName("SOURCE_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.SourceState)
                .HasColumnName("SOURCE_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SourceZipCode)
                .HasColumnName("SOURCE_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.XsourceName)
                .HasColumnName("XSOURCE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
