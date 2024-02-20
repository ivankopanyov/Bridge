namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MarketsInt
{
    public string? Resort { get; set; }
    public string? MarketCode { get; set; }
    public string? ParentMarketCode { get; set; }
    public string? Description { get; set; }
    public decimal? SellSequence { get; set; }
    public string? DisplayColor { get; set; }
    public string? InactiveDate { get; set; }
    public string? InActiveYn { get; set; }
    public decimal? ScOrderby { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MarketsInt>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MARKETS_INT");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DisplayColor)
                .HasColumnName("DISPLAY_COLOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InActiveYn)
                .HasColumnName("IN_ACTIVE_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .IsRequired()
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParentMarketCode)
                .HasColumnName("PARENT_MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.ScOrderby)
                .HasColumnName("SC_ORDERBY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .HasColumnType("NUMBER");
        });
	}
}
