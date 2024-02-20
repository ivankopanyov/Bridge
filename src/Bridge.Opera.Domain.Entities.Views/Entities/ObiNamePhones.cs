namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiNamePhones
{
    public decimal? NameId { get; set; }
    public string? HomePhoneNumber { get; set; }
    public string? BusinessPhoneNumber { get; set; }
    public string? BusinessExtension { get; set; }
    public string? MobilePhoneNumber { get; set; }
    public string? WebPage { get; set; }
    public string? Email { get; set; }
    public string? EmailFormat { get; set; }
    public string? FaxNo { get; set; }
    public string? PhoneNo { get; set; }
    public string? PhoneType { get; set; }
    public string? PhoneExtension { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiNamePhones>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_NAME_PHONES");

            entity.Property(e => e.BusinessExtension)
                .HasColumnName("BUSINESS_EXTENSION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BusinessPhoneNumber)
                .HasColumnName("BUSINESS_PHONE_NUMBER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EmailFormat)
                .HasColumnName("EMAIL_FORMAT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FaxNo)
                .HasColumnName("FAX_NO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HomePhoneNumber)
                .HasColumnName("HOME_PHONE_NUMBER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MobilePhoneNumber)
                .HasColumnName("MOBILE_PHONE_NUMBER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneExtension)
                .HasColumnName("PHONE_EXTENSION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNo)
                .HasColumnName("PHONE_NO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PhoneType)
                .HasColumnName("PHONE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WebPage)
                .HasColumnName("WEB_PAGE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
