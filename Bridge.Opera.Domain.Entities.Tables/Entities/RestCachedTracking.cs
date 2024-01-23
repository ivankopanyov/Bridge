namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RestCachedTracking
{
    public string Resort { get; set; }
    public DateTime LastUpdateTime { get; set; }
    public decimal LastUpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RestCachedTracking>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("REST_CACHED_TRACKING");

            entity.HasIndex(e => e.Resort)
                .HasName("REST_CACHED_TRACKING_IDX");

            entity.Property(e => e.LastUpdateTime)
                .HasColumnName("LAST_UPDATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.LastUpdateUser)
                .HasColumnName("LAST_UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
