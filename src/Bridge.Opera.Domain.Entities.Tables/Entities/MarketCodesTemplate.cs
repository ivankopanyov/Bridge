namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MarketCodesTemplate
{
    public string? MarketCode { get; set; }
    public string? ParentMarketCode { get; set; }
    public string? Description { get; set; }
    public int? SellSequence { get; set; }
    public string? DisplayColor { get; set; }
    public decimal? ScOrderby { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? PrintGroup { get; set; }
    public string? ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MarketCodesTemplate>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.MarketCode })
                .HasName("MARKET_CODE_TEMPLATE_PK");

            entity.ToTable("MARKET_CODES_TEMPLATE");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DisplayColor)
                .HasColumnName("DISPLAY_COLOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentMarketCode)
                .HasColumnName("PARENT_MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrintGroup)
                .HasColumnName("PRINT_GROUP")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.ScOrderby)
                .HasColumnName("SC_ORDERBY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SellSequence).HasColumnName("SELL_SEQUENCE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
