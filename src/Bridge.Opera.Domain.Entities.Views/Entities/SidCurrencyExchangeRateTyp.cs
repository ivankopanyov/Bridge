namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidCurrencyExchangeRateTyp
{
    public string? Resort { get; set; }
    public string? ExchangeRateType { get; set; }
    public string? ExchangeYn { get; set; }
    public string? SettlementYn { get; set; }
    public string? ForecastYn { get; set; }
    public string? Description { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? PostingYn { get; set; }
    public string? TaCommYn { get; set; }
    public string? MembershipYn { get; set; }
    public string? ExchangeCheckYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidCurrencyExchangeRateTyp>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_CURRENCY_EXCHANGE_RATE_TYP");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeCheckYn)
                .HasColumnName("EXCHANGE_CHECK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

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

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipYn)
                .HasColumnName("MEMBERSHIP_YN")
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

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
