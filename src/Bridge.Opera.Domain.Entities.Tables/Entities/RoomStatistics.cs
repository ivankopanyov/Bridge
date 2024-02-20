namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomStatistics
{
    public string? Resort { get; set; }
    public DateTime? StatDate { get; set; }
    public string? RoomsSynchronizedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomStatistics>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.StatDate })
                .HasName("ROOM_STATISTICS_PK");

            entity.ToTable("ROOM_STATISTICS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatDate)
                .HasColumnName("STAT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RoomsSynchronizedYn)
                .HasColumnName("ROOMS_SYNCHRONIZED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
