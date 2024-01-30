namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationDailyElements
{
    public string? Resort { get; set; }
    public DateTime? ReservationDate { get; set; }
    public decimal? ResvDailyElSeq { get; set; }
    public string? ResvStatus { get; set; }
    public string? ExternalReference { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomCategory { get; set; }
    public string? BookedRoomCategory { get; set; }
    public string? Room { get; set; }
    public decimal? CancellationNo { get; set; }
    public DateTime? CancellationDate { get; set; }
    public string? CancellationCode { get; set; }
    public string? CancellationReasonDesc { get; set; }
    public string? GuaranteeCode { get; set; }
    public string? MarketCode { get; set; }
    public string? OriginOfBooking { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? OriginalBaseRate { get; set; }
    public decimal? BaseRateAmount { get; set; }
    public decimal? RateAmount { get; set; }
    public decimal? RoomCost { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? PhysicalQuantity { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? DayUseYn { get; set; }
    public string? DueOutYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? InsertActionInstanceId { get; set; }
    public decimal? DmlSeqNo { get; set; }
    public decimal? ExtSeqNo { get; set; }
    public decimal? ExtSegNo { get; set; }
    public decimal? Cribs { get; set; }
    public decimal? ExtraBeds { get; set; }
    public string? AllotmentRecordType { get; set; }
    public string? BlockResort { get; set; }
    public decimal? BlockId { get; set; }
    public string? TurndownStatus { get; set; }
    public string? AwdUpgrFrom { get; set; }
    public string? AwdUpgrTo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationDailyElements>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ReservationDate, e.ResvDailyElSeq })
                .HasName("RESERVATION_DAILY_ELEMENTS_PK");

            entity.ToTable("RESERVATION_DAILY_ELEMENTS");

            entity.HasIndex(e => new { e.MarketCode, e.Resort })
                .HasName("RDE_MARKET_CODE_IND");

            entity.HasIndex(e => new { e.BlockResort, e.BlockId, e.RoomCategory })
                .HasName("RDE_BLOCK_CAT_IND");

            entity.HasIndex(e => new { e.Resort, e.AllotmentHeaderId, e.ReservationDate })
                .HasName("RDE_BLOCK_DATE_IND");

            entity.HasIndex(e => new { e.Resort, e.AllotmentHeaderId, e.RoomCategory })
                .HasName("RDE_BLOCK_IND");

            entity.HasIndex(e => new { e.Resort, e.ExternalReference, e.ExtSegNo })
                .HasName("RDE_EXT_REF_IND1");

            entity.HasIndex(e => new { e.Room, e.ReservationDate, e.ResvStatus })
                .HasName("RESVDE_RES_RM_DT_ST_IDX_MP");

            entity.HasIndex(e => new { e.Resort, e.Room, e.ReservationDate, e.DueOutYn })
                .HasName("RES_RM_DT_DUE_OUT_IDX");

            entity.HasIndex(e => new { e.Resort, e.Room, e.ReservationDate, e.ResvStatus })
                .HasName("RESVDE_RES_RM_DT_ST_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvDailyElSeq)
                .HasColumnName("RESV_DAILY_EL_SEQ")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AllotmentRecordType)
                .HasColumnName("ALLOTMENT_RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwdUpgrFrom)
                .HasColumnName("AWD_UPGR_FROM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AwdUpgrTo)
                .HasColumnName("AWD_UPGR_TO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BaseRateAmount)
                .HasColumnName("BASE_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockId)
                .HasColumnName("BLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockResort)
                .HasColumnName("BLOCK_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookedRoomCategory)
                .IsRequired()
                .HasColumnName("BOOKED_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CancellationCode)
                .HasColumnName("CANCELLATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancellationNo)
                .HasColumnName("CANCELLATION_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancellationReasonDesc)
                .HasColumnName("CANCELLATION_REASON_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Cribs)
                .HasColumnName("CRIBS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DayUseYn)
                .HasColumnName("DAY_USE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DmlSeqNo)
                .HasColumnName("DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DueOutYn)
                .HasColumnName("DUE_OUT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtSegNo)
                .HasColumnName("EXT_SEG_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExtSeqNo)
                .HasColumnName("EXT_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalReference)
                .HasColumnName("EXTERNAL_REFERENCE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ExtraBeds)
                .HasColumnName("EXTRA_BEDS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertActionInstanceId)
                .HasColumnName("INSERT_ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OriginOfBooking)
                .HasColumnName("ORIGIN_OF_BOOKING")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OriginalBaseRate)
                .HasColumnName("ORIGINAL_BASE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhysicalQuantity)
                .HasColumnName("PHYSICAL_QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCost)
                .HasColumnName("ROOM_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TurndownStatus)
                .HasColumnName("TURNDOWN_STATUS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
