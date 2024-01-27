namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NameGoal1
{
    public decimal GoalId { get; set; }
    public decimal? NameId { get; set; }
    public string GoalType { get; set; }
    public string Resort { get; set; }
    public string ArrivalGoalYn { get; set; }
    public DateTime? ProductionStartdate { get; set; }
    public DateTime? ProductionEnddate { get; set; }
    public DateTime? ArrivalStartdate { get; set; }
    public DateTime? ArrivalEnddate { get; set; }
    public string MarketCode { get; set; }
    public decimal? RoomNights { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? RoomAvgRate { get; set; }
    public decimal? CateringCovers { get; set; }
    public decimal? CateringFbRevenue { get; set; }
    public decimal? CateringAvgCheck { get; set; }
    public decimal? CateringOtherRevenue { get; set; }
    public string ActType { get; set; }
    public decimal? ActNumber { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string PeriodType { get; set; }
    public string PeriodCode { get; set; }
    public string BudgetType { get; set; }
    public decimal? YearId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameGoal1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NAME_GOAL");

            entity.Property(e => e.ActNumber)
                .HasColumnName("ACT_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActType)
                .HasColumnName("ACT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalEnddate)
                .HasColumnName("ARRIVAL_ENDDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ArrivalGoalYn)
                .HasColumnName("ARRIVAL_GOAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalStartdate)
                .HasColumnName("ARRIVAL_STARTDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BudgetType)
                .HasColumnName("BUDGET_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CateringAvgCheck)
                .HasColumnName("CATERING_AVG_CHECK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CateringCovers)
                .HasColumnName("CATERING_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CateringFbRevenue)
                .HasColumnName("CATERING_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CateringOtherRevenue)
                .HasColumnName("CATERING_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GoalId)
                .HasColumnName("GOAL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GoalType)
                .IsRequired()
                .HasColumnName("GOAL_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PeriodCode)
                .HasColumnName("PERIOD_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PeriodType)
                .HasColumnName("PERIOD_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProductionEnddate)
                .HasColumnName("PRODUCTION_ENDDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProductionStartdate)
                .HasColumnName("PRODUCTION_STARTDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomAvgRate)
                .HasColumnName("ROOM_AVG_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNights)
                .HasColumnName("ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearId)
                .HasColumnName("YEAR_ID")
                .HasColumnType("NUMBER");
        });
	}
}
