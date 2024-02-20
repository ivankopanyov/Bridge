namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EuroExchangeRates
{
    public string? Resort { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? ExchangeRate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EuroExchangeRates>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.CurrencyCode })
                .HasName("EE_PK");

            entity.ToTable("EURO_EXCHANGE_RATES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");
        });
	}
}
