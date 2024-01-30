namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArCollectionStatistics
{
    public decimal? ReportId { get; set; }
    public string? Resort { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? InvoiceNo { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Paid { get; set; }
    public decimal? AccountCode { get; set; }
    public decimal? NameId { get; set; }
    public DateTime? LastPaidDate { get; set; }
    public DateTime? ArTransferDate { get; set; }
    public DateTime? BusinessDate { get; set; }
    public DateTime? TrxDate { get; set; }
    public string? AccountNo { get; set; }
    public string? AccountName { get; set; }
    public string? GuestName { get; set; }
    public decimal? AccountTypeId { get; set; }
    public string? AccountType { get; set; }
    public string? AccountTypeDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArCollectionStatistics>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_COLLECTION_STATISTICS");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeDesc)
                .HasColumnName("ACCOUNT_TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeId)
                .HasColumnName("ACCOUNT_TYPE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArTransferDate)
                .HasColumnName("AR_TRANSFER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastPaidDate)
                .HasColumnName("LAST_PAID_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Paid)
                .HasColumnName("PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
