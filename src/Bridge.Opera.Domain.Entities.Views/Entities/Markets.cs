namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Markets
{
    public string MarketCode { get; set; }
    public string Resort { get; set; }
    public string ParentMarketCode { get; set; }
    public string Description { get; set; }
    public int? SellSequence { get; set; }
    public string DisplayColor { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string InActiveYn { get; set; }
    public string PrintGroup { get; set; }
    public decimal? ScOrderby { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Markets>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MARKETS");

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
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MarketCode)
                .IsRequired()
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParentMarketCode)
                .HasColumnName("PARENT_MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrintGroup)
                .HasColumnName("PRINT_GROUP")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScOrderby)
                .HasColumnName("SC_ORDERBY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SellSequence).HasColumnName("SELL_SEQUENCE");
        });
	}
}
