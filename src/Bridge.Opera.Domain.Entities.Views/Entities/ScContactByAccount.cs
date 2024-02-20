namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScContactByAccount
{
    public decimal? AccountId { get; set; }
    public string? AccountName { get; set; }
    public string? AccountSname { get; set; }
    public string? AccountCity { get; set; }
    public string? AccountPhone { get; set; }
    public string? AccountType { get; set; }
    public string? AccountIata { get; set; }
    public decimal? ContactId { get; set; }
    public string? ContactName { get; set; }
    public string? PrimaryYn { get; set; }
    public string? ContactFirst { get; set; }
    public string? ContactLast { get; set; }
    public string? ContactYn { get; set; }
    public string? ConActiveYn { get; set; }
    public string? ContactSname { get; set; }
    public string? ContactSxname { get; set; }
    public string? ContactPhone { get; set; }
    public string? ContactCity { get; set; }
    public string? Relationship { get; set; }
    public string? RelationshipDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScContactByAccount>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_CONTACT_BY_ACCOUNT");

            entity.Property(e => e.AccountCity)
                .HasColumnName("ACCOUNT_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccountIata)
                .HasColumnName("ACCOUNT_IATA")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountPhone)
                .HasColumnName("ACCOUNT_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.AccountSname)
                .IsRequired()
                .HasColumnName("ACCOUNT_SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountType)
                .IsRequired()
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConActiveYn)
                .HasColumnName("CON_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ContactCity)
                .HasColumnName("CONTACT_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactFirst)
                .HasColumnName("CONTACT_FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactId)
                .HasColumnName("CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContactLast)
                .HasColumnName("CONTACT_LAST")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactName)
                .HasColumnName("CONTACT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactPhone)
                .HasColumnName("CONTACT_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.ContactSname)
                .IsRequired()
                .HasColumnName("CONTACT_SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactSxname)
                .HasColumnName("CONTACT_SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ContactYn)
                .IsRequired()
                .HasColumnName("CONTACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Relationship)
                .IsRequired()
                .HasColumnName("RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RelationshipDesc)
                .HasColumnName("RELATIONSHIP_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
