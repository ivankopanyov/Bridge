namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FinTranPostDtl
{
    public decimal? ResvNameId { get; set; }
    public decimal? OldTranActionId { get; set; }
    public decimal? TranActionId { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? TrxNoHeader { get; set; }
    public decimal? TrxNoAddedBy { get; set; }
    public string TrxCode { get; set; }
    public string Description { get; set; }
    public decimal? TrxAmount { get; set; }
    public decimal? NetAmount { get; set; }
    public string Reference { get; set; }
    public string ActionDesc { get; set; }
    public string TransType { get; set; }
    public string FinActionEvent { get; set; }
    public decimal? FinDmlSeqNo { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string ForexType { get; set; }
    public decimal? ForexCommPerc { get; set; }
    public decimal? ForexCommAmount { get; set; }
    public decimal? PostedAmount { get; set; }
    public string Currency { get; set; }
    public decimal? EuroExchangeRate { get; set; }
    public decimal? PricePerUnit { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FinTranPostDtl>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIN_TRAN_POST_DTL");

            entity.Property(e => e.ActionDesc)
                .HasColumnName("ACTION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EuroExchangeRate)
                .HasColumnName("EURO_EXCHANGE_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FinActionEvent)
                .HasColumnName("FIN_ACTION_EVENT")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FinDmlSeqNo)
                .HasColumnName("FIN_DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForexCommAmount)
                .HasColumnName("FOREX_COMM_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForexCommPerc)
                .HasColumnName("FOREX_COMM_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForexType)
                .HasColumnName("FOREX_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OldTranActionId)
                .HasColumnName("OLD_TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PricePerUnit)
                .HasColumnName("PRICE_PER_UNIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

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
