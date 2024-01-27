namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DphBlockComparison
{
    public string PropertyCode { get; set; }
    public string DelphiId { get; set; }
    public string ReservationId { get; set; }
    public string BookingName { get; set; }
    public string AllotmentDate { get; set; }
    public string RoomType { get; set; }
    public string NoRoomsBlocked { get; set; }
    public string HoldAllMarketSegments { get; set; }
    public string MktSegmentToHold { get; set; }
    public string Dummy { get; set; }
    public string BlockControlFlag { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DphBlockComparison>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DPH_BLOCK_COMPARISON");

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.BlockControlFlag)
                .HasColumnName("BLOCK_CONTROL_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BookingName)
                .HasColumnName("BOOKING_NAME")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.DelphiId)
                .HasColumnName("DELPHI_ID")
                .HasMaxLength(54)
                .IsUnicode(false);

            entity.Property(e => e.Dummy)
                .HasColumnName("DUMMY")
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.HoldAllMarketSegments)
                .HasColumnName("HOLD_ALL_MARKET_SEGMENTS")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.MktSegmentToHold)
                .HasColumnName("MKT_SEGMENT_TO_HOLD")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.NoRoomsBlocked)
                .HasColumnName("NO_ROOMS_BLOCKED")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.ReservationId)
                .HasColumnName("RESERVATION_ID")
                .HasMaxLength(45)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(60)
                .IsUnicode(false);
        });
	}
}
