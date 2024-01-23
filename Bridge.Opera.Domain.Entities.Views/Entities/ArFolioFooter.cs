namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArFolioFooter
{
    public decimal? InvoiceNumberFooter { get; set; }
    public decimal? BillNumberFooter { get; set; }
    public decimal? RevisionNumberFooter { get; set; }
    public string TotalCredit { get; set; }
    public string TotalDebit { get; set; }
    public string TotalEuroDebit { get; set; }
    public string TotalEuroCredit { get; set; }
    public string TotalEuroBalance { get; set; }
    public decimal? EuroExchangeRate { get; set; }
    public string Balance { get; set; }
    public string SummaryCurrencyDebit { get; set; }
    public string SummaryCurrencyCredit { get; set; }
    public string SummaryBalance { get; set; }
    public string SummaryCurrency { get; set; }
    public decimal? SummaryCurrencyExchangeRt { get; set; }
    public string TotalGross { get; set; }
    public string TotalDiff { get; set; }
    public string TotalEuroGross { get; set; }
    public string TotalEuroDiff { get; set; }
    public string MerchantNumberFooter { get; set; }
    public decimal? DirectTotalCredit { get; set; }
    public decimal? DirectTotalDebit { get; set; }
    public decimal? DirectTotalEuroDebit { get; set; }
    public decimal? DirectTotalEuroCredit { get; set; }
    public decimal? DirectSummaryEuroBalance { get; set; }
    public decimal? DirectBalance { get; set; }
    public decimal? DirectSummaryCurrencyDebit { get; set; }
    public decimal? DirectSummaryCurrencyCredit { get; set; }
    public decimal? DirectSummaryBalance { get; set; }
    public string TotalDebitInWords { get; set; }
    public string TotalCreditInWords { get; set; }
    public string BalanceInWords { get; set; }
    public string ArNumberInFooter { get; set; }
    public string RefInvNumber { get; set; }
    public string MembershipFolioMessage { get; set; }
    public decimal? Deposits { get; set; }
    public decimal? Paidouts { get; set; }
    public decimal? Settlements { get; set; }
    public decimal? TotalBaseExcl { get; set; }
    public decimal? TotalBaseExclEuro { get; set; }
    public decimal? TotalGrossExclvat { get; set; }
    public decimal? TotalGrossExclvatEuro { get; set; }
    public decimal? TotalGrossInclvat { get; set; }
    public decimal? TotalGrossInclvatEuro { get; set; }
    public decimal? TotalNetIncl { get; set; }
    public decimal? TotalNetInclEuro { get; set; }
    public decimal? TotalNonTaxable { get; set; }
    public decimal? TotalNonTaxableEuro { get; set; }
    public decimal? TotalVatExcl { get; set; }
    public decimal? TotalVatExclEuro { get; set; }
    public decimal? TotalVatIncl { get; set; }
    public decimal? TotalVatInclEuro { get; set; }
    public decimal? NonhotelSupplies { get; set; }
    public string TotalNet { get; set; }
    public string TotalEuroNet { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArFolioFooter>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_FOLIO_FOOTER");

            entity.Property(e => e.ArNumberInFooter)
                .HasColumnName("AR_NUMBER_IN_FOOTER")
                .IsUnicode(false);

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .IsUnicode(false);

            entity.Property(e => e.BalanceInWords)
                .HasColumnName("BALANCE_IN_WORDS")
                .IsUnicode(false);

            entity.Property(e => e.BillNumberFooter)
                .HasColumnName("BILL_NUMBER_FOOTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Deposits)
                .HasColumnName("DEPOSITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectBalance)
                .HasColumnName("DIRECT_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectSummaryBalance)
                .HasColumnName("DIRECT_SUMMARY_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectSummaryCurrencyCredit)
                .HasColumnName("DIRECT_SUMMARY_CURRENCY_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectSummaryCurrencyDebit)
                .HasColumnName("DIRECT_SUMMARY_CURRENCY_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectSummaryEuroBalance)
                .HasColumnName("DIRECT_SUMMARY_EURO_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectTotalCredit)
                .HasColumnName("DIRECT_TOTAL_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectTotalDebit)
                .HasColumnName("DIRECT_TOTAL_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectTotalEuroCredit)
                .HasColumnName("DIRECT_TOTAL_EURO_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DirectTotalEuroDebit)
                .HasColumnName("DIRECT_TOTAL_EURO_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EuroExchangeRate)
                .HasColumnName("EURO_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceNumberFooter)
                .HasColumnName("INVOICE_NUMBER_FOOTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipFolioMessage)
                .HasColumnName("MEMBERSHIP_FOLIO_MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.MerchantNumberFooter)
                .HasColumnName("MERCHANT_NUMBER_FOOTER")
                .IsUnicode(false);

            entity.Property(e => e.NonhotelSupplies)
                .HasColumnName("NONHOTEL_SUPPLIES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Paidouts)
                .HasColumnName("PAIDOUTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RefInvNumber)
                .HasColumnName("REF_INV_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RevisionNumberFooter)
                .HasColumnName("REVISION_NUMBER_FOOTER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Settlements)
                .HasColumnName("SETTLEMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SummaryBalance)
                .HasColumnName("SUMMARY_BALANCE")
                .IsUnicode(false);

            entity.Property(e => e.SummaryCurrency)
                .HasColumnName("SUMMARY_CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.SummaryCurrencyCredit)
                .HasColumnName("SUMMARY_CURRENCY_CREDIT")
                .IsUnicode(false);

            entity.Property(e => e.SummaryCurrencyDebit)
                .HasColumnName("SUMMARY_CURRENCY_DEBIT")
                .IsUnicode(false);

            entity.Property(e => e.SummaryCurrencyExchangeRt)
                .HasColumnName("SUMMARY_CURRENCY_EXCHANGE_RT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalBaseExcl)
                .HasColumnName("TOTAL_BASE_EXCL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalBaseExclEuro)
                .HasColumnName("TOTAL_BASE_EXCL_EURO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCredit)
                .HasColumnName("TOTAL_CREDIT")
                .IsUnicode(false);

            entity.Property(e => e.TotalCreditInWords)
                .HasColumnName("TOTAL_CREDIT_IN_WORDS")
                .IsUnicode(false);

            entity.Property(e => e.TotalDebit)
                .HasColumnName("TOTAL_DEBIT")
                .IsUnicode(false);

            entity.Property(e => e.TotalDebitInWords)
                .HasColumnName("TOTAL_DEBIT_IN_WORDS")
                .IsUnicode(false);

            entity.Property(e => e.TotalDiff)
                .HasColumnName("TOTAL_DIFF")
                .IsUnicode(false);

            entity.Property(e => e.TotalEuroBalance)
                .HasColumnName("TOTAL_EURO_BALANCE")
                .IsUnicode(false);

            entity.Property(e => e.TotalEuroCredit)
                .HasColumnName("TOTAL_EURO_CREDIT")
                .IsUnicode(false);

            entity.Property(e => e.TotalEuroDebit)
                .HasColumnName("TOTAL_EURO_DEBIT")
                .IsUnicode(false);

            entity.Property(e => e.TotalEuroDiff)
                .HasColumnName("TOTAL_EURO_DIFF")
                .IsUnicode(false);

            entity.Property(e => e.TotalEuroGross)
                .HasColumnName("TOTAL_EURO_GROSS")
                .IsUnicode(false);

            entity.Property(e => e.TotalEuroNet)
                .HasColumnName("TOTAL_EURO_NET")
                .IsUnicode(false);

            entity.Property(e => e.TotalGross)
                .HasColumnName("TOTAL_GROSS")
                .IsUnicode(false);

            entity.Property(e => e.TotalGrossExclvat)
                .HasColumnName("TOTAL_GROSS_EXCLVAT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalGrossExclvatEuro)
                .HasColumnName("TOTAL_GROSS_EXCLVAT_EURO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalGrossInclvat)
                .HasColumnName("TOTAL_GROSS_INCLVAT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalGrossInclvatEuro)
                .HasColumnName("TOTAL_GROSS_INCLVAT_EURO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNet)
                .HasColumnName("TOTAL_NET")
                .IsUnicode(false);

            entity.Property(e => e.TotalNetIncl)
                .HasColumnName("TOTAL_NET_INCL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNetInclEuro)
                .HasColumnName("TOTAL_NET_INCL_EURO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNonTaxable)
                .HasColumnName("TOTAL_NON_TAXABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNonTaxableEuro)
                .HasColumnName("TOTAL_NON_TAXABLE_EURO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalVatExcl)
                .HasColumnName("TOTAL_VAT_EXCL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalVatExclEuro)
                .HasColumnName("TOTAL_VAT_EXCL_EURO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalVatIncl)
                .HasColumnName("TOTAL_VAT_INCL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalVatInclEuro)
                .HasColumnName("TOTAL_VAT_INCL_EURO")
                .HasColumnType("NUMBER");
        });
	}
}
