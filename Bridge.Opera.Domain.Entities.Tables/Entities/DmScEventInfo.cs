namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DmScEventInfo
{
    public string Resort { get; set; }
    public decimal BookId { get; set; }
    public decimal EventId { get; set; }
    public string EvResort { get; set; }
    public string MasterYn { get; set; }
    public decimal? MasterEventId { get; set; }
    public string EvName { get; set; }
    public string EvType { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? SetupTime { get; set; }
    public decimal? SetdownTime { get; set; }
    public string EvStatus { get; set; }
    public string EvStatusDesc { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? SetAttendees { get; set; }
    public decimal? Guaranteed { get; set; }
    public decimal? ActualAttendees { get; set; }
    public decimal? FbaId { get; set; }
    public DateTime? Blockend { get; set; }
    public DateTime? Blockstart { get; set; }
    public string DontMoveYn { get; set; }
    public string Doorcard { get; set; }
    public string DoorcardYn { get; set; }
    public decimal? EventLinkId { get; set; }
    public string EventLinkType { get; set; }
    public string ExcludeFromForecastYn { get; set; }
    public string ForecastRevenueOnlyYn { get; set; }
    public string ProblemYn { get; set; }
    public decimal? ProgramId { get; set; }
    public string ProgramDesc { get; set; }
    public decimal? PkgId { get; set; }
    public string PkgName { get; set; }
    public decimal? PkgEvId { get; set; }
    public decimal? PkgActAttendees { get; set; }
    public decimal? PkgExpAttendees { get; set; }
    public decimal? PkgGuaAttendees { get; set; }
    public decimal? PkgLink { get; set; }
    public string RateCode { get; set; }
    public string RateCodeDesc { get; set; }
    public string Room { get; set; }
    public string RoomDesc { get; set; }
    public string RoomSetup { get; set; }
    public string RoomSetupDesc { get; set; }
    public string TurntoStatus { get; set; }
    public string TurntoStatusDesc { get; set; }
    public string WaitlistYn { get; set; }
    public string WlIgnoreYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? DmProcessed { get; set; }
    public string DmProcessedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DmScEventInfo>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.BookId, e.EventId })
                .HasName("DM_SC_EV_INFO_PK");

            entity.ToTable("DM_SC_EVENT_INFO");

            entity.HasIndex(e => new { e.DmProcessedYn, e.Resort, e.InsertDate })
                .HasName("DM_SC_EV_INFO_PROCESSED_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualAttendees)
                .HasColumnName("ACTUAL_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Blockend)
                .HasColumnName("BLOCKEND")
                .HasColumnType("DATE");

            entity.Property(e => e.Blockstart)
                .HasColumnName("BLOCKSTART")
                .HasColumnType("DATE");

            entity.Property(e => e.DmProcessed)
                .HasColumnName("DM_PROCESSED")
                .HasColumnType("DATE");

            entity.Property(e => e.DmProcessedYn)
                .HasColumnName("DM_PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DontMoveYn)
                .HasColumnName("DONT_MOVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Doorcard)
                .HasColumnName("DOORCARD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DoorcardYn)
                .HasColumnName("DOORCARD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EvName)
                .HasColumnName("EV_NAME")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.EvResort)
                .IsRequired()
                .HasColumnName("EV_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EvStatus)
                .HasColumnName("EV_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.EvStatusDesc)
                .HasColumnName("EV_STATUS_DESC")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EvType)
                .HasColumnName("EV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventLinkId)
                .HasColumnName("EVENT_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventLinkType)
                .HasColumnName("EVENT_LINK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExcludeFromForecastYn)
                .HasColumnName("EXCLUDE_FROM_FORECAST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FbaId)
                .HasColumnName("FBA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastRevenueOnlyYn)
                .HasColumnName("FORECAST_REVENUE_ONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Guaranteed)
                .HasColumnName("GUARANTEED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterEventId)
                .HasColumnName("MASTER_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterYn)
                .HasColumnName("MASTER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PkgActAttendees)
                .HasColumnName("PKG_ACT_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgEvId)
                .HasColumnName("PKG_EV_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgExpAttendees)
                .HasColumnName("PKG_EXP_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgGuaAttendees)
                .HasColumnName("PKG_GUA_ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER");

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
                .IsUnicode(false);

            entity.Property(e => e.ProgramDesc)
                .HasColumnName("PROGRAM_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ProgramId)
                .HasColumnName("PROGRAM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCodeDesc)
                .HasColumnName("RATE_CODE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomDesc)
                .HasColumnName("ROOM_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomSetup)
                .HasColumnName("ROOM_SETUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomSetupDesc)
                .HasColumnName("ROOM_SETUP_DESC")
                .HasMaxLength(200)
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
                .HasColumnType("DATE");

            entity.Property(e => e.TurntoStatus)
                .HasColumnName("TURNTO_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.TurntoStatusDesc)
                .HasColumnName("TURNTO_STATUS_DESC")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WaitlistYn)
                .HasColumnName("WAITLIST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WlIgnoreYn)
                .HasColumnName("WL_IGNORE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
