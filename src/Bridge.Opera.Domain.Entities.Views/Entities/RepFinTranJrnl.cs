namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepFinTranJrnl
{
    public string? Resort { get; set; }
    public decimal? TrxNo { get; set; }
    public string? ActionFormatDate { get; set; }
    public string? ActionDate { get; set; }
    public string? ActionTime { get; set; }
    public decimal? FinActionId { get; set; }
    public string? FinActionEvent { get; set; }
    public decimal? CashierId { get; set; }
    public string? Room { get; set; }
    public string? RoomNo { get; set; }
    public decimal? CashierCredit { get; set; }
    public decimal? CashierDebit { get; set; }
    public decimal? RevenueAmt { get; set; }
    public string? TrxCode { get; set; }
    public string? TrxCodeNo { get; set; }
    public string? TrxDesc { get; set; }
    public decimal? NameId { get; set; }
    public string? FinActionDesc { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Arrival { get; set; }
    public string? ArrivalTime { get; set; }
    public decimal? Nights { get; set; }
    public string? Departure { get; set; }
    public string? DepartureTime { get; set; }
    public string? PaymentMethod { get; set; }
    public string? FullName { get; set; }
    public string? RoomCategoryLabel { get; set; }
    public string? MarketCode { get; set; }
    public string? Remark { get; set; }
    public decimal? GuestCredit { get; set; }
    public decimal? GuestDebit { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepFinTranJrnl>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_FIN_TRAN_JRNL");

            entity.Property(e => e.ActionDate)
                .HasColumnName("ACTION_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ActionFormatDate)
                .HasColumnName("ACTION_FORMAT_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ActionTime)
                .HasColumnName("ACTION_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalTime)
                .HasColumnName("ARRIVAL_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CashierCredit)
                .HasColumnName("CASHIER_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.CashierDebit)
                .HasColumnName("CASHIER_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.DepartureTime)
                .HasColumnName("DEPARTURE_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FinActionDesc)
                .HasColumnName("FIN_ACTION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FinActionEvent)
                .IsRequired()
                .HasColumnName("FIN_ACTION_EVENT")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FinActionId)
                .HasColumnName("FIN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GuestCredit)
                .HasColumnName("GUEST_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GuestDebit)
                .HasColumnName("GUEST_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueAmt)
                .HasColumnName("REVENUE_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.RoomNo)
                .HasColumnName("ROOM_NO")
                .HasMaxLength(36)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeNo)
                .HasColumnName("TRX_CODE_NO")
                .HasMaxLength(36)
                .IsUnicode(false);

            entity.Property(e => e.TrxDesc)
                .HasColumnName("TRX_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
