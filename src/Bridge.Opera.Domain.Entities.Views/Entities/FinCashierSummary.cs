namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FinCashierSummary
{
    public string? Title { get; set; }
    public DateTime? Timeoffirstopen { get; set; }
    public DateTime? Timeoflastclose { get; set; }
    public decimal? TimesOpened { get; set; }
    public string? TrxCode { get; set; }
    public string? Currency { get; set; }
    public decimal? CashierId { get; set; }
    public string? TrxDesc { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? TrxAmount { get; set; }
    public decimal? PostedAmount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FinCashierSummary>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIN_CASHIER_SUMMARY");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currency)
                .IsRequired()
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Timeoffirstopen)
                .HasColumnName("TIMEOFFIRSTOPEN")
                .HasColumnType("DATE");

            entity.Property(e => e.Timeoflastclose)
                .HasColumnName("TIMEOFLASTCLOSE")
                .HasColumnType("DATE");

            entity.Property(e => e.TimesOpened)
                .HasColumnName("TIMES_OPENED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDesc)
                .HasColumnName("TRX_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
