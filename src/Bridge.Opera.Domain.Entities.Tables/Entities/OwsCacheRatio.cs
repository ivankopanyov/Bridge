namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OwsCacheRatio
{
    public string? Resort { get; set; }
    public string? Channel { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public decimal? Nights { get; set; }
    public string? DataInfo { get; set; }
    public DateTime? LastUpdateTimestamp { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OwsCacheRatio>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OWS_CACHE_RATIO");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Channel)
                .IsRequired()
                .HasColumnName("CHANNEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DataInfo)
                .HasColumnName("DATA_INFO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LastUpdateTimestamp)
                .HasColumnName("LAST_UPDATE_TIMESTAMP")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
