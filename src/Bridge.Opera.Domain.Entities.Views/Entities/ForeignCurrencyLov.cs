namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ForeignCurrencyLov
{
    public string? CurrencyCode { get; set; }
    public string? FormatMask { get; set; }
    public decimal? DecimalPositions { get; set; }
    public string? Description { get; set; }
    public string? TrianMethodYn { get; set; }
    public string? PreviousLocalCurrencyYn { get; set; }
    public decimal? CurrActionId { get; set; }
    public string? CanDeleteYn { get; set; }
    public string? CurrencySymbol { get; set; }
    public string? SellCurrencyYn { get; set; }
    public string? ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ForeignCurrencyLov>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FOREIGN_CURRENCY_LOV");

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrActionId)
                .HasColumnName("CURR_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .IsRequired()
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencySymbol)
                .HasColumnName("CURRENCY_SYMBOL")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.DecimalPositions)
                .HasColumnName("DECIMAL_POSITIONS")
                .HasColumnType("NUMBER(30)");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FormatMask)
                .HasColumnName("FORMAT_MASK")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PreviousLocalCurrencyYn)
                .HasColumnName("PREVIOUS_LOCAL_CURRENCY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SellCurrencyYn)
                .HasColumnName("SELL_CURRENCY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TrianMethodYn)
                .HasColumnName("TRIAN_METHOD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
