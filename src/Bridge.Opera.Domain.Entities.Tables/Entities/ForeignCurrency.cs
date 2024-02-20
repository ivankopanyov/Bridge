namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ForeignCurrency
{
    public ForeignCurrency()
    {
        ForeignCurrencyLimits = new HashSet<ForeignCurrencyLimits>();
    }

    public string? CurrencyCode { get; set; }
    public string? FormatMask { get; set; }
    public decimal? DecimalPositions { get; set; }
    public string? Description { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? TrianMethodYn { get; set; }
    public string? PreviousLocalCurrencyYn { get; set; }
    public decimal? CurrActionId { get; set; }
    public string? CanDeleteYn { get; set; }
    public string? CurrencySymbol { get; set; }
    public string? SellCurrencyYn { get; set; }
    public string? ChainCode { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? UsedForCcPaymentsYn { get; set; }
    public decimal? OrderBy { get; set; }

    public virtual ICollection<ForeignCurrencyLimits> ForeignCurrencyLimits { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ForeignCurrency>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.CurrencyCode })
                .HasName("FOREIGN_CURRENCY_PK");

            entity.ToTable("FOREIGN_CURRENCY");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CurrActionId)
                .HasColumnName("CURR_ACTION_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CurrencySymbol)
                .HasColumnName("CURRENCY_SYMBOL")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.DecimalPositions)
                .HasColumnName("DECIMAL_POSITIONS")
                .HasColumnType("NUMBER(30)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FormatMask)
                .HasColumnName("FORMAT_MASK")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER(30)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PreviousLocalCurrencyYn)
                .HasColumnName("PREVIOUS_LOCAL_CURRENCY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SellCurrencyYn)
                .HasColumnName("SELL_CURRENCY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TrianMethodYn)
                .HasColumnName("TRIAN_METHOD_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER(30)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UsedForCcPaymentsYn)
                .HasColumnName("USED_FOR_CC_PAYMENTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(ForeignCurrencyLimits)))
				entity.Ignore(e => e.ForeignCurrencyLimits);
		});
	}
}
