namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiAllotmentStatDailyPop
{
    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? PmsAllotmentHeaderId { get; set; }
    public string? AllotmentCode { get; set; }
    public DateTime? AllotmentDate { get; set; }
    public string? AllotmentResort { get; set; }
    public decimal? PmsAllotmentDetailId { get; set; }
    public string? AllotmentType { get; set; }
    public string? RoomCategory { get; set; }
    public string? MarketCode { get; set; }
    public string? Source { get; set; }
    public string? Channel { get; set; }
    public string? Status { get; set; }
    public decimal? RmsOwner { get; set; }
    public string? RmsOwnerCode { get; set; }
    public string? RmsOwnerResort { get; set; }
    public decimal? CatOwner { get; set; }
    public string? CatOwnerCode { get; set; }
    public string? CatOwnerResort { get; set; }
    public decimal? CompanyId { get; set; }
    public decimal? AgentId { get; set; }
    public decimal? CompanyContactId { get; set; }
    public decimal? AgentContactId { get; set; }
    public decimal? ForcastedToSell { get; set; }
    public decimal? ToSell { get; set; }
    public decimal? Sold { get; set; }
    public decimal? Released { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? NonRevenue { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? Adults { get; set; }
    public string? ShoulderYn { get; set; }
    public decimal? ShoulderY { get; set; }
    public decimal? ShoulderN { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiAllotmentStatDailyPop>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_ALLOTMENT_STAT_DAILY_POP");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentContactId)
                .HasColumnName("AGENT_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentId)
                .HasColumnName("AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentCode)
                .IsRequired()
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentResort)
                .IsRequired()
                .HasColumnName("ALLOTMENT_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentType)
                .IsRequired()
                .HasColumnName("ALLOTMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatOwner)
                .HasColumnName("CAT_OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatOwnerCode)
                .HasColumnName("CAT_OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CatOwnerResort)
                .HasColumnName("CAT_OWNER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompanyContactId)
                .HasColumnName("COMPANY_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForcastedToSell)
                .HasColumnName("FORCASTED_TO_SELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsAllotmentDetailId)
                .HasColumnName("PMS_ALLOTMENT_DETAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsAllotmentHeaderId)
                .HasColumnName("PMS_ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Released)
                .HasColumnName("RELEASED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsOwner)
                .HasColumnName("RMS_OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmsOwnerCode)
                .HasColumnName("RMS_OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerResort)
                .HasColumnName("RMS_OWNER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShoulderN)
                .HasColumnName("SHOULDER_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShoulderY)
                .HasColumnName("SHOULDER_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShoulderYn)
                .HasColumnName("SHOULDER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Sold)
                .HasColumnName("SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Source)
                .HasColumnName("SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToSell)
                .HasColumnName("TO_SELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTax)
                .HasColumnName("TOTAL_TAX")
                .HasColumnType("NUMBER");
        });
	}
}
