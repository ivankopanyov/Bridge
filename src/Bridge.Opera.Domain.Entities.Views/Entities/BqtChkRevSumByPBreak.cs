namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BqtChkRevSumByPBreak
{
    public string RevenueSumPBreak { get; set; }
    public string RevenueSumName { get; set; }
    public string RevenueSumCurrency { get; set; }
    public decimal? RevenueSumAmount { get; set; }
    public decimal? ReportId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BqtChkRevSumByPBreak>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BQT_CHK_REV_SUM_BY_P_BREAK");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueSumAmount)
                .HasColumnName("REVENUE_SUM_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueSumCurrency)
                .HasColumnName("REVENUE_SUM_CURRENCY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RevenueSumName)
                .HasColumnName("REVENUE_SUM_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RevenueSumPBreak)
                .HasColumnName("REVENUE_SUM_P_BREAK")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
