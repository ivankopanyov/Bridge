namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUpeResvFinancials
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public decimal? CashierId { get; set; }
    public decimal? ArNumber { get; set; }
    public decimal? FromResvId { get; set; }
    public decimal? TbAmountGross { get; set; }
    public decimal? TbAmountNet { get; set; }
    public decimal? TbAmountTax { get; set; }
    public decimal? IsDebit01 { get; set; }
    public decimal? IsCredit01 { get; set; }
    public decimal? GuestAccountDebit { get; set; }
    public decimal? GuestAccountCredit { get; set; }
    public decimal? DepLedDebit { get; set; }
    public decimal? DepLedCredit { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? Persons { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? TaxPercentage { get; set; }
    public decimal? PostitNo { get; set; }
    public decimal? BillNo { get; set; }
    public decimal? RoomCategory { get; set; }
    public string? TrxCode { get; set; }
    public string? TcGroup { get; set; }
    public string? TcSubgroup { get; set; }
    public string? FtSubtype { get; set; }
    public string? TrxType { get; set; }
    public string? Room { get; set; }
    public string? SourceCode { get; set; }
    public string? MarketCode { get; set; }
    public string? MarketMainCode { get; set; }
    public string? Channel { get; set; }
    public string? CountryCode { get; set; }
    public string? CalcFinResvStatus { get; set; }
    public string? PostingType { get; set; }
    public string? Currency { get; set; }
    public string? Covers { get; set; }
    public string? TcTransactionType { get; set; }
    public string? IndCash { get; set; }
    public string? CcTrxFeePct { get; set; }
    public string? TaxElements { get; set; }
    public string? FolioId { get; set; }
    public string? TrxCodeType { get; set; }
    public string? IsPermanentBillingYn { get; set; }
    public string? PermanentBillingId { get; set; }
    public string? AccountNo { get; set; }
    public string? InclInFoliosYn { get; set; }
    public string? InclInFinalFoliosYn { get; set; }
    public string? DepPostingFlag { get; set; }
    public string? IsDepositLedTrxCodeYn { get; set; }
    public string? ChequeNumber { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? TrxDate { get; set; }
    public string? TransactionDescription { get; set; }
    public string? TcGroupDesc { get; set; }
    public string? Reference { get; set; }
    public string? Remark { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUpeResvFinancials>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_UPE_RESV_FINANCIALS");

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CalcFinResvStatus)
                .HasColumnName("CALC_FIN_RESV_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcTrxFeePct)
                .HasColumnName("CC_TRX_FEE_PCT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChequeNumber)
                .HasColumnName("CHEQUE_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Covers)
                .HasColumnName("COVERS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepLedCredit)
                .HasColumnName("DEP_LED_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepLedDebit)
                .HasColumnName("DEP_LED_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepPostingFlag)
                .HasColumnName("DEP_POSTING_FLAG")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioId)
                .HasColumnName("FOLIO_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromResvId)
                .HasColumnName("FROM_RESV_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FtSubtype)
                .HasColumnName("FT_SUBTYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestAccountCredit)
                .HasColumnName("GUEST_ACCOUNT_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestAccountDebit)
                .HasColumnName("GUEST_ACCOUNT_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InclInFinalFoliosYn)
                .HasColumnName("INCL_IN_FINAL_FOLIOS_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InclInFoliosYn)
                .HasColumnName("INCL_IN_FOLIOS_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IndCash)
                .HasColumnName("IND_CASH")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsCredit01)
                .HasColumnName("IS_CREDIT_01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsDebit01)
                .HasColumnName("IS_DEBIT_01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsDepositLedTrxCodeYn)
                .HasColumnName("IS_DEPOSIT_LED_TRX_CODE_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IsPermanentBillingYn)
                .HasColumnName("IS_PERMANENT_BILLING_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketMainCode)
                .HasColumnName("MARKET_MAIN_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PermanentBillingId)
                .HasColumnName("PERMANENT_BILLING_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Persons)
                .HasColumnName("PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostingType)
                .HasColumnName("POSTING_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PostitNo)
                .HasColumnName("POSTIT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxElements)
                .HasColumnName("TAX_ELEMENTS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxPercentage)
                .HasColumnName("TAX_PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TbAmountGross)
                .HasColumnName("TB_AMOUNT_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TbAmountNet)
                .HasColumnName("TB_AMOUNT_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TbAmountTax)
                .HasColumnName("TB_AMOUNT_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TcGroup)
                .HasColumnName("TC_GROUP")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TcGroupDesc)
                .HasColumnName("TC_GROUP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TcTransactionType)
                .HasColumnName("TC_TRANSACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TransactionDescription)
                .HasColumnName("TRANSACTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeType)
                .HasColumnName("TRX_CODE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxType)
                .HasColumnName("TRX_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
