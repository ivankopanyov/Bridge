namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AutoFolioSettleView
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal? Balance { get; set; }
    public decimal GuestNameId { get; set; }
    public string Room { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public string GuestName { get; set; }
    public string GuestFirstName { get; set; }
    public DateTime? LastSettleDate { get; set; }
    public decimal? AutoSettleDays { get; set; }
    public string CanAutoSettleYn { get; set; }
    public string DirectBillBatchType { get; set; }
    public string AutoSettleYn { get; set; }
    public string ConfirmationNo { get; set; }
    public decimal? DaysSinceLastSettle { get; set; }
    public string RateCode { get; set; }
    public DateTime ReservationDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AutoFolioSettleView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AUTO_FOLIO_SETTLE_VIEW");

            entity.Property(e => e.AutoSettleDays)
                .HasColumnName("AUTO_SETTLE_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AutoSettleYn)
                .HasColumnName("AUTO_SETTLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CanAutoSettleYn)
                .HasColumnName("CAN_AUTO_SETTLE_YN")
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DaysSinceLastSettle)
                .HasColumnName("DAYS_SINCE_LAST_SETTLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectBillBatchType)
                .HasColumnName("DIRECT_BILL_BATCH_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastSettleDate)
                .HasColumnName("LAST_SETTLE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");
        });
	}
}
