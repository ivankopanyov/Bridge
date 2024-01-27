namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GtempCashierClose
{
    public string Resort { get; set; }
    public string ResortCurrency { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string Currency { get; set; }
    public decimal? ExpectCashierBalance { get; set; }
    public decimal? ActualCashierBalance { get; set; }
    public decimal? CashierCredit { get; set; }
    public decimal? CashierDebit { get; set; }
    public decimal? CashierOpeningBalance { get; set; }
    public decimal? ToGeneralCashier { get; set; }
    public string TrxType { get; set; }
    public string TrxCode { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? CashierId { get; set; }
    public decimal? ClosureNo { get; set; }
    public decimal? CashierCreditLocal { get; set; }
    public decimal? CashierDebitLocal { get; set; }
    public decimal? ToGeneralCashierLocal { get; set; }
    public decimal? ExpectCashierBalanceLocal { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GtempCashierClose>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GTEMP_CASHIER_CLOSE");

            entity.HasIndex(e => new { e.Resort, e.Currency, e.TrxType })
                .HasName("GTEMP_CASHIER_CLOSE_IDX1");

            entity.Property(e => e.ActualCashierBalance)
                .HasColumnName("ACTUAL_CASHIER_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CashierCredit)
                .HasColumnName("CASHIER_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierCreditLocal)
                .HasColumnName("CASHIER_CREDIT_LOCAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierDebit)
                .HasColumnName("CASHIER_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierDebitLocal)
                .HasColumnName("CASHIER_DEBIT_LOCAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierOpeningBalance)
                .HasColumnName("CASHIER_OPENING_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClosureNo)
                .HasColumnName("CLOSURE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectCashierBalance)
                .HasColumnName("EXPECT_CASHIER_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectCashierBalanceLocal)
                .HasColumnName("EXPECT_CASHIER_BALANCE_LOCAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortCurrency)
                .HasColumnName("RESORT_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToGeneralCashier)
                .HasColumnName("TO_GENERAL_CASHIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToGeneralCashierLocal)
                .HasColumnName("TO_GENERAL_CASHIER_LOCAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxType)
                .HasColumnName("TRX_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);
        });
	}
}
