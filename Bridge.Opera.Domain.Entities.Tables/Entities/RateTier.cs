namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateTier
{
    public string Resort { get; set; }
    public decimal TierId { get; set; }
    public decimal FromLos { get; set; }
    public decimal? ToLos { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateTier>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TierId })
                .HasName("RATE_TIER_PK");

            entity.ToTable("RATE_TIER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TierId)
                .HasColumnName("TIER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FromLos)
                .HasColumnName("FROM_LOS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ToLos)
                .HasColumnName("TO_LOS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
