namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpMembershipScc
{
    public decimal? ExportId { get; set; }
    public decimal? RowSequence { get; set; }
    public string ExportType { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? ResvNameId { get; set; }
    public string PropertyCode { get; set; }
    public string ConfirmationNo { get; set; }
    public string LoyaltyMemberNo { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public decimal? LoyaltyTotalNights { get; set; }
    public decimal? AverageRoomRate { get; set; }
    public decimal? AverageRoomRateLoyalty { get; set; }
    public decimal? TotalRevenue { get; set; }
    public string GuestCountryCode { get; set; }
    public string CurrencyCode { get; set; }
    public DateTime? TransmitDate { get; set; }
    public string LoyaltyMemberType { get; set; }
    public string ReservationStatus { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpMembershipScc>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_MEMBERSHIP_SCC");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AverageRoomRate)
                .HasColumnName("AVERAGE_ROOM_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AverageRoomRateLoyalty)
                .HasColumnName("AVERAGE_ROOM_RATE_LOYALTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

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

            entity.Property(e => e.GuestCountryCode)
                .HasColumnName("GUEST_COUNTRY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyMemberNo)
                .HasColumnName("LOYALTY_MEMBER_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyMemberType)
                .HasColumnName("LOYALTY_MEMBER_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LoyaltyTotalNights)
                .HasColumnName("LOYALTY_TOTAL_NIGHTS")
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

            entity.Property(e => e.RowSequence)
                .HasColumnName("ROW_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransmitDate)
                .HasColumnName("TRANSMIT_DATE")
                .HasColumnType("DATE");
        });
	}
}
