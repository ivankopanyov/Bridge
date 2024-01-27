namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiDateTable
{
    public DateTime DayId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiDateTable>(entity =>
        {
            entity.HasKey(e => e.DayId)
                .HasName("OBI_DATE_PK");

            entity.ToTable("OBI_DATE_TABLE");

            entity.Property(e => e.DayId)
                .HasColumnName("DAY_ID")
                .HasColumnType("DATE");
        });
	}
}
