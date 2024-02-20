namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RoomStatisticsView
{
    public string? Resort { get; set; }
    public DateTime? StatDate { get; set; }
    public string? RoomsSynchronizedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomStatisticsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ROOM_STATISTICS_VIEW");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomsSynchronizedYn)
                .HasColumnName("ROOMS_SYNCHRONIZED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.StatDate)
                .HasColumnName("STAT_DATE")
                .HasColumnType("DATE");
        });
	}
}
