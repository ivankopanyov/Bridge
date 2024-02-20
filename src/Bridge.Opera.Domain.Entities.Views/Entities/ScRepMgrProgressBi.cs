namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScRepMgrProgressBi
{
    public decimal? ReportId { get; set; }
    public string? LabelGroupingId { get; set; }
    public string? StayGroupingId { get; set; }
    public string? BeginProductionDate { get; set; }
    public string? EndProductionDate { get; set; }
    public decimal? OwnerId { get; set; }
    public decimal? NewDefData { get; set; }
    public decimal? CancelData { get; set; }
    public decimal? RevalData { get; set; }
    public decimal? SlippageData { get; set; }
    public decimal? NetChangeData { get; set; }
    public decimal? PpRoomRevenue { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? Status1Rooms { get; set; }
    public decimal? Status1Data { get; set; }
    public decimal? Status2Rooms { get; set; }
    public decimal? Status2Data { get; set; }
    public decimal? Status3Rooms { get; set; }
    public decimal? Status3Data { get; set; }
    public decimal? Goal { get; set; }
    public decimal? NewDefDataDivisor { get; set; }
    public decimal? CancelDataDivisor { get; set; }
    public decimal? RevalDataDivisor { get; set; }
    public decimal? SlippageDataDivisor { get; set; }
    public decimal? NetChangeDataDivisor { get; set; }
    public decimal? PpRoomRevenueDivisor { get; set; }
    public decimal? FbRevenueDivisor { get; set; }
    public decimal? OtherRevenueDivisor { get; set; }
    public decimal? Status1RoomsDivisor { get; set; }
    public decimal? Status1DataDivisor { get; set; }
    public decimal? Status2RoomsDivisor { get; set; }
    public decimal? Status2DataDivisor { get; set; }
    public decimal? Status3RoomsDivisor { get; set; }
    public decimal? Status3DataDivisor { get; set; }
    public decimal? GoalDivisor { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScRepMgrProgressBi>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_REP_MGR_PROGRESS_BI");

            entity.Property(e => e.BeginProductionDate)
                .HasColumnName("BEGIN_PRODUCTION_DATE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CancelData)
                .HasColumnName("CANCEL_DATA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelDataDivisor)
                .HasColumnName("CANCEL_DATA_DIVISOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndProductionDate)
                .HasColumnName("END_PRODUCTION_DATE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRevenueDivisor)
                .HasColumnName("FB_REVENUE_DIVISOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Goal)
                .HasColumnName("GOAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GoalDivisor)
                .HasColumnName("GOAL_DIVISOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LabelGroupingId)
                .HasColumnName("LABEL_GROUPING_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NetChangeData)
                .HasColumnName("NET_CHANGE_DATA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetChangeDataDivisor)
                .HasColumnName("NET_CHANGE_DATA_DIVISOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewDefData)
                .HasColumnName("NEW_DEF_DATA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewDefDataDivisor)
                .HasColumnName("NEW_DEF_DATA_DIVISOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenueDivisor)
                .HasColumnName("OTHER_REVENUE_DIVISOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerId)
                .HasColumnName("OWNER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PpRoomRevenue)
                .HasColumnName("PP_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PpRoomRevenueDivisor)
                .HasColumnName("PP_ROOM_REVENUE_DIVISOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevalData)
                .HasColumnName("REVAL_DATA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevalDataDivisor)
                .HasColumnName("REVAL_DATA_DIVISOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SlippageData)
                .HasColumnName("SLIPPAGE_DATA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SlippageDataDivisor)
                .HasColumnName("SLIPPAGE_DATA_DIVISOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status1Data)
                .HasColumnName("STATUS1_DATA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status1DataDivisor)
                .HasColumnName("STATUS1_DATA_DIVISOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status1Rooms)
                .HasColumnName("STATUS1_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status1RoomsDivisor)
                .HasColumnName("STATUS1_ROOMS_DIVISOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status2Data)
                .HasColumnName("STATUS2_DATA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status2DataDivisor)
                .HasColumnName("STATUS2_DATA_DIVISOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status2Rooms)
                .HasColumnName("STATUS2_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status2RoomsDivisor)
                .HasColumnName("STATUS2_ROOMS_DIVISOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status3Data)
                .HasColumnName("STATUS3_DATA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status3DataDivisor)
                .HasColumnName("STATUS3_DATA_DIVISOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status3Rooms)
                .HasColumnName("STATUS3_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status3RoomsDivisor)
                .HasColumnName("STATUS3_ROOMS_DIVISOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayGroupingId)
                .HasColumnName("STAY_GROUPING_ID")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
