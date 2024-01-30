namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ReservationStaysDailySold
{
    public string? Resort { get; set; }
    public DateTime? ReservationDate { get; set; }
    public string? RoomCategory { get; set; }
    public decimal? TransientResvDeduct { get; set; }
    public decimal? TransientResvNonDeduct { get; set; }
    public decimal? BlockResvDeduct { get; set; }
    public decimal? BlockResvNonDeduct { get; set; }
    public decimal? StayCount { get; set; }
    public decimal? ReservationCount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationStaysDailySold>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESERVATION_STAYS_DAILY_SOLD");

            entity.Property(e => e.BlockResvDeduct)
                .HasColumnName("BLOCK_RESV_DEDUCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockResvNonDeduct)
                .HasColumnName("BLOCK_RESV_NON_DEDUCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationCount)
                .HasColumnName("RESERVATION_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StayCount)
                .HasColumnName("STAY_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransientResvDeduct)
                .HasColumnName("TRANSIENT_RESV_DEDUCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransientResvNonDeduct)
                .HasColumnName("TRANSIENT_RESV_NON_DEDUCT")
                .HasColumnType("NUMBER");
        });
	}
}
