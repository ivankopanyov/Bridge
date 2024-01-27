namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TransactionRevenues
{
    public string Resort { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public decimal? Day { get; set; }
    public decimal? DayTimesUsed { get; set; }
    public decimal? Month { get; set; }
    public decimal? MonthTimesUsed { get; set; }
    public decimal? Year { get; set; }
    public decimal? YearTimesUsed { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TransactionRevenues>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TRANSACTION_REVENUES");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Day)
                .HasColumnName("DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayTimesUsed)
                .HasColumnName("DAY_TIMES_USED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Month)
                .HasColumnName("MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MonthTimesUsed)
                .HasColumnName("MONTH_TIMES_USED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Year)
                .HasColumnName("YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearTimesUsed)
                .HasColumnName("YEAR_TIMES_USED")
                .HasColumnType("NUMBER");
        });
	}
}
