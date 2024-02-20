namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpFinStatDailyBase
{
    public string? RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public string? Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? PmsResvNo { get; set; }
    public string? PmsDeptCode { get; set; }
    public string? PmsNameId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public string? TrxCode { get; set; }
    public string? TcSubgroup { get; set; }
    public string? MarketCode { get; set; }
    public decimal? NetAmount { get; set; }
    public decimal? GrossAmount { get; set; }
    public string? CentralCurrencyCode { get; set; }
    public decimal? CentralExchangeRate { get; set; }
    public string? CheckNumber { get; set; }
    public string? CheckNumberId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpFinStatDailyBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXP_FIN_STAT_DAILY_BASE");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CentralCurrencyCode)
                .HasColumnName("CENTRAL_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CentralExchangeRate)
                .HasColumnName("CENTRAL_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckNumber)
                .HasColumnName("CHECK_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CheckNumberId)
                .HasColumnName("CHECK_NUMBER_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PmsDeptCode)
                .IsRequired()
                .HasColumnName("PMS_DEPT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsNameId)
                .HasColumnName("PMS_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsResvNo)
                .IsRequired()
                .HasColumnName("PMS_RESV_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(99)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.TcSubgroup)
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
