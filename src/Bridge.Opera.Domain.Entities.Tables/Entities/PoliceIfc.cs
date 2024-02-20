namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PoliceIfc
{
    public decimal? ResvNameId { get; set; }
    public string? Resort { get; set; }
    public decimal? PoliceId { get; set; }
    public decimal? GuestNameId { get; set; }
    public string? PoliceNumber { get; set; }
    public string? PoliceStatus { get; set; }
    public string? Room { get; set; }
    public string? ResvType { get; set; }
    public string? GuestName { get; set; }
    public string? GuestFirstName { get; set; }
    public string? Gender { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? BirthPlace { get; set; }
    public string? BirthCountry { get; set; }
    public string? Address1 { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? Country { get; set; }
    public string? Nationality { get; set; }
    public string? Profession { get; set; }
    public string? TransportMethod { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string? IdType { get; set; }
    public string? IdNumber { get; set; }
    public DateTime? IdDate { get; set; }
    public string? IdPlace { get; set; }
    public string? IdCountry { get; set; }
    public decimal? AccompanyNameId { get; set; }
    public string? AccompanyLast { get; set; }
    public string? AccompanyFirst { get; set; }
    public string? ErrorMessage { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? HotelKey { get; set; }
    public string? BirthDateStr { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PoliceIfc>(entity =>
        {
            entity.HasKey(e => e.ResvNameId)
                .HasName("POLICE_IFC_PK");

            entity.ToTable("POLICE_IFC");

            entity.HasIndex(e => e.HotelKey)
                .HasName("POLICE_IFC_IND1")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.Departure })
                .HasName("POLICE_IFC_PURGE_IND");

            entity.HasIndex(e => new { e.Resort, e.PoliceId })
                .HasName("POLICE_IFC_UK")
                .IsUnique();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AccompanyFirst)
                .HasColumnName("ACCOMPANY_FIRST")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AccompanyLast)
                .HasColumnName("ACCOMPANY_LAST")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AccompanyNameId)
                .HasColumnName("ACCOMPANY_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BirthCountry)
                .HasColumnName("BIRTH_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BirthDate)
                .HasColumnName("BIRTH_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BirthDateStr)
                .HasColumnName("BIRTH_DATE_STR")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BirthPlace)
                .HasColumnName("BIRTH_PLACE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ErrorMessage)
                .HasColumnName("ERROR_MESSAGE")
                .HasMaxLength(1000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Gender)
                .HasColumnName("GENDER")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HotelKey)
                .IsRequired()
                .HasColumnName("HOTEL_KEY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IdCountry)
                .HasColumnName("ID_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IdDate)
                .HasColumnName("ID_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IdNumber)
                .HasColumnName("ID_NUMBER")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IdPlace)
                .HasColumnName("ID_PLACE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IdType)
                .HasColumnName("ID_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PoliceId)
                .HasColumnName("POLICE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PoliceNumber)
                .HasColumnName("POLICE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PoliceStatus)
                .HasColumnName("POLICE_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Profession)
                .HasColumnName("PROFESSION")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvType)
                .HasColumnName("RESV_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TransportMethod)
                .HasColumnName("TRANSPORT_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
