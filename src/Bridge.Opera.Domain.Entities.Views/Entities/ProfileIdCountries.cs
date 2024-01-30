namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ProfileIdCountries
{
    public string? CountryCode { get; set; }
    public string? CountryName { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileIdCountries>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PROFILE_ID_COUNTRIES");

            entity.Property(e => e.CountryCode)
                .IsRequired()
                .HasColumnName("COUNTRY_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CountryName)
                .HasColumnName("COUNTRY_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
