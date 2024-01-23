namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CurrExchangeRates
{
    public DateTime BeginDate { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string Resort { get; set; }
    public string ExchangeRateType { get; set; }
    public string BaseCurrCode { get; set; }
    public string CurrencyCode { get; set; }
    public string ExchangeYn { get; set; }
    public string SettlementYn { get; set; }
    public string ForecastYn { get; set; }
    public string PostingYn { get; set; }
    public string TaCommYn { get; set; }
    public string MembershipYn { get; set; }
    public string ExchangeCheckYn { get; set; }
    public string OcisEcertYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CurrExchangeRates>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CURR_EXCHANGE_RATES");

            entity.Property(e => e.BaseCurrCode)
                .IsRequired()
                .HasColumnName("BASE_CURR_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CurrencyCode)
                .IsRequired()
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeCheckYn)
                .HasColumnName("EXCHANGE_CHECK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExchangeRateType)
                .IsRequired()
                .HasColumnName("EXCHANGE_RATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeYn)
                .HasColumnName("EXCHANGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ForecastYn)
                .HasColumnName("FORECAST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MembershipYn)
                .HasColumnName("MEMBERSHIP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OcisEcertYn)
                .HasColumnName("OCIS_ECERT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PostingYn)
                .HasColumnName("POSTING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SettlementYn)
                .HasColumnName("SETTLEMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TaCommYn)
                .HasColumnName("TA_COMM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
