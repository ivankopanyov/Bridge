namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IsoCountryCodes
{
    public string? Country { get; set; }
    public string? CharCode2 { get; set; }
    public string? CharCode3 { get; set; }
    public string? NumCode3 { get; set; }
    public string? TextMessageYn { get; set; }
    public decimal? CountryDialingCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IsoCountryCodes>(entity =>
        {
            entity.HasKey(e => e.CharCode2)
                .HasName("ISO_COUNTRY_CODES_PK");

            entity.ToTable("ISO_COUNTRY_CODES");

            entity.Property(e => e.CharCode2)
                .HasColumnName("CHAR_CODE2")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.CharCode3)
                .HasColumnName("CHAR_CODE3")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .IsRequired()
                .HasColumnName("COUNTRY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CountryDialingCode)
                .HasColumnName("COUNTRY_DIALING_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumCode3)
                .HasColumnName("NUM_CODE3")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.TextMessageYn)
                .HasColumnName("TEXT_MESSAGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
