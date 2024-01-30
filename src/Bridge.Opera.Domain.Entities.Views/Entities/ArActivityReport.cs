namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArActivityReport
{
    public string? AccountType { get; set; }
    public string? TypeDesc { get; set; }
    public string? AccountName { get; set; }
    public string? GuestName { get; set; }
    public string? AccountNo { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? NameId { get; set; }
    public decimal? AccountCode { get; set; }
    public string? Terminal { get; set; }
    public string? Machine { get; set; }
    public string? Cashier { get; set; }
    public decimal? InvoiceNo { get; set; }
    public decimal? Amount { get; set; }
    public string? TrxCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InserUser { get; set; }
    public decimal? FinActionId { get; set; }
    public string? FinActionDesc { get; set; }
    public string? FinActionType { get; set; }
    public string? FinActionEvent { get; set; }
    public string? ReasonCode { get; set; }
    public string? FtSubtype { get; set; }
    public string? AccTypeFlag { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArActivityReport>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_ACTIVITY_REPORT");

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

            entity.Property(e => e.AccountType)
                .IsRequired()
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Cashier)
                .HasColumnName("CASHIER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FinActionDesc)
                .HasColumnName("FIN_ACTION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FinActionEvent)
                .IsRequired()
                .HasColumnName("FIN_ACTION_EVENT")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FinActionId)
                .HasColumnName("FIN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FinActionType)
                .HasColumnName("FIN_ACTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FtSubtype)
                .IsRequired()
                .HasColumnName("FT_SUBTYPE")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InserUser)
                .HasColumnName("INSER_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReasonCode)
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TypeDesc)
                .IsRequired()
                .HasColumnName("TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
