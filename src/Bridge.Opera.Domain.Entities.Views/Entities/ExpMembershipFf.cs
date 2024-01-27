namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpMembershipFf
{
    public decimal? ExportId { get; set; }
    public decimal? RowSequence { get; set; }
    public string ExportType { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? ResvNameId { get; set; }
    public string GuestLastName { get; set; }
    public string GuestFirstName { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public decimal? RoomNightsTotal { get; set; }
    public string AirlineMemberType { get; set; }
    public string AirlineMemberNo { get; set; }
    public decimal? AirlineTotalPoints { get; set; }
    public decimal? AirlineBonusPoints { get; set; }
    public string ReservationStatus { get; set; }
    public string PropertyCode { get; set; }
    public decimal? LoyaltyTotalPoints { get; set; }
    public decimal? LoyaltyBonusPoints { get; set; }
    public string LoyaltyMemberType { get; set; }
    public string LoyaltyMemberNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpMembershipFf>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_MEMBERSHIP_FF");

            entity.Property(e => e.AirlineBonusPoints)
                .HasColumnName("AIRLINE_BONUS_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AirlineMemberNo)
                .HasColumnName("AIRLINE_MEMBER_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AirlineMemberType)
                .HasColumnName("AIRLINE_MEMBER_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AirlineTotalPoints)
                .HasColumnName("AIRLINE_TOTAL_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportType)
                .HasColumnName("EXPORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestLastName)
                .HasColumnName("GUEST_LAST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyBonusPoints)
                .HasColumnName("LOYALTY_BONUS_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LoyaltyMemberNo)
                .HasColumnName("LOYALTY_MEMBER_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyMemberType)
                .HasColumnName("LOYALTY_MEMBER_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyTotalPoints)
                .HasColumnName("LOYALTY_TOTAL_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReservationStatus)
                .HasColumnName("RESERVATION_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNightsTotal)
                .HasColumnName("ROOM_NIGHTS_TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowSequence)
                .HasColumnName("ROW_SEQUENCE")
                .HasColumnType("NUMBER");
        });
	}
}
