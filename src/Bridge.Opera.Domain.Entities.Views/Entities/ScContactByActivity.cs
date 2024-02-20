namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScContactByActivity
{
    public string? Type { get; set; }
    public decimal? ActId { get; set; }
    public string? ActResort { get; set; }
    public string? PrimaryYn { get; set; }
    public decimal? ContactId { get; set; }
    public string? Name { get; set; }
    public string? ContactOwner { get; set; }
    public string? ContactOwnerName { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    public string? Country { get; set; }
    public string? PhoneNumber { get; set; }
    public string? ActiveYn { get; set; }
    public string? LetterGreeting { get; set; }
    public string? ContactBusinessGreeting { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScContactByActivity>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_CONTACT_BY_ACTIVITY");

            entity.Property(e => e.ActId)
                .HasColumnName("ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActResort)
                .HasColumnName("ACT_RESORT")
                .HasMaxLength(20)
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

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContactBusinessGreeting)
                .HasColumnName("CONTACT_BUSINESS_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactId)
                .HasColumnName("CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContactOwner)
                .HasColumnName("CONTACT_OWNER")
                .IsUnicode(false);

            entity.Property(e => e.ContactOwnerName)
                .HasColumnName("CONTACT_OWNER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LetterGreeting)
                .HasColumnName("LETTER_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNumber)
                .HasColumnName("PHONE_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
