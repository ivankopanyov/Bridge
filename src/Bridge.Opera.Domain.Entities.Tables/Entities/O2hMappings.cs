namespace Bridge.Opera.Domain.Entities.Tables;

public partial class O2hMappings
{
    public decimal? MapId { get; set; }
    public decimal? SourceId { get; set; }
    public decimal? TargetId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<O2hMappings>(entity =>
        {
            entity.HasKey(e => new { e.MapId, e.SourceId })
                .HasName("O2H_MAPPINGS_PK");

            entity.ToTable("O2H_MAPPINGS");

            entity.Property(e => e.MapId)
                .HasColumnName("MAP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TargetId)
                .HasColumnName("TARGET_ID")
                .HasColumnType("NUMBER");
        });
	}
}
