namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsSdReservationSummary
{
    public decimal? Id { get; set; }
    public string RecType { get; set; }
    public decimal? CalId { get; set; }
    public decimal? MatchId { get; set; }
    public string GraphType { get; set; }
    public string IdType { get; set; }
    public string Resort { get; set; }
    public DateTime? StayDate { get; set; }
    public string YieldCategory { get; set; }
    public string BookingClass { get; set; }
    public string SeriesCode { get; set; }
    public decimal? Maxrnk { get; set; }
    public decimal? Rooms { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsSdReservationSummary>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_SD_RESERVATION_SUMMARY");

            entity.Property(e => e.BookingClass)
                .HasColumnName("BOOKING_CLASS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CalId)
                .HasColumnName("CAL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GraphType)
                .HasColumnName("GRAPH_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IdType)
                .HasColumnName("ID_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MatchId)
                .HasColumnName("MATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Maxrnk)
                .HasColumnName("MAXRNK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecType)
                .HasColumnName("REC_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Rooms)
                .HasColumnName("ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SeriesCode)
                .HasColumnName("SERIES_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
