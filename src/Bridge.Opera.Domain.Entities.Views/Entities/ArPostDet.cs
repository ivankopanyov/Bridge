namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArPostDet
{
    public string? Resort { get; set; }
    public decimal? AccountCode { get; set; }
    public string? AccountName { get; set; }
    public DateTime? PostDate { get; set; }
    public decimal? TrxNo { get; set; }
    public string? GuestName { get; set; }
    public decimal? NameId { get; set; }
    public string? Room { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? TrxCode { get; set; }
    public decimal? Invoice { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? OrgAmt { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Aropen { get; set; }
    public decimal? Ardebit { get; set; }
    public decimal? Arcredit { get; set; }
    public string? AdjustYn { get; set; }
    public string? Remark { get; set; }
    public string? Reference { get; set; }
    public string? Currency { get; set; }
    public string? CurrencyDesc { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? EuroExchangeRate { get; set; }
    public decimal? PostedAmount { get; set; }
    public DateTime? InvoiceCloseDate { get; set; }
    public DateTime? ArTransferDate { get; set; }
    public string? InvStatus { get; set; }
    public string? RecType { get; set; }
    public decimal? TranActionId { get; set; }
    public string? AppFull { get; set; }
    public string? InvoiceType { get; set; }
    public decimal? InvoiceAge { get; set; }
    public DateTime? UpdDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArPostDet>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_POST_DET");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AdjustYn)
                .HasColumnName("ADJUST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppFull)
                .HasColumnName("APP_FULL")
                .IsUnicode(false);

            entity.Property(e => e.ArTransferDate)
                .HasColumnName("AR_TRANSFER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Arcredit)
                .HasColumnName("ARCREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Ardebit)
                .HasColumnName("ARDEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Aropen)
                .HasColumnName("AROPEN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currency)
                .IsRequired()
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyDesc)
                .HasColumnName("CURRENCY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.EuroExchangeRate)
                .HasColumnName("EURO_EXCHANGE_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InvStatus)
                .HasColumnName("INV_STATUS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Invoice)
                .HasColumnName("INVOICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceAge)
                .HasColumnName("INVOICE_AGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceCloseDate)
                .HasColumnName("INVOICE_CLOSE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvoiceType)
                .HasColumnName("INVOICE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrgAmt)
                .HasColumnName("ORG_AMT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Paid)
                .HasColumnName("PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostDate)
                .HasColumnName("POST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.RecType)
                .HasColumnName("REC_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdDate)
                .HasColumnName("UPD_DATE")
                .HasColumnType("DATE");
        });
	}
}
