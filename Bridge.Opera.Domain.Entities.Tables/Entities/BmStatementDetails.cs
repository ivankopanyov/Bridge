namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BmStatementDetails
{
    public decimal StatementId { get; set; }
    public decimal ContractId { get; set; }
    public decimal Seq { get; set; }
    public string ChannelType { get; set; }
    public string Channel { get; set; }
    public decimal? Qty { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? TimeUnits { get; set; }
    public string Currency { get; set; }
    public string Type { get; set; }
    public string Note { get; set; }
    public string TrxCode { get; set; }
    public string PriceBasedOn { get; set; }
    public string Range { get; set; }
    public decimal? MinRange { get; set; }
    public decimal? MaxRange { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string ArNo { get; set; }
    public string Resort { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? Amount { get; set; }
    public decimal? InvoiceAmount { get; set; }
    public string InvoiceCurrency { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BmStatementDetails>(entity =>
        {
            entity.HasKey(e => new { e.StatementId, e.ContractId, e.Resort, e.Seq })
                .HasName("BMSD_PK");

            entity.ToTable("BM_STATEMENT_DETAILS");

            entity.HasIndex(e => new { e.Channel, e.Type })
                .HasName("BMSD_SOURCE");

            entity.HasIndex(e => new { e.ChannelType, e.Type })
                .HasName("BMSD_CHANNEL");

            entity.HasIndex(e => new { e.ContractId, e.Seq })
                .HasName("BMSD_CONT_SEQ");

            entity.Property(e => e.StatementId)
                .HasColumnName("STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'*'");

            entity.Property(e => e.Seq)
                .HasColumnName("SEQ")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArNo)
                .IsRequired()
                .HasColumnName("AR_NO")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'*'");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChannelType)
                .HasColumnName("CHANNEL_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceAmount)
                .HasColumnName("INVOICE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InvoiceCurrency)
                .HasColumnName("INVOICE_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxRange)
                .HasColumnName("MAX_RANGE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MinRange)
                .HasColumnName("MIN_RANGE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Note)
                .HasColumnName("NOTE")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriceBasedOn)
                .HasColumnName("PRICE_BASED_ON")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Qty)
                .HasColumnName("QTY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Range)
                .HasColumnName("RANGE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TimeUnits)
                .HasColumnName("TIME_UNITS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(240)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UnitPrice)
                .HasColumnName("UNIT_PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
