namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BmStatementSummary
{
    public decimal? StatementId { get; set; }
    public decimal? ContractId { get; set; }
    public decimal? Seq { get; set; }
    public string Type { get; set; }
    public string ChannelType { get; set; }
    public string Channel { get; set; }
    public string Resort { get; set; }
    public decimal? Qty { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? TimeUnits { get; set; }
    public string Currency { get; set; }
    public string Note { get; set; }
    public string ArNo { get; set; }
    public decimal? MinRange { get; set; }
    public decimal? MaxRange { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? Amount { get; set; }
    public decimal? InvoiceAmount { get; set; }
    public string InvoiceCurrency { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BmStatementSummary>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BM_STATEMENT_SUMMARY");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArNo)
                .HasColumnName("AR_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ChannelType)
                .HasColumnName("CHANNEL_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceAmount)
                .HasColumnName("INVOICE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceCurrency)
                .HasColumnName("INVOICE_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MaxRange)
                .HasColumnName("MAX_RANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinRange)
                .HasColumnName("MIN_RANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Note)
                .HasColumnName("NOTE")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Qty)
                .HasColumnName("QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Seq)
                .HasColumnName("SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatementId)
                .HasColumnName("STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TimeUnits)
                .HasColumnName("TIME_UNITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UnitPrice)
                .HasColumnName("UNIT_PRICE")
                .HasColumnType("NUMBER");
        });
	}
}
