namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FinCashierRep
{
    public string RepType { get; set; }
    public string Resort { get; set; }
    public decimal? TrxNo { get; set; }
    public string TcGroup { get; set; }
    public string TcSubgroup { get; set; }
    public string TrxCode { get; set; }
    public string TrxDesc { get; set; }
    public string Remark { get; set; }
    public string Currency { get; set; }
    public string LocalCurrency { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? CashierId { get; set; }
    public DateTime? TrxDate { get; set; }
    public string GuestName { get; set; }
    public string RoomNo { get; set; }
    public decimal? CashierDebit { get; set; }
    public decimal? CashierCredit { get; set; }
    public decimal? CreditAmt { get; set; }
    public decimal? DebitAmt { get; set; }
    public decimal? LocalCurrCreditAmt { get; set; }
    public decimal? LocalCurrDebitAmt { get; set; }
    public decimal? PostedAmount { get; set; }
    public string Time { get; set; }
    public decimal? FolioNumber { get; set; }
    public decimal? UserId { get; set; }
    public string CreditCardNumberStr { get; set; }
    public string CreditCardExpDateStr { get; set; }
    public string AppUser { get; set; }
    public decimal? ServiceTax { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FinCashierRep>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIN_CASHIER_REP");

            entity.Property(e => e.AppUser)
                .HasColumnName("APP_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CashierCredit)
                .HasColumnName("CASHIER_CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.CashierDebit)
                .HasColumnName("CASHIER_DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditAmt)
                .HasColumnName("CREDIT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardExpDateStr)
                .HasColumnName("CREDIT_CARD_EXP_DATE_STR")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNumberStr)
                .HasColumnName("CREDIT_CARD_NUMBER_STR")
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DebitAmt)
                .HasColumnName("DEBIT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNumber)
                .HasColumnName("FOLIO_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.LocalCurrCreditAmt)
                .HasColumnName("LOCAL_CURR_CREDIT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocalCurrDebitAmt)
                .HasColumnName("LOCAL_CURR_DEBIT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocalCurrency)
                .HasColumnName("LOCAL_CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RepType)
                .HasColumnName("REP_TYPE")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomNo)
                .HasColumnName("ROOM_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ServiceTax)
                .HasColumnName("SERVICE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TcGroup)
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Time)
                .HasColumnName("TIME")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxDesc)
                .HasColumnName("TRX_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER");
        });
	}
}
