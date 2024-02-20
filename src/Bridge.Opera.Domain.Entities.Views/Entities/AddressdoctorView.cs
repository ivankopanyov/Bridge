namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AddressdoctorView
{
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string? Address4 { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? Contact { get; set; }
    public string? Organization { get; set; }
    public string? Street { get; set; }
    public string? Recordid { get; set; }
    public string? Department { get; set; }
    public string? Building { get; set; }
    public string? Housenumber { get; set; }
    public string? Pobox { get; set; }
    public string? Residue { get; set; }
    public string? Countryspecificlocalityline { get; set; }
    public string? Deliveryaddresslines { get; set; }
    public string? Formattedaddress { get; set; }
    public string? Validationstatus { get; set; }
    public decimal? Resultpercentage { get; set; }
    public string? Elementmatchstatus { get; set; }
    public string? Elementresultstatus { get; set; }
    public string? ValidationstatusDesc { get; set; }
    public string? Vrvalidationstatus { get; set; }
    public string? VrvalidationstatusDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AddressdoctorView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ADDRESSDOCTOR_VIEW");

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS2")
                .IsUnicode(false);

            entity.Property(e => e.Address3)
                .HasColumnName("ADDRESS3")
                .IsUnicode(false);

            entity.Property(e => e.Address4)
                .HasColumnName("ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Building)
                .HasColumnName("BUILDING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Contact)
                .HasColumnName("CONTACT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Countryspecificlocalityline)
                .HasColumnName("COUNTRYSPECIFICLOCALITYLINE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Deliveryaddresslines)
                .HasColumnName("DELIVERYADDRESSLINES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Department)
                .HasColumnName("DEPARTMENT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Elementmatchstatus)
                .HasColumnName("ELEMENTMATCHSTATUS")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Elementresultstatus)
                .HasColumnName("ELEMENTRESULTSTATUS")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Formattedaddress)
                .HasColumnName("FORMATTEDADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.Housenumber)
                .HasColumnName("HOUSENUMBER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Organization)
                .HasColumnName("ORGANIZATION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Pobox)
                .HasColumnName("POBOX")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Recordid)
                .HasColumnName("RECORDID")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Residue)
                .HasColumnName("RESIDUE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Resultpercentage)
                .HasColumnName("RESULTPERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .IsUnicode(false);

            entity.Property(e => e.Street)
                .HasColumnName("STREET")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Validationstatus)
                .HasColumnName("VALIDATIONSTATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ValidationstatusDesc)
                .HasColumnName("VALIDATIONSTATUS_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Vrvalidationstatus)
                .HasColumnName("VRVALIDATIONSTATUS")
                .IsUnicode(false);

            entity.Property(e => e.VrvalidationstatusDesc)
                .HasColumnName("VRVALIDATIONSTATUS_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
