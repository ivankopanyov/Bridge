namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsPropupUpdate
{
    public GdsPropupUpdate()
    {
        GdsAirptUpdate = new HashSet<GdsAirptUpdate>();
        GdsAmentupUpdate = new HashSet<GdsAmentupUpdate>();
        GdsRatingUpdate = new HashSet<GdsRatingUpdate>();
        GdsResccUpdate = new HashSet<GdsResccUpdate>();
        GdsResrtyUpdate = new HashSet<GdsResrtyUpdate>();
    }

    public decimal PropupId { get; set; }
    public string UpdateCode { get; set; }
    public string ChainCode { get; set; }
    public string Resort { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Action { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public string AutoCommission { get; set; }
    public string PropertyStatus { get; set; }
    public string PropertyName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string PostalCode { get; set; }
    public string TelephoneNumber { get; set; }
    public string FaxNumber { get; set; }
    public string TelexNumber { get; set; }
    public string Directions { get; set; }
    public string PropLocationDesc { get; set; }
    public string YearlyClosures { get; set; }
    public DateTime? DateOpened { get; set; }
    public DateTime? DateRenovated { get; set; }
    public string TimeZone { get; set; }
    public string GmtOffset { get; set; }
    public string CheckinTime { get; set; }
    public string CheckoutTime { get; set; }
    public decimal? NumberRooms { get; set; }
    public decimal? NumberSuites { get; set; }
    public decimal? NumberFloors { get; set; }
    public string NativeCurrencyCode { get; set; }
    public decimal? MaxRoomOccupancy { get; set; }
    public string DefaultStatusCode { get; set; }
    public string RollInStatusCode { get; set; }
    public string DeliverStatusCode { get; set; }
    public string DeliverStatusDate { get; set; }
    public string SessionId { get; set; }
    public string GdsHost { get; set; }

    public virtual ICollection<GdsAirptUpdate> GdsAirptUpdate { get; set; }
    public virtual ICollection<GdsAmentupUpdate> GdsAmentupUpdate { get; set; }
    public virtual ICollection<GdsRatingUpdate> GdsRatingUpdate { get; set; }
    public virtual ICollection<GdsResccUpdate> GdsResccUpdate { get; set; }
    public virtual ICollection<GdsResrtyUpdate> GdsResrtyUpdate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsPropupUpdate>(entity =>
        {
            entity.HasKey(e => e.PropupId)
                .HasName("GDS_PROPUP_UPDATE_PK");

            entity.ToTable("GDS_PROPUP_UPDATE");

            entity.HasIndex(e => e.DeliverStatusCode)
                .HasName("GDS_PROPUP_UPDATE_IND2");

            entity.HasIndex(e => e.Resort)
                .HasName("GDS_PROPUP_UPDATE_IND1");

            entity.Property(e => e.PropupId)
                .HasColumnName("PROPUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Action)
                .IsRequired()
                .HasColumnName("ACTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AutoCommission)
                .HasColumnName("AUTO_COMMISSION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CheckinTime)
                .HasColumnName("CHECKIN_TIME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CheckoutTime)
                .HasColumnName("CHECKOUT_TIME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .IsRequired()
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .IsRequired()
                .HasColumnName("COUNTRY")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.DateOpened)
                .HasColumnName("DATE_OPENED")
                .HasColumnType("DATE");

            entity.Property(e => e.DateRenovated)
                .HasColumnName("DATE_RENOVATED")
                .HasColumnType("DATE");

            entity.Property(e => e.DefaultStatusCode)
                .HasColumnName("DEFAULT_STATUS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeliverStatusCode)
                .HasColumnName("DELIVER_STATUS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeliverStatusDate)
                .HasColumnName("DELIVER_STATUS_DATE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Directions)
                .HasColumnName("DIRECTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FaxNumber)
                .HasColumnName("FAX_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GmtOffset)
                .HasColumnName("GMT_OFFSET")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxRoomOccupancy)
                .HasColumnName("MAX_ROOM_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NativeCurrencyCode)
                .HasColumnName("NATIVE_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NumberFloors)
                .HasColumnName("NUMBER_FLOORS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberRooms)
                .HasColumnName("NUMBER_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberSuites)
                .HasColumnName("NUMBER_SUITES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostalCode)
                .HasColumnName("POSTAL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropLocationDesc)
                .HasColumnName("PROP_LOCATION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropertyName)
                .IsRequired()
                .HasColumnName("PROPERTY_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropertyStatus)
                .IsRequired()
                .HasColumnName("PROPERTY_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RollInStatusCode)
                .HasColumnName("ROLL_IN_STATUS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SessionId)
                .HasColumnName("SESSION_ID")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Street)
                .HasColumnName("STREET")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TelephoneNumber)
                .HasColumnName("TELEPHONE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TelexNumber)
                .HasColumnName("TELEX_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TimeZone)
                .HasColumnName("TIME_ZONE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateCode)
                .HasColumnName("UPDATE_CODE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.YearlyClosures)
                .HasColumnName("YEARLY_CLOSURES")
                .HasMaxLength(45)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(GdsAirptUpdate)))
				entity.Ignore(e => e.GdsAirptUpdate);

			if (!types.Contains(typeof(GdsAmentupUpdate)))
				entity.Ignore(e => e.GdsAmentupUpdate);

			if (!types.Contains(typeof(GdsRatingUpdate)))
				entity.Ignore(e => e.GdsRatingUpdate);

			if (!types.Contains(typeof(GdsResccUpdate)))
				entity.Ignore(e => e.GdsResccUpdate);

			if (!types.Contains(typeof(GdsResrtyUpdate)))
				entity.Ignore(e => e.GdsResrtyUpdate);
		});
	}
}
