namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RequestLog
{
    public decimal? RequestId { get; set; }
    public DateTime? RequestDate { get; set; }
    public string? RequestType { get; set; }
    public string? RequestSourceType { get; set; }
    public string? RequestSource { get; set; }
    public string? Resort { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public decimal? Nights { get; set; }
    public decimal? Rooms { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? AgentId { get; set; }
    public decimal? SourceId { get; set; }
    public decimal? GroupId { get; set; }
    public decimal? CompanyId { get; set; }
    public decimal? NameId { get; set; }
    public string? SgaCode { get; set; }
    public string? PseudoCity { get; set; }
    public string? City { get; set; }
    public string? PromotionCode { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? RequestStatus { get; set; }
    public string? RequestError { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? CallHeaderId { get; set; }
    public string? RateCode { get; set; }
    public string? RegionCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RequestLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("REQUEST_LOG");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentId)
                .HasColumnName("AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CallHeaderId)
                .HasColumnName("CALL_HEADER_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
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

            entity.Property(e => e.RequestDate)
                .HasColumnName("REQUEST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RequestError)
                .HasColumnName("REQUEST_ERROR")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestSource)
                .IsRequired()
                .HasColumnName("REQUEST_SOURCE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RequestSourceType)
                .IsRequired()
                .HasColumnName("REQUEST_SOURCE_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RequestStatus)
                .HasColumnName("REQUEST_STATUS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RequestType)
                .IsRequired()
                .HasColumnName("REQUEST_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rooms)
                .HasColumnName("ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SgaCode)
                .HasColumnName("SGA_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
