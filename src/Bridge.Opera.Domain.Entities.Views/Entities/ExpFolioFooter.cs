namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpFolioFooter
{
    public decimal? ResvNameId { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? BillNo { get; set; }
    public string? FolioType { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? Totexp1Amt { get; set; }
    public decimal? Totexp2Amt { get; set; }
    public decimal? Totexp3Amt { get; set; }
    public decimal? Totexp4Amt { get; set; }
    public decimal? Totexp5Amt { get; set; }
    public decimal? Totexp6Amt { get; set; }
    public decimal? Totexp7Amt { get; set; }
    public decimal? Totexp8Amt { get; set; }
    public decimal? Totexp9Amt { get; set; }
    public decimal? Totexp10Amt { get; set; }
    public decimal? Totexp11Amt { get; set; }
    public decimal? Totexp12Amt { get; set; }
    public decimal? Tot1CurrAmt { get; set; }
    public decimal? Tot2CurrAmt { get; set; }
    public decimal? Tot3CurrAmt { get; set; }
    public decimal? Tot4CurrAmt { get; set; }
    public decimal? Tot5CurrAmt { get; set; }
    public decimal? Tot6CurrAmt { get; set; }
    public decimal? Tot7CurrAmt { get; set; }
    public decimal? Tot8CurrAmt { get; set; }
    public decimal? Tot9CurrAmt { get; set; }
    public decimal? Tot10CurrAmt { get; set; }
    public decimal? Tot11CurrAmt { get; set; }
    public decimal? Tot12CurrAmt { get; set; }
    public decimal? Total { get; set; }
    public decimal? DebitCurrAmt { get; set; }
    public decimal? Totpayments { get; set; }
    public decimal? CreditCurrAmt { get; set; }
    public string? SummCurr { get; set; }
    public decimal? SummExchRate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpFolioFooter>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_FOLIO_FOOTER");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCurrAmt)
                .HasColumnName("CREDIT_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DebitCurrAmt)
                .HasColumnName("DEBIT_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SummCurr)
                .HasColumnName("SUMM_CURR")
                .IsUnicode(false);

            entity.Property(e => e.SummExchRate)
                .HasColumnName("SUMM_EXCH_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot10CurrAmt)
                .HasColumnName("TOT10_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot11CurrAmt)
                .HasColumnName("TOT11_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot12CurrAmt)
                .HasColumnName("TOT12_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot1CurrAmt)
                .HasColumnName("TOT1_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot2CurrAmt)
                .HasColumnName("TOT2_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot3CurrAmt)
                .HasColumnName("TOT3_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot4CurrAmt)
                .HasColumnName("TOT4_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot5CurrAmt)
                .HasColumnName("TOT5_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot6CurrAmt)
                .HasColumnName("TOT6_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot7CurrAmt)
                .HasColumnName("TOT7_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot8CurrAmt)
                .HasColumnName("TOT8_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot9CurrAmt)
                .HasColumnName("TOT9_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Total)
                .HasColumnName("TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totexp10Amt)
                .HasColumnName("TOTEXP10_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totexp11Amt)
                .HasColumnName("TOTEXP11_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totexp12Amt)
                .HasColumnName("TOTEXP12_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totexp1Amt)
                .HasColumnName("TOTEXP1_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totexp2Amt)
                .HasColumnName("TOTEXP2_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totexp3Amt)
                .HasColumnName("TOTEXP3_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totexp4Amt)
                .HasColumnName("TOTEXP4_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totexp5Amt)
                .HasColumnName("TOTEXP5_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totexp6Amt)
                .HasColumnName("TOTEXP6_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totexp7Amt)
                .HasColumnName("TOTEXP7_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totexp8Amt)
                .HasColumnName("TOTEXP8_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totexp9Amt)
                .HasColumnName("TOTEXP9_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totpayments)
                .HasColumnName("TOTPAYMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");
        });
	}
}
