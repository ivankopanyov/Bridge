namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiAwBuildResorts
{
    public decimal? BuildLogId { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiAwBuildResorts>(entity =>
        {
            entity.HasKey(e => new { e.BuildLogId, e.Resort })
                .HasName("OBI_BUILD_RESORTS_PK");

            entity.ToTable("OBI_AW_BUILD_RESORTS");

            entity.Property(e => e.BuildLogId)
                .HasColumnName("BUILD_LOG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
