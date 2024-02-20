namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiStayFactVw
{
    public DateTime? BusinessDate { get; set; }
    public string? StayRecordId { get; set; }
    public string? Resort { get; set; }
    public string? RecordType { get; set; }
    public string? RoomType { get; set; }
    public string? SourceCode { get; set; }
    public string? GuestNameId { get; set; }
    public string? CompanyNameId { get; set; }
    public string? ResInsertSource { get; set; }
    public string? TransactionRevenueType { get; set; }
    public string? RateCode { get; set; }
    public string? MarketCode { get; set; }
    public decimal? CancelledRoomNights { get; set; }
    public decimal? NoshowRoomNights { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? MiscRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? NumberStay { get; set; }
    public decimal? NumberNights { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? CTotalRevenue { get; set; }
    public decimal? CRoomRevenue { get; set; }
    public decimal? CFbRevenue { get; set; }
    public decimal? CMiscRevenue { get; set; }
    public decimal? COtherRevenue { get; set; }
    public decimal? RoomRevenueTax { get; set; }
    public decimal? FbRevenueTax { get; set; }
    public decimal? MiscRevenueTax { get; set; }
    public decimal? OtherRevenueTax { get; set; }
    public decimal? LocalTrxRev { get; set; }
    public decimal? CentralTrxRev { get; set; }
    public decimal? LocalDailyRateAmt { get; set; }
    public decimal? CentralDailyRateAmt { get; set; }
    public decimal? Rcnt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiStayFactVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_STAY_FACT_VW");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CFbRevenue)
                .HasColumnName("C_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CMiscRevenue)
                .HasColumnName("C_MISC_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.COtherRevenue)
                .HasColumnName("C_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRoomRevenue)
                .HasColumnName("C_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTotalRevenue)
                .HasColumnName("C_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelledRoomNights)
                .HasColumnName("CANCELLED_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CentralDailyRateAmt)
                .HasColumnName("CENTRAL_DAILY_RATE_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CentralTrxRev)
                .HasColumnName("CENTRAL_TRX_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyNameId)
                .HasColumnName("COMPANY_NAME_ID")
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRevenueTax)
                .HasColumnName("FB_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .IsUnicode(false);

            entity.Property(e => e.LocalDailyRateAmt)
                .HasColumnName("LOCAL_DAILY_RATE_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocalTrxRev)
                .HasColumnName("LOCAL_TRX_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .IsUnicode(false);

            entity.Property(e => e.MiscRevenue)
                .HasColumnName("MISC_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MiscRevenueTax)
                .HasColumnName("MISC_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoshowRoomNights)
                .HasColumnName("NOSHOW_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberNights)
                .HasColumnName("NUMBER_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberStay)
                .HasColumnName("NUMBER_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenueTax)
                .HasColumnName("OTHER_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.Rcnt)
                .HasColumnName("RCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.ResInsertSource)
                .HasColumnName("RES_INSERT_SOURCE")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenueTax)
                .HasColumnName("ROOM_REVENUE_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .IsUnicode(false);

            entity.Property(e => e.StayRecordId)
                .HasColumnName("STAY_RECORD_ID")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransactionRevenueType)
                .HasColumnName("TRANSACTION_REVENUE_TYPE")
                .IsUnicode(false);
        });
	}
}
