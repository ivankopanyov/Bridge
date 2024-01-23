namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidRateTier
{
    public string Resort { get; set; }
    public decimal TierId { get; set; }
    public decimal FromLos { get; set; }
    public decimal? ToLos { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidRateTier>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_RATE_TIER");

            entity.Property(e => e.FromLos)
                .HasColumnName("FROM_LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TierId)
                .HasColumnName("TIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToLos)
                .HasColumnName("TO_LOS")
                .HasColumnType("NUMBER");
        });
	}
}
