namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TaGuestCommissions
{
    public decimal? CommissionId { get; set; }
    public string? Resort { get; set; }
    public decimal? TravelAgentId { get; set; }
    public decimal? ResvNameId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? NameId { get; set; }
    public string? NameType { get; set; }
    public string? ManualEditYn { get; set; }
    public string? ResvStatus { get; set; }
    public string? GuestName { get; set; }
    public string? SguestName { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string? CommCode { get; set; }
    public string? CommissionHoldCode { get; set; }
    public string? CommissionHoldDesc { get; set; }
    public decimal? PaymentId { get; set; }
    public string? CommType { get; set; }
    public string? Currency { get; set; }
    public string? ManualResvYn { get; set; }
    public string? PpdRemarks { get; set; }
    public string? PpdEditYn { get; set; }
    public string? CommCodeDiffYn { get; set; }
    public decimal? CommissionRevenue { get; set; }
    public decimal? CommissionAmount { get; set; }
    public decimal? GrossCommAmt { get; set; }
    public decimal? VatAmount { get; set; }
    public decimal? PrepaidComm { get; set; }
    public decimal? ARAmount { get; set; }
    public string? GuestLastName { get; set; }
    public string? GuestFirstName { get; set; }
    public string? GuestDisplayName { get; set; }
    public string? GuestTax1No { get; set; }
    public string? ConfirmationNo { get; set; }
    public decimal? Nights { get; set; }
    public DateTime? BookingDate { get; set; }
    public string? CommissionHoldRemarks { get; set; }
    public string? ArYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaGuestCommissions>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TA_GUEST_COMMISSIONS");

            entity.Property(e => e.ARAmount)
                .HasColumnName("A_R_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArYn)
                .HasColumnName("AR_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookingDate)
                .HasColumnName("BOOKING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CommCode)
                .HasColumnName("COMM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommCodeDiffYn)
                .HasColumnName("COMM_CODE_DIFF_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CommType)
                .HasColumnName("COMM_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.CommissionAmount)
                .HasColumnName("COMMISSION_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionHoldCode)
                .HasColumnName("COMMISSION_HOLD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommissionHoldDesc)
                .HasColumnName("COMMISSION_HOLD_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CommissionHoldRemarks)
                .HasColumnName("COMMISSION_HOLD_REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CommissionId)
                .HasColumnName("COMMISSION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionRevenue)
                .HasColumnName("COMMISSION_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GrossCommAmt)
                .HasColumnName("GROSS_COMM_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestDisplayName)
                .HasColumnName("GUEST_DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestLastName)
                .HasColumnName("GUEST_LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.GuestTax1No)
                .HasColumnName("GUEST_TAX1_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ManualEditYn)
                .HasColumnName("MANUAL_EDIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ManualResvYn)
                .HasColumnName("MANUAL_RESV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentId)
                .HasColumnName("PAYMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PpdEditYn)
                .HasColumnName("PPD_EDIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PpdRemarks)
                .HasColumnName("PPD_REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PrepaidComm)
                .HasColumnName("PREPAID_COMM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VatAmount)
                .HasColumnName("VAT_AMOUNT")
                .HasColumnType("NUMBER");
        });
	}
}
