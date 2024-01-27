namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProfileLookupRequests
{
    public decimal RequestId { get; set; }
    public string Resort { get; set; }
    public string NameType { get; set; }
    public string NameCode { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string CountryCode { get; set; }
    public string Communication { get; set; }
    public string MembershipType { get; set; }
    public string MembershipNumber { get; set; }
    public string LegalCompany { get; set; }
    public string KeywordType { get; set; }
    public string Keyword { get; set; }
    public string LoginUserName { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string RelationshipListFlg { get; set; }
    public string RelationshipType { get; set; }
    public string RelatedToNameType { get; set; }
    public string RelatedToNameCode { get; set; }
    public string RelatedToName { get; set; }
    public string RelatedToNameFirst { get; set; }
    public string RelatedFrHostNameId { get; set; }
    public string RelatedFrClientNameId { get; set; }
    public decimal? MaxRecReturned { get; set; }
    public string ExtAccnameYn { get; set; }
    public string AccountType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileLookupRequests>(entity =>
        {
            entity.HasKey(e => e.RequestId)
                .HasName("PLT_PK");

            entity.ToTable("PROFILE_LOOKUP_REQUESTS");

            entity.HasIndex(e => e.InsertDate)
                .HasName("PROF_LOOKUP_REQ_IDX1");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Communication)
                .HasColumnName("COMMUNICATION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExtAccnameYn)
                .HasColumnName("EXT_ACCNAME_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Keyword)
                .HasColumnName("KEYWORD")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.KeywordType)
                .HasColumnName("KEYWORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LegalCompany)
                .HasColumnName("LEGAL_COMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LoginUserName)
                .HasColumnName("LOGIN_USER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MaxRecReturned)
                .HasColumnName("MAX_REC_RETURNED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipNumber)
                .HasColumnName("MEMBERSHIP_NUMBER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameCode)
                .HasColumnName("NAME_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RelatedFrClientNameId)
                .HasColumnName("RELATED_FR_CLIENT_NAME_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RelatedFrHostNameId)
                .HasColumnName("RELATED_FR_HOST_NAME_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RelatedToName)
                .HasColumnName("RELATED_TO_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RelatedToNameCode)
                .HasColumnName("RELATED_TO_NAME_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RelatedToNameFirst)
                .HasColumnName("RELATED_TO_NAME_FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RelatedToNameType)
                .HasColumnName("RELATED_TO_NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipListFlg)
                .HasColumnName("RELATIONSHIP_LIST_FLG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipType)
                .HasColumnName("RELATIONSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
