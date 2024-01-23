namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ProfileRequestsView
{
    public decimal WoNumber { get; set; }
    public string Resort { get; set; }
    public DateTime CreatedDate { get; set; }
    public decimal CreatedBy { get; set; }
    public decimal? CompletedBy { get; set; }
    public DateTime? CompletedDate { get; set; }
    public string ActType { get; set; }
    public string TypeCode { get; set; }
    public string SendMethod { get; set; }
    public string CompletedYn { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string ActTypeDesc { get; set; }
    public string DefaultSendMethod { get; set; }
    public string Url { get; set; }
    public decimal? RequestId { get; set; }
    public decimal? AttachTemplateId { get; set; }
    public string LinkType { get; set; }
    public decimal LinkId { get; set; }
    public decimal NameId { get; set; }
    public string NameType { get; set; }
    public string NameTypeDesc { get; set; }
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public string First { get; set; }
    public string Middle { get; set; }
    public string Name2 { get; set; }
    public string Name3 { get; set; }
    public string Sname { get; set; }
    public string Sfirst { get; set; }
    public string ContactYn { get; set; }
    public string Language { get; set; }
    public string LanguageDesc { get; set; }
    public string AddressType { get; set; }
    public decimal? AddressId { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string Address3 { get; set; }
    public string Address4 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string ZipCode { get; set; }
    public string StateDesc { get; set; }
    public string CountryDesc { get; set; }
    public decimal? EmailId { get; set; }
    public string Email { get; set; }
    public string Xname { get; set; }
    public string XfirstName { get; set; }
    public string Xtitle { get; set; }
    public string Xsalutation { get; set; }
    public string Sxname { get; set; }
    public string SxfirstName { get; set; }
    public string XdisplayName { get; set; }
    public decimal? RequestAddressId { get; set; }
    public decimal? PrimaryAddressId { get; set; }
    public decimal? RequestEmailId { get; set; }
    public decimal? PrimaryEmailId { get; set; }
    public string Title { get; set; }
    public string Salutation { get; set; }
    public string ProductInterest { get; set; }
    public string XenvelopeGreeting { get; set; }
    public string Xlanguage { get; set; }
    public string XlanguageDesc { get; set; }
    public decimal? ParentWoNumber { get; set; }
    public string CampaignDesc { get; set; }
    public string LoggedSrepCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileRequestsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PROFILE_REQUESTS_VIEW");

            entity.Property(e => e.ActType)
                .HasColumnName("ACT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActTypeDesc)
                .HasColumnName("ACT_TYPE_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

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
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AddressType)
                .HasColumnName("ADDRESS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AttachTemplateId)
                .HasColumnName("ATTACH_TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CampaignDesc)
                .HasColumnName("CAMPAIGN_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CompletedBy)
                .HasColumnName("COMPLETED_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CompletedDate)
                .HasColumnName("COMPLETED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CompletedYn)
                .HasColumnName("COMPLETED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ContactYn)
                .IsRequired()
                .HasColumnName("CONTACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CreatedBy)
                .HasColumnName("CREATED_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CREATED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultSendMethod)
                .HasColumnName("DEFAULT_SEND_METHOD")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.EmailId)
                .HasColumnName("EMAIL_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LanguageDesc)
                .HasColumnName("LANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.LinkId)
                .HasColumnName("LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LinkType)
                .IsRequired()
                .HasColumnName("LINK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LoggedSrepCode)
                .HasColumnName("LOGGED_SREP_CODE")
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
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameTypeDesc)
                .HasColumnName("NAME_TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ParentWoNumber)
                .HasColumnName("PARENT_WO_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrimaryAddressId)
                .HasColumnName("PRIMARY_ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrimaryEmailId)
                .HasColumnName("PRIMARY_EMAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProductInterest)
                .HasColumnName("PRODUCT_INTEREST")
                .IsUnicode(false);

            entity.Property(e => e.RequestAddressId)
                .HasColumnName("REQUEST_ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestEmailId)
                .HasColumnName("REQUEST_EMAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Salutation)
                .HasColumnName("SALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.SendMethod)
                .HasColumnName("SEND_METHOD")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Sfirst)
                .HasColumnName("SFIRST")
                .HasMaxLength(40)
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

            entity.Property(e => e.StateDesc)
                .HasColumnName("STATE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.SxfirstName)
                .HasColumnName("SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Sxname)
                .HasColumnName("SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TypeCode)
                .IsRequired()
                .HasColumnName("TYPE_CODE")
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

            entity.Property(e => e.Url)
                .HasColumnName("URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.WoNumber)
                .HasColumnName("WO_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.XdisplayName)
                .HasColumnName("XDISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.XenvelopeGreeting)
                .HasColumnName("XENVELOPE_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.XfirstName)
                .HasColumnName("XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Xlanguage)
                .HasColumnName("XLANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XlanguageDesc)
                .HasColumnName("XLANGUAGE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Xname)
                .HasColumnName("XNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Xsalutation)
                .HasColumnName("XSALUTATION")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Xtitle)
                .HasColumnName("XTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
