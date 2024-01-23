namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidInstalledAppLicensesSys
{
    public string Application { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidInstalledAppLicensesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_INSTALLED_APP_LICENSES_SYS");

            entity.Property(e => e.Application)
                .IsRequired()
                .HasColumnName("APPLICATION")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
