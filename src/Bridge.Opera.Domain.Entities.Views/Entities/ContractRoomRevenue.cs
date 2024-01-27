namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ContractRoomRevenue
{
    public string Resort { get; set; }
    public decimal ContractId { get; set; }
    public string ContractName { get; set; }
    public string ContractNumber { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ContractStatus { get; set; }
    public decimal? OwnerId { get; set; }
    public string Owner { get; set; }
    public decimal? CompanyNameId { get; set; }
    public decimal? ContactNameId { get; set; }
    public string AccountName { get; set; }
    public string ContactName { get; set; }
    public string SendStatus { get; set; }
    public string ReplyStatus { get; set; }
    public string RateCode { get; set; }
    public string RateOverride { get; set; }
    public string RateOverrideReason { get; set; }
    public decimal? DiscountLevel { get; set; }
    public decimal? DiscountPercentage { get; set; }
    public decimal? ProjectedRoomNights { get; set; }
    public decimal? ProjectedRevenue { get; set; }
    public decimal? ProjectedFbRevenue { get; set; }
    public decimal? ProjectedOtherRevenue { get; set; }
    public string ChainProductionCode { get; set; }
    public decimal? TotalProjectedRoomNights { get; set; }
    public decimal? ContractedRooms { get; set; }
    public decimal? NegotiatedRooms { get; set; }
    public decimal? AllRooms { get; set; }
    public decimal? ContractedRevenue { get; set; }
    public decimal? NegotiatedRevenue { get; set; }
    public decimal? AllRevenue { get; set; }
    public decimal? ContRmsInclSubs { get; set; }
    public decimal? NegRmsInclSubs { get; set; }
    public decimal? AllRmsInclSubs { get; set; }
    public decimal? ContRevInclSubs { get; set; }
    public decimal? NegRevInclSubs { get; set; }
    public decimal? AllRevInclSubs { get; set; }
    public decimal? ContRmsPriorYr { get; set; }
    public decimal? ContRmsPrior2Yrs { get; set; }
    public decimal? ContRmsInclSubsPriorYr { get; set; }
    public decimal? ContRmsInclSubsPrior2Yrs { get; set; }
    public decimal? NegRmsPriorYr { get; set; }
    public decimal? NegRmsPrior2Yrs { get; set; }
    public decimal? NegRmsInclSubsPriorYr { get; set; }
    public decimal? NegRmsInclSubsPrior2Yrs { get; set; }
    public decimal? AllRmsPriorYr { get; set; }
    public decimal? AllRmsPrior2Yrs { get; set; }
    public decimal? AllRmsInclSubsPriorYr { get; set; }
    public decimal? AllRmsInclSubsPrior2Yrs { get; set; }
    public string FitContractType { get; set; }
    public string FitDiscountType { get; set; }
    public string LoggedSrepCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ContractRoomRevenue>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CONTRACT_ROOM_REVENUE");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AllRevInclSubs)
                .HasColumnName("ALL_REV_INCL_SUBS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllRevenue)
                .HasColumnName("ALL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllRmsInclSubs)
                .HasColumnName("ALL_RMS_INCL_SUBS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllRmsInclSubsPrior2Yrs)
                .HasColumnName("ALL_RMS_INCL_SUBS_PRIOR_2_YRS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllRmsInclSubsPriorYr)
                .HasColumnName("ALL_RMS_INCL_SUBS_PRIOR_YR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllRmsPrior2Yrs)
                .HasColumnName("ALL_RMS_PRIOR_2_YRS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllRmsPriorYr)
                .HasColumnName("ALL_RMS_PRIOR_YR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllRooms)
                .HasColumnName("ALL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChainProductionCode)
                .HasColumnName("CHAIN_PRODUCTION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CompanyNameId)
                .HasColumnName("COMPANY_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContRevInclSubs)
                .HasColumnName("CONT_REV_INCL_SUBS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContRmsInclSubs)
                .HasColumnName("CONT_RMS_INCL_SUBS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContRmsInclSubsPrior2Yrs)
                .HasColumnName("CONT_RMS_INCL_SUBS_PRIOR_2_YRS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContRmsInclSubsPriorYr)
                .HasColumnName("CONT_RMS_INCL_SUBS_PRIOR_YR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContRmsPrior2Yrs)
                .HasColumnName("CONT_RMS_PRIOR_2_YRS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContRmsPriorYr)
                .HasColumnName("CONT_RMS_PRIOR_YR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContactName)
                .HasColumnName("CONTACT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ContactNameId)
                .HasColumnName("CONTACT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractName)
                .IsRequired()
                .HasColumnName("CONTRACT_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ContractNumber)
                .IsRequired()
                .HasColumnName("CONTRACT_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContractStatus)
                .IsRequired()
                .HasColumnName("CONTRACT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ContractedRevenue)
                .HasColumnName("CONTRACTED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractedRooms)
                .HasColumnName("CONTRACTED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountLevel)
                .HasColumnName("DISCOUNT_LEVEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountPercentage)
                .HasColumnName("DISCOUNT_PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FitContractType)
                .HasColumnName("FIT_CONTRACT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FitDiscountType)
                .HasColumnName("FIT_DISCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LoggedSrepCode)
                .HasColumnName("LOGGED_SREP_CODE")
                .IsUnicode(false);

            entity.Property(e => e.NegRevInclSubs)
                .HasColumnName("NEG_REV_INCL_SUBS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NegRmsInclSubs)
                .HasColumnName("NEG_RMS_INCL_SUBS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NegRmsInclSubsPrior2Yrs)
                .HasColumnName("NEG_RMS_INCL_SUBS_PRIOR_2_YRS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NegRmsInclSubsPriorYr)
                .HasColumnName("NEG_RMS_INCL_SUBS_PRIOR_YR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NegRmsPrior2Yrs)
                .HasColumnName("NEG_RMS_PRIOR_2_YRS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NegRmsPriorYr)
                .HasColumnName("NEG_RMS_PRIOR_YR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NegotiatedRevenue)
                .HasColumnName("NEGOTIATED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NegotiatedRooms)
                .HasColumnName("NEGOTIATED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Owner)
                .IsRequired()
                .HasColumnName("OWNER")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.OwnerId)
                .HasColumnName("OWNER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProjectedFbRevenue)
                .HasColumnName("PROJECTED_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProjectedOtherRevenue)
                .HasColumnName("PROJECTED_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProjectedRevenue)
                .HasColumnName("PROJECTED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProjectedRoomNights)
                .HasColumnName("PROJECTED_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateOverride)
                .HasColumnName("RATE_OVERRIDE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateOverrideReason)
                .HasColumnName("RATE_OVERRIDE_REASON")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReplyStatus)
                .HasColumnName("REPLY_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SendStatus)
                .HasColumnName("SEND_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.TotalProjectedRoomNights)
                .HasColumnName("TOTAL_PROJECTED_ROOM_NIGHTS")
                .HasColumnType("NUMBER");
        });
	}
}
