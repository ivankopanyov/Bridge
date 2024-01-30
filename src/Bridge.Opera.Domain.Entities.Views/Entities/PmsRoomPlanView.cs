namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PmsRoomPlanView
{
    public string? Room { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomStatus { get; set; }
    public string? Resort { get; set; }
    public string? Description { get; set; }
    public DateTime? StFromDt { get; set; }
    public DateTime? StEndDt { get; set; }
    public string? RoomClass { get; set; }
    public string? SmokingPreference { get; set; }
    public decimal? RoomUseCount { get; set; }
    public decimal? RoomCatOrderBy { get; set; }
    public decimal? RoomOrderBy { get; set; }
    public string? AssignType { get; set; }
    public string? AssignReason { get; set; }
    public DateTime? LastCheckOutDate { get; set; }
    public string? PsuedoRoomType { get; set; }
    public decimal? TotalPoints { get; set; }
    public decimal? TotForecastedPoints { get; set; }
    public string? OvosGradeCode { get; set; }
    public decimal? GradeCodeSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PmsRoomPlanView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PMS_ROOM_PLAN_VIEW");

            entity.Property(e => e.AssignReason)
                .HasColumnName("ASSIGN_REASON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AssignType)
                .HasColumnName("ASSIGN_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.GradeCodeSeq)
                .HasColumnName("GRADE_CODE_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastCheckOutDate)
                .HasColumnName("LAST_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OvosGradeCode)
                .HasColumnName("OVOS_GRADE_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PsuedoRoomType)
                .HasColumnName("PSUEDO_ROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCatOrderBy)
                .HasColumnName("ROOM_CAT_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .IsRequired()
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomOrderBy)
                .HasColumnName("ROOM_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomStatus)
                .HasColumnName("ROOM_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.RoomUseCount)
                .HasColumnName("ROOM_USE_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SmokingPreference)
                .HasColumnName("SMOKING_PREFERENCE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.StEndDt)
                .HasColumnName("ST_END_DT")
                .HasColumnType("DATE");

            entity.Property(e => e.StFromDt)
                .HasColumnName("ST_FROM_DT")
                .HasColumnType("DATE");

            entity.Property(e => e.TotForecastedPoints)
                .HasColumnName("TOT_FORECASTED_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPoints)
                .HasColumnName("TOTAL_POINTS")
                .HasColumnType("NUMBER");
        });
	}
}
