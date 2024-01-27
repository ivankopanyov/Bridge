namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipClaims
{
    public decimal MembershipClaimId { get; set; }
    public DateTime ClaimDate { get; set; }
    public DateTime? ReplyByDate { get; set; }
    public string RecordType { get; set; }
    public string Resort { get; set; }
    public string PmsResvNo { get; set; }
    public string CrsBookNo { get; set; }
    public string ClaimStatus { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public string MembershipType { get; set; }
    public string MembershipCardNo { get; set; }
    public decimal? NameId { get; set; }
    public decimal? MembershipId { get; set; }
    public string CallerName { get; set; }
    public string CallerInformation { get; set; }
    public string Comments { get; set; }
    public decimal? MembershipTrxId { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public DateTime? CloseDate { get; set; }
    public decimal? ClaimOwner { get; set; }
    public string ClaimType { get; set; }
    public string ApproveReject { get; set; }
    public string ClaimSource { get; set; }
    public string ClaimAdjLimitCode { get; set; }
    public decimal? TotalBasePoints { get; set; }
    public decimal? TotalBonusPoints { get; set; }
    public decimal? TotalMiscPoints { get; set; }
    public decimal? MembershipBaseStay { get; set; }
    public decimal? MembershipBonusStay { get; set; }
    public decimal? MembershipBaseNights { get; set; }
    public decimal? MembershipBaseRevenue { get; set; }
    public decimal? MembershipBonusNights { get; set; }
    public decimal? MembershipBonusRevenue { get; set; }
    public string ClaimOrigin { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipClaims>(entity =>
        {
            entity.HasKey(e => e.MembershipClaimId)
                .HasName("MEMBERSHIP_CLAIMS_PK");

            entity.ToTable("MEMBERSHIP_CLAIMS");

            entity.HasIndex(e => e.ApproveReject)
                .HasName("MEMBERSHIP_CLAIM_APRRJT");

            entity.HasIndex(e => e.ClaimOwner)
                .HasName("MEMBERSHIP_CLAIM_OWNER_IND");

            entity.HasIndex(e => e.ClaimSource)
                .HasName("MEMBERSHIP_CLAIM_SOURCE");

            entity.HasIndex(e => e.ClaimStatus)
                .HasName("MEMBERSHIP_CLAIM_STATUS_IND");

            entity.HasIndex(e => e.ClaimType)
                .HasName("MEMBERSHIP_CLAIM_TYPE_IND");

            entity.HasIndex(e => e.CrsBookNo)
                .HasName("MEMBERSHIP_CLAIM_IND2");

            entity.HasIndex(e => e.InsertUser)
                .HasName("MEMBERSHIP_CLAIM_INSUSR_IND");

            entity.HasIndex(e => e.MembershipCardNo)
                .HasName("MEMBERSHIP_CLAIM_IND3");

            entity.HasIndex(e => e.MembershipId)
                .HasName("MEMBERSHIP_CLAIM_MEM_IND");

            entity.HasIndex(e => e.NameId)
                .HasName("MEMBERSHIP_CLAIM_NAME_IND");

            entity.HasIndex(e => e.ReplyByDate)
                .HasName("MEMERSHIP_CLAIM_REP_IND");

            entity.HasIndex(e => new { e.Resort, e.PmsResvNo })
                .HasName("MEMBERSHIP_CLAIM_IND1");

            entity.Property(e => e.MembershipClaimId)
                .HasColumnName("MEMBERSHIP_CLAIM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ApproveReject)
                .HasColumnName("APPROVE_REJECT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CallerInformation)
                .HasColumnName("CALLER_INFORMATION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CallerName)
                .HasColumnName("CALLER_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ClaimAdjLimitCode)
                .HasColumnName("CLAIM_ADJ_LIMIT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClaimDate)
                .HasColumnName("CLAIM_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ClaimOrigin)
                .HasColumnName("CLAIM_ORIGIN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClaimOwner)
                .HasColumnName("CLAIM_OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClaimSource)
                .HasColumnName("CLAIM_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClaimStatus)
                .HasColumnName("CLAIM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClaimType)
                .HasColumnName("CLAIM_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CloseDate)
                .HasColumnName("CLOSE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CrsBookNo)
                .HasColumnName("CRS_BOOK_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBaseNights)
                .HasColumnName("MEMBERSHIP_BASE_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBaseRevenue)
                .HasColumnName("MEMBERSHIP_BASE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBaseStay)
                .HasColumnName("MEMBERSHIP_BASE_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBonusNights)
                .HasColumnName("MEMBERSHIP_BONUS_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBonusRevenue)
                .HasColumnName("MEMBERSHIP_BONUS_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipBonusStay)
                .HasColumnName("MEMBERSHIP_BONUS_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipTrxId)
                .HasColumnName("MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsResvNo)
                .HasColumnName("PMS_RESV_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReplyByDate)
                .HasColumnName("REPLY_BY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalBasePoints)
                .HasColumnName("TOTAL_BASE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalBonusPoints)
                .HasColumnName("TOTAL_BONUS_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalMiscPoints)
                .HasColumnName("TOTAL_MISC_POINTS")
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
