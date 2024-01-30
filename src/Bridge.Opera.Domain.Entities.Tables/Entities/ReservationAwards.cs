namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationAwards
{
    public decimal? ResvAwardId { get; set; }
    public decimal? IssuedAwardId { get; set; }
    public string? AwardVoucherNo { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? ChainCode { get; set; }
    public string? MembershipType { get; set; }
    public string? AwardType { get; set; }
    public string? AwardStatus { get; set; }
    public DateTime? DateAwarded { get; set; }
    public DateTime? ConsumptionDate { get; set; }
    public decimal? PointsRequired { get; set; }
    public string? RateCode { get; set; }
    public string? RoomLabel { get; set; }
    public string? FromRoomLabel { get; set; }
    public string? ToRoomLabel { get; set; }
    public string? Product { get; set; }
    public decimal? AwardCancellationNo { get; set; }
    public DateTime? AwardCancelDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? StayDate { get; set; }
    public decimal? ProductId { get; set; }
    public decimal? CancelPenaltyPoints { get; set; }
    public decimal? CancelPenaltyDays { get; set; }
    public string? CancelPolicyType { get; set; }
    public decimal? NumberOfNights { get; set; }
    public decimal? ActualCancelPoints { get; set; }
    public string? CanCancelYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationAwards>(entity =>
        {
            entity.HasKey(e => e.ResvAwardId)
                .HasName("RESV_AWARDS_PK");

            entity.ToTable("RESERVATION_AWARDS");

            entity.HasIndex(e => e.AwardVoucherNo)
                .HasName("RESERVATION_AWARDS_IDX3");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("RESERVATION_AWARDS_IDX1");

            entity.HasIndex(e => new { e.ChainCode, e.MembershipType, e.AwardType })
                .HasName("RESERVATION_AWARDS_IDX2");

            entity.Property(e => e.ResvAwardId)
                .HasColumnName("RESV_AWARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualCancelPoints)
                .HasColumnName("ACTUAL_CANCEL_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardCancelDate)
                .HasColumnName("AWARD_CANCEL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AwardCancellationNo)
                .HasColumnName("AWARD_CANCELLATION_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardStatus)
                .HasColumnName("AWARD_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AwardType)
                .IsRequired()
                .HasColumnName("AWARD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AwardVoucherNo)
                .HasColumnName("AWARD_VOUCHER_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CanCancelYn)
                .HasColumnName("CAN_CANCEL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CancelPenaltyDays)
                .HasColumnName("CANCEL_PENALTY_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPenaltyPoints)
                .HasColumnName("CANCEL_PENALTY_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelPolicyType)
                .HasColumnName("CANCEL_POLICY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsumptionDate)
                .HasColumnName("CONSUMPTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DateAwarded)
                .HasColumnName("DATE_AWARDED")
                .HasColumnType("DATE");

            entity.Property(e => e.FromRoomLabel)
                .HasColumnName("FROM_ROOM_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IssuedAwardId)
                .HasColumnName("ISSUED_AWARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NumberOfNights)
                .HasColumnName("NUMBER_OF_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsRequired)
                .HasColumnName("POINTS_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ProductId)
                .HasColumnName("PRODUCT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomLabel)
                .HasColumnName("ROOM_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ToRoomLabel)
                .HasColumnName("TO_ROOM_LABEL")
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
