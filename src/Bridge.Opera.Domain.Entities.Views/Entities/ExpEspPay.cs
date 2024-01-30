namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEspPay
{
    public decimal? ExportId { get; set; }
    public decimal? ResvNameId { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? FolioView { get; set; }
    public decimal? Amount { get; set; }
    public string? PayIndicator { get; set; }
    public string? PaymentType { get; set; }
    public decimal? BillNo { get; set; }
    public decimal? CreditCardId { get; set; }
    public string? CcNo { get; set; }
    public DateTime? CcExpDate { get; set; }
    public string? CcType { get; set; }
    public string? TrxCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEspPay>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_ESP_PAY");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CcExpDate)
                .HasColumnName("CC_EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CcNo)
                .HasColumnName("CC_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CcType)
                .HasColumnName("CC_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayIndicator)
                .HasColumnName("PAY_INDICATOR")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
