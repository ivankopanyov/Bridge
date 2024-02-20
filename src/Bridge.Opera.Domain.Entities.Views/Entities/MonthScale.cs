namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MonthScale
{
    public decimal? M { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MonthScale>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MONTH_SCALE");

            entity.Property(e => e.M).HasColumnType("NUMBER");
        });
	}
}
