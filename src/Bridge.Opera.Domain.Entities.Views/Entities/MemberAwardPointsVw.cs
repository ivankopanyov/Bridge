namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemberAwardPointsVw
{
    public string? Application { get; set; }
    public decimal? MembershipTrxId { get; set; }
    public DateTime? MembershipTrxDate { get; set; }
    public string? RecordType { get; set; }
    public decimal? MembershipId { get; set; }
    public decimal? NameId { get; set; }
    public string? Resort { get; set; }
    public string? PmsResvNo { get; set; }
    public string? OrsBookNo { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public decimal? StayRecordId { get; set; }
    public string? PointsCalculatedYn { get; set; }
    public decimal? TotalPoints { get; set; }
    public decimal? TotalBasePoints { get; set; }
    public decimal? TotalBonusPoints { get; set; }
    public decimal? TotalMiscPoints { get; set; }
    public DateTime? PointsCreditDate { get; set; }
    public DateTime? PointsExpirationDate { get; set; }
    public string? AdjustmentYn { get; set; }
    public decimal? StatementId { get; set; }
    public decimal? TrxInsertUser { get; set; }
    public DateTime? TrxInsertDate { get; set; }
    public decimal? TrxUpdateUser { get; set; }
    public DateTime? TrxUpdateDate { get; set; }
    public DateTime? TrxInactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberAwardPointsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBER_AWARD_POINTS_VW");

            entity.Property(e => e.AdjustmentYn)
                .HasColumnName("ADJUSTMENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Application)
                .HasColumnName("APPLICATION")
                .HasColumnType("CHAR(3)");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipTrxDate)
                .HasColumnName("MEMBERSHIP_TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MembershipTrxId)
                .HasColumnName("MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrsBookNo)
                .HasColumnName("ORS_BOOK_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PmsResvNo)
                .HasColumnName("PMS_RESV_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PointsCalculatedYn)
                .HasColumnName("POINTS_CALCULATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PointsCreditDate)
                .HasColumnName("POINTS_CREDIT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PointsExpirationDate)
                .HasColumnName("POINTS_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatementId)
                .HasColumnName("STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRecordId)
                .HasColumnName("STAY_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalBasePoints)
                .HasColumnName("TOTAL_BASE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalBonusPoints)
                .HasColumnName("TOTAL_BONUS_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalMiscPoints)
                .HasColumnName("TOTAL_MISC_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPoints)
                .HasColumnName("TOTAL_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxInactiveDate)
                .HasColumnName("TRX_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxInsertDate)
                .HasColumnName("TRX_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxInsertUser)
                .HasColumnName("TRX_INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxUpdateDate)
                .HasColumnName("TRX_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxUpdateUser)
                .HasColumnName("TRX_UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
