namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiScNameGoalFact
{
    public string Resort { get; set; }
    public string ActType { get; set; }
    public string MarketCode { get; set; }
    public DateTime? GoalStartdate { get; set; }
    public DateTime? GoalEnddate { get; set; }
    public string GoalType { get; set; }
    public decimal? OwnerNameId { get; set; }
    public decimal? GoalRoomNights { get; set; }
    public decimal? GoalRoomRevenue { get; set; }
    public decimal? GoalFbRevenue { get; set; }
    public decimal? GoalOtherRevenue { get; set; }
    public decimal? GoalCateringCovers { get; set; }
    public decimal? GoalTotalActivities { get; set; }
    public decimal? Roomnight { get; set; }
    public decimal? Roomblockrevgross { get; set; }
    public decimal? Roomblockrevnet { get; set; }
    public decimal? Rmcontractrev { get; set; }
    public decimal? Rmcontract { get; set; }
    public decimal? Pickrmnight { get; set; }
    public decimal? Pickrmrev { get; set; }
    public decimal? Catfbrev { get; set; }
    public decimal? Catotherrev { get; set; }
    public decimal? Catconvers { get; set; }
    public decimal? Totalactivities { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiScNameGoalFact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SC_NAME_GOAL_FACT");

            entity.Property(e => e.ActType)
                .HasColumnName("ACT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Catconvers)
                .HasColumnName("CATCONVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Catfbrev)
                .HasColumnName("CATFBREV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Catotherrev)
                .HasColumnName("CATOTHERREV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GoalCateringCovers)
                .HasColumnName("GOAL_CATERING_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GoalEnddate)
                .HasColumnName("GOAL_ENDDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GoalFbRevenue)
                .HasColumnName("GOAL_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GoalOtherRevenue)
                .HasColumnName("GOAL_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GoalRoomNights)
                .HasColumnName("GOAL_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GoalRoomRevenue)
                .HasColumnName("GOAL_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GoalStartdate)
                .HasColumnName("GOAL_STARTDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GoalTotalActivities)
                .HasColumnName("GOAL_TOTAL_ACTIVITIES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GoalType)
                .HasColumnName("GOAL_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OwnerNameId)
                .HasColumnName("OWNER_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Pickrmnight)
                .HasColumnName("PICKRMNIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Pickrmrev)
                .HasColumnName("PICKRMREV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Rmcontract)
                .HasColumnName("RMCONTRACT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rmcontractrev)
                .HasColumnName("RMCONTRACTREV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Roomblockrevgross)
                .HasColumnName("ROOMBLOCKREVGROSS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Roomblockrevnet)
                .HasColumnName("ROOMBLOCKREVNET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Roomnight)
                .HasColumnName("ROOMNIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totalactivities)
                .HasColumnName("TOTALACTIVITIES")
                .HasColumnType("NUMBER");
        });
	}
}
