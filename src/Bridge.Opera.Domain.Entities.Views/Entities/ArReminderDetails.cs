namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArReminderDetails
{
    public decimal? AccountCode { get; set; }
    public decimal? AccountTypeId { get; set; }
    public decimal? NameId { get; set; }
    public string? Room { get; set; }
    public string? GuestName { get; set; }
    public string? Remark { get; set; }
    public decimal? InvoiceAge { get; set; }
    public decimal? PostedAmount { get; set; }
    public decimal? Payments { get; set; }
    public decimal? InvoiceAmount { get; set; }
    public decimal? InvoiceNumber { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? Paid { get; set; }
    public DateTime? BillingDate { get; set; }
    public DateTime? TransferDate { get; set; }
    public decimal? OpenBalance { get; set; }
    public string? Currency { get; set; }
    public string? ReminderStyle { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? EuroExchangeRate { get; set; }
    public decimal? PrintedInvAmount { get; set; }
    public decimal? PrintedPaid { get; set; }
    public decimal? PrintedOpenBalance { get; set; }
    public string? PrintedCurrency { get; set; }
    public string? PrintedExchInfo { get; set; }
    public string? PrintedExchRate { get; set; }
    public decimal? BillNumber { get; set; }
    public decimal? ReminderCycle { get; set; }
    public DateTime? ReminderDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArReminderDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_REMINDER_DETAILS");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountTypeId)
                .HasColumnName("ACCOUNT_TYPE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNumber)
                .HasColumnName("BILL_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillingDate)
                .HasColumnName("BILLING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.EuroExchangeRate)
                .HasColumnName("EURO_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InvoiceAge)
                .HasColumnName("INVOICE_AGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceAmount)
                .HasColumnName("INVOICE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceNumber)
                .HasColumnName("INVOICE_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpenBalance)
                .HasColumnName("OPEN_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Paid)
                .HasColumnName("PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Payments)
                .HasColumnName("PAYMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintedCurrency)
                .HasColumnName("PRINTED_CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.PrintedExchInfo)
                .HasColumnName("PRINTED_EXCH_INFO")
                .IsUnicode(false);

            entity.Property(e => e.PrintedExchRate)
                .HasColumnName("PRINTED_EXCH_RATE")
                .IsUnicode(false);

            entity.Property(e => e.PrintedInvAmount)
                .HasColumnName("PRINTED_INV_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintedOpenBalance)
                .HasColumnName("PRINTED_OPEN_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintedPaid)
                .HasColumnName("PRINTED_PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .IsUnicode(false);

            entity.Property(e => e.ReminderCycle)
                .HasColumnName("REMINDER_CYCLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReminderDate)
                .HasColumnName("REMINDER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ReminderStyle)
                .HasColumnName("REMINDER_STYLE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TransferDate)
                .HasColumnName("TRANSFER_DATE")
                .HasColumnType("DATE");
        });
	}
}
