namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CampaignManagement
{
    public decimal? CampaignId { get; set; }
    public string? Resort { get; set; }
    public decimal? OwnerId { get; set; }
    public string? Salesrep { get; set; }
    public string? CampaignDesc { get; set; }
    public decimal? EstTotalCost { get; set; }
    public string? StatusCode { get; set; }
    public string? TypeCode { get; set; }
    public decimal? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? ActClass { get; set; }
    public string? RateCode { get; set; }
    public string? PromotionCode { get; set; }
    public string? GenerateActivityYn { get; set; }
    public decimal? TargetQueryId { get; set; }
    public decimal? EstRmNights { get; set; }
    public decimal? EstRmRevenue { get; set; }
    public decimal? EstCatRevenue { get; set; }
    public decimal? EstOtherRevenue { get; set; }
    public string? RequestTypeId { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? CompletedYn { get; set; }
    public string? EmailSubject { get; set; }
    public decimal? RequestTypeTemplatesId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CampaignManagement>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CAMPAIGN_MANAGEMENT");

            entity.Property(e => e.ActClass)
                .HasColumnName("ACT_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CampaignDesc)
                .HasColumnName("CAMPAIGN_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CampaignId)
                .HasColumnName("CAMPAIGN_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CompletedYn)
                .HasColumnName("COMPLETED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreatedBy)
                .HasColumnName("CREATED_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CREATED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmailSubject)
                .HasColumnName("EMAIL_SUBJECT")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EstCatRevenue)
                .HasColumnName("EST_CAT_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EstOtherRevenue)
                .HasColumnName("EST_OTHER_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EstRmNights)
                .HasColumnName("EST_RM_NIGHTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EstRmRevenue)
                .HasColumnName("EST_RM_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EstTotalCost)
                .HasColumnName("EST_TOTAL_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GenerateActivityYn)
                .HasColumnName("GENERATE_ACTIVITY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerId)
                .HasColumnName("OWNER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PromotionCode)
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RequestTypeId)
                .HasColumnName("REQUEST_TYPE_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RequestTypeTemplatesId)
                .HasColumnName("REQUEST_TYPE_TEMPLATES_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Salesrep)
                .HasColumnName("SALESREP")
                .IsUnicode(false);

            entity.Property(e => e.StatusCode)
                .HasColumnName("STATUS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TargetQueryId)
                .HasColumnName("TARGET_QUERY_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TypeCode)
                .IsRequired()
                .HasColumnName("TYPE_CODE")
                .HasMaxLength(20)
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
