namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CashierStartAmounts
{
    public string Resort { get; set; }
    public decimal CashierId { get; set; }
    public string CurrencyCode { get; set; }
    public decimal? StartingAmount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CashierStartAmounts>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.CashierId, e.CurrencyCode })
                .HasName("CSA_PK");

            entity.ToTable("CASHIER_START_AMOUNTS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartingAmount)
                .HasColumnName("STARTING_AMOUNT")
                .HasColumnType("NUMBER");
        });
	}
}
