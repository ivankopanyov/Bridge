namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PassbyArFolioDetailV
{
    public decimal? ResvNameIdDetail { get; set; }
    public decimal? SourceResvNameId { get; set; }
    public decimal? FolioNoDetail { get; set; }
    public decimal? BillNumberDetail { get; set; }
    public decimal? RevisionNumberDetail { get; set; }
    public decimal? WindowNo { get; set; }
    public string? FolioStyle { get; set; }
    public string? PhoneDetails { get; set; }
    public string? RoomNumberDetail { get; set; }
    public string? TrxDate { get; set; }
    public string? TransactionCode { get; set; }
    public decimal? Quantity { get; set; }
    public string? Reference { get; set; }
    public string? Description { get; set; }
    public string? Supplement { get; set; }
    public string? Debit { get; set; }
    public string? Credit { get; set; }
    public string? EuroDebit { get; set; }
    public string? EuroCredit { get; set; }
    public string? ExchangeRate { get; set; }
    public string? DetailCurrencyDebit { get; set; }
    public string? DetailCurrencyCredit { get; set; }
    public string? DetailCurrency { get; set; }
    public decimal? DetailCurrencyExchangeRt { get; set; }
    public string? CcApprovalCode { get; set; }
    public DateTime? ExpiryDateDetail { get; set; }
    public string? CurrencyDetail { get; set; }
    public decimal? ExchRate { get; set; }
    public decimal? EuroExchRate { get; set; }
    public decimal? PostedAmount { get; set; }
    public string? CurrFormatMask { get; set; }
    public string? Refinvo { get; set; }
    public string? ChequeNumber { get; set; }
    public string? NetAmount { get; set; }
    public string? GrossAmount { get; set; }
    public string? EuroNetAmount { get; set; }
    public string? EuroGrossAmount { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? TranActionId { get; set; }
    public DateTime? DirectTrxDate { get; set; }
    public decimal? FolioViewDetail { get; set; }
    public decimal? DirectDebit { get; set; }
    public decimal? DirectCredit { get; set; }
    public decimal? DirectEuroDebit { get; set; }
    public decimal? DirectEuroCredit { get; set; }
    public decimal? DirectDetailCurrencyDebit { get; set; }
    public decimal? DirectDetailCurrencyCredit { get; set; }
    public decimal? DirectNetAmount { get; set; }
    public decimal? DirectGross { get; set; }
    public decimal? DirectEuroNet { get; set; }
    public decimal? DirectEuroGross { get; set; }
    public string? RecordType { get; set; }
    public string? SourceRoomNumber { get; set; }
    public string? TrxCodeType { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? TargetResort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PassbyArFolioDetailV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PASSBY_AR_FOLIO_DETAIL_V");

            entity.Property(e => e.BillNumberDetail)
                .HasColumnName("BILL_NUMBER_DETAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcApprovalCode)
                .HasColumnName("CC_APPROVAL_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ChequeNumber)
                .HasColumnName("CHEQUE_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Credit)
                .HasColumnName("CREDIT")
                .IsUnicode(false);

            entity.Property(e => e.CurrFormatMask)
                .HasColumnName("CURR_FORMAT_MASK")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyDetail)
                .HasColumnName("CURRENCY_DETAIL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Debit)
                .HasColumnName("DEBIT")
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DetailCurrency)
                .HasColumnName("DETAIL_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DetailCurrencyCredit)
                .HasColumnName("DETAIL_CURRENCY_CREDIT")
                .IsUnicode(false);

            entity.Property(e => e.DetailCurrencyDebit)
                .HasColumnName("DETAIL_CURRENCY_DEBIT")
                .IsUnicode(false);

            entity.Property(e => e.DetailCurrencyExchangeRt)
                .HasColumnName("DETAIL_CURRENCY_EXCHANGE_RT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectCredit)
                .HasColumnName("DIRECT_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectDebit)
                .HasColumnName("DIRECT_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectDetailCurrencyCredit)
                .HasColumnName("DIRECT_DETAIL_CURRENCY_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectDetailCurrencyDebit)
                .HasColumnName("DIRECT_DETAIL_CURRENCY_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectEuroCredit)
                .HasColumnName("DIRECT_EURO_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectEuroDebit)
                .HasColumnName("DIRECT_EURO_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectEuroGross)
                .HasColumnName("DIRECT_EURO_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectEuroNet)
                .HasColumnName("DIRECT_EURO_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectGross)
                .HasColumnName("DIRECT_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectNetAmount)
                .HasColumnName("DIRECT_NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectTrxDate)
                .HasColumnName("DIRECT_TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EuroCredit)
                .HasColumnName("EURO_CREDIT")
                .IsUnicode(false);

            entity.Property(e => e.EuroDebit)
                .HasColumnName("EURO_DEBIT")
                .IsUnicode(false);

            entity.Property(e => e.EuroExchRate)
                .HasColumnName("EURO_EXCH_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EuroGrossAmount)
                .HasColumnName("EURO_GROSS_AMOUNT")
                .IsUnicode(false);

            entity.Property(e => e.EuroNetAmount)
                .HasColumnName("EURO_NET_AMOUNT")
                .IsUnicode(false);

            entity.Property(e => e.ExchRate)
                .HasColumnName("EXCH_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExpiryDateDetail)
                .HasColumnName("EXPIRY_DATE_DETAIL")
                .HasColumnType("DATE");

            entity.Property(e => e.FolioNoDetail)
                .HasColumnName("FOLIO_NO_DETAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioStyle)
                .HasColumnName("FOLIO_STYLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FolioViewDetail)
                .HasColumnName("FOLIO_VIEW_DETAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .IsUnicode(false);

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .IsUnicode(false);

            entity.Property(e => e.PhoneDetails)
                .HasColumnName("PHONE_DETAILS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Refinvo)
                .HasColumnName("REFINVO")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameIdDetail)
                .HasColumnName("RESV_NAME_ID_DETAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevisionNumberDetail)
                .HasColumnName("REVISION_NUMBER_DETAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNumberDetail)
                .HasColumnName("ROOM_NUMBER_DETAIL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceResvNameId)
                .HasColumnName("SOURCE_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceRoomNumber)
                .HasColumnName("SOURCE_ROOM_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Supplement)
                .HasColumnName("SUPPLEMENT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TargetResort)
                .HasColumnName("TARGET_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransactionCode)
                .HasColumnName("TRANSACTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeType)
                .HasColumnName("TRX_CODE_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.WindowNo)
                .HasColumnName("WINDOW_NO")
                .HasColumnType("NUMBER");
        });
	}
}
