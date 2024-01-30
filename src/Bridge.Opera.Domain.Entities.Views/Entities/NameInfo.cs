namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NameInfo
{
    public decimal? NameId { get; set; }
    public string? NameCode { get; set; }
    public string? Company { get; set; }
    public string? First { get; set; }
    public string? Last { get; set; }
    public string? Name2 { get; set; }
    public string? Name3 { get; set; }
    public string? Position { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? ZipCode { get; set; }
    public decimal? PhoneId { get; set; }
    public string? Phone { get; set; }
    public string? PhoneType { get; set; }
    public decimal? FaxId { get; set; }
    public string? Fax { get; set; }
    public decimal? EmailId { get; set; }
    public string? Email { get; set; }
    public string? Title { get; set; }
    public string? Salutation { get; set; }
    public string? LetterGreeting { get; set; }
    public string? Xfirst { get; set; }
    public string? Xlast { get; set; }
    public string? Xcompany { get; set; }
    public string? Xtitle { get; set; }
    public string? AddressType { get; set; }
    public string? EnvelopeGreeting { get; set; }
    public string? XenvelopeGreeting { get; set; }
    public decimal? WebPageId { get; set; }
    public string? WebPage { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NAME_INFO");

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AddressType)
                .HasColumnName("ADDRESS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.EmailId)
                .HasColumnName("EMAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EnvelopeGreeting)
                .HasColumnName("ENVELOPE_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Fax)
                .HasColumnName("FAX")
                .IsUnicode(false);

            entity.Property(e => e.FaxId)
                .HasColumnName("FAX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Last)
                .HasColumnName("LAST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LetterGreeting)
                .HasColumnName("LETTER_GREETING")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.Name2)
                .HasColumnName("NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Name3)
                .HasColumnName("NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameCode)
                .HasColumnName("NAME_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Phone)
                .HasColumnName("PHONE")
                .IsUnicode(false);

            entity.Property(e => e.PhoneId)
                .HasColumnName("PHONE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneType)
                .HasColumnName("PHONE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Position)
                .HasColumnName("POSITION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Salutation)
                .HasColumnName("SALUTATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.WebPage)
                .HasColumnName("WEB_PAGE")
                .IsUnicode(false);

            entity.Property(e => e.WebPageId)
                .HasColumnName("WEB_PAGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Xcompany)
                .HasColumnName("XCOMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.XenvelopeGreeting)
                .HasColumnName("XENVELOPE_GREETING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Xfirst)
                .HasColumnName("XFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Xlast)
                .HasColumnName("XLAST")
                .HasMaxLength(40)
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
