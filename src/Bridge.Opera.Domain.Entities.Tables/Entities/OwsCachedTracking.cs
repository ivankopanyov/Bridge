namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OwsCachedTracking
{
    public string? Resort { get; set; }
    public string? Channel { get; set; }
    public DateTime? LastUpdateTime { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OwsCachedTracking>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Channel })
                .HasName("OWC_PK");

            entity.ToTable("OWS_CACHED_TRACKING");

            entity.HasIndex(e => e.Channel)
                .HasName("OWS_CACHED_IDX1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LastUpdateTime)
                .HasColumnName("LAST_UPDATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
