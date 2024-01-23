namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArRview
{
    public string Resort { get; set; }
    public decimal? AccountCode { get; set; }
    public string AccountType { get; set; }
    public string AccountNo { get; set; }
    public decimal? CreditLimit { get; set; }
    public string AccountName { get; set; }
    public DateTime? TrxDate { get; set; }
    public DateTime? BusinessDate { get; set; }
    public DateTime? PostDate { get; set; }
    public decimal? TrxNo { get; set; }
    public string GuestName { get; set; }
    public decimal? NameId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? Invoice { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? OrgAmt { get; set; }
    public DateTime? ArTransferDate { get; set; }
    public string InvStatus { get; set; }
    public string AccountStatus { get; set; }
    public string InvoiceType { get; set; }
    public decimal? TranActionId { get; set; }
    public DateTime? CheckOutDate { get; set; }
    public decimal? CashierId { get; set; }
    public string PasserbyInd { get; set; }
    public string PurgeYn { get; set; }
    public decimal? BillNumber { get; set; }
    public string AccTypeFlag { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArRview>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_RVIEW");

            entity.Property(e => e.AccTypeFlag)
                .HasColumnName("ACC_TYPE_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .IsUnicode(false);

            entity.Property(e => e.AccountStatus)
                .HasColumnName("ACCOUNT_STATUS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccountType)
                .IsRequired()
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArTransferDate)
                .HasColumnName("AR_TRANSFER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillNumber)
                .HasColumnName("BILL_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckOutDate)
                .HasColumnName("CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InvStatus)
                .HasColumnName("INV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Invoice)
                .HasColumnName("INVOICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceType)
                .HasColumnName("INVOICE_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrgAmt)
                .HasColumnName("ORG_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PasserbyInd)
                .HasColumnName("PASSERBY_IND")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.PostDate)
                .HasColumnName("POST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PurgeYn)
                .HasColumnName("PURGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
