namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OvosPeriodsView
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosPeriodsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OVOS_PERIODS_VIEW");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");
        });
	}
}
