namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpPoliceIfcView
{
    public string HotelKey { get; set; }
    public string HotelCode { get; set; }
    public string RoomUser { get; set; }
    public string LastName { get; set; }
    public string Accompany { get; set; }
    public string FirstName { get; set; }
    public string Sex { get; set; }
    public string BirthDate { get; set; }
    public string BirthPlace { get; set; }
    public string BirthCountry { get; set; }
    public string Nationality { get; set; }
    public string Profession { get; set; }
    public string Address1 { get; set; }
    public string ZipCityCountry { get; set; }
    public string City { get; set; }
    public string Zip { get; set; }
    public string Country { get; set; }
    public string Arrival { get; set; }
    public string Departure { get; set; }
    public string TransportMethod { get; set; }
    public string DocType { get; set; }
    public string DocIssueDate { get; set; }
    public string DocIssuePlace { get; set; }
    public string DocIssueCountry { get; set; }
    public string GuestType { get; set; }
    public string ActionType { get; set; }
    public string PoliceNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpPoliceIfcView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_POLICE_IFC_VIEW");

            entity.Property(e => e.Accompany)
                .HasColumnName("ACCOMPANY")
                .HasMaxLength(201)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.BirthCountry)
                .HasColumnName("BIRTH_COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BirthDate)
                .HasColumnName("BIRTH_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.BirthPlace)
                .HasColumnName("BIRTH_PLACE")
                .HasMaxLength(100)
                .IsUnicode(false);

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
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.DocIssueCountry)
                .HasColumnName("DOC_ISSUE_COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DocIssueDate)
                .HasColumnName("DOC_ISSUE_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.DocIssuePlace)
                .HasColumnName("DOC_ISSUE_PLACE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DocType)
                .HasColumnName("DOC_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestType)
                .HasColumnName("GUEST_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HotelKey)
                .HasColumnName("HOTEL_KEY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PoliceNo)
                .HasColumnName("POLICE_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Profession)
                .HasColumnName("PROFESSION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomUser)
                .HasColumnName("ROOM_USER")
                .IsUnicode(false);

            entity.Property(e => e.Sex)
                .HasColumnName("SEX")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TransportMethod)
                .HasColumnName("TRANSPORT_METHOD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Zip)
                .HasColumnName("ZIP")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ZipCityCountry)
                .HasColumnName("ZIP_CITY_COUNTRY")
                .HasMaxLength(302)
                .IsUnicode(false);
        });
	}
}
