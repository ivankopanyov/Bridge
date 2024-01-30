namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LocationLookupV
{
    public string? LocCode { get; set; }
    public string? Type { get; set; }
    public string? ConcatCode { get; set; }
    public string? LocationDesc { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LocationLookupV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LOCATION_LOOKUP_V");

            entity.Property(e => e.ConcatCode)
                .HasColumnName("CONCAT_CODE")
                .HasMaxLength(21)
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
