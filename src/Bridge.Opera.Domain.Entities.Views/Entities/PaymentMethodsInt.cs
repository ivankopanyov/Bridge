namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PaymentMethodsInt
{
    public string? PaymentMethod { get; set; }
    public string? Description { get; set; }
    public string? CcCode { get; set; }
    public string? TrxCode { get; set; }
    public decimal? IssueNumber { get; set; }
    public decimal? StartDate { get; set; }
    public string? ResvPaymentYn { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PaymentMethodsInt>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PAYMENT_METHODS_INT");

            entity.Property(e => e.CcCode)
                .HasColumnName("CC_CODE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IssueNumber)
                .HasColumnName("ISSUE_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentMethod)
                .IsRequired()
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvPaymentYn)
                .HasColumnName("RESV_PAYMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
