namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AwardFbaTrackingView
{
    public string AprRowid { get; set; }
    public string Resort { get; set; }
    public decimal NameId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string CertificateNumber { get; set; }
    public string MembershipNo { get; set; }
    public string AwardCode { get; set; }
    public string Status { get; set; }
    public string Description { get; set; }
    public decimal? Nights { get; set; }
    public string SourceType { get; set; }
    public decimal? OrderBy { get; set; }
    public string MasterCertificateNumber { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string CrsHotelCode { get; set; }
    public string CrsConfirmationNumber { get; set; }
    public decimal? PointsCost { get; set; }
    public string FbaYn { get; set; }
    public string FbaStatus { get; set; }
    public decimal? FbaMonetaryValue { get; set; }
    public decimal? FbaAmount { get; set; }
    public decimal? FbaPostedAmount { get; set; }
    public decimal? FbaReimbursedAmount { get; set; }
    public DateTime? FbaPostingDateTime { get; set; }
    public DateTime? FbaPostingBusinessDate { get; set; }
    public DateTime? FbaSettlementDateTime { get; set; }
    public DateTime? FbaSettlementBusinessDate { get; set; }
    public DateTime? FbaReimbursementDateTime { get; set; }
    public DateTime? FbaReimburseBusinessDate { get; set; }
    public string IsResCertOrDetailCert { get; set; }
    public string FbaPostedYn { get; set; }
    public string FbaSettledYn { get; set; }
    public string FbaReimbursedYn { get; set; }
    public string Room { get; set; }
    public string SguestName { get; set; }
    public string SfirstGuestName { get; set; }
    public string GuestName { get; set; }
    public string GuestFirstName { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public string ConfirmationNo { get; set; }
    public DateTime? TruncArrival { get; set; }
    public string ResvStatus { get; set; }
    public decimal? FbaBillNo { get; set; }
    public string OrphanCertificateYn { get; set; }
    public DateTime? FbaBillGenerationDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AwardFbaTrackingView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AWARD_FBA_TRACKING_VIEW");

            entity.Property(e => e.AprRowid)
                .HasColumnName("APR_ROWID")
                .HasColumnType("ROWID");

            entity.Property(e => e.AwardCode)
                .HasColumnName("AWARD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CertificateNumber)
                .HasColumnName("CERTIFICATE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CrsConfirmationNumber)
                .HasColumnName("CRS_CONFIRMATION_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CrsHotelCode)
                .HasColumnName("CRS_HOTEL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FbaAmount)
                .HasColumnName("FBA_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbaBillGenerationDate)
                .HasColumnName("FBA_BILL_GENERATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FbaBillNo)
                .HasColumnName("FBA_BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbaMonetaryValue)
                .HasColumnName("FBA_MONETARY_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbaPostedAmount)
                .HasColumnName("FBA_POSTED_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbaPostedYn)
                .HasColumnName("FBA_POSTED_YN")
                .IsUnicode(false);

            entity.Property(e => e.FbaPostingBusinessDate)
                .HasColumnName("FBA_POSTING_BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FbaPostingDateTime)
                .HasColumnName("FBA_POSTING_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.FbaReimburseBusinessDate)
                .HasColumnName("FBA_REIMBURSE_BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FbaReimbursedAmount)
                .HasColumnName("FBA_REIMBURSED_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbaReimbursedYn)
                .HasColumnName("FBA_REIMBURSED_YN")
                .IsUnicode(false);

            entity.Property(e => e.FbaReimbursementDateTime)
                .HasColumnName("FBA_REIMBURSEMENT_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.FbaSettledYn)
                .HasColumnName("FBA_SETTLED_YN")
                .IsUnicode(false);

            entity.Property(e => e.FbaSettlementBusinessDate)
                .HasColumnName("FBA_SETTLEMENT_BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FbaSettlementDateTime)
                .HasColumnName("FBA_SETTLEMENT_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.FbaStatus)
                .HasColumnName("FBA_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FbaYn)
                .HasColumnName("FBA_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsResCertOrDetailCert)
                .HasColumnName("IS_RES_CERT_OR_DETAIL_CERT")
                .IsUnicode(false);

            entity.Property(e => e.MasterCertificateNumber)
                .HasColumnName("MASTER_CERTIFICATE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipNo)
                .HasColumnName("MEMBERSHIP_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrphanCertificateYn)
                .HasColumnName("ORPHAN_CERTIFICATE_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.PointsCost)
                .HasColumnName("POINTS_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SfirstGuestName)
                .HasColumnName("SFIRST_GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceType)
                .HasColumnName("SOURCE_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
