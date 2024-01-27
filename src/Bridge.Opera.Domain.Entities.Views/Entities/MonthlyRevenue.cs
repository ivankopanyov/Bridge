namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MonthlyRevenue
{
    public string Resort { get; set; }
    public string TrxCode { get; set; }
    public string TcGroup { get; set; }
    public string TcSubGroup { get; set; }
    public decimal? RevenueAmt { get; set; }
    public decimal? BudgetAmt { get; set; }
    public decimal? DiffAmt { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MonthlyRevenue>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MONTHLY_REVENUE");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BudgetAmt)
                .HasColumnName("BUDGET_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiffAmt)
                .HasColumnName("DIFF_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueAmt)
                .HasColumnName("REVENUE_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TcGroup)
                .IsRequired()
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubGroup)
                .IsRequired()
                .HasColumnName("TC_SUB_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
