namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiRhMarketDim
{
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string MarketCode { get; set; }
    public string MarketDesc { get; set; }
    public string MarketGroup { get; set; }
    public string MarketGroupDesc { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiRhMarketDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_RH_MARKET_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .IsUnicode(false);

            entity.Property(e => e.MarketDesc)
                .HasColumnName("MARKET_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MarketGroup)
                .HasColumnName("MARKET_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.MarketGroupDesc)
                .HasColumnName("MARKET_GROUP_DESC")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
