namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemEvent
{
    public GemEvent()
    {
        CateringExternalReferences = new HashSet<CateringExternalReferences>();
        EventChanges = new HashSet<EventChanges>();
        EventItem = new HashSet<EventItem>();
        EventItemgroup = new HashSet<EventItemgroup>();
        EventLink = new HashSet<EventLink>();
        EventMenu = new HashSet<EventMenu>();
        EventNotes = new HashSet<EventNotes>();
        EventRegisteredAttendees = new HashSet<EventRegisteredAttendees>();
        EventReservation = new HashSet<EventReservation>();
        EventStatusChanges = new HashSet<EventStatusChanges>();
        GemEventPkgRevenue = new HashSet<GemEventPkgRevenue>();
        GemEventRevenue = new HashSet<GemEventRevenue>();
        InverseMasterEvent = new HashSet<GemEvent>();
        MeetingRoomWaitlist = new HashSet<MeetingRoomWaitlist>();
        ResourceNotes = new HashSet<ResourceNotes>();
    }

    public decimal EventId { get; set; }
    public decimal? MasterEventId { get; set; }
    public string Resort { get; set; }
    public decimal BookId { get; set; }
    public string EvType { get; set; }
    public string EvName { get; set; }
    public string EvStatus { get; set; }
    public decimal? PkgId { get; set; }
    public string WaitlistYn { get; set; }
    public string TurntoStatus { get; set; }
    public decimal? GroupId { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? ActualAttendees { get; set; }
    public string ActualManual { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime? Blockstart { get; set; }
    public DateTime? Blockend { get; set; }
    public decimal? Guaranteed { get; set; }
    public string Doorcard { get; set; }
    public string Room { get; set; }
    public string RoomSetup { get; set; }
    public decimal? SetupTime { get; set; }
    public decimal? SetdownTime { get; set; }
    public string Tracecode { get; set; }
    public string DontMoveYn { get; set; }
    public string ProblemYn { get; set; }
    public string WlIgnoreYn { get; set; }
    public string MasterYn { get; set; }
    public decimal? EventLinkId { get; set; }
    public string InspectedYn { get; set; }
    public DateTime? InspectedDate { get; set; }
    public decimal? InspectedUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string EvResort { get; set; }
    public string DoorcardYn { get; set; }
    public string EventLinkType { get; set; }
    public decimal? PkgExpAttendees { get; set; }
    public decimal? PkgGuaAttendees { get; set; }
    public decimal? PkgActAttendees { get; set; }
    public decimal? V6EventId { get; set; }
    public string ForecastRevenueOnlyYn { get; set; }
    public string ExcludeFromForecastYn { get; set; }
    public string PkgName { get; set; }
    public decimal? PkgLink { get; set; }
    public decimal? PkgEvId { get; set; }
    public decimal? SetAttendees { get; set; }
    public decimal? FbaId { get; set; }
    public string SelectRatecodeInCentralYn { get; set; }
    public string DetailedPostingYn { get; set; }
    public string AllowRegistryYn { get; set; }
    public decimal? OrigEventId { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }
    public virtual GemEventgroup Group { get; set; }
    public virtual GemEvent MasterEvent { get; set; }
    public virtual Resort ResortNavigation { get; set; }
    public virtual Room RoomNavigation { get; set; }
    public virtual ICollection<CateringExternalReferences> CateringExternalReferences { get; set; }
    public virtual ICollection<EventChanges> EventChanges { get; set; }
    public virtual ICollection<EventItem> EventItem { get; set; }
    public virtual ICollection<EventItemgroup> EventItemgroup { get; set; }
    public virtual ICollection<EventLink> EventLink { get; set; }
    public virtual ICollection<EventMenu> EventMenu { get; set; }
    public virtual ICollection<EventNotes> EventNotes { get; set; }
    public virtual ICollection<EventRegisteredAttendees> EventRegisteredAttendees { get; set; }
    public virtual ICollection<EventReservation> EventReservation { get; set; }
    public virtual ICollection<EventStatusChanges> EventStatusChanges { get; set; }
    public virtual ICollection<GemEventPkgRevenue> GemEventPkgRevenue { get; set; }
    public virtual ICollection<GemEventRevenue> GemEventRevenue { get; set; }
    public virtual ICollection<GemEvent> InverseMasterEvent { get; set; }
    public virtual ICollection<MeetingRoomWaitlist> MeetingRoomWaitlist { get; set; }
    public virtual ICollection<ResourceNotes> ResourceNotes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemEvent>(entity =>
        {
            entity.HasKey(e => e.EventId)
                .HasName("EV_PK");

            entity.ToTable("GEM$EVENT");

            entity.HasIndex(e => e.EndDate)
                .HasName("GE_ENDDATE_IDX");

            entity.HasIndex(e => e.EvStatus)
                .HasName("GE_BS_FK_IDX");

            entity.HasIndex(e => e.EvType)
                .HasName("GE_ET_FK_IDX");

            entity.HasIndex(e => e.GroupId)
                .HasName("GE_GROUPID_IDX");

            entity.HasIndex(e => e.MasterEventId)
                .HasName("GE_MASTERID_IDX");

            entity.HasIndex(e => e.Resort)
                .HasName("GE_RESORT_IDX");

            entity.HasIndex(e => e.StartDate)
                .HasName("GE_STARTDATE_IDX");

            entity.HasIndex(e => e.Tracecode)
                .HasName("GE_TRACECODE_IDX");

            entity.HasIndex(e => new { e.EventLinkType, e.EventLinkId })
                .HasName("GE_EVLINK_IDX");

            entity.HasIndex(e => new { e.Resort, e.InsertDate })
                .HasName("GE_INSERT_DATE_IDX");

            entity.HasIndex(e => new { e.Resort, e.UpdateDate })
                .HasName("GE_UPDATE_DATE_IDX");

            entity.HasIndex(e => new { e.EvResort, e.BookId, e.Resort })
                .HasName("GE_EVRESORT_IDX");

            entity.HasIndex(e => new { e.EvResort, e.Room, e.StartDate })
                .HasName("GE_ROOM_SD_IDX");

            entity.HasIndex(e => new { e.EvResort, e.StartDate, e.EndDate })
                .HasName("GE_EVRESORT_DATE_IDX");

            entity.HasIndex(e => new { e.BookId, e.Resort, e.PkgId, e.PkgLink, e.PkgEvId })
                .HasName("GE_BOOKING_IDX");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActualAttendees)
                .HasColumnName("ACTUAL_ATTENDEES")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActualManual)
                .HasColumnName("ACTUAL_MANUAL")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AllowRegistryYn)
                .HasColumnName("ALLOW_REGISTRY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Blockend)
                .HasColumnName("BLOCKEND")
                .HasColumnType("DATE");

            entity.Property(e => e.Blockstart)
                .HasColumnName("BLOCKSTART")
                .HasColumnType("DATE");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DetailedPostingYn)
                .HasColumnName("DETAILED_POSTING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DontMoveYn)
                .HasColumnName("DONT_MOVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Doorcard)
                .HasColumnName("DOORCARD")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DoorcardYn)
                .HasColumnName("DOORCARD_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EvName)
                .IsRequired()
                .HasColumnName("EV_NAME")
                .HasMaxLength(60)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EvResort)
                .IsRequired()
                .HasColumnName("EV_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EvStatus)
                .IsRequired()
                .HasColumnName("EV_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EvType)
                .IsRequired()
                .HasColumnName("EV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventLinkId)
                .HasColumnName("EVENT_LINK_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventLinkType)
                .HasColumnName("EVENT_LINK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExcludeFromForecastYn)
                .HasColumnName("EXCLUDE_FROM_FORECAST_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FbaId)
                .HasColumnName("FBA_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ForecastRevenueOnlyYn)
                .HasColumnName("FORECAST_REVENUE_ONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Guaranteed)
                .HasColumnName("GUARANTEED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InspectedDate)
                .HasColumnName("INSPECTED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InspectedUser)
                .HasColumnName("INSPECTED_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InspectedYn)
                .HasColumnName("INSPECTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MasterEventId)
                .HasColumnName("MASTER_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterYn)
                .HasColumnName("MASTER_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.OrigEventId)
                .HasColumnName("ORIG_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgActAttendees)
                .HasColumnName("PKG_ACT_ATTENDEES")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PkgEvId)
                .HasColumnName("PKG_EV_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgExpAttendees)
                .HasColumnName("PKG_EXP_ATTENDEES")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PkgGuaAttendees)
                .HasColumnName("PKG_GUA_ATTENDEES")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PkgLink)
                .HasColumnName("PKG_LINK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgName)
                .HasColumnName("PKG_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ProblemYn)
                .HasColumnName("PROBLEM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomSetup)
                .HasColumnName("ROOM_SETUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SelectRatecodeInCentralYn)
                .HasColumnName("SELECT_RATECODE_IN_CENTRAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SetAttendees)
                .HasColumnName("SET_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetdownTime)
                .HasColumnName("SETDOWN_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetupTime)
                .HasColumnName("SETUP_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tracecode)
                .HasColumnName("TRACECODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.TurntoStatus)
                .HasColumnName("TURNTO_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.V6EventId)
                .HasColumnName("V6_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WaitlistYn)
                .HasColumnName("WAITLIST_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.WlIgnoreYn)
                .HasColumnName("WL_IGNORE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(GemEventgroup)))
				entity.Ignore(e => e.Group);
			else
	            entity.HasOne(d => d.Group)
	                .WithMany(p => p.GemEvent)
	                .HasForeignKey(d => d.GroupId)
	                .HasConstraintName("GE_GROUP_FK");

			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.MasterEvent);
			else
	            entity.HasOne(d => d.MasterEvent)
	                .WithMany(p => p.InverseMasterEvent)
	                .HasForeignKey(d => d.MasterEventId)
	                .HasConstraintName("GE_MASTER_FK");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.GemEvent)
	                .HasForeignKey(d => d.Resort)
	                .HasConstraintName("GE_RESORT_FK");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.GemEvent)
	                .HasForeignKey(d => new { d.BookId, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("GE_BOOKING_FK");

			if (!types.Contains(typeof(Room)))
				entity.Ignore(e => e.RoomNavigation);
			else
	            entity.HasOne(d => d.RoomNavigation)
	                .WithMany(p => p.GemEvent)
	                .HasForeignKey(d => new { d.EvResort, d.Room })
	                .HasConstraintName("GE_ROOM_FK");
        
			if (!types.Contains(typeof(CateringExternalReferences)))
				entity.Ignore(e => e.CateringExternalReferences);

			if (!types.Contains(typeof(EventChanges)))
				entity.Ignore(e => e.EventChanges);

			if (!types.Contains(typeof(EventItem)))
				entity.Ignore(e => e.EventItem);

			if (!types.Contains(typeof(EventItemgroup)))
				entity.Ignore(e => e.EventItemgroup);

			if (!types.Contains(typeof(EventLink)))
				entity.Ignore(e => e.EventLink);

			if (!types.Contains(typeof(EventMenu)))
				entity.Ignore(e => e.EventMenu);

			if (!types.Contains(typeof(EventNotes)))
				entity.Ignore(e => e.EventNotes);

			if (!types.Contains(typeof(EventRegisteredAttendees)))
				entity.Ignore(e => e.EventRegisteredAttendees);

			if (!types.Contains(typeof(EventReservation)))
				entity.Ignore(e => e.EventReservation);

			if (!types.Contains(typeof(EventStatusChanges)))
				entity.Ignore(e => e.EventStatusChanges);

			if (!types.Contains(typeof(GemEventPkgRevenue)))
				entity.Ignore(e => e.GemEventPkgRevenue);

			if (!types.Contains(typeof(GemEventRevenue)))
				entity.Ignore(e => e.GemEventRevenue);

			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.InverseMasterEvent);

			if (!types.Contains(typeof(MeetingRoomWaitlist)))
				entity.Ignore(e => e.MeetingRoomWaitlist);

			if (!types.Contains(typeof(ResourceNotes)))
				entity.Ignore(e => e.ResourceNotes);
		});
	}
}
