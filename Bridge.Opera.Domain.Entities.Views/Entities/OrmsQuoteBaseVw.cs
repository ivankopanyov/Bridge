namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsQuoteBaseVw
{
    public decimal RequestId { get; set; }
    public string Resort { get; set; }
    public decimal AllotmentHeaderId { get; set; }
    public string BlockStatus { get; set; }
    public DateTime RequestDate { get; set; }
    public string RequestType { get; set; }
    public DateTime BlockBeginDate { get; set; }
    public DateTime BlockEndDate { get; set; }
    public decimal? RequestedAmount { get; set; }
    public string ResponseStatus { get; set; }
    public DateTime AllotmentDate { get; set; }
    public string YieldCategory { get; set; }
    public decimal? RoomsOtbYieldable { get; set; }
    public decimal? RoomsForeYieldable { get; set; }
    public decimal? RoomsForeEmpty { get; set; }
    public decimal? RoomsOtbNonyieldable { get; set; }
    public decimal? RoomsForeNonyieldable { get; set; }
    public decimal? RespAmtOtbYieldable { get; set; }
    public decimal? RespAmtForeYieldable { get; set; }
    public decimal? RespAmtForeEmpty { get; set; }
    public decimal? RespAmtOtbNonyieldable { get; set; }
    public decimal? RespAmtForeNonyieldable { get; set; }
    public decimal? RowTotalAmt { get; set; }
    public decimal? RowTotalRooms { get; set; }
    public decimal RequestedRooms { get; set; }
    public decimal? ORoomsForeEmpty { get; set; }
    public decimal? TotalRooms { get; set; }
    public string BlockCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsQuoteBaseVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_QUOTE_BASE_VW");

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockBeginDate)
                .HasColumnName("BLOCK_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BlockEndDate)
                .HasColumnName("BLOCK_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockStatus)
                .IsRequired()
                .HasColumnName("BLOCK_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ORoomsForeEmpty)
                .HasColumnName("O_ROOMS_FORE_EMPTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestDate)
                .HasColumnName("REQUEST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestType)
                .IsRequired()
                .HasColumnName("REQUEST_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RequestedAmount)
                .HasColumnName("REQUESTED_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestedRooms)
                .HasColumnName("REQUESTED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RespAmtForeEmpty)
                .HasColumnName("RESP_AMT_FORE_EMPTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RespAmtForeNonyieldable)
                .HasColumnName("RESP_AMT_FORE_NONYIELDABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RespAmtForeYieldable)
                .HasColumnName("RESP_AMT_FORE_YIELDABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RespAmtOtbNonyieldable)
                .HasColumnName("RESP_AMT_OTB_NONYIELDABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RespAmtOtbYieldable)
                .HasColumnName("RESP_AMT_OTB_YIELDABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResponseStatus)
                .HasColumnName("RESPONSE_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RoomsForeEmpty)
                .HasColumnName("ROOMS_FORE_EMPTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsForeNonyieldable)
                .HasColumnName("ROOMS_FORE_NONYIELDABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsForeYieldable)
                .HasColumnName("ROOMS_FORE_YIELDABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsOtbNonyieldable)
                .HasColumnName("ROOMS_OTB_NONYIELDABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsOtbYieldable)
                .HasColumnName("ROOMS_OTB_YIELDABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowTotalAmt)
                .HasColumnName("ROW_TOTAL_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowTotalRooms)
                .HasColumnName("ROW_TOTAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRooms)
                .HasColumnName("TOTAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YieldCategory)
                .IsRequired()
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
