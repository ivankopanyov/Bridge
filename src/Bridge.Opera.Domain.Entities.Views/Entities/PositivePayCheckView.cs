namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PositivePayCheckView
{
    public decimal? ReportId { get; set; }
    public string Resort { get; set; }
    public decimal? AccountId { get; set; }
    public decimal? TravelAgentId { get; set; }
    public decimal? BatchId { get; set; }
    public decimal? PaymentId { get; set; }
    public string AccountNo { get; set; }
    public DateTime? ProcessingDate { get; set; }
    public decimal? CheckNo { get; set; }
    public DateTime? PaymentDate { get; set; }
    public decimal? Amount { get; set; }
    public string TransactionCode { get; set; }
    public decimal? TotalRecords { get; set; }
    public decimal? TotalAmount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PositivePayCheckView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("POSITIVE_PAY_CHECK_VIEW");

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckNo)
                .HasColumnName("CHECK_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentDate)
                .HasColumnName("PAYMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PaymentId)
                .HasColumnName("PAYMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessingDate)
                .HasColumnName("PROCESSING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TotalAmount)
                .HasColumnName("TOTAL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRecords)
                .HasColumnName("TOTAL_RECORDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransactionCode)
                .HasColumnName("TRANSACTION_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");
        });
	}
}
