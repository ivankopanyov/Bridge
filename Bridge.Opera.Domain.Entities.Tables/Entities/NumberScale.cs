namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NumberScale
{
    public decimal N { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NumberScale>(entity =>
        {
            entity.HasKey(e => e.N)
                .HasName("SYS_IOT_TOP_130889");

            entity.ToTable("NUMBER_SCALE");

            entity.Property(e => e.N).HasColumnType("NUMBER");
        });
	}
}
