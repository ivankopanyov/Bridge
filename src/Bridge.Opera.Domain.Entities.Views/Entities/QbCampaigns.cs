namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class QbCampaigns
{
    public string? Resort { get; set; }
    public string? CampaignCode { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? Type { get; set; }
    public string? Category { get; set; }
    public decimal? OwnerId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? EspCode { get; set; }
    public decimal? ApprovalUserId { get; set; }
    public DateTime? ApprovalDate { get; set; }
    public string? ApprovalStatusFlg { get; set; }
    public DateTime? ApprovalSubDate { get; set; }
    public decimal? EstTotalCost { get; set; }
    public decimal? EstRmNights { get; set; }
    public decimal? EstRmRevenue { get; set; }
    public decimal? EstCatRevenue { get; set; }
    public decimal? EstOtherRevenue { get; set; }
    public string? StatusCode { get; set; }
    public string? RequestTypeId { get; set; }
    public string? GenerateActivityYn { get; set; }
    public string? GenerateProfileRequestYn { get; set; }
    public string? EmailYnFlg { get; set; }
    public string? EmailYnOptInFlg { get; set; }
    public string? GuestPrivYnFlg { get; set; }
    public string? GuestPrivYnOptInFlg { get; set; }
    public decimal? OcrmProfileId { get; set; }
    public string? EspReplyStatus { get; set; }
    public decimal? NameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QbCampaigns>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QB_CAMPAIGNS");

            entity.Property(e => e.ApprovalDate)
                .HasColumnName("APPROVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ApprovalStatusFlg)
                .HasColumnName("APPROVAL_STATUS_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ApprovalSubDate)
                .HasColumnName("APPROVAL_SUB_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ApprovalUserId)
                .HasColumnName("APPROVAL_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CampaignCode)
                .IsRequired()
                .HasColumnName("CAMPAIGN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Category)
                .HasColumnName("CATEGORY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EmailYnFlg)
                .HasColumnName("EMAIL_YN_FLG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EmailYnOptInFlg)
                .HasColumnName("EMAIL_YN_OPT_IN_FLG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EspCode)
                .HasColumnName("ESP_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EspReplyStatus)
                .HasColumnName("ESP_REPLY_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EstCatRevenue)
                .HasColumnName("EST_CAT_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstOtherRevenue)
                .HasColumnName("EST_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstRmNights)
                .HasColumnName("EST_RM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstRmRevenue)
                .HasColumnName("EST_RM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstTotalCost)
                .HasColumnName("EST_TOTAL_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GenerateActivityYn)
                .HasColumnName("GENERATE_ACTIVITY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GenerateProfileRequestYn)
                .HasColumnName("GENERATE_PROFILE_REQUEST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GuestPrivYnFlg)
                .HasColumnName("GUEST_PRIV_YN_FLG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestPrivYnOptInFlg)
                .HasColumnName("GUEST_PRIV_YN_OPT_IN_FLG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OcrmProfileId)
                .HasColumnName("OCRM_PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerId)
                .HasColumnName("OWNER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestTypeId)
                .HasColumnName("REQUEST_TYPE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatusCode)
                .HasColumnName("STATUS_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
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
