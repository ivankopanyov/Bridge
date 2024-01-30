namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class QbAddress
{
    public decimal? AddressId { get; set; }
    public decimal? NameId { get; set; }
    public string? AddressType { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string? Address4 { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? Province { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? PrimaryYn { get; set; }
    public string? ForeignCountry { get; set; }
    public string? InCareOf { get; set; }
    public string? CityExt { get; set; }
    public byte? LaptopChange { get; set; }
    public string? LanguageCode { get; set; }
    public string? CleansedStatus { get; set; }
    public DateTime? CleansedDatetime { get; set; }
    public string? CleansedErrormsg { get; set; }
    public string? CleansedValidationstatus { get; set; }
    public string? CleansedMatchstatus { get; set; }
    public string? Barcode { get; set; }
    public string? LastUpdatedResort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QbAddress>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QB_ADDRESS");

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
                .IsRequired()
                .HasColumnName("ADDRESS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Barcode)
                .HasColumnName("BARCODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CityExt)
                .HasColumnName("CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CleansedDatetime)
                .HasColumnName("CLEANSED_DATETIME")
                .HasColumnType("DATE");

            entity.Property(e => e.CleansedErrormsg)
                .HasColumnName("CLEANSED_ERRORMSG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CleansedMatchstatus)
                .HasColumnName("CLEANSED_MATCHSTATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CleansedStatus)
                .HasColumnName("CLEANSED_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CleansedValidationstatus)
                .HasColumnName("CLEANSED_VALIDATIONSTATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ForeignCountry)
                .HasColumnName("FOREIGN_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InCareOf)
                .HasColumnName("IN_CARE_OF")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.LastUpdatedResort)
                .HasColumnName("LAST_UPDATED_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Province)
                .HasColumnName("PROVINCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
