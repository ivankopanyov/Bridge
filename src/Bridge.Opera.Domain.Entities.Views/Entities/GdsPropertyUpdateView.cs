namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GdsPropertyUpdateView
{
    public string PropAirdirt { get; set; }
    public string PropTransport { get; set; }
    public string PropDistunit { get; set; }
    public string PropAirdist { get; set; }
    public string PropAircode { get; set; }
    public string PropGdsResort { get; set; }
    public string PropRating { get; set; }
    public string PropGdsHost { get; set; }
    public string PropRoomcode { get; set; }
    public string PropRoomdesc1 { get; set; }
    public string PropRoomdesc2 { get; set; }
    public string PropRoomdesc3 { get; set; }
    public string PropRoomoccu { get; set; }
    public string PropRoll { get; set; }
    public string PropCode { get; set; }
    public decimal? PropMax { get; set; }
    public string PropCurr { get; set; }
    public string PropAction { get; set; }
    public decimal? PropFloor { get; set; }
    public decimal? PropSuite { get; set; }
    public decimal? PropRooms { get; set; }
    public string PropCheckout { get; set; }
    public string PropCheckin { get; set; }
    public string GmtOffset { get; set; }
    public string TimeOffset { get; set; }
    public DateTime? DateRenovated { get; set; }
    public string YearlyClose { get; set; }
    public DateTime? DateOpened { get; set; }
    public string Resort { get; set; }
    public string Chain { get; set; }
    public decimal? PropId { get; set; }
    public string PropStatus { get; set; }
    public string Commission { get; set; }
    public string PropName { get; set; }
    public string PropStreet { get; set; }
    public string PropCity { get; set; }
    public string PropState { get; set; }
    public string PropCountry { get; set; }
    public string PropPostal { get; set; }
    public string PropPhone { get; set; }
    public string PropFax { get; set; }
    public string PropDirection { get; set; }
    public string PropLocation { get; set; }
    public string PropAmenitycode { get; set; }
    public string PropAmenityid { get; set; }
    public string PropAmenityflg { get; set; }
    public string PropDepositcc { get; set; }
    public string PropGuarcc { get; set; }
    public string PropError { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsPropertyUpdateView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GDS_PROPERTY_UPDATE_VIEW");

            entity.Property(e => e.Chain)
                .HasColumnName("CHAIN")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Commission)
                .HasColumnName("COMMISSION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DateOpened)
                .HasColumnName("DATE_OPENED")
                .HasColumnType("DATE");

            entity.Property(e => e.DateRenovated)
                .HasColumnName("DATE_RENOVATED")
                .HasColumnType("DATE");

            entity.Property(e => e.GmtOffset)
                .HasColumnName("GMT_OFFSET")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropAction)
                .HasColumnName("PROP_ACTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropAircode)
                .HasColumnName("PROP_AIRCODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropAirdirt)
                .HasColumnName("PROP_AIRDIRT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropAirdist)
                .HasColumnName("PROP_AIRDIST")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropAmenitycode)
                .HasColumnName("PROP_AMENITYCODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropAmenityflg)
                .HasColumnName("PROP_AMENITYFLG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropAmenityid)
                .HasColumnName("PROP_AMENITYID")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropCheckin)
                .HasColumnName("PROP_CHECKIN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropCheckout)
                .HasColumnName("PROP_CHECKOUT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropCity)
                .HasColumnName("PROP_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PropCode)
                .HasColumnName("PROP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropCountry)
                .HasColumnName("PROP_COUNTRY")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.PropCurr)
                .HasColumnName("PROP_CURR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropDepositcc)
                .HasColumnName("PROP_DEPOSITCC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropDirection)
                .HasColumnName("PROP_DIRECTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropDistunit)
                .HasColumnName("PROP_DISTUNIT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropError)
                .HasColumnName("PROP_ERROR")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropFax)
                .HasColumnName("PROP_FAX")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropFloor)
                .HasColumnName("PROP_FLOOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropGdsHost)
                .HasColumnName("PROP_GDS_HOST")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropGdsResort)
                .HasColumnName("PROP_GDS_RESORT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropGuarcc)
                .HasColumnName("PROP_GUARCC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropId)
                .HasColumnName("PROP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropLocation)
                .HasColumnName("PROP_LOCATION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropMax)
                .HasColumnName("PROP_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropName)
                .HasColumnName("PROP_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.PropPhone)
                .HasColumnName("PROP_PHONE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropPostal)
                .HasColumnName("PROP_POSTAL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropRating)
                .HasColumnName("PROP_RATING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropRoll)
                .HasColumnName("PROP_ROLL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropRoomcode)
                .HasColumnName("PROP_ROOMCODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropRoomdesc1)
                .HasColumnName("PROP_ROOMDESC1")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropRoomdesc2)
                .HasColumnName("PROP_ROOMDESC2")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropRoomdesc3)
                .HasColumnName("PROP_ROOMDESC3")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropRoomoccu)
                .HasColumnName("PROP_ROOMOCCU")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropRooms)
                .HasColumnName("PROP_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropState)
                .HasColumnName("PROP_STATE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropStatus)
                .HasColumnName("PROP_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PropStreet)
                .HasColumnName("PROP_STREET")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PropSuite)
                .HasColumnName("PROP_SUITE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropTransport)
                .HasColumnName("PROP_TRANSPORT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TimeOffset)
                .HasColumnName("TIME_OFFSET")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YearlyClose)
                .HasColumnName("YEARLY_CLOSE")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
