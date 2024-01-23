namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class QrushView
{
    public string AvgTimeActual { get; set; }
    public string AvgTimeCurrent { get; set; }
    public decimal? TotalRoomsInQueue { get; set; }
    public string Overview { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QrushView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QRUSH_VIEW");

            entity.Property(e => e.AvgTimeActual)
                .HasColumnName("AVG_TIME_ACTUAL")
                .IsUnicode(false);

            entity.Property(e => e.AvgTimeCurrent)
                .HasColumnName("AVG_TIME_CURRENT")
                .IsUnicode(false);

            entity.Property(e => e.Overview)
                .HasColumnName("OVERVIEW")
                .IsUnicode(false);

            entity.Property(e => e.TotalRoomsInQueue)
                .HasColumnName("TOTAL_ROOMS_IN_QUEUE")
                .HasColumnType("NUMBER");
        });
	}
}
