namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RateInfoView
{
    public string RateCode { get; set; }
    public string RateCodeShortDesc { get; set; }
    public string RateCodeLongDesc { get; set; }
    public string RoomCategory { get; set; }
    public string RoomCategoryLabel { get; set; }
    public DateTime? RateDate { get; set; }
    public string RateDow { get; set; }
    public string CurrencyCode { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public string RoomRevenue { get; set; }
    public string PkgRevenue { get; set; }
    public string TotalAmount { get; set; }
    public string GeneratesAmount { get; set; }
    public string GrandTotal { get; set; }
    public string SumTotal { get; set; }
    public string SumGrandTotal { get; set; }
    public string WeekendRow { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateInfoView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RATE_INFO_VIEW");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GeneratesAmount)
                .HasColumnName("GENERATES_AMOUNT")
                .HasMaxLength(38)
                .IsUnicode(false);

            entity.Property(e => e.GrandTotal)
                .HasColumnName("GRAND_TOTAL")
                .HasMaxLength(38)
                .IsUnicode(false);

            entity.Property(e => e.PkgRevenue)
                .HasColumnName("PKG_REVENUE")
                .HasMaxLength(38)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCodeLongDesc)
                .HasColumnName("RATE_CODE_LONG_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateCodeShortDesc)
                .HasColumnName("RATE_CODE_SHORT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateDate)
                .HasColumnName("RATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateDow)
                .HasColumnName("RATE_DOW")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasMaxLength(38)
                .IsUnicode(false);

            entity.Property(e => e.SumGrandTotal)
                .HasColumnName("SUM_GRAND_TOTAL")
                .HasMaxLength(38)
                .IsUnicode(false);

            entity.Property(e => e.SumTotal)
                .HasColumnName("SUM_TOTAL")
                .HasMaxLength(38)
                .IsUnicode(false);

            entity.Property(e => e.TotalAmount)
                .HasColumnName("TOTAL_AMOUNT")
                .HasMaxLength(38)
                .IsUnicode(false);

            entity.Property(e => e.WeekendRow)
                .HasColumnName("WEEKEND_ROW")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
