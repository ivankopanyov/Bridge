namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEdwResv
{
    public decimal? ExportId { get; set; }
    public string? EdwType { get; set; }
    public string? PmsVersion { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? GuestNameId { get; set; }
    public string? PmsConfirmationNo { get; set; }
    public string? ExternalReferenceNo { get; set; }
    public string? ResvStatus { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public DateTime? CreationDate { get; set; }
    public DateTime? CancellationDate { get; set; }
    public string? BrandId { get; set; }
    public string? HotelCode { get; set; }
    public decimal? Nights { get; set; }
    public string? OriginOfBooking { get; set; }
    public string? MarketSegment { get; set; }
    public string? PmsCrsResv { get; set; }
    public decimal? InsertUser { get; set; }
    public string? CompanyCorpId { get; set; }
    public string? AgentIataNo { get; set; }
    public string? LoyaltyMembershipNumber { get; set; }
    public string? MarketMainGroup { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public string? PaymentMethod { get; set; }
    public string? PaymentReference { get; set; }
    public decimal? HgtTotalRevenue { get; set; }
    public decimal? LeadDays { get; set; }
    public string? OriginTypeCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEdwResv>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_EDW_RESV");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentIataNo)
                .HasColumnName("AGENT_IATA_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BrandId)
                .HasColumnName("BRAND_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyCorpId)
                .HasColumnName("COMPANY_CORP_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreationDate)
                .HasColumnName("CREATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.EdwType)
                .HasColumnName("EDW_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalReferenceNo)
                .HasColumnName("EXTERNAL_REFERENCE_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HgtTotalRevenue)
                .HasColumnName("HGT_TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadDays)
                .HasColumnName("LEAD_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LoyaltyMembershipNumber)
                .HasColumnName("LOYALTY_MEMBERSHIP_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketMainGroup)
                .HasColumnName("MARKET_MAIN_GROUP")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketSegment)
                .HasColumnName("MARKET_SEGMENT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginOfBooking)
                .HasColumnName("ORIGIN_OF_BOOKING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OriginTypeCode)
                .HasColumnName("ORIGIN_TYPE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PaymentReference)
                .HasColumnName("PAYMENT_REFERENCE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PmsConfirmationNo)
                .HasColumnName("PMS_CONFIRMATION_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PmsCrsResv)
                .HasColumnName("PMS_CRS_RESV")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PmsVersion)
                .HasColumnName("PMS_VERSION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
