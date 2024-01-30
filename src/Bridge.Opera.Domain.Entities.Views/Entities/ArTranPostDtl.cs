namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArTranPostDtl
{
    public decimal? NameId { get; set; }
    public decimal? AccountCode { get; set; }
    public decimal? OldTranActionId { get; set; }
    public decimal? TranActionId { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? TrxNoHeader { get; set; }
    public decimal? TrxNoAddedBy { get; set; }
    public string? TrxCode { get; set; }
    public string? Description { get; set; }
    public decimal? TrxAmount { get; set; }
    public string? Reference { get; set; }
    public string? ActionDesc { get; set; }
    public string? TransType { get; set; }
    public string? FinActionEvent { get; set; }
    public decimal? FinDmlSeqNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArTranPostDtl>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_TRAN_POST_DTL");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionDesc)
                .HasColumnName("ACTION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FinActionEvent)
                .HasColumnName("FIN_ACTION_EVENT")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FinDmlSeqNo)
                .HasColumnName("FIN_DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OldTranActionId)
                .HasColumnName("OLD_TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TranActionId)
                .HasColumnName("TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransType)
                .HasColumnName("TRANS_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoAddedBy)
                .HasColumnName("TRX_NO_ADDED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoHeader)
                .HasColumnName("TRX_NO_HEADER")
                .HasColumnType("NUMBER");
        });
	}
}
