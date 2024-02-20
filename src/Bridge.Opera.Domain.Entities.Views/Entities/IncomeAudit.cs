namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IncomeAudit
{
    public decimal? TrxNo { get; set; }
    public string? TcGroup { get; set; }
    public string? TcSubgroup { get; set; }
    public string? TrxCode { get; set; }
    public decimal? ResvNameId { get; set; }
    public DateTime? TrxDate { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? Currency { get; set; }
    public string? Resort { get; set; }
    public decimal? CashierId { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? PricePerUnit { get; set; }
    public string? Room { get; set; }
    public string? TclCode1 { get; set; }
    public string? TclCode2 { get; set; }
    public decimal? Amount { get; set; }
    public decimal? PostedAmount { get; set; }
    public int? FolioView { get; set; }
    public string? Remark { get; set; }
    public string? Reference { get; set; }
    public decimal? CreditCardId { get; set; }
    public decimal? NameId { get; set; }
    public string? MarketCode { get; set; }
    public string? RateCode { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string? HotelAcct { get; set; }
    public string? ReasonCode { get; set; }
    public decimal? RoutingInstrnId { get; set; }
    public decimal? FromResvId { get; set; }
    public string? PasserByName { get; set; }
    public string? Product { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IncomeAudit>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INCOME_AUDIT");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currency)
                .IsRequired()
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER(9)");

            entity.Property(e => e.FromResvId)
                .HasColumnName("FROM_RESV_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HotelAcct)
                .HasColumnName("HOTEL_ACCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PasserByName)
                .HasColumnName("PASSER_BY_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PostedAmount)
                .HasColumnName("POSTED_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PricePerUnit)
                .HasColumnName("PRICE_PER_UNIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER(12,3)");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReasonCode)
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
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

            entity.Property(e => e.RoutingInstrnId)
                .HasColumnName("ROUTING_INSTRN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TcGroup)
                .IsRequired()
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .IsRequired()
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TclCode1)
                .HasColumnName("TCL_CODE1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TclCode2)
                .HasColumnName("TCL_CODE2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
