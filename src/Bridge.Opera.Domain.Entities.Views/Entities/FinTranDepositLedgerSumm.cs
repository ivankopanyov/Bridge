namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FinTranDepositLedgerSumm
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public string GuestName { get; set; }
    public string GuestFirstName { get; set; }
    public string RoomCategory { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public decimal? Persons { get; set; }
    public string ConfirmationNo { get; set; }
    public decimal? TotalDepositAmt { get; set; }
    public decimal? TotalPaidAmt { get; set; }
    public DateTime? LastPaidDate { get; set; }
    public string SguestName { get; set; }
    public string ResvStatus { get; set; }
    public string XfirstName { get; set; }
    public string XlastName { get; set; }
    public string PaymentMethod { get; set; }
    public string GuaranteeCode { get; set; }
    public string ComputedResvStatus { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FinTranDepositLedgerSumm>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIN_TRAN_DEPOSIT_LEDGER_SUMM");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

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

            entity.Property(e => e.LastPaidDate)
                .HasColumnName("LAST_PAID_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Persons)
                .HasColumnName("PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .IsUnicode(false);

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TotalDepositAmt)
                .HasColumnName("TOTAL_DEPOSIT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPaidAmt)
                .HasColumnName("TOTAL_PAID_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
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
