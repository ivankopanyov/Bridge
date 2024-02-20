namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CurrencyExchangeRateType
{
    public CurrencyExchangeRateType()
    {
        CurrencyExchangeRates = new HashSet<CurrencyExchangeRates>();
        CurrencyExchangeRatesBak = new HashSet<CurrencyExchangeRatesBak>();
    }

    public string? ExchangeRateType { get; set; }
    public string? ExchangeYn { get; set; }
    public string? SettlementYn { get; set; }
    public string? ForecastYn { get; set; }
    public string? Description { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Resort { get; set; }
    public string? PostingYn { get; set; }
    public string? TaCommYn { get; set; }
    public string? MembershipYn { get; set; }
    public string? ExchangeCheckYn { get; set; }
    public string? OcisEcertYn { get; set; }

    public virtual ICollection<CurrencyExchangeRates> CurrencyExchangeRates { get; set; }
    public virtual ICollection<CurrencyExchangeRatesBak> CurrencyExchangeRatesBak { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CurrencyExchangeRateType>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ExchangeRateType })
                .HasName("EXCH_RATE_TYPE_PK");

            entity.ToTable("CURRENCY_EXCHANGE_RATE_TYPE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExchangeRateType)
                .HasColumnName("EXCHANGE_RATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeCheckYn)
                .HasColumnName("EXCHANGE_CHECK_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.ExchangeYn)
                .HasColumnName("EXCHANGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ForecastYn)
                .HasColumnName("FORECAST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipYn)
                .HasColumnName("MEMBERSHIP_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.OcisEcertYn)
                .HasColumnName("OCIS_ECERT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.PostingYn)
                .HasColumnName("POSTING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.SettlementYn)
                .HasColumnName("SETTLEMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TaCommYn)
                .HasColumnName("TA_COMM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(CurrencyExchangeRates)))
				entity.Ignore(e => e.CurrencyExchangeRates);

			if (!types.Contains(typeof(CurrencyExchangeRatesBak)))
				entity.Ignore(e => e.CurrencyExchangeRatesBak);
		});
	}
}
