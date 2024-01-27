namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DemoSequenceAttributes
{
    public string SequenceName { get; set; }
    public decimal? CacheSize { get; set; }
    public decimal? LastNumber { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DemoSequenceAttributes>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("DEMO_SEQUENCE_ATTRIBUTES");

            entity.Property(e => e.CacheSize)
                .HasColumnName("CACHE_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastNumber)
                .HasColumnName("LAST_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SequenceName)
                .HasColumnName("SEQUENCE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
