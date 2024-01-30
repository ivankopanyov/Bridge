namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepCurrencyExchange
{
    public string? RecordType { get; set; }
    public DateTime? TrxDate { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? NetExchangeRate { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string? ForexType { get; set; }
    public decimal? ForexCommPerc { get; set; }
    public decimal? TrxAmount { get; set; }
    public decimal? PostedAmount { get; set; }
    public decimal? ForexCommAmount { get; set; }
    public decimal? ServiceTax { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepCurrencyExchange>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_CURRENCY_EXCHANGE");

            entity.Property(e => e.CurrencyCode)
                .IsRequired()
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForexCommAmount)
                .HasColumnName("FOREX_COMM_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForexCommPerc)
                .HasColumnName("FOREX_COMM_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForexType)
                .HasColumnName("FOREX_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.NetExchangeRate)
                .HasColumnName("NET_EXCHANGE_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(17)
                .IsUnicode(false);

            entity.Property(e => e.ServiceTax)
                .HasColumnName("SERVICE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");
        });
	}
}
