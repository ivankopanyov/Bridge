namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CurrencyExchangeAvailRates
{
    public string? CurrencyCode { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CurrencyExchangeAvailRates>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CURRENCY_EXCHANGE_AVAIL_RATES");

            entity.Property(e => e.CurrencyCode)
                .IsRequired()
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
