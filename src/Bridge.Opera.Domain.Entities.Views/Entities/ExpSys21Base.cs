namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSys21Base
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public string? HotelCode { get; set; }
    public string? ResortType { get; set; }
    public string? HotelName { get; set; }
    public string? OperaVersion { get; set; }
    public string? CurrencyCode { get; set; }
    public string? HotelCity { get; set; }
    public string? HotelStreet { get; set; }
    public string? HotelAddress1 { get; set; }
    public string? HotelAddress2 { get; set; }
    public string? HotelPostalCode { get; set; }
    public string? HotelTelephone { get; set; }
    public string? HotelCountryCode { get; set; }
    public string? HotelState { get; set; }
    public string? PmsType { get; set; }
    public decimal? UtcOffsetMinutes { get; set; }
    public decimal? HilstarInd { get; set; }
    public DateTime? ConsideredDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSys21Base>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SYS21_BASE");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HilstarInd)
                .HasColumnName("HILSTAR_IND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HotelAddress1)
                .HasColumnName("HOTEL_ADDRESS1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HotelAddress2)
                .HasColumnName("HOTEL_ADDRESS2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HotelCity)
                .HasColumnName("HOTEL_CITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HotelCountryCode)
                .HasColumnName("HOTEL_COUNTRY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HotelName)
                .HasColumnName("HOTEL_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HotelPostalCode)
                .HasColumnName("HOTEL_POSTAL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HotelState)
                .HasColumnName("HOTEL_STATE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HotelStreet)
                .HasColumnName("HOTEL_STREET")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HotelTelephone)
                .HasColumnName("HOTEL_TELEPHONE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OperaVersion)
                .HasColumnName("OPERA_VERSION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PmsType)
                .HasColumnName("PMS_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResortType)
                .HasColumnName("RESORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UtcOffsetMinutes)
                .HasColumnName("UTC_OFFSET_MINUTES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
