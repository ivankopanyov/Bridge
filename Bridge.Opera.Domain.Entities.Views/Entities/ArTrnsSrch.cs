namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArTrnsSrch
{
    public decimal? AccountCode { get; set; }
    public string AccountName { get; set; }
    public string AccountSname { get; set; }
    public string XaccountSname { get; set; }
    public string AccountNo { get; set; }
    public DateTime? InvoiceDate { get; set; }
    public decimal? TrxNo { get; set; }
    public string GuestName { get; set; }
    public string XguestName { get; set; }
    public decimal? NameId { get; set; }
    public decimal? InvoiceNo { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? OrgAmt { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Balance { get; set; }
    public string AdjustYn { get; set; }
    public string PaymentRef { get; set; }
    public string Remark { get; set; }
    public decimal? CashierId { get; set; }
    public string CashierName { get; set; }
    public DateTime? DepartureDate { get; set; }
    public string Room { get; set; }
    public string TrxCode { get; set; }
    public string DepartureTime { get; set; }
    public DateTime? TransferDate { get; set; }
    public decimal? TranActionId { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? TrnsActivityDate { get; set; }
    public decimal? TrnsFromAcct { get; set; }
    public decimal? TrnsToAcct { get; set; }
    public decimal? BillNo { get; set; }
    public string FiscalBillNo { get; set; }
    public string AccTypeFlag { get; set; }
    public decimal? MasterInvoiceNo { get; set; }
    public string FolioType { get; set; }
    public decimal? AddresseeNameId { get; set; }
    public string AddresseeName { get; set; }
    public string XaddresseeName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArTrnsSrch>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_TRNS_SRCH");

            entity.Property(e => e.AccTypeFlag)
                .HasColumnName("ACC_TYPE_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .IsRequired()
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountSname)
                .HasColumnName("ACCOUNT_SNAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AddresseeName)
                .HasColumnName("ADDRESSEE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AddresseeNameId)
                .HasColumnName("ADDRESSEE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdjustYn)
                .HasColumnName("ADJUST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierName)
                .HasColumnName("CASHIER_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureTime)
                .HasColumnName("DEPARTURE_TIME")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.FiscalBillNo)
                .HasColumnName("FISCAL_BILL_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InvoiceDate)
                .HasColumnName("INVOICE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterInvoiceNo)
                .HasColumnName("MASTER_INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrgAmt)
                .HasColumnName("ORG_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Paid)
                .HasColumnName("PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentRef)
                .HasColumnName("PAYMENT_REF")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransferDate)
                .HasColumnName("TRANSFER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrnsActivityDate)
                .HasColumnName("TRNS_ACTIVITY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrnsFromAcct)
                .HasColumnName("TRNS_FROM_ACCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrnsToAcct)
                .HasColumnName("TRNS_TO_ACCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.XaccountSname)
                .HasColumnName("XACCOUNT_SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.XaddresseeName)
                .HasColumnName("XADDRESSEE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.XguestName)
                .HasColumnName("XGUEST_NAME")
                .IsUnicode(false);
        });
	}
}
