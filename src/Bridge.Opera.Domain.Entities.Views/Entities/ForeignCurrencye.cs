namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ForeignCurrencye
{
    public string? CurrencyCode { get; set; }
    public string? FormatMask { get; set; }
    public decimal? DecimalPositions { get; set; }
    public string? Description { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? TrianMethodYn { get; set; }
    public string? SellCurrencyYn { get; set; }
    public string? UsedForCcPaymentsYn { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ForeignCurrencye>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FOREIGN_CURRENCYE");

            entity.Property(e => e.CurrencyCode)
                .IsRequired()
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
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
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER(30)");

            entity.Property(e => e.SellCurrencyYn)
                .HasColumnName("SELL_CURRENCY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TrianMethodYn)
                .HasColumnName("TRIAN_METHOD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER(30)");

            entity.Property(e => e.UsedForCcPaymentsYn)
                .HasColumnName("USED_FOR_CC_PAYMENTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
