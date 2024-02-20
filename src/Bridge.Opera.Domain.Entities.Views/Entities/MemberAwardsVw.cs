namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemberAwardsVw
{
    public string? Application { get; set; }
    public decimal? IssuedAwardId { get; set; }
    public DateTime? DateAwarded { get; set; }
    public string? MembershipType { get; set; }
    public string? AwardType { get; set; }
    public string? AwardBasedOn { get; set; }
    public decimal? MembershipId { get; set; }
    public decimal? NameId { get; set; }
    public string? Resort { get; set; }
    public string? PmsResvNo { get; set; }
    public string? OrsBookNo { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public string? RateCode { get; set; }
    public string? RateRoomCategory { get; set; }
    public string? RateRoomLabel { get; set; }
    public string? FromRoomCategory { get; set; }
    public string? FromRoomLabel { get; set; }
    public string? ToRoomCategory { get; set; }
    public string? ToRoomLabel { get; set; }
    public string? Product { get; set; }
    public decimal? PointsRequired { get; set; }
    public decimal? CancelPenaltyDays { get; set; }
    public decimal? CancelPenaltyPoints { get; set; }
    public decimal? AwardCancellationNo { get; set; }
    public DateTime? AwardCancelDate { get; set; }
    public string? ResvCancelNo { get; set; }
    public decimal? ActualCancelPoints { get; set; }
    public DateTime? StayDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberAwardsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBER_AWARDS_VW");

            entity.Property(e => e.ActualCancelPoints)
                .HasColumnName("ACTUAL_CANCEL_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Application)
                .HasColumnName("APPLICATION")
                .HasColumnType("CHAR(3)");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AwardBasedOn)
                .HasColumnName("AWARD_BASED_ON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AwardCancelDate)
                .HasColumnName("AWARD_CANCEL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AwardCancellationNo)
                .HasColumnName("AWARD_CANCELLATION_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardType)
                .HasColumnName("AWARD_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CancelPenaltyDays)
                .HasColumnName("CANCEL_PENALTY_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPenaltyPoints)
                .HasColumnName("CANCEL_PENALTY_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DateAwarded)
                .HasColumnName("DATE_AWARDED")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FromRoomCategory)
                .HasColumnName("FROM_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FromRoomLabel)
                .HasColumnName("FROM_ROOM_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.IssuedAwardId)
                .HasColumnName("ISSUED_AWARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrsBookNo)
                .HasColumnName("ORS_BOOK_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PmsResvNo)
                .HasColumnName("PMS_RESV_NO")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.PointsRequired)
                .HasColumnName("POINTS_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateRoomCategory)
                .HasColumnName("RATE_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateRoomLabel)
                .HasColumnName("RATE_ROOM_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvCancelNo)
                .HasColumnName("RESV_CANCEL_NO")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ToRoomCategory)
                .HasColumnName("TO_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToRoomLabel)
                .HasColumnName("TO_ROOM_LABEL")
                .IsUnicode(false);
        });
	}
}
