namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEfolioParty
{
    public decimal? ExportId { get; set; }
    public decimal? RowSequence { get; set; }
    public decimal? PartySequence { get; set; }
    public decimal? PNameId { get; set; }
    public string ExportType { get; set; }
    public string PPartyType { get; set; }
    public string PName1 { get; set; }
    public string PAddress1 { get; set; }
    public string PAddress2 { get; set; }
    public string PAddress3 { get; set; }
    public string PAddress4 { get; set; }
    public string PCity { get; set; }
    public string PPostalCode { get; set; }
    public string PTelephone { get; set; }
    public string PCountryCode { get; set; }
    public string PStateCode { get; set; }
    public string PArAccountNo { get; set; }
    public string PFax { get; set; }
    public string PEmail { get; set; }
    public string PAddressType { get; set; }
    public string PName2 { get; set; }
    public string PName3 { get; set; }
    public string PMerchantId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEfolioParty>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_EFOLIO_PARTY");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportType)
                .HasColumnName("EXPORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PAddress1)
                .HasColumnName("P_ADDRESS_1")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PAddress2)
                .HasColumnName("P_ADDRESS_2")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PAddress3)
                .HasColumnName("P_ADDRESS_3")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PAddress4)
                .HasColumnName("P_ADDRESS_4")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PAddressType)
                .HasColumnName("P_ADDRESS_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PArAccountNo)
                .HasColumnName("P_AR_ACCOUNT_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PCity)
                .HasColumnName("P_CITY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PCountryCode)
                .HasColumnName("P_COUNTRY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PEmail)
                .HasColumnName("P_EMAIL")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PFax)
                .HasColumnName("P_FAX")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PMerchantId)
                .HasColumnName("P_MERCHANT_ID")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PName1)
                .HasColumnName("P_NAME1")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PName2)
                .HasColumnName("P_NAME2")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PName3)
                .HasColumnName("P_NAME3")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PNameId)
                .HasColumnName("P_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PPartyType)
                .HasColumnName("P_PARTY_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PPostalCode)
                .HasColumnName("P_POSTAL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PStateCode)
                .HasColumnName("P_STATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PTelephone)
                .HasColumnName("P_TELEPHONE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PartySequence)
                .HasColumnName("PARTY_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RowSequence)
                .HasColumnName("ROW_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
