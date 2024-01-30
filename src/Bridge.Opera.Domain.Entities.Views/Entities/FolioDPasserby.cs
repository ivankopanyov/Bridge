namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FolioDPasserby
{
    public decimal? NameId { get; set; }
    public int? FolioView { get; set; }
    public string? FolioStyle { get; set; }
    public string? TrxCode { get; set; }
    public string? Description { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? Quantity { get; set; }
    public string? Reference { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? EuroDebit { get; set; }
    public decimal? EuroCredit { get; set; }
    public string? ExchangeRate { get; set; }
    public decimal? DetailCurrencyDebit { get; set; }
    public decimal? DetailCurrencyCredit { get; set; }
    public string? DetailCurrency { get; set; }
    public string? DetailCurrencyExchangeRate { get; set; }
    public string? ApprovalCode { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string? Currency { get; set; }
    public decimal? ExchRate { get; set; }
    public decimal? EuroExchangeRate { get; set; }
    public decimal? PostedAmount { get; set; }
    public DateTime? Timestamp { get; set; }
    public decimal? FolioNameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FolioDPasserby>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FOLIO_D_PASSERBY");

            entity.Property(e => e.ApprovalCode)
                .HasColumnName("APPROVAL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Credit)
                .HasColumnName("CREDIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Currency)
                .IsRequired()
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Debit)
                .HasColumnName("DEBIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.DetailCurrency)
                .HasColumnName("DETAIL_CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.DetailCurrencyCredit)
                .HasColumnName("DETAIL_CURRENCY_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DetailCurrencyDebit)
                .HasColumnName("DETAIL_CURRENCY_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DetailCurrencyExchangeRate)
                .HasColumnName("DETAIL_CURRENCY_EXCHANGE_RATE")
                .IsUnicode(false);

            entity.Property(e => e.EuroCredit)
                .HasColumnName("EURO_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EuroDebit)
                .HasColumnName("EURO_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EuroExchangeRate)
                .HasColumnName("EURO_EXCHANGE_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ExchRate)
                .HasColumnName("EXCH_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .IsUnicode(false);

            entity.Property(e => e.ExpiryDate)
                .HasColumnName("EXPIRY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FolioNameId)
                .HasColumnName("FOLIO_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioStyle)
                .HasColumnName("FOLIO_STYLE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER(9)");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER(12,3)");

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Timestamp)
                .HasColumnName("TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");
        });
	}
}
