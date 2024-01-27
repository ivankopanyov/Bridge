namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Room
{
    public Room()
    {
        GemEvent = new HashSet<GemEvent>();
        MeetingRoomDetails = new HashSet<MeetingRoomDetails>();
        MeetingRoomWaitlist = new HashSet<MeetingRoomWaitlist>();
        RoomComboRoom = new HashSet<RoomCombo>();
        RoomComboRoomNavigation = new HashSet<RoomCombo>();
        RoomRates = new HashSet<RoomRates>();
        RoomSetup = new HashSet<RoomSetup>();
        RoomVnPool = new HashSet<RoomVnPool>();
    }

    public string Resort { get; set; }
    public string Room1 { get; set; }
    public string RoomCategory { get; set; }
    public string RoomClass { get; set; }
    public string RoomStatus { get; set; }
    public string SuiteType { get; set; }
    public DateTime? RmStatusToDate { get; set; }
    public string RmStatusReason { get; set; }
    public string RmStatusRemarks { get; set; }
    public string ReturnStatus { get; set; }
    public decimal? Credits { get; set; }
    public decimal? CreditsDeparture { get; set; }
    public string FoStatus { get; set; }
    public decimal? FoPers { get; set; }
    public string FrontDeskLocation { get; set; }
    public decimal? SquareUnits { get; set; }
    public string SquareUnitMeasurement { get; set; }
    public string Floor { get; set; }
    public string Unit { get; set; }
    public string PhoneNumber { get; set; }
    public decimal? OrderBy { get; set; }
    public string KeyCode { get; set; }
    public string Pcode { get; set; }
    public string Building { get; set; }
    public decimal? MaxOccupancy { get; set; }
    public decimal? MinOccupancy { get; set; }
    public decimal? LastMeterReading { get; set; }
    public string AssignStatus { get; set; }
    public DateTime? RmStatusFromDate { get; set; }
    public string AssignType { get; set; }
    public string AssignReason { get; set; }
    public string OccupancyCondition { get; set; }
    public string HkStatus { get; set; }
    public decimal? HkPers { get; set; }
    public string HkInspFlag { get; set; }
    public DateTime? HkInspDate { get; set; }
    public string HkInspEmpId { get; set; }
    public string HkSectionCode { get; set; }
    public string RateCode { get; set; }
    public decimal? RackRate { get; set; }
    public string HkEveningSection { get; set; }
    public decimal? RoomUseCount { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal? AssignUid { get; set; }
    public DateTime? AssignDate { get; set; }
    public string Description { get; set; }
    public decimal? OccupantDiscrepancy { get; set; }
    public decimal? PersonDiscrepancy { get; set; }
    public string SmokingPreference { get; set; }
    public string PseudoYn { get; set; }
    public string MeetingroomYn { get; set; }
    public string Remarks { get; set; }
    public string ShareableYn { get; set; }
    public string DiaryDisplayYn { get; set; }
    public string DiaryName { get; set; }
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
    public decimal? ImageId { get; set; }
    public string Light { get; set; }
    public string Facing { get; set; }
    public string Doors { get; set; }
    public string LoudspeakersYn { get; set; }
    public decimal? TvRadioSockets { get; set; }
    public decimal? TranslationboothNum { get; set; }
    public decimal? MicrophoneSockets { get; set; }
    public string MicrophoneSocketTypes { get; set; }
    public string HandicapYn { get; set; }
    public string ComboYn { get; set; }
    public string MeetingroomType { get; set; }
    public string TurndownYn { get; set; }
    public decimal? MaxSharedGroups { get; set; }
    public decimal? OrderBy2 { get; set; }
    public decimal? OrderBy3 { get; set; }
    public decimal? OrderBy4 { get; set; }
    public decimal? OrderBy5 { get; set; }
    public string SetupNotes { get; set; }
    public decimal? CreditsPickup { get; set; }
    public string ServiceStatus { get; set; }
    public string ForceAlternateYn { get; set; }
    public decimal? CreditsTurndown { get; set; }
    public decimal? FullUtilizationTime { get; set; }
    public string ExcludedEventTypes { get; set; }
    public string OnlinePrintingYn { get; set; }
    public DateTime? HoldDateTime { get; set; }
    public decimal? HoldUser { get; set; }
    public string HoldType { get; set; }
    public string Comments { get; set; }
    public decimal? NoOfBeds { get; set; }
    public DateTime? LastCheckOutDate { get; set; }
    public string WebBookingYn { get; set; }
    public decimal? MinAdvance { get; set; }
    public decimal? MaxAdvance { get; set; }
    public decimal? MinimumRevenue { get; set; }
    public string OvosUnitYn { get; set; }
    public decimal? MaxCapacity { get; set; }
    public string VisibleOnWebYn { get; set; }
    public string OvosGradeCode { get; set; }

    public virtual ResortRoomClasses R { get; set; }
    public virtual ResortAssignmentReasons ResortAssignmentReasons { get; set; }
    public virtual ResortHkSections ResortHkSections { get; set; }
    public virtual ICollection<GemEvent> GemEvent { get; set; }
    public virtual ICollection<MeetingRoomDetails> MeetingRoomDetails { get; set; }
    public virtual ICollection<MeetingRoomWaitlist> MeetingRoomWaitlist { get; set; }
    public virtual ICollection<RoomCombo> RoomComboRoom { get; set; }
    public virtual ICollection<RoomCombo> RoomComboRoomNavigation { get; set; }
    public virtual ICollection<RoomRates> RoomRates { get; set; }
    public virtual ICollection<RoomSetup> RoomSetup { get; set; }
    public virtual ICollection<RoomVnPool> RoomVnPool { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Room1 })
                .HasName("ROOM_PK");

            entity.ToTable("ROOM");

            entity.HasIndex(e => new { e.HkSectionCode, e.Resort })
                .HasName("ROOM_HK_SECTIONS_FK_IDX");

            entity.HasIndex(e => new { e.Resort, e.AssignReason })
                .HasName("ROOM_ASSIGN_REASON_FK_IDX");

            entity.HasIndex(e => new { e.Resort, e.RoomCategory })
                .HasName("ROOM_ROOMCATEGORY_IDX");

            entity.HasIndex(e => new { e.Resort, e.RoomClass })
                .HasName("ROOM_ROOM_CLASS_FK_IDX");

            entity.HasIndex(e => new { e.OrderBy, e.Resort, e.Room1 })
                .HasName("ROOM_ORDER1_IDX");

            entity.HasIndex(e => new { e.OrderBy2, e.Resort, e.Room1 })
                .HasName("ROOM_ORDER2_IDX");

            entity.HasIndex(e => new { e.OrderBy3, e.Resort, e.Room1 })
                .HasName("ROOM_ORDER3_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Room1)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AreaF)
                .HasColumnName("AREA_F")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AreaM)
                .HasColumnName("AREA_M")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AssignDate)
                .HasColumnName("ASSIGN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AssignReason)
                .HasColumnName("ASSIGN_REASON")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AssignStatus)
                .HasColumnName("ASSIGN_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AssignType)
                .HasColumnName("ASSIGN_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AssignUid)
                .HasColumnName("ASSIGN_UID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Building)
                .HasColumnName("BUILDING")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ComboYn)
                .HasColumnName("COMBO_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Credits)
                .HasColumnName("CREDITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditsDeparture)
                .HasColumnName("CREDITS_DEPARTURE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditsPickup)
                .HasColumnName("CREDITS_PICKUP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditsTurndown)
                .HasColumnName("CREDITS_TURNDOWN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiaryDisplayYn)
                .HasColumnName("DIARY_DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiaryName)
                .HasColumnName("DIARY_NAME")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Doors)
                .HasColumnName("DOORS")
                .HasMaxLength(400)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExcludedEventTypes)
                .HasColumnName("EXCLUDED_EVENT_TYPES")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Facing)
                .HasColumnName("FACING")
                .HasMaxLength(400)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Floor)
                .HasColumnName("FLOOR")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FoPers)
                .HasColumnName("FO_PERS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FoStatus)
                .HasColumnName("FO_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ForceAlternateYn)
                .HasColumnName("FORCE_ALTERNATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FrontDeskLocation)
                .HasColumnName("FRONT_DESK_LOCATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FullUtilizationTime)
                .HasColumnName("FULL_UTILIZATION_TIME")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HandicapYn)
                .HasColumnName("HANDICAP_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HeightmaxF)
                .HasColumnName("HEIGHTMAX_F")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HeightmaxM)
                .HasColumnName("HEIGHTMAX_M")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HeightminF)
                .HasColumnName("HEIGHTMIN_F")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HeightminM)
                .HasColumnName("HEIGHTMIN_M")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HkEveningSection)
                .HasColumnName("HK_EVENING_SECTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HkInspDate)
                .HasColumnName("HK_INSP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.HkInspEmpId)
                .HasColumnName("HK_INSP_EMP_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HkInspFlag)
                .IsRequired()
                .HasColumnName("HK_INSP_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.HkPers)
                .HasColumnName("HK_PERS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HkSectionCode)
                .HasColumnName("HK_SECTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HkStatus)
                .IsRequired()
                .HasColumnName("HK_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HoldDateTime)
                .HasColumnName("HOLD_DATE_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HoldType)
                .HasColumnName("HOLD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HoldUser)
                .HasColumnName("HOLD_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ImageId)
                .HasColumnName("IMAGE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyCode)
                .HasColumnName("KEY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LastCheckOutDate)
                .HasColumnName("LAST_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastMeterReading)
                .HasColumnName("LAST_METER_READING")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LengthF)
                .HasColumnName("LENGTH_F")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LengthM)
                .HasColumnName("LENGTH_M")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Light)
                .HasColumnName("LIGHT")
                .HasMaxLength(400)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LoudspeakersYn)
                .HasColumnName("LOUDSPEAKERS_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxAdvance)
                .HasColumnName("MAX_ADVANCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxCapacity)
                .HasColumnName("MAX_CAPACITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxOccupancy)
                .HasColumnName("MAX_OCCUPANCY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaxSharedGroups)
                .HasColumnName("MAX_SHARED_GROUPS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MeetingroomType)
                .HasColumnName("MEETINGROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MeetingroomYn)
                .HasColumnName("MEETINGROOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.MicrophoneSocketTypes)
                .HasColumnName("MICROPHONE_SOCKET_TYPES")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MicrophoneSockets)
                .HasColumnName("MICROPHONE_SOCKETS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MinAdvance)
                .HasColumnName("MIN_ADVANCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MinOccupancy)
                .HasColumnName("MIN_OCCUPANCY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MinimumRevenue)
                .HasColumnName("MINIMUM_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoOfBeds)
                .HasColumnName("NO_OF_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OccupancyCondition)
                .HasColumnName("OCCUPANCY_CONDITION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OccupantDiscrepancy)
                .HasColumnName("OCCUPANT_DISCREPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OnlinePrintingYn)
                .HasColumnName("ONLINE_PRINTING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy2)
                .HasColumnName("ORDER_BY2")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy3)
                .HasColumnName("ORDER_BY3")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy4)
                .HasColumnName("ORDER_BY4")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy5)
                .HasColumnName("ORDER_BY5")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OvosGradeCode)
                .HasColumnName("OVOS_GRADE_CODE")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OvosUnitYn)
                .HasColumnName("OVOS_UNIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Pcode)
                .HasColumnName("PCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PersonDiscrepancy)
                .HasColumnName("PERSON_DISCREPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneNumber)
                .HasColumnName("PHONE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PseudoYn)
                .HasColumnName("PSEUDO_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.RackRate)
                .HasColumnName("RACK_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Remarks)
                .HasColumnName("REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReturnStatus)
                .HasColumnName("RETURN_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmStatusFromDate)
                .HasColumnName("RM_STATUS_FROM_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RmStatusReason)
                .HasColumnName("RM_STATUS_REASON")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RmStatusRemarks)
                .HasColumnName("RM_STATUS_REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RmStatusToDate)
                .HasColumnName("RM_STATUS_TO_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomClass)
                .IsRequired()
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomStatus)
                .IsRequired()
                .HasColumnName("ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomUseCount)
                .HasColumnName("ROOM_USE_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ServiceStatus)
                .HasColumnName("SERVICE_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SetupNotes)
                .HasColumnName("SETUP_NOTES")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShareableYn)
                .HasColumnName("SHAREABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SmokingPreference)
                .HasColumnName("SMOKING_PREFERENCE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SquareUnitMeasurement)
                .HasColumnName("SQUARE_UNIT_MEASUREMENT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SquareUnits)
                .HasColumnName("SQUARE_UNITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SuiteType)
                .HasColumnName("SUITE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TranslationboothNum)
                .HasColumnName("TRANSLATIONBOOTH_NUM")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TurndownYn)
                .HasColumnName("TURNDOWN_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.TvRadioSockets)
                .HasColumnName("TV_RADIO_SOCKETS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Unit)
                .HasColumnName("UNIT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VisibleOnWebYn)
                .HasColumnName("VISIBLE_ON_WEB_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WebBookingYn)
                .HasColumnName("WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WeightF)
                .HasColumnName("WEIGHT_F")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WeightM)
                .HasColumnName("WEIGHT_M")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WidthF)
                .HasColumnName("WIDTH_F")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WidthM)
                .HasColumnName("WIDTH_M")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ResortHkSections)))
				entity.Ignore(e => e.ResortHkSections);
			else
	            entity.HasOne(d => d.ResortHkSections)
	                .WithMany(p => p.Room)
	                .HasPrincipalKey(p => new { p.SectionCode, p.Resort })
	                .HasForeignKey(d => new { d.HkSectionCode, d.Resort })
	                .HasConstraintName("ROOM_HK_SECTIONS_FK");

			if (!types.Contains(typeof(ResortAssignmentReasons)))
				entity.Ignore(e => e.ResortAssignmentReasons);
			else
	            entity.HasOne(d => d.ResortAssignmentReasons)
	                .WithMany(p => p.Room)
	                .HasForeignKey(d => new { d.Resort, d.AssignReason })
	                .HasConstraintName("ROOM_ASSIGN_REASON_FK");

			if (!types.Contains(typeof(ResortRoomClasses)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.Room)
	                .HasForeignKey(d => new { d.Resort, d.RoomClass })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ROOM_ROOM_CLASS_FK");
        
			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.GemEvent);

			if (!types.Contains(typeof(MeetingRoomDetails)))
				entity.Ignore(e => e.MeetingRoomDetails);

			if (!types.Contains(typeof(MeetingRoomWaitlist)))
				entity.Ignore(e => e.MeetingRoomWaitlist);

			if (!types.Contains(typeof(RoomCombo)))
				entity.Ignore(e => e.RoomComboRoom);

			if (!types.Contains(typeof(RoomCombo)))
				entity.Ignore(e => e.RoomComboRoomNavigation);

			if (!types.Contains(typeof(RoomRates)))
				entity.Ignore(e => e.RoomRates);

			if (!types.Contains(typeof(RoomSetup)))
				entity.Ignore(e => e.RoomSetup);

			if (!types.Contains(typeof(RoomVnPool)))
				entity.Ignore(e => e.RoomVnPool);
		});
	}
}
