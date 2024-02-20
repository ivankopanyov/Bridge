namespace Bridge.Opera.Domain.Entities.Tables;

public partial class HskRsAction
{
    public decimal? Id { get; set; }
    public string? Resort { get; set; }
    public string? AttendantId { get; set; }
    public string? Room { get; set; }
    public string? RoomCategory { get; set; }
    public DateTime? BusinessDate { get; set; }
    public DateTime? TimeIn { get; set; }
    public DateTime? TimeOut { get; set; }
    public string? RoomStatus { get; set; }
    public string? HskStatus { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? TaskSheetNo { get; set; }
    public string? MostRecentYn { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? StartRoomStatus { get; set; }
    public string? EndRoomStatus { get; set; }
    public decimal? TaskSeqNo { get; set; }
    public string? FoStatus { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public string? VipCode { get; set; }
    public string? MembershipType { get; set; }
    public string? MembershipLevel { get; set; }
    public string? RateCode { get; set; }
    public string? MarketCode { get; set; }
    public string? TaskCode { get; set; }
    public string? Type { get; set; }
    public decimal? AllottedMinutes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HskRsAction>(entity =>
        {
            entity.ToTable("HSK_RS_ACTION");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate, e.MostRecentYn })
                .HasName("RESORT_RECENT_IDX");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate, e.Room })
                .HasName("HRA_RES_BD_RM_IDX");

            entity.HasIndex(e => new { e.Resort, e.Room, e.BusinessDate, e.AttendantId })
                .HasName("RESORT_RM_ATTENDANT_IDX");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate, e.AttendantId, e.Type, e.TaskSeqNo, e.Room })
                .HasName("HRA_BD_ATTENDANT_TYPE_IDX");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllottedMinutes)
                .HasColumnName("ALLOTTED_MINUTES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttendantId)
                .IsRequired()
                .HasColumnName("ATTENDANT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndRoomStatus)
                .HasColumnName("END_ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FoStatus)
                .HasColumnName("FO_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HskStatus)
                .HasColumnName("HSK_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MostRecentYn)
                .HasColumnName("MOST_RECENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomStatus)
                .HasColumnName("ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartRoomStatus)
                .HasColumnName("START_ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaskSeqNo)
                .HasColumnName("TASK_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaskSheetNo)
                .HasColumnName("TASK_SHEET_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TimeIn)
                .HasColumnName("TIME_IN")
                .HasColumnType("DATE");

            entity.Property(e => e.TimeOut)
                .HasColumnName("TIME_OUT")
                .HasColumnType("DATE");

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VipCode)
                .HasColumnName("VIP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
