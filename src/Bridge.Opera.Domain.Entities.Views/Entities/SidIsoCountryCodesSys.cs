namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidIsoCountryCodesSys
{
    public string? Country { get; set; }
    public string? CharCode2 { get; set; }
    public string? CharCode3 { get; set; }
    public string? NumCode3 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidIsoCountryCodesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_ISO_COUNTRY_CODES_SYS");

            entity.Property(e => e.CharCode2)
                .IsRequired()
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

            entity.Property(e => e.NumCode3)
                .HasColumnName("NUM_CODE3")
                .HasMaxLength(3)
                .IsUnicode(false);
        });
	}
}
