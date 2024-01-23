namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiHourDim
{
    public string AllDates { get; set; }
    public string AllDatesDesc { get; set; }
    public string ObiHour { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiHourDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_HOUR_DIM");

            entity.Property(e => e.AllDates)
                .HasColumnName("ALL_DATES")
                .IsUnicode(false);

            entity.Property(e => e.AllDatesDesc)
                .HasColumnName("ALL_DATES_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ObiHour)
                .HasColumnName("OBI_HOUR")
                .HasMaxLength(6)
                .IsUnicode(false);
        });
	}
}
