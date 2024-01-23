namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RoomsLocationsView
{
    public string ConcatDesc { get; set; }
    public string LocCode { get; set; }
    public string Type { get; set; }
    public string LocationDesc { get; set; }
    public string Resort { get; set; }
    public string ApplicableToPmYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomsLocationsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ROOMS_LOCATIONS_VIEW");

            entity.Property(e => e.ApplicableToPmYn)
                .HasColumnName("APPLICABLE_TO_PM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConcatDesc)
                .HasColumnName("CONCAT_DESC")
                .HasMaxLength(82)
                .IsUnicode(false);

            entity.Property(e => e.LocCode)
                .HasColumnName("LOC_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LocationDesc)
                .HasColumnName("LOCATION_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasColumnType("CHAR(1)");
        });
	}
}
