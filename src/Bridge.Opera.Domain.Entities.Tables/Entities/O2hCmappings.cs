namespace Bridge.Opera.Domain.Entities.Tables;

public partial class O2hCmappings
{
    public decimal? MapId { get; set; }
    public string? SourceId { get; set; }
    public string? TargetId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<O2hCmappings>(entity =>
        {
            entity.HasKey(e => new { e.MapId, e.SourceId })
                .HasName("O2H_CMAPPINGS_PK");

            entity.ToTable("O2H_CMAPPINGS");

            entity.Property(e => e.MapId)
                .HasColumnName("MAP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TargetId)
                .HasColumnName("TARGET_ID")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
