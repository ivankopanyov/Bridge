namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ReceiptHistory
{
    public string Resort { get; set; }
    public string RecptType { get; set; }
    public string RecptTypeDesc { get; set; }
    public decimal? RecptNo { get; set; }
    public string DecodeRecptNo { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? NameId { get; set; }
    public decimal? RecptAmt { get; set; }
    public string DisplayName { get; set; }
    public string FirstName { get; set; }
    public string Sfirst { get; set; }
    public string Sname { get; set; }
    public decimal? TrxNo { get; set; }
    public string Reference { get; set; }
    public string TaxInvNo { get; set; }
    public string PaymentType { get; set; }
    public string XlastName { get; set; }
    public string XfirstName { get; set; }
    public string Xtitle { get; set; }
    public string XfullName { get; set; }
    public string Sxname { get; set; }
    public string SxfirstName { get; set; }
    public string PasserByName { get; set; }
    public string Company { get; set; }
    public decimal? CashierId { get; set; }
    public string Workstation { get; set; }
    public string TrxCode { get; set; }
    public string TrxDesc { get; set; }
    public string Remark { get; set; }
    public string Room { get; set; }
    public string PostingTime { get; set; }
    public string PayeeAddress { get; set; }
    public string PayeeFirstName { get; set; }
    public string PayeeLastName { get; set; }
    public string PayeeName { get; set; }
    public string PayeeName2 { get; set; }
    public string PayeeName3 { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string Name2 { get; set; }
    public string Name3 { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string CurrencyDesc { get; set; }
    public string CcApprovalCode { get; set; }
    public string ConfirmationNo { get; set; }
    public string CreditCardExpDate { get; set; }
    public string CreditCardNo { get; set; }
    public decimal? FolioView { get; set; }
    public string CurrencyCode { get; set; }
    public decimal? XmlActionSeq { get; set; }
    public string CheckExchangeType { get; set; }
    public string MCreditCardNo { get; set; }
    public decimal? ResvNameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReceiptHistory>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RECEIPT_HISTORY");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcApprovalCode)
                .HasColumnName("CC_APPROVAL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CheckExchangeType)
                .HasColumnName("CHECK_EXCHANGE_TYPE")
                .HasMaxLength(11)
                .IsUnicode(false);

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardExpDate)
                .HasColumnName("CREDIT_CARD_EXP_DATE")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNo)
                .HasColumnName("CREDIT_CARD_NO")
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CurrencyDesc)
                .HasColumnName("CURRENCY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.DecodeRecptNo)
                .HasColumnName("DECODE_RECPT_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MCreditCardNo)
                .HasColumnName("M_CREDIT_CARD_NO")
                .IsUnicode(false);

            entity.Property(e => e.MiddleName)
                .HasColumnName("MIDDLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Name2)
                .HasColumnName("NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Name3)
                .HasColumnName("NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PasserByName)
                .HasColumnName("PASSER_BY_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PayeeAddress)
                .HasColumnName("PAYEE_ADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.PayeeFirstName)
                .HasColumnName("PAYEE_FIRST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.PayeeLastName)
                .HasColumnName("PAYEE_LAST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.PayeeName)
                .HasColumnName("PAYEE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.PayeeName2)
                .HasColumnName("PAYEE_NAME2")
                .IsUnicode(false);

            entity.Property(e => e.PayeeName3)
                .HasColumnName("PAYEE_NAME3")
                .IsUnicode(false);

            entity.Property(e => e.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.PostingTime)
                .HasColumnName("POSTING_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.RecptAmt)
                .HasColumnName("RECPT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecptNo)
                .HasColumnName("RECPT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecptType)
                .HasColumnName("RECPT_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.RecptTypeDesc)
                .HasColumnName("RECPT_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .IsUnicode(false);

            entity.Property(e => e.Sfirst)
                .HasColumnName("SFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Sname)
                .HasColumnName("SNAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SxfirstName)
                .HasColumnName("SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Sxname)
                .HasColumnName("SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TaxInvNo)
                .HasColumnName("TAX_INV_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
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

            entity.Property(e => e.Workstation)
                .HasColumnName("WORKSTATION")
                .IsUnicode(false);

            entity.Property(e => e.XfirstName)
                .HasColumnName("XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.XfullName)
                .HasColumnName("XFULL_NAME")
                .HasMaxLength(82)
                .IsUnicode(false);

            entity.Property(e => e.XlastName)
                .HasColumnName("XLAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.XmlActionSeq)
                .HasColumnName("XML_ACTION_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Xtitle)
                .HasColumnName("XTITLE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
