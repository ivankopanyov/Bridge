namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArStatementDetails
{
    public decimal? AccountCode { get; set; }
    public decimal? NameId { get; set; }
    public string Room { get; set; }
    public string GuestName { get; set; }
    public string Remark { get; set; }
    public string Reference { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? Payments { get; set; }
    public decimal? InvoiceAmount { get; set; }
    public decimal? InvoiceNumber { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? BillNo { get; set; }
    public decimal? Paid { get; set; }
    public DateTime? BillingDate { get; set; }
    public DateTime? BillingDateTime { get; set; }
    public decimal? OpenBalance { get; set; }
    public decimal? ArDebit { get; set; }
    public decimal? ArCredit { get; set; }
    public decimal? RunningTotal { get; set; }
    public string ReminderStyle { get; set; }
    public decimal? TranActionId { get; set; }
    public decimal? InvoiceAge { get; set; }
    public decimal? Aging1 { get; set; }
    public decimal? Aging2 { get; set; }
    public decimal? Aging3 { get; set; }
    public decimal? Aging4 { get; set; }
    public decimal? Aging5 { get; set; }
    public decimal? Aging6 { get; set; }
    public decimal? AmtAging1 { get; set; }
    public decimal? AmtAging2 { get; set; }
    public decimal? AmtAging3 { get; set; }
    public decimal? AmtAging4 { get; set; }
    public decimal? AmtAging5 { get; set; }
    public decimal? AmtAging6 { get; set; }
    public decimal? PrintedInvAmount { get; set; }
    public decimal? PrintedPaid { get; set; }
    public decimal? PrintedOpenBalance { get; set; }
    public decimal? PrintedAging1 { get; set; }
    public decimal? PrintedAging2 { get; set; }
    public decimal? PrintedAging3 { get; set; }
    public decimal? PrintedAging4 { get; set; }
    public decimal? PrintedAging5 { get; set; }
    public decimal? PrintedAging6 { get; set; }
    public string PrintedCurrency { get; set; }
    public string PrintedExchInfo { get; set; }
    public string PrintedExchRate { get; set; }
    public string Currency { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? EuroExchangeRate { get; set; }
    public string CurrFormatMask { get; set; }
    public DateTime? UpdDate { get; set; }
    public DateTime? TrnsActivityDate { get; set; }
    public decimal? TrnsFromAcct { get; set; }
    public decimal? TrnsToAcct { get; set; }
    public decimal? LineBalance { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? FolioView { get; set; }
    public string BillingContactName { get; set; }
    public string ExternalReference { get; set; }
    public string CustomReference { get; set; }
    public string TaRecordLocator { get; set; }
    public string PrintedYn { get; set; }
    public DateTime? DepartureDate { get; set; }
    public decimal? StatementNo { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public string PurgeYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArStatementDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_STATEMENT_DETAILS");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging1)
                .HasColumnName("AGING1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging2)
                .HasColumnName("AGING2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging3)
                .HasColumnName("AGING3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging4)
                .HasColumnName("AGING4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging5)
                .HasColumnName("AGING5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging6)
                .HasColumnName("AGING6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmtAging1)
                .HasColumnName("AMT_AGING1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmtAging2)
                .HasColumnName("AMT_AGING2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmtAging3)
                .HasColumnName("AMT_AGING3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmtAging4)
                .HasColumnName("AMT_AGING4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmtAging5)
                .HasColumnName("AMT_AGING5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmtAging6)
                .HasColumnName("AMT_AGING6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArCredit)
                .HasColumnName("AR_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArDebit)
                .HasColumnName("AR_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillingContactName)
                .HasColumnName("BILLING_CONTACT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.BillingDate)
                .HasColumnName("BILLING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillingDateTime)
                .HasColumnName("BILLING_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.CurrFormatMask)
                .HasColumnName("CURR_FORMAT_MASK")
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CustomReference)
                .HasColumnName("CUSTOM_REFERENCE")
                .IsUnicode(false);

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EuroExchangeRate)
                .HasColumnName("EURO_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalReference)
                .HasColumnName("EXTERNAL_REFERENCE")
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
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

            entity.Property(e => e.LineBalance)
                .HasColumnName("LINE_BALANCE")
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

            entity.Property(e => e.PrintedAging1)
                .HasColumnName("PRINTED_AGING1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintedAging2)
                .HasColumnName("PRINTED_AGING2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintedAging3)
                .HasColumnName("PRINTED_AGING3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintedAging4)
                .HasColumnName("PRINTED_AGING4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintedAging5)
                .HasColumnName("PRINTED_AGING5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintedAging6)
                .HasColumnName("PRINTED_AGING6")
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

            entity.Property(e => e.PrintedYn)
                .HasColumnName("PRINTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PurgeYn)
                .HasColumnName("PURGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ReminderStyle)
                .HasColumnName("REMINDER_STYLE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RunningTotal)
                .HasColumnName("RUNNING_TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatementNo)
                .HasColumnName("STATEMENT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaRecordLocator)
                .HasColumnName("TA_RECORD_LOCATOR")
                .IsUnicode(false);

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrnsActivityDate)
                .HasColumnName("TRNS_ACTIVITY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrnsFromAcct)
                .HasColumnName("TRNS_FROM_ACCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrnsToAcct)
                .HasColumnName("TRNS_TO_ACCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdDate)
                .HasColumnName("UPD_DATE")
                .HasColumnType("DATE");
        });
	}
}
