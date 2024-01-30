namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepNonrevenueSumm
{
    public string? Resort { get; set; }
    public string? TcGroup { get; set; }
    public string? TcSubgroup { get; set; }
    public string? TrxCode { get; set; }
    public string? Description { get; set; }
    public decimal? DayRevenue { get; set; }
    public decimal? MtdRevenue { get; set; }
    public decimal? YtdRevenue { get; set; }
    public decimal? DayPayment { get; set; }
    public decimal? MtdPayment { get; set; }
    public decimal? YtdPayment { get; set; }
    public decimal? LydayRevenue { get; set; }
    public decimal? LymtdRevenue { get; set; }
    public decimal? LyytdRevenue { get; set; }
    public decimal? MonthBudget { get; set; }
    public decimal? YearBudget { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepNonrevenueSumm>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_NONREVENUE_SUMM");

            entity.Property(e => e.DayPayment)
                .HasColumnName("DAY_PAYMENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayRevenue)
                .HasColumnName("DAY_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LydayRevenue)
                .HasColumnName("LYDAY_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LymtdRevenue)
                .HasColumnName("LYMTD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LyytdRevenue)
                .HasColumnName("LYYTD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MonthBudget)
                .HasColumnName("MONTH_BUDGET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MtdPayment)
                .HasColumnName("MTD_PAYMENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MtdRevenue)
                .HasColumnName("MTD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcGroup)
                .IsRequired()
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .IsRequired()
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YearBudget)
                .HasColumnName("YEAR_BUDGET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdPayment)
                .HasColumnName("YTD_PAYMENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdRevenue)
                .HasColumnName("YTD_REVENUE")
                .HasColumnType("NUMBER");
        });
	}
}
