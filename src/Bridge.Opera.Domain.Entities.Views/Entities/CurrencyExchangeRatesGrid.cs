namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CurrencyExchangeRatesGrid
{
    public string? Resort { get; set; }
    public string? CurrencyCode { get; set; }
    public string? BaseCurrCode { get; set; }
    public string? ExchangeRateType { get; set; }
    public DateTime? BeginDate { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? BuyCommPerc { get; set; }
    public decimal? NetBuyRate { get; set; }
    public decimal? SellExchangeRate { get; set; }
    public decimal? SellCommPerc { get; set; }
    public decimal? NetSellRate { get; set; }
    public string? LockRateYn { get; set; }
    public decimal? CurrActionId { get; set; }
    public string? Comments { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Description { get; set; }
    public decimal? BuyForeignExchangeRate { get; set; }
    public decimal? SellForeignExchangeRate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CurrencyExchangeRatesGrid>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CURRENCY_EXCHANGE_RATES_GRID");

            entity.Property(e => e.BaseCurrCode)
                .IsRequired()
                .HasColumnName("BASE_CURR_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BuyCommPerc)
                .HasColumnName("BUY_COMM_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BuyForeignExchangeRate)
                .HasColumnName("BUY_FOREIGN_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CurrActionId)
                .HasColumnName("CURR_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .IsRequired()
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExchangeRateType)
                .IsRequired()
                .HasColumnName("EXCHANGE_RATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LockRateYn)
                .IsRequired()
                .HasColumnName("LOCK_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NetBuyRate)
                .HasColumnName("NET_BUY_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetSellRate)
                .HasColumnName("NET_SELL_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellCommPerc)
                .HasColumnName("SELL_COMM_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SellExchangeRate)
                .HasColumnName("SELL_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SellForeignExchangeRate)
                .HasColumnName("SELL_FOREIGN_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
