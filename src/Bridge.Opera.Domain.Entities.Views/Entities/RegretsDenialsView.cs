namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RegretsDenialsView
{
    public decimal? ReservationRegretId { get; set; }
    public string? RegretDenialFlg { get; set; }
    public string? Resort { get; set; }
    public decimal? NameId { get; set; }
    public string? GuestName { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public decimal? Nights { get; set; }
    public decimal? NoOfRooms { get; set; }
    public string? MarketCode { get; set; }
    public string? MarketDesc { get; set; }
    public string? TurnawayCode { get; set; }
    public string? TurnawayDesc { get; set; }
    public decimal? CreatedByUid { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? CreatedOn { get; set; }
    public string? RateCode { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomCategoryLabel { get; set; }
    public string? TurnawayComments { get; set; }
    public decimal? RequestId { get; set; }
    public DateTime? RequestDate { get; set; }
    public string? RequestType { get; set; }
    public string? RequestSourceType { get; set; }
    public string? RequestSource { get; set; }
    public string? RequestedResort { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? TravelAgentId { get; set; }
    public string? TravelAgentName { get; set; }
    public decimal? SourceId { get; set; }
    public string? SourceName { get; set; }
    public decimal? GroupId { get; set; }
    public string? GroupName { get; set; }
    public decimal? CompanyId { get; set; }
    public string? CompanyName { get; set; }
    public string? SgaCode { get; set; }
    public string? PseudoCity { get; set; }
    public string? City { get; set; }
    public string? PromotionCode { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? AllotmentCode { get; set; }
    public string? RequestedRateCode { get; set; }
    public string? RegionCode { get; set; }
    public string? CallBegin { get; set; }
    public string? CallEnd { get; set; }
    public string? CallerName { get; set; }
    public string? CallerPhone { get; set; }
    public string? CallerFax { get; set; }
    public string? CallerEmail { get; set; }
    public string? IataNo { get; set; }
    public string? CorpNo { get; set; }
    public string? FpcNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RegretsDenialsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REGRETS_DENIALS_VIEW");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentCode)
                .HasColumnName("ALLOTMENT_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CallBegin)
                .HasColumnName("CALL_BEGIN")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.CallEnd)
                .HasColumnName("CALL_END")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.CallerEmail)
                .HasColumnName("CALLER_EMAIL")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CallerFax)
                .HasColumnName("CALLER_FAX")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CallerName)
                .HasColumnName("CALLER_NAME")
                .HasMaxLength(361)
                .IsUnicode(false);

            entity.Property(e => e.CallerPhone)
                .HasColumnName("CALLER_PHONE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.CorpNo)
                .HasColumnName("CORP_NO")
                .IsUnicode(false);

            entity.Property(e => e.CreatedBy)
                .HasColumnName("CREATED_BY")
                .IsUnicode(false);

            entity.Property(e => e.CreatedByUid)
                .HasColumnName("CREATED_BY_UID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreatedOn)
                .HasColumnName("CREATED_ON")
                .HasColumnType("DATE");

            entity.Property(e => e.FpcNo)
                .HasColumnName("FPC_NO")
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.IataNo)
                .HasColumnName("IATA_NO")
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketDesc)
                .HasColumnName("MARKET_DESC")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PromotionCode)
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PseudoCity)
                .HasColumnName("PSEUDO_CITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RegretDenialFlg)
                .HasColumnName("REGRET_DENIAL_FLG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RequestDate)
                .HasColumnName("REQUEST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestSource)
                .HasColumnName("REQUEST_SOURCE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RequestSourceType)
                .HasColumnName("REQUEST_SOURCE_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RequestType)
                .HasColumnName("REQUEST_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RequestedRateCode)
                .HasColumnName("REQUESTED_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RequestedResort)
                .HasColumnName("REQUESTED_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservationRegretId)
                .HasColumnName("RESERVATION_REGRET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.SgaCode)
                .HasColumnName("SGA_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentName)
                .HasColumnName("TRAVEL_AGENT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.TurnawayCode)
                .HasColumnName("TURNAWAY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TurnawayComments)
                .HasColumnName("TURNAWAY_COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.TurnawayDesc)
                .HasColumnName("TURNAWAY_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
