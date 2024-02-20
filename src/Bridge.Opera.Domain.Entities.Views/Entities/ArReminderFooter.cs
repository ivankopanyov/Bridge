namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArReminderFooter
{
    public decimal? AccountCode { get; set; }
    public decimal? NoOfInvoice { get; set; }
    public decimal? Aging1Amount { get; set; }
    public decimal? Aging2Amount { get; set; }
    public decimal? Aging3Amount { get; set; }
    public decimal? Aging4Amount { get; set; }
    public decimal? Aging5Amount { get; set; }
    public decimal? Aging6Amount { get; set; }
    public decimal? TotalAmount { get; set; }
    public decimal? TotalOpenBalance { get; set; }
    public decimal? TotalOrgAmount { get; set; }
    public decimal? TotalPaidAmount { get; set; }
    public string? PrintedTotPaidAmount { get; set; }
    public string? PrintedTotOrgAmount { get; set; }
    public string? PrintedTotOpenBalance { get; set; }
    public string? PrintedTotAmount { get; set; }
    public string? PrintedCurrency { get; set; }
    public string? PrintedExchRate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArReminderFooter>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_REMINDER_FOOTER");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging1Amount)
                .HasColumnName("AGING1_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging2Amount)
                .HasColumnName("AGING2_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging3Amount)
                .HasColumnName("AGING3_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging4Amount)
                .HasColumnName("AGING4_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging5Amount)
                .HasColumnName("AGING5_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Aging6Amount)
                .HasColumnName("AGING6_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfInvoice)
                .HasColumnName("NO_OF_INVOICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintedCurrency)
                .HasColumnName("PRINTED_CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.PrintedExchRate)
                .HasColumnName("PRINTED_EXCH_RATE")
                .IsUnicode(false);

            entity.Property(e => e.PrintedTotAmount)
                .HasColumnName("PRINTED_TOT_AMOUNT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PrintedTotOpenBalance)
                .HasColumnName("PRINTED_TOT_OPEN_BALANCE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PrintedTotOrgAmount)
                .HasColumnName("PRINTED_TOT_ORG_AMOUNT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PrintedTotPaidAmount)
                .HasColumnName("PRINTED_TOT_PAID_AMOUNT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TotalAmount)
                .HasColumnName("TOTAL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOpenBalance)
                .HasColumnName("TOTAL_OPEN_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOrgAmount)
                .HasColumnName("TOTAL_ORG_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPaidAmount)
                .HasColumnName("TOTAL_PAID_AMOUNT")
                .HasColumnType("NUMBER");
        });
	}
}
