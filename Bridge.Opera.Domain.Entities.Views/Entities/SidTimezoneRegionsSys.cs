namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidTimezoneRegionsSys
{
    public string TimezoneRegion { get; set; }
    public string Description { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidTimezoneRegionsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_TIMEZONE_REGIONS_SYS");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TimezoneRegion)
                .IsRequired()
                .HasColumnName("TIMEZONE_REGION")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
