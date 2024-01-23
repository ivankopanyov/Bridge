namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateCachedTracking
{
    public string Resort { get; set; }
    public string RateCode { get; set; }
    public DateTime LastUpdateTime { get; set; }
    public decimal LastUpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateCachedTracking>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateCode })
                .HasName("RATE_CACHED_TRACKING_PK");

            entity.ToTable("RATE_CACHED_TRACKING");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LastUpdateTime)
                .HasColumnName("LAST_UPDATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.LastUpdateUser)
                .HasColumnName("LAST_UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
