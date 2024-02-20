namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BudgetGridDailyView
{
    public string? Resort { get; set; }
    public decimal? AccountingYear { get; set; }
    public string? BudgetType { get; set; }
    public string? BudgetCodeType { get; set; }
    public string? BudgetCodeValue { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? BudgetMonthNo { get; set; }
    public decimal? BudgetDayNo { get; set; }
    public string? BudgetDayDesc { get; set; }
    public string? BudgetMonthDesc { get; set; }
    public decimal? Revenue { get; set; }
    public decimal? RoomNights { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BudgetGridDailyView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BUDGET_GRID_DAILY_VIEW");

            entity.Property(e => e.AccountingYear)
                .HasColumnName("ACCOUNTING_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetCodeType)
                .IsRequired()
                .HasColumnName("BUDGET_CODE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BudgetCodeValue)
                .IsRequired()
                .HasColumnName("BUDGET_CODE_VALUE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BudgetDayDesc)
                .HasColumnName("BUDGET_DAY_DESC")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.BudgetDayNo)
                .HasColumnName("BUDGET_DAY_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetMonthDesc)
                .HasColumnName("BUDGET_MONTH_DESC")
                .IsUnicode(false);

            entity.Property(e => e.BudgetMonthNo)
                .HasColumnName("BUDGET_MONTH_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetType)
                .IsRequired()
                .HasColumnName("BUDGET_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Revenue)
                .HasColumnName("REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNights)
                .HasColumnName("ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");
        });
	}
}
