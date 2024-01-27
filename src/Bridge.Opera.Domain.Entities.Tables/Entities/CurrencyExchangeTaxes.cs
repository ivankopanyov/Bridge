namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CurrencyExchangeTaxes
{
    public string Resort { get; set; }
    public string ServiceTaxType { get; set; }
    public decimal? MinAmount { get; set; }
    public decimal? MaxAmount { get; set; }
    public decimal? MinServiceTax { get; set; }
    public decimal? MaxServiceTax { get; set; }
    public decimal PercentTax { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CurrencyExchangeTaxes>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CURRENCY_EXCHANGE_TAXES");

            entity.HasIndex(e => new { e.Resort, e.ServiceTaxType })
                .HasName("CURRENCY_EXCHANGE_TAXES_UK")
                .IsUnique();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxAmount)
                .HasColumnName("MAX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxServiceTax)
                .HasColumnName("MAX_SERVICE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinAmount)
                .HasColumnName("MIN_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinServiceTax)
                .HasColumnName("MIN_SERVICE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PercentTax)
                .HasColumnName("PERCENT_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ServiceTaxType)
                .IsRequired()
                .HasColumnName("SERVICE_TAX_TYPE")
                .HasMaxLength(10)
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
