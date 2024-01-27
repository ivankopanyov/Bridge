namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Tlpdbver
{
    public int? Ndbversion { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Tlpdbver>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TLPDBVER");

            entity.Property(e => e.Ndbversion)
                .HasColumnName("NDBVERSION")
                .HasColumnType("NUMBER(6)");
        });
	}
}
