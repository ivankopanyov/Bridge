namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArAgingReportDetailHold
{
    public decimal? AccountCode { get; set; }
    public string? AccountName { get; set; }
    public string? AccountNo { get; set; }
    public string? AccountType { get; set; }
    public string? Contact { get; set; }
    public DateTime? PostDate { get; set; }
    public decimal? Invoice { get; set; }
    public decimal? FolioNo { get; set; }
    public string? GuestName { get; set; }
    public decimal? Age1 { get; set; }
    public decimal? Age2 { get; set; }
    public decimal? Age3 { get; set; }
    public decimal? Age4 { get; set; }
    public decimal? Age5 { get; set; }
    public decimal? Age6 { get; set; }
    public decimal? Aropen { get; set; }
    public decimal? InvoiceAge { get; set; }
    public string? InvoiceStatus { get; set; }
    public decimal? TrxNo { get; set; }
    public string? ArResort { get; set; }
    public decimal? BillNo { get; set; }
    public string? AccTypeFlag { get; set; }
    public decimal? AccountTypeId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArAgingReportDetailHold>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_AGING_REPORT_DETAIL_HOLD");

            entity.Property(e => e.AccTypeFlag)
                .HasColumnName("ACC_TYPE_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .IsUnicode(false);

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountTypeId)
                .HasColumnName("ACCOUNT_TYPE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Age1)
                .HasColumnName("AGE1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Age2)
                .HasColumnName("AGE2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Age3)
                .HasColumnName("AGE3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Age4)
                .HasColumnName("AGE4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Age5)
                .HasColumnName("AGE5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Age6)
                .HasColumnName("AGE6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArResort)
                .HasColumnName("AR_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Aropen)
                .HasColumnName("AROPEN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Contact)
                .HasColumnName("CONTACT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.Invoice)
                .HasColumnName("INVOICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceAge)
                .HasColumnName("INVOICE_AGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceStatus)
                .HasColumnName("INVOICE_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PostDate)
                .HasColumnName("POST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
