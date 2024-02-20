namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DateScale
{
    public DateTime? D { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DateScale>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DATE_SCALE");

            entity.Property(e => e.D).HasColumnType("DATE");
        });
	}
}
