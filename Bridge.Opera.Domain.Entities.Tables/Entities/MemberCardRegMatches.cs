namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MemberCardRegMatches
{
    public string MemberCardRegCode { get; set; }
    public decimal OcisNameId { get; set; }
    public string DatabaseId { get; set; }
    public string ChainCode { get; set; }
    public string MatchDesc { get; set; }
    public decimal? MatchWeight { get; set; }
    public string ResortNameId { get; set; }
    public string NameType { get; set; }
    public string NameCode { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string AlternateName { get; set; }
    public string AlternateFirst { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string CountryCode { get; set; }
    public string Email { get; set; }
    public string PrimaryPhone { get; set; }
    public string MembershipType { get; set; }
    public string MembershipNumber { get; set; }
    public string FrequentFlyerType { get; set; }
    public string FrequentFlyerNumber { get; set; }
    public string Gender { get; set; }
    public string ProcessingMessage { get; set; }
    public decimal? NameId { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string RouteDatabaseId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberCardRegMatches>(entity =>
        {
            entity.HasKey(e => new { e.MemberCardRegCode, e.OcisNameId, e.DatabaseId })
                .HasName("MEMBER_CARD_REG_MATCHES_PK");

            entity.ToTable("MEMBER_CARD_REG_MATCHES");

            entity.Property(e => e.MemberCardRegCode)
                .HasColumnName("MEMBER_CARD_REG_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OcisNameId)
                .HasColumnName("OCIS_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DatabaseId)
                .HasColumnName("DATABASE_ID")
                .HasMaxLength(20)
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

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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

            entity.Property(e => e.Gender)
                .HasColumnName("GENDER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MatchDesc)
                .HasColumnName("MATCH_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MatchWeight)
                .HasColumnName("MATCH_WEIGHT")
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

            entity.Property(e => e.PrimaryPhone)
                .HasColumnName("PRIMARY_PHONE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ProcessingMessage)
                .HasColumnName("PROCESSING_MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RouteDatabaseId)
                .HasColumnName("ROUTE_DATABASE_ID")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

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
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
