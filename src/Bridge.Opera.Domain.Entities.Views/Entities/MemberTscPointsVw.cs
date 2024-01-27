namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemberTscPointsVw
{
    public string Application { get; set; }
    public decimal MembershipTrxId { get; set; }
    public DateTime? MembershipTrxDate { get; set; }
    public string RecordType { get; set; }
    public decimal MembershipId { get; set; }
    public decimal? NameId { get; set; }
    public string Resort { get; set; }
    public string PmsResvNo { get; set; }
    public string OrsBookNo { get; set; }
    public DateTime ArrivalDate { get; set; }
    public DateTime DepartureDate { get; set; }
    public decimal? StayRecordId { get; set; }
    public string PointsCalculatedYn { get; set; }
    public decimal? MembershipBaseStay { get; set; }
    public decimal? MembershipBonusStay { get; set; }
    public decimal? MembershipBaseNights { get; set; }
    public decimal? MembershipBonusNights { get; set; }
    public decimal? MembershipBaseRevenue { get; set; }
    public decimal? MembershipBonusRevenue { get; set; }
    public decimal? TotalBasePoints { get; set; }
    public decimal? TotalBonusPoints { get; set; }
    public decimal? TotalMiscPoints { get; set; }
    public DateTime? PointsCreditDate { get; set; }
    public DateTime? PointsExpirationDate { get; set; }
    public string AdjustmentYn { get; set; }
    public decimal? StatementId { get; set; }
    public decimal TrxInsertUser { get; set; }
    public DateTime TrxInsertDate { get; set; }
    public decimal TrxUpdateUser { get; set; }
    public DateTime TrxUpdateDate { get; set; }
    public DateTime? TrxInactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberTscPointsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBER_TSC_POINTS_VW");

            entity.Property(e => e.AdjustmentYn)
                .IsRequired()
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
                .IsRequired()
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
                .IsRequired()
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
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
