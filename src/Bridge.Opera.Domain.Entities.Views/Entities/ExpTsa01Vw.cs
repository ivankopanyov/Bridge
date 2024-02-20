namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpTsa01Vw
{
    public string? BusinessDate { get; set; }
    public string? Resort { get; set; }
    public string? Name { get; set; }
    public string? RmNo { get; set; }
    public string? RmType { get; set; }
    public string? PrevRmType { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public string? GuestLastName { get; set; }
    public string? GuestFirstName { get; set; }
    public string? ConfirmationNo { get; set; }
    public decimal? NameId { get; set; }
    public string? Chkindte { get; set; }
    public string? Chkoutdte { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? RmRate { get; set; }
    public decimal? UsdRate { get; set; }
    public string? MarketCode { get; set; }
    public string? MarketDesc { get; set; }
    public string? MarketGrp { get; set; }
    public string? MarketGrpDesc { get; set; }
    public string? Packages { get; set; }
    public decimal? PkgPrice { get; set; }
    public string? PakDesc { get; set; }
    public string? PkgBegin { get; set; }
    public string? PkgEnd { get; set; }
    public decimal? Quantity { get; set; }
    public string? Outdate { get; set; }
    public string? ResvStatus { get; set; }
    public string? Nationality { get; set; }
    public string? RateCode { get; set; }
    public string? RateDesc { get; set; }
    public decimal? CfgPrice { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpTsa01Vw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_TSA01_VW");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.CfgPrice)
                .HasColumnName("CFG_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Chkindte)
                .HasColumnName("CHKINDTE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.Chkoutdte)
                .HasColumnName("CHKOUTDTE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestLastName)
                .HasColumnName("GUEST_LAST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketDesc)
                .HasColumnName("MARKET_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MarketGrp)
                .HasColumnName("MARKET_GRP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketGrpDesc)
                .HasColumnName("MARKET_GRP_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Outdate)
                .HasColumnName("OUTDATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.Packages)
                .IsRequired()
                .HasColumnName("PACKAGES")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PakDesc)
                .HasColumnName("PAK_DESC")
                .IsUnicode(false);

            entity.Property(e => e.PkgBegin)
                .HasColumnName("PKG_BEGIN")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.PkgEnd)
                .HasColumnName("PKG_END")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.PkgPrice)
                .HasColumnName("PKG_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrevRmType)
                .HasColumnName("PREV_RM_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateDesc)
                .HasColumnName("RATE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmNo)
                .HasColumnName("RM_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmRate)
                .HasColumnName("RM_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmType)
                .HasColumnName("RM_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.UsdRate)
                .HasColumnName("USD_RATE")
                .HasColumnType("NUMBER");
        });
	}
}
