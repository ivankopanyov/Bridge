namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OcrmCampaigns
{
    public OcrmCampaigns()
    {
        OcrmOffers = new HashSet<OcrmOffers>();
        OcrmResvStayOfferLink = new HashSet<OcrmResvStayOfferLink>();
    }

    public decimal CampaignId { get; set; }
    public string Resort { get; set; }
    public string CampaignCode { get; set; }
    public string CampaignName { get; set; }
    public string CampaignDescription { get; set; }
    public decimal? SegId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string Type { get; set; }
    public string Category { get; set; }
    public decimal? OwnerId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string EspCode { get; set; }
    public decimal? ApprovalUserId { get; set; }
    public DateTime? ApprovalDate { get; set; }
    public string ApprovalStatusFlg { get; set; }
    public DateTime? ApprovalSubDate { get; set; }
    public decimal? EstTotalCost { get; set; }
    public decimal? EstRmNights { get; set; }
    public decimal? EstRmRevenue { get; set; }
    public decimal? EstCatRevenue { get; set; }
    public decimal? EstOtherRevenue { get; set; }
    public string StatusCode { get; set; }
    public string RequestTypeId { get; set; }
    public string GenerateActivityYn { get; set; }
    public string GenerateProfileRequestYn { get; set; }
    public string EmailYnFlg { get; set; }
    public string EmailYnOptInFlg { get; set; }
    public string GuestPrivYnFlg { get; set; }
    public string GuestPrivYnOptInFlg { get; set; }
    public decimal? TaskInstId { get; set; }
    public decimal? ExpFileId { get; set; }
    public string EmailColName { get; set; }
    public string ExpFileProcessType { get; set; }
    public string Module { get; set; }
    public string ActionType { get; set; }
    public string ActPurpose { get; set; }
    public string ActType { get; set; }
    public DateTime? ActStartDate { get; set; }
    public DateTime? ActEndDate { get; set; }
    public string ReqType { get; set; }

    public virtual ActionType ActionTypeNavigation { get; set; }
    public virtual OcrmProfileSegHdr Seg { get; set; }
    public virtual ICollection<OcrmOffers> OcrmOffers { get; set; }
    public virtual ICollection<OcrmResvStayOfferLink> OcrmResvStayOfferLink { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmCampaigns>(entity =>
        {
            entity.HasKey(e => e.CampaignId)
                .HasName("OCN_PK");

            entity.ToTable("OCRM_CAMPAIGNS");

            entity.HasIndex(e => e.ExpFileId)
                .HasName("OCRM_CAMP_IDX06");

            entity.HasIndex(e => e.OwnerId)
                .HasName("OCRM_CAMP_IDX03");

            entity.HasIndex(e => e.Resort)
                .HasName("OCRM_CAMP_IDX01");

            entity.HasIndex(e => e.SegId)
                .HasName("OCRM_CAMP_IDX02");

            entity.HasIndex(e => new { e.CampaignCode, e.Resort })
                .HasName("OCRM_CAMP_UK01")
                .IsUnique();

            entity.HasIndex(e => new { e.Category, e.Resort })
                .HasName("OCRM_CAMP_IDX04");

            entity.HasIndex(e => new { e.EspCode, e.Resort })
                .HasName("OCRM_CAMP_IDX07");

            entity.HasIndex(e => new { e.Module, e.ActionType })
                .HasName("OCRM_CAMP_BE_FKI");

            entity.HasIndex(e => new { e.Type, e.Resort })
                .HasName("OCRM_CAMP_IDX05");

            entity.Property(e => e.CampaignId)
                .HasColumnName("CAMPAIGN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActEndDate)
                .HasColumnName("ACT_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ActPurpose)
                .HasColumnName("ACT_PURPOSE")
                .IsUnicode(false);

            entity.Property(e => e.ActStartDate)
                .HasColumnName("ACT_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ActType)
                .HasColumnName("ACT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);

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

            entity.Property(e => e.CampaignDescription)
                .HasColumnName("CAMPAIGN_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.CampaignName)
                .HasColumnName("CAMPAIGN_NAME")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Category)
                .HasColumnName("CATEGORY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EmailColName)
                .HasColumnName("EMAIL_COL_NAME")
                .HasMaxLength(80)
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

            entity.Property(e => e.ExpFileId)
                .HasColumnName("EXP_FILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpFileProcessType)
                .HasColumnName("EXP_FILE_PROCESS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.OwnerId)
                .HasColumnName("OWNER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReqType)
                .HasColumnName("REQ_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RequestTypeId)
                .HasColumnName("REQUEST_TYPE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SegId)
                .HasColumnName("SEG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatusCode)
                .HasColumnName("STATUS_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TaskInstId)
                .HasColumnName("TASK_INST_ID")
                .HasColumnType("NUMBER");

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

			if (!types.Contains(typeof(OcrmProfileSegHdr)))
				entity.Ignore(e => e.Seg);
			else
	            entity.HasOne(d => d.Seg)
	                .WithMany(p => p.OcrmCampaigns)
	                .HasForeignKey(d => d.SegId)
	                .HasConstraintName("OCRM_CAMPAIGNS_FK01");

			if (!types.Contains(typeof(ActionType)))
				entity.Ignore(e => e.ActionTypeNavigation);
			else
	            entity.HasOne(d => d.ActionTypeNavigation)
	                .WithMany(p => p.OcrmCampaigns)
	                .HasForeignKey(d => new { d.Module, d.ActionType })
	                .HasConstraintName("OCRM_CAMPAIGNS_FK02");
        
			if (!types.Contains(typeof(OcrmOffers)))
				entity.Ignore(e => e.OcrmOffers);

			if (!types.Contains(typeof(OcrmResvStayOfferLink)))
				entity.Ignore(e => e.OcrmResvStayOfferLink);
		});
	}
}
