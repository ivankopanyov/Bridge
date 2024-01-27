namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RoomGrid
{
    public string Resort { get; set; }
    public string Building { get; set; }
    public string Room { get; set; }
    public string RoomClass { get; set; }
    public string Type { get; set; }
    public string RoomCategory { get; set; }
    public string Description { get; set; }
    public string RoomStatus { get; set; }
    public string RoomFeatures { get; set; }
    public decimal? MaxOccupancy { get; set; }
    public string Floor { get; set; }
    public string SmokingPreference { get; set; }
    public string FoStatus { get; set; }
    public string AssignType { get; set; }
    public decimal? PersonDiscrepancy { get; set; }
    public decimal? OccupantDiscrepancy { get; set; }
    public string AssignReason { get; set; }
    public decimal? RoomUseCount { get; set; }
    public decimal? RoomCatOrderBy { get; set; }
    public decimal? RoomOrderBy { get; set; }
    public string ResvStatus { get; set; }
    public string Remarks { get; set; }
    public string HkStatus { get; set; }
    public decimal? TotalPoints { get; set; }
    public DateTime? HoldDateTime { get; set; }
    public decimal? HoldUser { get; set; }
    public string Comments { get; set; }
    public decimal? ConsolidatedOrderBy { get; set; }
    public DateTime? LastCheckOutDate { get; set; }
    public decimal? TotForecastedPoints { get; set; }
    public string PsuedoRoomType { get; set; }
    public decimal? MaxCapacity { get; set; }
    public string OvosGradeCode { get; set; }
    public decimal? GradeCodeSeq { get; set; }
    public string HousekeeperInRoomYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomGrid>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ROOM_GRID");

            entity.Property(e => e.AssignReason)
                .HasColumnName("ASSIGN_REASON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AssignType)
                .HasColumnName("ASSIGN_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Building)
                .HasColumnName("BUILDING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ConsolidatedOrderBy)
                .HasColumnName("CONSOLIDATED_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Floor)
                .HasColumnName("FLOOR")
                .IsUnicode(false);

            entity.Property(e => e.FoStatus)
                .HasColumnName("FO_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GradeCodeSeq)
                .HasColumnName("GRADE_CODE_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HkStatus)
                .HasColumnName("HK_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.HoldDateTime)
                .HasColumnName("HOLD_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.HoldUser)
                .HasColumnName("HOLD_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HousekeeperInRoomYn)
                .HasColumnName("HOUSEKEEPER_IN_ROOM_YN")
                .IsUnicode(false);

            entity.Property(e => e.LastCheckOutDate)
                .HasColumnName("LAST_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MaxCapacity)
                .HasColumnName("MAX_CAPACITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxOccupancy)
                .HasColumnName("MAX_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccupantDiscrepancy)
                .HasColumnName("OCCUPANT_DISCREPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OvosGradeCode)
                .HasColumnName("OVOS_GRADE_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PersonDiscrepancy)
                .HasColumnName("PERSON_DISCREPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PsuedoRoomType)
                .HasColumnName("PSUEDO_ROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Remarks)
                .HasColumnName("REMARKS")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
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

            entity.Property(e => e.RoomFeatures)
                .HasColumnName("ROOM_FEATURES")
                .IsUnicode(false);

            entity.Property(e => e.RoomOrderBy)
                .HasColumnName("ROOM_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomStatus)
                .IsRequired()
                .HasColumnName("ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomUseCount)
                .HasColumnName("ROOM_USE_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SmokingPreference)
                .HasColumnName("SMOKING_PREFERENCE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TotForecastedPoints)
                .HasColumnName("TOT_FORECASTED_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPoints)
                .HasColumnName("TOTAL_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
