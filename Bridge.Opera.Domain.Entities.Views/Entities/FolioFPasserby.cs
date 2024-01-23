namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FolioFPasserby
{
    public decimal? GuestNameId { get; set; }
    public decimal? FolioNo { get; set; }
    public int? FolioView { get; set; }
    public decimal? TotalCredit { get; set; }
    public decimal? TotalDebit { get; set; }
    public decimal? TotalEuroDebit { get; set; }
    public decimal? TotalEuroCredit { get; set; }
    public decimal? TotalEuroBalance { get; set; }
    public decimal? EuroExchangeRate { get; set; }
    public decimal? Balance { get; set; }
    public decimal? SummaryCurrencyDebit { get; set; }
    public decimal? SummaryCurrencyCredit { get; set; }
    public decimal? SummaryBalance { get; set; }
    public string SummaryCurrency { get; set; }
    public decimal? SummaryCurrencyExchangeRt { get; set; }
    public decimal? TotalNet { get; set; }
    public decimal? TotalGross { get; set; }
    public decimal? TotalDiff { get; set; }
    public decimal? TotalEuroNet { get; set; }
    public decimal? TotalEuroGross { get; set; }
    public decimal? TotalEuroDiff { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FolioFPasserby>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FOLIO_F_PASSERBY");

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EuroExchangeRate)
                .HasColumnName("EURO_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER(9)");

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SummaryBalance)
                .HasColumnName("SUMMARY_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SummaryCurrency)
                .HasColumnName("SUMMARY_CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.SummaryCurrencyCredit)
                .HasColumnName("SUMMARY_CURRENCY_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SummaryCurrencyDebit)
                .HasColumnName("SUMMARY_CURRENCY_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SummaryCurrencyExchangeRt)
                .HasColumnName("SUMMARY_CURRENCY_EXCHANGE_RT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCredit)
                .HasColumnName("TOTAL_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalDebit)
                .HasColumnName("TOTAL_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalDiff)
                .HasColumnName("TOTAL_DIFF")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalEuroBalance)
                .HasColumnName("TOTAL_EURO_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalEuroCredit)
                .HasColumnName("TOTAL_EURO_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalEuroDebit)
                .HasColumnName("TOTAL_EURO_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalEuroDiff)
                .HasColumnName("TOTAL_EURO_DIFF")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalEuroGross)
                .HasColumnName("TOTAL_EURO_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalEuroNet)
                .HasColumnName("TOTAL_EURO_NET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalGross)
                .HasColumnName("TOTAL_GROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNet)
                .HasColumnName("TOTAL_NET")
                .HasColumnType("NUMBER");
        });
	}
}
