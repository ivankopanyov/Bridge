namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BudgetForecastCodes
{
    public string? Resort { get; set; }
    public string? BudgetCodeType { get; set; }
    public string? BudgetCode { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BudgetForecastCodes>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BUDGET_FORECAST_CODES");

            entity.HasIndex(e => new { e.Resort, e.BudgetCodeType, e.BudgetCode })
                .HasName("BUDGET_FORECAST_CODES_UK")
                .IsUnique();

            entity.Property(e => e.BudgetCode)
                .IsRequired()
                .HasColumnName("BUDGET_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BudgetCodeType)
                .IsRequired()
                .HasColumnName("BUDGET_CODE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
