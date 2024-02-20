namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LookupResponseView
{
    public string? ResortNameId { get; set; }
    public decimal? NameId { get; set; }
    public string? NameType { get; set; }
    public string? NameCode { get; set; }
    public string? Name { get; set; }
    public string? FirstName { get; set; }
    public string? AlternateName { get; set; }
    public string? AlternateFirst { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    public string? CountryCode { get; set; }
    public string? Email { get; set; }
    public string? PrimaryPhone { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipNumber { get; set; }
    public string? FrequentFlyerType { get; set; }
    public string? FrequentFlyerNumber { get; set; }
    public string? LegalCompany { get; set; }
    public string? Passport { get; set; }
    public string? IdType { get; set; }
    public string? IdNumber { get; set; }
    public string? RouteDatabaseId { get; set; }
    public string? ActiveYn { get; set; }
    public string? RelatedFrHostNameId { get; set; }
    public string? RelatedFrClientNameId { get; set; }
    public string? RelationshipType { get; set; }
    public string? RelationshipTypeLst { get; set; }
    public string? AccountType { get; set; }
    public string? PrimaryOwnerDisplayName { get; set; }
    public string? PrimaryOwnerId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LookupResponseView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LOOKUP_RESPONSE_VIEW");

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AlternateFirst)
                .HasColumnName("ALTERNATE_FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AlternateName)
                .HasColumnName("ALTERNATE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FrequentFlyerNumber)
                .HasColumnName("FREQUENT_FLYER_NUMBER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FrequentFlyerType)
                .HasColumnName("FREQUENT_FLYER_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IdNumber)
                .HasColumnName("ID_NUMBER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.IdType)
                .HasColumnName("ID_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LegalCompany)
                .HasColumnName("LEGAL_COMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

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
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.NameCode)
                .HasColumnName("NAME_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Passport)
                .HasColumnName("PASSPORT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryOwnerDisplayName)
                .HasColumnName("PRIMARY_OWNER_DISPLAY_NAME")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryOwnerId)
                .HasColumnName("PRIMARY_OWNER_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryPhone)
                .HasColumnName("PRIMARY_PHONE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RelatedFrClientNameId)
                .HasColumnName("RELATED_FR_CLIENT_NAME_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RelatedFrHostNameId)
                .HasColumnName("RELATED_FR_HOST_NAME_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipType)
                .HasColumnName("RELATIONSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipTypeLst)
                .HasColumnName("RELATIONSHIP_TYPE_LST")
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RouteDatabaseId)
                .HasColumnName("ROUTE_DATABASE_ID")
                .HasMaxLength(500)
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
