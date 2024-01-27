namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameGoal
{
    public NameGoal()
    {
        NameGoalDetails = new HashSet<NameGoalDetails>();
        NameGoalRevtypes = new HashSet<NameGoalRevtypes>();
    }

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
    public byte? LaptopChange { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string PeriodType { get; set; }
    public string PeriodCode { get; set; }
    public string BudgetType { get; set; }
    public decimal? YearId { get; set; }

    public virtual Name Name { get; set; }
    public virtual ResortActivityTypes ResortActivityTypes { get; set; }
    public virtual ICollection<NameGoalDetails> NameGoalDetails { get; set; }
    public virtual ICollection<NameGoalRevtypes> NameGoalRevtypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameGoal>(entity =>
        {
            entity.HasKey(e => e.GoalId)
                .HasName("NGOAL_PK");

            entity.ToTable("NAME$GOAL");

            entity.HasIndex(e => e.NameId)
                .HasName("NGOAL_NAMEID_IDX");

            entity.HasIndex(e => new { e.ActType, e.Resort })
                .HasName("NGOAL_ACTTYPE_IDX");

            entity.HasIndex(e => new { e.Resort, e.GoalType, e.BudgetType, e.PeriodType, e.YearId, e.PeriodCode })
                .HasName("NGOAL_GOALTYPE_IDX");

            entity.Property(e => e.GoalId)
                .HasColumnName("GOAL_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.GoalType)
                .IsRequired()
                .HasColumnName("GOAL_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

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

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany(p => p.NameGoal)
	                .HasForeignKey(d => d.NameId)
	                .OnDelete(DeleteBehavior.Cascade)
	                .HasConstraintName("NGOAL_NAME_FK");

			if (!types.Contains(typeof(ResortActivityTypes)))
				entity.Ignore(e => e.ResortActivityTypes);
			else
	            entity.HasOne(d => d.ResortActivityTypes)
	                .WithMany(p => p.NameGoal)
	                .HasForeignKey(d => new { d.ActType, d.Resort })
	                .OnDelete(DeleteBehavior.Cascade)
	                .HasConstraintName("NGOAL_RAT_FK");
        
			if (!types.Contains(typeof(NameGoalDetails)))
				entity.Ignore(e => e.NameGoalDetails);

			if (!types.Contains(typeof(NameGoalRevtypes)))
				entity.Ignore(e => e.NameGoalRevtypes);
		});
	}
}
