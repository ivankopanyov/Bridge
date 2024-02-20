namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArPayHist
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
    public decimal? Invoice { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? AppliedAmt { get; set; }
    public decimal? OrgAmt { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Aropen { get; set; }
    public string? AdjustYn { get; set; }
    public string? Remark { get; set; }
    public string? Reference { get; set; }
    public DateTime? InvoiceCloseDate { get; set; }
    public DateTime? ArTransferDate { get; set; }
    public string? InvStatus { get; set; }
    public string? RecType { get; set; }
    public decimal? TranActionId { get; set; }
    public string? ActionEvent { get; set; }
    public string? AppFull { get; set; }
    public string? TrxCode { get; set; }
    public string? TrxDesc { get; set; }
    public string? UpdateUser { get; set; }
    public decimal? CreditedToTrxNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArPayHist>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_PAY_HIST");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ActionEvent)
                .IsRequired()
                .HasColumnName("ACTION_EVENT")
                .HasMaxLength(30)
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
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AppliedAmt)
                .HasColumnName("APPLIED_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArTransferDate)
                .HasColumnName("AR_TRANSFER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Aropen)
                .HasColumnName("AROPEN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditedToTrxNo)
                .HasColumnName("CREDITED_TO_TRX_NO")
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

            entity.Property(e => e.InvoiceCloseDate)
                .HasColumnName("INVOICE_CLOSE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrgAmt)
                .HasColumnName("ORG_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Paid)
                .HasColumnName("PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostDate)
                .HasColumnName("POST_DATE")
                .HasColumnType("DATE");

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
                .HasColumnName("RESORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDesc)
                .HasColumnName("TRX_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .IsUnicode(false);
        });
	}
}
