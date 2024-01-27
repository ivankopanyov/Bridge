namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConBlk
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? CompanyNameId { get; set; }
    public decimal? AgentNameId { get; set; }
    public decimal? GroupId { get; set; }
    public decimal? SourceNameId { get; set; }
    public decimal? ContactNameId { get; set; }
    public decimal? AgentContactNameId { get; set; }
    public decimal? OpenForPickup01 { get; set; }
    public string InclInBlkElementYn { get; set; }
    public string BookingType { get; set; }
    public string BlockCode { get; set; }
    public string InvBlockStatus { get; set; }
    public string RestdBookList { get; set; }
    public string CutoffDays { get; set; }
    public string OffsetCalcMode { get; set; }
    public string Channel { get; set; }
    public string PymtMethodDesc { get; set; }
    public string PymtMethod { get; set; }
    public string ResvMethod { get; set; }
    public string ResvType { get; set; }
    public string UpdateUser { get; set; }
    public string Status { get; set; }
    public string RateCode { get; set; }
    public string MarketCode { get; set; }
    public string CurrencyCode { get; set; }
    public string BlockName { get; set; }
    public string MarketCodeDesc { get; set; }
    public DateTime? BlockStartDate { get; set; }
    public DateTime? BlockEndDate { get; set; }
    public DateTime? CutoffDate { get; set; }
    public DateTime? CancelDate { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConBlk>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_BLK");

            entity.Property(e => e.AgentContactNameId)
                .HasColumnName("AGENT_CONTACT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentNameId)
                .HasColumnName("AGENT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BlockEndDate)
                .HasColumnName("BLOCK_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockName)
                .HasColumnName("BLOCK_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.BlockStartDate)
                .HasColumnName("BLOCK_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookingType)
                .HasColumnName("BOOKING_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CancelDate)
                .HasColumnName("CANCEL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CompanyNameId)
                .HasColumnName("COMPANY_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContactNameId)
                .HasColumnName("CONTACT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CutoffDate)
                .HasColumnName("CUTOFF_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CutoffDays)
                .HasColumnName("CUTOFF_DAYS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InclInBlkElementYn)
                .HasColumnName("INCL_IN_BLK_ELEMENT_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InvBlockStatus)
                .HasColumnName("INV_BLOCK_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketCodeDesc)
                .HasColumnName("MARKET_CODE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.OffsetCalcMode)
                .HasColumnName("OFFSET_CALC_MODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OpenForPickup01)
                .HasColumnName("OPEN_FOR_PICKUP_01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PymtMethod)
                .HasColumnName("PYMT_METHOD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PymtMethodDesc)
                .HasColumnName("PYMT_METHOD_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RestdBookList)
                .HasColumnName("RESTD_BOOK_LIST")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvMethod)
                .HasColumnName("RESV_METHOD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvType)
                .HasColumnName("RESV_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SourceNameId)
                .HasColumnName("SOURCE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
