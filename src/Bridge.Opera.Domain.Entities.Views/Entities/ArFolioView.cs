namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArFolioView
{
    public string? Resort { get; set; }
    public string? FolioStyle { get; set; }
    public decimal? AccountCode { get; set; }
    public string? AccountName { get; set; }
    public decimal? NameId { get; set; }
    public decimal? TranActionId { get; set; }
    public decimal? InvoiceNo { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? TrxNo { get; set; }
    public string? TcGroup { get; set; }
    public string? TcSubgroup { get; set; }
    public string? TrxCode { get; set; }
    public string? TrxDesc { get; set; }
    public string? FtGeneratedType { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? FtSubtype { get; set; }
    public DateTime? TrxDate { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? PricePerUnit { get; set; }
    public decimal? Amount { get; set; }
    public string? Currency { get; set; }
    public int? FolioView { get; set; }
    public string? Remark { get; set; }
    public string? Reference { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? UpdatedBy { get; set; }
    public string? TclCode1 { get; set; }
    public string? TclCode2 { get; set; }
    public decimal? CashierId { get; set; }
    public string? CashierName { get; set; }
    public DateTime? TransferDate { get; set; }
    public string? InvStatus { get; set; }
    public decimal? BillNumber { get; set; }
    public decimal? RevisionNumber { get; set; }
    public decimal? ArLedDebit { get; set; }
    public string? FolioType { get; set; }
    public decimal? BillNo { get; set; }
    public string? MarketCode { get; set; }
    public string? SourceCode { get; set; }
    public string? RoomClass { get; set; }
    public string? ChequeNumber { get; set; }
    public string? ArChargeTransferYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArFolioView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_FOLIO_VIEW");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArChargeTransferYn)
                .HasColumnName("AR_CHARGE_TRANSFER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ArLedDebit)
                .HasColumnName("AR_LED_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
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
                .IsUnicode(false);

            entity.Property(e => e.ChequeNumber)
                .HasColumnName("CHEQUE_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioStyle)
                .HasColumnName("FOLIO_STYLE")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER(9)");

            entity.Property(e => e.FtGeneratedType)
                .HasColumnName("FT_GENERATED_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FtSubtype)
                .HasColumnName("FT_SUBTYPE")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.InvStatus)
                .HasColumnName("INV_STATUS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PricePerUnit)
                .HasColumnName("PRICE_PER_UNIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER(12,3)");

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevisionNumber)
                .HasColumnName("REVISION_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcGroup)
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .HasColumnName("TC_SUBGROUP")
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

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransferDate)
                .HasColumnName("TRANSFER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxDesc)
                .HasColumnName("TRX_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdatedBy)
                .HasColumnName("UPDATED_BY")
                .IsUnicode(false);
        });
	}
}
