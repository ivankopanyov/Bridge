namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpVisaParty
{
    public decimal? ExpDataId { get; set; }
    public decimal? ExpViewId { get; set; }
    public string? MultiPropertyYn { get; set; }
    public string? Resort { get; set; }
    public decimal? PartyId { get; set; }
    public decimal? PartySequence { get; set; }
    public decimal? NameId { get; set; }
    public string? PartyType { get; set; }
    public string? Name1 { get; set; }
    public string? Name2 { get; set; }
    public string? Name3 { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string? Address4 { get; set; }
    public string? City { get; set; }
    public string? PostalCode { get; set; }
    public string? Telephone { get; set; }
    public string? CountryCode { get; set; }
    public string? StateCode { get; set; }
    public string? ArAccountNo { get; set; }
    public string? Email { get; set; }
    public string? MerchantId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpVisaParty>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_VISA_PARTY");

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS_1")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS_2")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Address3)
                .HasColumnName("ADDRESS_3")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Address4)
                .HasColumnName("ADDRESS_4")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArAccountNo)
                .HasColumnName("AR_ACCOUNT_NO")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpDataId)
                .HasColumnName("EXP_DATA_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpViewId)
                .HasColumnName("EXP_VIEW_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MerchantId)
                .HasColumnName("MERCHANT_ID")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MultiPropertyYn)
                .IsRequired()
                .HasColumnName("MULTI_PROPERTY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name1)
                .HasColumnName("NAME1")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name2)
                .HasColumnName("NAME2")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name3)
                .HasColumnName("NAME3")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PartyId)
                .HasColumnName("PARTY_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PartySequence)
                .HasColumnName("PARTY_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PartyType)
                .HasColumnName("PARTY_TYPE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostalCode)
                .HasColumnName("POSTAL_CODE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StateCode)
                .HasColumnName("STATE_CODE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Telephone)
                .HasColumnName("TELEPHONE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
