namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidInstalledAppLicenses
{
    public string? Application { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidInstalledAppLicenses>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_INSTALLED_APP_LICENSES");

            entity.Property(e => e.Application)
                .IsRequired()
                .HasColumnName("APPLICATION")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
