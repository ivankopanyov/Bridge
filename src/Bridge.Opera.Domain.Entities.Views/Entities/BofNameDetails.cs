namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofNameDetails
{
    public decimal? NameId { get; set; }
    public string? Name { get; set; }
    public string? First { get; set; }
    public string? Middle { get; set; }
    public string? Name2 { get; set; }
    public string? Name3 { get; set; }
    public string? Sname { get; set; }
    public string? Passport { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Title { get; set; }
    public string? NameType { get; set; }
    public string? Nationality { get; set; }
    public string? Salutation { get; set; }
    public string? AddressType { get; set; }
    public decimal? AddressId { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string? Address4 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? CountryDesc { get; set; }
    public string? ZipCode { get; set; }
    public string? CityExt { get; set; }
    public string? PhoneNo { get; set; }
    public string? FaxNo { get; set; }
    public string? VipStatus { get; set; }
    public string? ArNo { get; set; }
    public string? MembershipNumber { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }
    public string? Tax1No { get; set; }
    public string? Tax2No { get; set; }
    public string? Gender { get; set; }
    public string? BirthPlace { get; set; }
    public string? BirthCountry { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofNameDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_NAME_DETAILS");

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address3)
                .HasColumnName("ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address4)
                .HasColumnName("ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AddressType)
                .HasColumnName("ADDRESS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArNo)
                .HasColumnName("AR_NO")
                .IsUnicode(false);

            entity.Property(e => e.BirthCountry)
                .HasColumnName("BIRTH_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BirthDate)
                .HasColumnName("BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BirthPlace)
                .HasColumnName("BIRTH_PLACE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CityExt)
                .HasColumnName("CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.FaxNo)
                .HasColumnName("FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Gender)
                .HasColumnName("GENDER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .IsUnicode(false);

            entity.Property(e => e.MembershipNumber)
                .HasColumnName("MEMBERSHIP_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Middle)
                .HasColumnName("MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Name2)
                .HasColumnName("NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Name3)
                .HasColumnName("NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Passport)
                .HasColumnName("PASSPORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNo)
                .HasColumnName("PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.Salutation)
                .HasColumnName("SALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Sname)
                .IsRequired()
                .HasColumnName("SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Tax1No)
                .HasColumnName("TAX1_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Tax2No)
                .HasColumnName("TAX2_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
