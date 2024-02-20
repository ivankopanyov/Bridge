namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConStayFolio
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? WindowNumber { get; set; }
    public decimal? BillNumber { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? RoomRate { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevAmt { get; set; }
    public decimal? BeverageRevenue { get; set; }
    public decimal? RoomRevenueAdjustment { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? GrpRoomQty { get; set; }
    public decimal? GrpRevAmt { get; set; }
    public decimal? ArrivalQty { get; set; }
    public decimal? WalkInd { get; set; }
    public decimal? HouseResvQty { get; set; }
    public decimal? CompRoomQty { get; set; }
    public decimal? SameDayCancQty { get; set; }
    public decimal? GuarNoshowQty { get; set; }
    public decimal? GuarNoshowRevAmt { get; set; }
    public decimal? TotalCount { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? NameId { get; set; }
    public decimal? NumOfRooms { get; set; }
    public string? GuestFirstName { get; set; }
    public string? GuestName { get; set; }
    public string? FfMemType { get; set; }
    public string? FfMemNumber { get; set; }
    public string? LoyalMemType { get; set; }
    public string? LoyalMemNumber { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomType { get; set; }
    public string? RoomNumber { get; set; }
    public string? PseudoRoomYn { get; set; }
    public string? AccomSeqNum { get; set; }
    public string? MarketCode { get; set; }
    public string? TaNumber { get; set; }
    public string? Udfc31 { get; set; }
    public string? CurrencyCode { get; set; }
    public string? RateCode { get; set; }
    public string? OriginalRateCode { get; set; }
    public string? BlockCode { get; set; }
    public string? AcctContact { get; set; }
    public string? GroupName { get; set; }
    public string? CompanyNameCode { get; set; }
    public string? PayType { get; set; }
    public string? PayRef { get; set; }
    public string? ExtRefNum { get; set; }
    public DateTime? StayDate { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? ArrivalTime { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public DateTime? DepartureTime { get; set; }
    public DateTime? OriginalCoDt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConStayFolio>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_STAY_FOLIO");

            entity.Property(e => e.AccomSeqNum)
                .HasColumnName("ACCOM_SEQ_NUM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AcctContact)
                .HasColumnName("ACCT_CONTACT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalQty)
                .HasColumnName("ARRIVAL_QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalTime)
                .HasColumnName("ARRIVAL_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.BeverageRevenue)
                .HasColumnName("BEVERAGE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNumber)
                .HasColumnName("BILL_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompRoomQty)
                .HasColumnName("COMP_ROOM_QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyNameCode)
                .HasColumnName("COMPANY_NAME_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepartureTime)
                .HasColumnName("DEPARTURE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtRefNum)
                .HasColumnName("EXT_REF_NUM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FfMemNumber)
                .HasColumnName("FF_MEM_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FfMemType)
                .HasColumnName("FF_MEM_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodRevAmt)
                .HasColumnName("FOOD_REV_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GrpRevAmt)
                .HasColumnName("GRP_REV_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrpRoomQty)
                .HasColumnName("GRP_ROOM_QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuarNoshowQty)
                .HasColumnName("GUAR_NOSHOW_QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuarNoshowRevAmt)
                .HasColumnName("GUAR_NOSHOW_REV_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HouseResvQty)
                .HasColumnName("HOUSE_RESV_QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LoyalMemNumber)
                .HasColumnName("LOYAL_MEM_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LoyalMemType)
                .HasColumnName("LOYAL_MEM_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumOfRooms)
                .HasColumnName("NUM_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginalCoDt)
                .HasColumnName("ORIGINAL_CO_DT")
                .HasColumnType("DATE");

            entity.Property(e => e.OriginalRateCode)
                .HasColumnName("ORIGINAL_RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PayRef)
                .HasColumnName("PAY_REF")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PayType)
                .HasColumnName("PAY_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PseudoRoomYn)
                .HasColumnName("PSEUDO_ROOM_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomNumber)
                .HasColumnName("ROOM_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomRate)
                .HasColumnName("ROOM_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueAdjustment)
                .HasColumnName("ROOM_REVENUE_ADJUSTMENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SameDayCancQty)
                .HasColumnName("SAME_DAY_CANC_QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaNumber)
                .HasColumnName("TA_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TotalCount)
                .HasColumnName("TOTAL_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfc31)
                .HasColumnName("UDFC31")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WalkInd)
                .HasColumnName("WALK_IND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WindowNumber)
                .HasColumnName("WINDOW_NUMBER")
                .HasColumnType("NUMBER");
        });
	}
}
