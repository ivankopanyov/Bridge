namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArFolioDetail
{
    public decimal? AccountCode { get; set; }
    public string AccountName { get; set; }
    public DateTime PostDate { get; set; }
    public DateTime BusinessDate { get; set; }
    public string GuestName { get; set; }
    public decimal? GuestNameId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string Remark { get; set; }
    public string Room { get; set; }
    public decimal TrxNo { get; set; }
    public DateTime? DepDate { get; set; }
    public DateTime? DepTime { get; set; }
    public decimal? Invoice { get; set; }
    public decimal? FolioNo { get; set; }
    public string InvoiceType { get; set; }
    public decimal? CashierId { get; set; }
    public string CashierName { get; set; }
    public decimal? OrgAmt { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Aropen { get; set; }
    public string Reference { get; set; }
    public string DepartmentCode { get; set; }
    public DateTime? TrasferDate { get; set; }
    public string AdjustYn { get; set; }
    public string TclCode1 { get; set; }
    public string TclCode2 { get; set; }
    public decimal? RoomCharge { get; set; }
    public string InvStatus { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal? Price { get; set; }
    public decimal? Qty { get; set; }
    public string Currency { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? EuroExchangeRate { get; set; }
    public decimal? BillNumber { get; set; }
    public decimal? RevisionNumber { get; set; }
    public string FolioType { get; set; }
    public string MarketCode { get; set; }
    public string SourceCode { get; set; }
    public string RoomClass { get; set; }
    public decimal? CreditCardId { get; set; }
    public string CreditCardExpDate { get; set; }
    public string CreditCardNo { get; set; }
    public string FiscalBillNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArFolioDetail>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_FOLIO_DETAIL");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AdjustYn)
                .HasColumnName("ADJUST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aropen)
                .HasColumnName("AROPEN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNumber)
                .HasColumnName("BILL_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierName)
                .HasColumnName("CASHIER_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardExpDate)
                .HasColumnName("CREDIT_CARD_EXP_DATE")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardNo)
                .HasColumnName("CREDIT_CARD_NO")
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .IsRequired()
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepDate)
                .HasColumnName("DEP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepTime)
                .HasColumnName("DEP_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartmentCode)
                .IsRequired()
                .HasColumnName("DEPARTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EuroExchangeRate)
                .HasColumnName("EURO_EXCHANGE_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER(38,12)");

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

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvStatus)
                .HasColumnName("INV_STATUS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Invoice)
                .HasColumnName("INVOICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceType)
                .HasColumnName("INVOICE_TYPE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrgAmt)
                .HasColumnName("ORG_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Paid)
                .HasColumnName("PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostDate)
                .HasColumnName("POST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Qty)
                .HasColumnName("QTY")
                .HasColumnType("NUMBER(12,3)");

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevisionNumber)
                .HasColumnName("REVISION_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCharge)
                .HasColumnName("ROOM_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TclCode1)
                .HasColumnName("TCL_CODE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TclCode2)
                .HasColumnName("TCL_CODE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrasferDate)
                .HasColumnName("TRASFER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
