namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArCreditFolioDetail
{
    public decimal? AccountCode { get; set; }
    public decimal? InvoiceNo { get; set; }
    public string? AccountNo { get; set; }
    public string? AccountName { get; set; }
    public DateTime? TransferDate { get; set; }
    public string? GuestName { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? FolioNo { get; set; }
    public string? Reference { get; set; }
    public string? Remark { get; set; }
    public decimal? TrxAmount { get; set; }
    public string? TrxCode { get; set; }
    public decimal? AccNameId { get; set; }
    public decimal? BillNumber { get; set; }
    public string? CreditCardNumberStr { get; set; }
    public string? CreditCardExpDateStr { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArCreditFolioDetail>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_CREDIT_FOLIO_DETAIL");

            entity.Property(e => e.AccNameId)
                .HasColumnName("ACC_NAME_ID")
                .HasColumnType("NUMBER");

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
                .IsUnicode(false);

            entity.Property(e => e.BillNumber)
                .HasColumnName("BILL_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardExpDateStr)
                .HasColumnName("CREDIT_CARD_EXP_DATE_STR")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNumberStr)
                .HasColumnName("CREDIT_CARD_NUMBER_STR")
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TransferDate)
                .HasColumnName("TRANSFER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
