namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempV5iCurrencyExchange
{
    public string Resort { get; set; }
    public string BaseCurrencyCode { get; set; }
    public string CurrencyCode { get; set; }
    public DateTime? BeginDate { get; set; }
    public decimal? ExchangeRate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempV5iCurrencyExchange>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_V5I_CURRENCY_EXCHANGE");

            entity.Property(e => e.BaseCurrencyCode)
                .HasColumnName("BASE_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
