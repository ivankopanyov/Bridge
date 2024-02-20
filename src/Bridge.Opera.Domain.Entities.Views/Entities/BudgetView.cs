namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BudgetView
{
    public decimal? GoalId { get; set; }
    public decimal? NameId { get; set; }
    public string? GoalType { get; set; }
    public string? Resort { get; set; }
    public DateTime? ArrivalStartdate { get; set; }
    public DateTime? ArrivalEnddate { get; set; }
    public decimal? RoomNights { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? RoomAvgRate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? YearId { get; set; }
    public string? BudgetType { get; set; }
    public string? PeriodCode { get; set; }
    public string? PeriodType { get; set; }
    public decimal? CateringFbRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BudgetView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BUDGET_VIEW");

            entity.Property(e => e.ArrivalEnddate)
                .HasColumnName("ARRIVAL_ENDDATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArrivalStartdate)
                .HasColumnName("ARRIVAL_STARTDATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BudgetType)
                .HasColumnName("BUDGET_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CateringFbRevenue)
                .HasColumnName("CATERING_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GoalId)
                .HasColumnName("GOAL_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GoalType)
                .IsRequired()
                .HasColumnName("GOAL_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PeriodCode)
                .HasColumnName("PERIOD_CODE")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PeriodType)
                .HasColumnName("PERIOD_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomAvgRate)
                .HasColumnName("ROOM_AVG_RATE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomNights)
                .HasColumnName("ROOM_NIGHTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YearId)
                .HasColumnName("YEAR_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
