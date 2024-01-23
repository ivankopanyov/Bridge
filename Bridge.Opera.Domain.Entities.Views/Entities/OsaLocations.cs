namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OsaLocations
{
    public string Resort { get; set; }
    public string LocationCode { get; set; }
    public string Description { get; set; }
    public string ActiveYn { get; set; }
    public string UsedInApp { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OsaLocations>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OSA_LOCATIONS");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LocationCode)
                .IsRequired()
                .HasColumnName("LOCATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UsedInApp)
                .IsRequired()
                .HasColumnName("USED_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
