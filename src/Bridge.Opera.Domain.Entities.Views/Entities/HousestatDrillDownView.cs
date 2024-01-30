namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HousestatDrillDownView
{
    public string? Code { get; set; }
    public string? Description { get; set; }
    public decimal? NoOfRooms { get; set; }
    public decimal? NoOfPersons { get; set; }
    public decimal? NoOfVips { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HousestatDrillDownView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HOUSESTAT_DRILL_DOWN_VIEW");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NoOfPersons)
                .HasColumnName("NO_OF_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfVips)
                .HasColumnName("NO_OF_VIPS")
                .HasColumnType("NUMBER");
        });
	}
}
