namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MeetingRoom
{
    public string? Resort { get; set; }
    public string? Room { get; set; }
    public string? Description { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomClass { get; set; }
    public string? MeetingroomType { get; set; }
    public string? SuiteType { get; set; }
    public string? RoomStatus { get; set; }
    public DateTime? RmStatusFromDate { get; set; }
    public DateTime? RmStatusToDate { get; set; }
    public string? RmStatusReason { get; set; }
    public string? RmStatusRemarks { get; set; }
    public string? Floor { get; set; }
    public decimal? OrderBy { get; set; }
    public string? KeyCode { get; set; }
    public string? Building { get; set; }
    public decimal? MaxOccupancy { get; set; }
    public decimal? MinOccupancy { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Remarks { get; set; }
    public string? ShareableYn { get; set; }
    public string? DiaryDisplayYn { get; set; }
    public decimal? AreaF { get; set; }
    public decimal? AreaM { get; set; }
    public decimal? LengthF { get; set; }
    public decimal? LengthM { get; set; }
    public decimal? WidthF { get; set; }
    public decimal? WidthM { get; set; }
    public decimal? HeightminF { get; set; }
    public decimal? HeightminM { get; set; }
    public decimal? HeightmaxF { get; set; }
    public decimal? HeightmaxM { get; set; }
    public decimal? WeightF { get; set; }
    public decimal? WeightM { get; set; }
    public string? Light { get; set; }
    public string? Facing { get; set; }
    public string? Doors { get; set; }
    public string? LoudspeakersYn { get; set; }
    public decimal? TvRadioSockets { get; set; }
    public decimal? TranslationboothNum { get; set; }
    public decimal? MicrophoneSockets { get; set; }
    public string? MicrophoneSocketTypes { get; set; }
    public string? HandicapYn { get; set; }
    public string? ComboYn { get; set; }
    public string? DiaryName { get; set; }
    public decimal? OrderBy2 { get; set; }
    public decimal? OrderBy3 { get; set; }
    public decimal? OrderBy4 { get; set; }
    public decimal? OrderBy5 { get; set; }
    public string? ForceAlternateYn { get; set; }
    public decimal? FullUtilizationTime { get; set; }
    public string? ExcludedEventTypes { get; set; }
    public string? WebBookingYn { get; set; }
    public decimal? MinAdvance { get; set; }
    public decimal? MaxAdvance { get; set; }
    public decimal? MinimumRevenue { get; set; }
    public decimal? MaxCapacity { get; set; }
    public string? VisibleOnWebYn { get; set; }
    public string? SetupNotes { get; set; }
    public decimal? MaxSharedGroups { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MeetingRoom>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEETING_ROOM");

            entity.Property(e => e.AreaF)
                .HasColumnName("AREA_F")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AreaM)
                .HasColumnName("AREA_M")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Building)
                .HasColumnName("BUILDING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ComboYn)
                .HasColumnName("COMBO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DiaryDisplayYn)
                .HasColumnName("DIARY_DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DiaryName)
                .HasColumnName("DIARY_NAME")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Doors)
                .HasColumnName("DOORS")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.ExcludedEventTypes)
                .HasColumnName("EXCLUDED_EVENT_TYPES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Facing)
                .HasColumnName("FACING")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.Floor)
                .HasColumnName("FLOOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ForceAlternateYn)
                .HasColumnName("FORCE_ALTERNATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FullUtilizationTime)
                .HasColumnName("FULL_UTILIZATION_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HandicapYn)
                .HasColumnName("HANDICAP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HeightmaxF)
                .HasColumnName("HEIGHTMAX_F")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HeightmaxM)
                .HasColumnName("HEIGHTMAX_M")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HeightminF)
                .HasColumnName("HEIGHTMIN_F")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HeightminM)
                .HasColumnName("HEIGHTMIN_M")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyCode)
                .HasColumnName("KEY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LengthF)
                .HasColumnName("LENGTH_F")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LengthM)
                .HasColumnName("LENGTH_M")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Light)
                .HasColumnName("LIGHT")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.LoudspeakersYn)
                .HasColumnName("LOUDSPEAKERS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MaxAdvance)
                .HasColumnName("MAX_ADVANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxCapacity)
                .HasColumnName("MAX_CAPACITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxOccupancy)
                .HasColumnName("MAX_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxSharedGroups)
                .HasColumnName("MAX_SHARED_GROUPS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MeetingroomType)
                .HasColumnName("MEETINGROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MicrophoneSocketTypes)
                .HasColumnName("MICROPHONE_SOCKET_TYPES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MicrophoneSockets)
                .HasColumnName("MICROPHONE_SOCKETS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinAdvance)
                .HasColumnName("MIN_ADVANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinOccupancy)
                .HasColumnName("MIN_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinimumRevenue)
                .HasColumnName("MINIMUM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy2)
                .HasColumnName("ORDER_BY2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy3)
                .HasColumnName("ORDER_BY3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy4)
                .HasColumnName("ORDER_BY4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy5)
                .HasColumnName("ORDER_BY5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Remarks)
                .HasColumnName("REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmStatusFromDate)
                .HasColumnName("RM_STATUS_FROM_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RmStatusReason)
                .HasColumnName("RM_STATUS_REASON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmStatusRemarks)
                .HasColumnName("RM_STATUS_REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RmStatusToDate)
                .HasColumnName("RM_STATUS_TO_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.RoomStatus)
                .IsRequired()
                .HasColumnName("ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SetupNotes)
                .HasColumnName("SETUP_NOTES")
                .IsUnicode(false);

            entity.Property(e => e.ShareableYn)
                .HasColumnName("SHAREABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SuiteType)
                .HasColumnName("SUITE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TranslationboothNum)
                .HasColumnName("TRANSLATIONBOOTH_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TvRadioSockets)
                .HasColumnName("TV_RADIO_SOCKETS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VisibleOnWebYn)
                .HasColumnName("VISIBLE_ON_WEB_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WebBookingYn)
                .HasColumnName("WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WeightF)
                .HasColumnName("WEIGHT_F")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WeightM)
                .HasColumnName("WEIGHT_M")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WidthF)
                .HasColumnName("WIDTH_F")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WidthM)
                .HasColumnName("WIDTH_M")
                .HasColumnType("NUMBER");
        });
	}
}
