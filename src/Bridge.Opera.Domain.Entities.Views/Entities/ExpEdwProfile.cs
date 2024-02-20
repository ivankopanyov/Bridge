namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEdwProfile
{
    public decimal? ExportId { get; set; }
    public string? EdwType { get; set; }
    public string? PmsVersion { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? GuestNameId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? NamePrefix { get; set; }
    public string? NameSuffix { get; set; }
    public string? BusinessTitle { get; set; }
    public string? HomeAddress1 { get; set; }
    public string? HomeAddress2 { get; set; }
    public string? HomeAddress3 { get; set; }
    public string? HomeAddress4 { get; set; }
    public string? HomeCity { get; set; }
    public string? HomeState { get; set; }
    public string? HomeZipCode { get; set; }
    public string? HomeCountry { get; set; }
    public string? BusinessName { get; set; }
    public string? BusinessAddress1 { get; set; }
    public string? BusinessAddress2 { get; set; }
    public string? BusinessAddress3 { get; set; }
    public string? BusinessAddress4 { get; set; }
    public string? BusinessCity { get; set; }
    public string? BusinessState { get; set; }
    public string? BusinessZip { get; set; }
    public string? BusinessCountry { get; set; }
    public string? EmailAddress { get; set; }
    public string? MailListYn { get; set; }
    public string? MarketResearchYn { get; set; }
    public string? AutoenrollYn { get; set; }
    public string? ThirdPartyYn { get; set; }
    public string? BrandId { get; set; }
    public string? HotelCode { get; set; }
    public string? RestrictionType { get; set; }
    public string? RestrictionLevel { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Gender { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEdwProfile>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_EDW_PROFILE");

            entity.Property(e => e.AutoenrollYn)
                .HasColumnName("AUTOENROLL_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BrandId)
                .HasColumnName("BRAND_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BusinessAddress1)
                .HasColumnName("BUSINESS_ADDRESS_1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BusinessAddress2)
                .HasColumnName("BUSINESS_ADDRESS_2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BusinessAddress3)
                .HasColumnName("BUSINESS_ADDRESS_3")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BusinessAddress4)
                .HasColumnName("BUSINESS_ADDRESS_4")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BusinessCity)
                .HasColumnName("BUSINESS_CITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BusinessCountry)
                .HasColumnName("BUSINESS_COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BusinessName)
                .HasColumnName("BUSINESS_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BusinessState)
                .HasColumnName("BUSINESS_STATE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BusinessTitle)
                .HasColumnName("BUSINESS_TITLE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BusinessZip)
                .HasColumnName("BUSINESS_ZIP")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DateOfBirth)
                .HasColumnName("DATE_OF_BIRTH")
                .HasColumnType("DATE");

            entity.Property(e => e.EdwType)
                .HasColumnName("EDW_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasColumnName("EMAIL_ADDRESS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Gender)
                .HasColumnName("GENDER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HomeAddress1)
                .HasColumnName("HOME_ADDRESS_1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HomeAddress2)
                .HasColumnName("HOME_ADDRESS_2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HomeAddress3)
                .HasColumnName("HOME_ADDRESS_3")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HomeAddress4)
                .HasColumnName("HOME_ADDRESS_4")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HomeCity)
                .HasColumnName("HOME_CITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HomeCountry)
                .HasColumnName("HOME_COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HomeState)
                .HasColumnName("HOME_STATE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HomeZipCode)
                .HasColumnName("HOME_ZIP_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MailListYn)
                .HasColumnName("MAIL_LIST_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketResearchYn)
                .HasColumnName("MARKET_RESEARCH_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MiddleName)
                .HasColumnName("MIDDLE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NamePrefix)
                .HasColumnName("NAME_PREFIX")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameSuffix)
                .HasColumnName("NAME_SUFFIX")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PmsVersion)
                .HasColumnName("PMS_VERSION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RestrictionLevel)
                .HasColumnName("RESTRICTION_LEVEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RestrictionType)
                .HasColumnName("RESTRICTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ThirdPartyYn)
                .HasColumnName("THIRD_PARTY_YN")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
