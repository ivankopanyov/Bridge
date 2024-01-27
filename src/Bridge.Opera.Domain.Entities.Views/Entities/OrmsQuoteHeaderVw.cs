namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsQuoteHeaderVw
{
    public decimal RequestId { get; set; }
    public string Resort { get; set; }
    public decimal QRequestId { get; set; }
    public string QResort { get; set; }
    public string QBlockCode { get; set; }
    public decimal QAllotmentHeaderId { get; set; }
    public string QBlockStatus { get; set; }
    public DateTime QBlockBeginDate { get; set; }
    public DateTime QBlockEndDate { get; set; }
    public DateTime QRequestDate { get; set; }
    public string QRequestType { get; set; }
    public decimal? QRequestedAmount { get; set; }
    public decimal? QTotalRooms { get; set; }
    public string QInsertUserName { get; set; }
    public decimal QInsertUser { get; set; }
    public DateTime QInsertDate { get; set; }
    public string QUpdateUserName { get; set; }
    public decimal QUpdateUser { get; set; }
    public DateTime QUpdateDate { get; set; }
    public string BResort { get; set; }
    public decimal BookId { get; set; }
    public string AllotmentCode { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string BookingStatus { get; set; }
    public string Company { get; set; }
    public string City { get; set; }
    public string GroupName { get; set; }
    public decimal? TotalAmt { get; set; }
    public decimal? TotalRooms { get; set; }
    public decimal? TotalCost { get; set; }
    public decimal? RoomsForeEmpty { get; set; }
    public decimal? RespAmtForeEmpty { get; set; }
    public decimal? CostForeEmpty { get; set; }
    public decimal? RoomsForeYieldable { get; set; }
    public decimal? RespAmtForeYieldable { get; set; }
    public decimal? CostForeYieldable { get; set; }
    public decimal? RoomsForeNonyieldable { get; set; }
    public decimal? RespAmtForeNonyieldable { get; set; }
    public decimal? CostForeNonyieldable { get; set; }
    public decimal? RoomsOtbYieldable { get; set; }
    public decimal? RespAmtOtbYieldable { get; set; }
    public decimal? CostOtbYieldable { get; set; }
    public decimal? RoomsOtbNonyieldable { get; set; }
    public decimal? RespAmtOtbNonyieldable { get; set; }
    public decimal? CostOtbNonyieldable { get; set; }
    public string TotalDisplay { get; set; }
    public string ForeEmptyDisplay { get; set; }
    public string ForeYieldableDisplay { get; set; }
    public string ForeNonyieldableDisplay { get; set; }
    public string OtbYieldableDisplay { get; set; }
    public string OtbNonyieldableDisplay { get; set; }
    public string TotalCostDisplay { get; set; }
    public string CostForeEmptyDisplay { get; set; }
    public string CostForeYieldableDisplay { get; set; }
    public string CostForeNonyieldableDisplay { get; set; }
    public string CostOtbYieldableDisplay { get; set; }
    public string CostOtbNonyieldableDisplay { get; set; }
    public string TotalLabel { get; set; }
    public string CostLabel { get; set; }
    public decimal? RequestedRooms { get; set; }
    public decimal? ORoomsForeEmpty { get; set; }
    public decimal? Offset { get; set; }
    public decimal? OffsetAmt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsQuoteHeaderVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_QUOTE_HEADER_VW");

            entity.Property(e => e.AllotmentCode)
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BResort)
                .IsRequired()
                .HasColumnName("B_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingStatus)
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.CostForeEmpty)
                .HasColumnName("COST_FORE_EMPTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CostForeEmptyDisplay)
                .HasColumnName("COST_FORE_EMPTY_DISPLAY")
                .IsUnicode(false);

            entity.Property(e => e.CostForeNonyieldable)
                .HasColumnName("COST_FORE_NONYIELDABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CostForeNonyieldableDisplay)
                .HasColumnName("COST_FORE_NONYIELDABLE_DISPLAY")
                .IsUnicode(false);

            entity.Property(e => e.CostForeYieldable)
                .HasColumnName("COST_FORE_YIELDABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CostForeYieldableDisplay)
                .HasColumnName("COST_FORE_YIELDABLE_DISPLAY")
                .IsUnicode(false);

            entity.Property(e => e.CostLabel)
                .HasColumnName("COST_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.CostOtbNonyieldable)
                .HasColumnName("COST_OTB_NONYIELDABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CostOtbNonyieldableDisplay)
                .HasColumnName("COST_OTB_NONYIELDABLE_DISPLAY")
                .IsUnicode(false);

            entity.Property(e => e.CostOtbYieldable)
                .HasColumnName("COST_OTB_YIELDABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CostOtbYieldableDisplay)
                .HasColumnName("COST_OTB_YIELDABLE_DISPLAY")
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ForeEmptyDisplay)
                .HasColumnName("FORE_EMPTY_DISPLAY")
                .IsUnicode(false);

            entity.Property(e => e.ForeNonyieldableDisplay)
                .HasColumnName("FORE_NONYIELDABLE_DISPLAY")
                .IsUnicode(false);

            entity.Property(e => e.ForeYieldableDisplay)
                .HasColumnName("FORE_YIELDABLE_DISPLAY")
                .IsUnicode(false);

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ORoomsForeEmpty)
                .HasColumnName("O_ROOMS_FORE_EMPTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Offset)
                .HasColumnName("OFFSET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OffsetAmt)
                .HasColumnName("OFFSET_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtbNonyieldableDisplay)
                .HasColumnName("OTB_NONYIELDABLE_DISPLAY")
                .IsUnicode(false);

            entity.Property(e => e.OtbYieldableDisplay)
                .HasColumnName("OTB_YIELDABLE_DISPLAY")
                .IsUnicode(false);

            entity.Property(e => e.QAllotmentHeaderId)
                .HasColumnName("Q_ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QBlockBeginDate)
                .HasColumnName("Q_BLOCK_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.QBlockCode)
                .HasColumnName("Q_BLOCK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.QBlockEndDate)
                .HasColumnName("Q_BLOCK_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.QBlockStatus)
                .IsRequired()
                .HasColumnName("Q_BLOCK_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.QInsertDate)
                .HasColumnName("Q_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.QInsertUser)
                .HasColumnName("Q_INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QInsertUserName)
                .HasColumnName("Q_INSERT_USER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.QRequestDate)
                .HasColumnName("Q_REQUEST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.QRequestId)
                .HasColumnName("Q_REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QRequestType)
                .IsRequired()
                .HasColumnName("Q_REQUEST_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.QRequestedAmount)
                .HasColumnName("Q_REQUESTED_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QResort)
                .IsRequired()
                .HasColumnName("Q_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.QTotalRooms)
                .HasColumnName("Q_TOTAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QUpdateDate)
                .HasColumnName("Q_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.QUpdateUser)
                .HasColumnName("Q_UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QUpdateUserName)
                .HasColumnName("Q_UPDATE_USER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
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

            entity.Property(e => e.TotalAmt)
                .HasColumnName("TOTAL_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCost)
                .HasColumnName("TOTAL_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCostDisplay)
                .HasColumnName("TOTAL_COST_DISPLAY")
                .IsUnicode(false);

            entity.Property(e => e.TotalDisplay)
                .HasColumnName("TOTAL_DISPLAY")
                .IsUnicode(false);

            entity.Property(e => e.TotalLabel)
                .HasColumnName("TOTAL_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.TotalRooms)
                .HasColumnName("TOTAL_ROOMS")
                .HasColumnType("NUMBER");
        });
	}
}
