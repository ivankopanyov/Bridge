namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortCountry
{
    public string? CountryCode { get; set; }
    public string? Resort { get; set; }
    public string? GuestAddressFormat { get; set; }
    public string? StatisticCode { get; set; }
    public string? RegionCode { get; set; }
    public decimal? ShowSequence { get; set; }
    public decimal? PrintSequence { get; set; }
    public string? CountryMainGroup { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? CountryName { get; set; }
    public string? AddressdoctorMode { get; set; }
    public string? DisplayCountryFlagYn { get; set; }

    public virtual Country CountryCodeNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortCountry>(entity =>
        {
            entity.HasKey(e => new { e.CountryCode, e.Resort })
                .HasName("RESORT_COUNTRY_PK");

            entity.ToTable("RESORT_COUNTRY");

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AddressdoctorMode)
                .HasColumnName("ADDRESSDOCTOR_MODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryMainGroup)
                .HasColumnName("COUNTRY_MAIN_GROUP")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CountryName)
                .HasColumnName("COUNTRY_NAME")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplayCountryFlagYn)
                .HasColumnName("DISPLAY_COUNTRY_FLAG_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GuestAddressFormat)
                .HasColumnName("GUEST_ADDRESS_FORMAT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrintSequence)
                .HasColumnName("PRINT_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShowSequence)
                .HasColumnName("SHOW_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StatisticCode)
                .HasColumnName("STATISTIC_CODE")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(Country)))
				entity.Ignore(e => e.CountryCodeNavigation);
			else
	            entity.HasOne(d => d.CountryCodeNavigation)
	                .WithMany(p => p.ResortCountry)
	                .HasForeignKey(d => d.CountryCode)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RCC_FK");
        });
	}
}
