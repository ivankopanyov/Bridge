namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AppAddonLicenses
{
    public string? Application { get; set; }
    public string? Resort { get; set; }
    public string? ResortName { get; set; }
    public string? LicName { get; set; }
    public string? LicDesc { get; set; }
    public string? LicCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ActiveYn { get; set; }
    public decimal? NoOfLaptops { get; set; }

    public virtual InstalledAppLicenses InstalledAppLicenses { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppAddonLicenses>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("APP_ADDON_LICENSES");

            entity.HasIndex(e => new { e.ActiveYn, e.Resort, e.LicCode })
                .HasName("ADDON_LIC_ACTIVE");

            entity.HasIndex(e => new { e.Application, e.Resort, e.LicName })
                .HasName("APP_LIC_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.LicName, e.ActiveYn })
                .HasName("ADDON_LIC_RESORT");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Application)
                .IsRequired()
                .HasColumnName("APPLICATION")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LicCode)
                .HasColumnName("LIC_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LicDesc)
                .HasColumnName("LIC_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LicName)
                .HasColumnName("LIC_NAME")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoOfLaptops)
                .HasColumnName("NO_OF_LAPTOPS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResortName)
                .HasColumnName("RESORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(InstalledAppLicenses)))
				entity.Ignore(e => e.InstalledAppLicenses);
			else
	            entity.HasOne(d => d.InstalledAppLicenses)
	                .WithMany()
	                .HasPrincipalKey(p => new { p.Application, p.Resort })
	                .HasForeignKey(d => new { d.Application, d.Resort })
	                .HasConstraintName("ADDON_LIC_FK");
        });
	}
}
