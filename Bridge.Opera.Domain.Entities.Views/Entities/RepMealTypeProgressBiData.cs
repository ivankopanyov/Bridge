namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepMealTypeProgressBiData
{
    public decimal? ReportId { get; set; }
    public string YearLabel { get; set; }
    public decimal? MonthOrderBy { get; set; }
    public string StatusListLabel { get; set; }
    public string LeftLabel { get; set; }
    public decimal? MealType1Covers { get; set; }
    public decimal? MealType2Covers { get; set; }
    public decimal? MealType3Covers { get; set; }
    public decimal? MealType4Covers { get; set; }
    public decimal? MealType5Covers { get; set; }
    public decimal? MealType1Revenue { get; set; }
    public decimal? MealType2Revenue { get; set; }
    public decimal? MealType3Revenue { get; set; }
    public decimal? MealType4Revenue { get; set; }
    public decimal? MealType5Revenue { get; set; }
    public decimal? RevType1Revenue { get; set; }
    public decimal? RevType2Revenue { get; set; }
    public decimal? RevType3Revenue { get; set; }
    public decimal? RevType4Revenue { get; set; }
    public decimal? MealType1Avg { get; set; }
    public decimal? MealType2Avg { get; set; }
    public decimal? MealType3Avg { get; set; }
    public decimal? MealType4Avg { get; set; }
    public decimal? MealType5Avg { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepMealTypeProgressBiData>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_MEAL_TYPE_PROGRESS_BI_DATA");

            entity.Property(e => e.LeftLabel)
                .HasColumnName("LEFT_LABEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MealType1Avg)
                .HasColumnName("MEAL_TYPE1_AVG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MealType1Covers)
                .HasColumnName("MEAL_TYPE1_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MealType1Revenue)
                .HasColumnName("MEAL_TYPE1_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MealType2Avg)
                .HasColumnName("MEAL_TYPE2_AVG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MealType2Covers)
                .HasColumnName("MEAL_TYPE2_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MealType2Revenue)
                .HasColumnName("MEAL_TYPE2_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MealType3Avg)
                .HasColumnName("MEAL_TYPE3_AVG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MealType3Covers)
                .HasColumnName("MEAL_TYPE3_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MealType3Revenue)
                .HasColumnName("MEAL_TYPE3_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MealType4Avg)
                .HasColumnName("MEAL_TYPE4_AVG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MealType4Covers)
                .HasColumnName("MEAL_TYPE4_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MealType4Revenue)
                .HasColumnName("MEAL_TYPE4_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MealType5Avg)
                .HasColumnName("MEAL_TYPE5_AVG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MealType5Covers)
                .HasColumnName("MEAL_TYPE5_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MealType5Revenue)
                .HasColumnName("MEAL_TYPE5_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MonthOrderBy)
                .HasColumnName("MONTH_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevType1Revenue)
                .HasColumnName("REV_TYPE1_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevType2Revenue)
                .HasColumnName("REV_TYPE2_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevType3Revenue)
                .HasColumnName("REV_TYPE3_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevType4Revenue)
                .HasColumnName("REV_TYPE4_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatusListLabel)
                .HasColumnName("STATUS_LIST_LABEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.YearLabel)
                .HasColumnName("YEAR_LABEL")
                .HasMaxLength(4)
                .IsUnicode(false);
        });
	}
}
