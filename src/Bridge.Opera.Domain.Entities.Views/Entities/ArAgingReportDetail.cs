namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArAgingReportDetail
{
    public string Resort { get; set; }
    public decimal? AccountCode { get; set; }
    public string AccountName { get; set; }
    public string AccountNo { get; set; }
    public decimal AccountTypeId { get; set; }
    public string Contact { get; set; }
    public decimal? TrxNo { get; set; }
    public DateTime? PostDate { get; set; }
    public decimal? Invoice { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? Age1 { get; set; }
    public decimal? Age2 { get; set; }
    public decimal? Age3 { get; set; }
    public decimal? Age4 { get; set; }
    public decimal? Age5 { get; set; }
    public decimal? Age6 { get; set; }
    public decimal? Aropen { get; set; }
    public decimal? InvoiceAge { get; set; }
    public string InvoiceStatus { get; set; }
    public decimal? ArLedDebit { get; set; }
    public string TrxCode { get; set; }
    public decimal? NameId { get; set; }
    public decimal? BillNo { get; set; }
    public string AccTypeFlag { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArAgingReportDetail>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_AGING_REPORT_DETAIL");

            entity.Property(e => e.AccTypeFlag)
                .HasColumnName("ACC_TYPE_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .IsRequired()
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
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

            entity.Property(e => e.ArLedDebit)
                .HasColumnName("AR_LED_DEBIT")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostDate)
                .HasColumnName("POST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
