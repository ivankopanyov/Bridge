namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsHistoryDatesVw
{
    public string? Resort { get; set; }
    public DateTime? TruncArrivalDate { get; set; }
    public decimal? BookingClassId { get; set; }
    public DateTime? HistoryArrivalDate { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? Rn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsHistoryDatesVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_HISTORY_DATES_VW");

            entity.Property(e => e.BookingClassId)
                .HasColumnName("BOOKING_CLASS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HistoryArrivalDate)
                .HasColumnName("HISTORY_ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Rn)
                .HasColumnName("RN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TruncArrivalDate)
                .HasColumnName("TRUNC_ARRIVAL_DATE")
                .HasColumnType("DATE");
        });
	}
}
