namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidMenuApplications
{
    public string Resort { get; set; }
    public string ApplicationName { get; set; }
    public string Description { get; set; }
    public string ConfigurableYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidMenuApplications>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_MENU_APPLICATIONS");

            entity.Property(e => e.ApplicationName)
                .IsRequired()
                .HasColumnName("APPLICATION_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConfigurableYn)
                .HasColumnName("CONFIGURABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
