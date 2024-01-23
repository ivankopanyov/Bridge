namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TimezoneRegions
{
    public string TimezoneRegion { get; set; }
    public string Description { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TimezoneRegions>(entity =>
        {
            entity.HasKey(e => e.TimezoneRegion)
                .HasName("TIMEZONE_REGIONS_PK");

            entity.ToTable("TIMEZONE_REGIONS");

            entity.Property(e => e.TimezoneRegion)
                .HasColumnName("TIMEZONE_REGION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");
        });
	}
}
