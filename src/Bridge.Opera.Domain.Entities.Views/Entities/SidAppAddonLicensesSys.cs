namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidAppAddonLicensesSys
{
    public string Application { get; set; }
    public string LicName { get; set; }
    public string LicDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidAppAddonLicensesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_APP_ADDON_LICENSES_SYS");

            entity.Property(e => e.Application)
                .IsRequired()
                .HasColumnName("APPLICATION")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.LicDesc)
                .HasColumnName("LIC_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LicName)
                .HasColumnName("LIC_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
