namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PrimeNumbers
{
    public decimal PrimeNumber { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PrimeNumbers>(entity =>
        {
            entity.HasKey(e => e.PrimeNumber)
                .HasName("PN_PK");

            entity.ToTable("PRIME_NUMBERS");

            entity.Property(e => e.PrimeNumber)
                .HasColumnName("PRIME_NUMBER")
                .HasColumnType("NUMBER");
        });
	}
}
