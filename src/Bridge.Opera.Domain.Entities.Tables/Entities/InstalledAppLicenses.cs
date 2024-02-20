namespace Bridge.Opera.Domain.Entities.Tables;

public partial class InstalledAppLicenses
{
    public string? Application { get; set; }
    public string? Resort { get; set; }
    public string? ResortName { get; set; }
    public decimal? NumberRooms { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string? LicenseCode { get; set; }
    public string? ProductCode { get; set; }
    public decimal? NoOfChains { get; set; }
    public string? ActiveYn { get; set; }

    public virtual InstalledApp ApplicationNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InstalledAppLicenses>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INSTALLED_APP_LICENSES");

            entity.HasIndex(e => e.Resort)
                .HasName("INS_APP_RESORT_FK_I");

            entity.HasIndex(e => new { e.Application, e.Resort })
                .HasName("INS_APP_LIC_UK")
                .IsUnique();

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

            entity.Property(e => e.ExpiryDate)
                .HasColumnName("EXPIRY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LicenseCode)
                .HasColumnName("LICENSE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NoOfChains)
                .HasColumnName("NO_OF_CHAINS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberRooms)
                .HasColumnName("NUMBER_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProductCode)
                .HasColumnName("PRODUCT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResortName)
                .HasColumnName("RESORT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

			if (!types.Contains(typeof(InstalledApp)))
				entity.Ignore(e => e.ApplicationNavigation);
			else
	            entity.HasOne(d => d.ApplicationNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.Application)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("INST_APP_LIC_FK");
        });
	}
}
