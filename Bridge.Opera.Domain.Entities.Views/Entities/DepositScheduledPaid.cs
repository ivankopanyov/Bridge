namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DepositScheduledPaid
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal GuestNameId { get; set; }
    public string GuestName { get; set; }
    public string GuestFirstName { get; set; }
    public string SguestName { get; set; }
    public string ConfirmationNo { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public string Room { get; set; }
    public string RoomCategory { get; set; }
    public string DepositResort { get; set; }
    public decimal? ResvDepositScheduleId { get; set; }
    public DateTime? DepositDueDate { get; set; }
    public decimal? CreditCardId { get; set; }
    public string PaymentMethod { get; set; }
    public string ResvStatus { get; set; }
    public string XlastName { get; set; }
    public string XfirstName { get; set; }
    public string GuaranteeCode { get; set; }
    public string ComputedResvStatus { get; set; }
    public decimal? DepositAmount { get; set; }
    public decimal? DepositTotal { get; set; }
    public decimal? DepositTotalCnt { get; set; }
    public decimal? PaidTotal { get; set; }
    public decimal? PaidTotalCnt { get; set; }
    public decimal? PaidCreditCardId { get; set; }
    public decimal? PaidDeposit { get; set; }
    public decimal? PaidAddTotal { get; set; }
    public decimal? DepositUnpaidTotal { get; set; }
    public string ExtTrxId { get; set; }
    public DateTime? CancellationDate { get; set; }
    public DateTime? PostingDate { get; set; }
    public string ExtSysResultMsg { get; set; }
    public string RateCode { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public DateTime? BusinessDateCreated { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DepositScheduledPaid>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DEPOSIT_SCHEDULED_PAID");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositAmount)
                .HasColumnName("DEPOSIT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositDueDate)
                .HasColumnName("DEPOSIT_DUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepositResort)
                .HasColumnName("DEPOSIT_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepositTotal)
                .HasColumnName("DEPOSIT_TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositTotalCnt)
                .HasColumnName("DEPOSIT_TOTAL_CNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositUnpaidTotal)
                .HasColumnName("DEPOSIT_UNPAID_TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtSysResultMsg)
                .HasColumnName("EXT_SYS_RESULT_MSG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExtTrxId)
                .HasColumnName("EXT_TRX_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
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

            entity.Property(e => e.PaidAddTotal)
                .HasColumnName("PAID_ADD_TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaidCreditCardId)
                .HasColumnName("PAID_CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaidDeposit)
                .HasColumnName("PAID_DEPOSIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaidTotal)
                .HasColumnName("PAID_TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaidTotalCnt)
                .HasColumnName("PAID_TOTAL_CNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PostingDate)
                .HasColumnName("POSTING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvDepositScheduleId)
                .HasColumnName("RESV_DEPOSIT_SCHEDULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.XfirstName)
                .HasColumnName("XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.XlastName)
                .HasColumnName("XLAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
