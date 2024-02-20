namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ReservationRestrictionsAll
{
    public decimal? ReservationRestrictionId { get; set; }
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? RoomCategory { get; set; }
    public string? RestrictionType { get; set; }
    public decimal? LosUnits { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? SeasonCode { get; set; }
    public string? RateClass { get; set; }
    public string? RateCategory { get; set; }
    public string? RateTier { get; set; }
    public string? RoomClass { get; set; }
    public decimal? HurdleRate { get; set; }
    public string? YieldCreatedYn { get; set; }
    public string? Los1Yn { get; set; }
    public string? Los2Yn { get; set; }
    public string? Los3Yn { get; set; }
    public string? Los4Yn { get; set; }
    public string? Los5Yn { get; set; }
    public string? Los6Yn { get; set; }
    public string? Los7Yn { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? ClearPreviousYn { get; set; }
    public decimal? DaySeq { get; set; }
    public string? GdsOnRequest { get; set; }
    public string? GdsHost { get; set; }
    public string? Ordr { get; set; }
    public string? RestrType { get; set; }
    public string? Yieldability { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationRestrictionsAll>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESERVATION_RESTRICTIONS_ALL");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ClearPreviousYn)
                .HasColumnName("CLEAR_PREVIOUS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DaySeq)
                .HasColumnName("DAY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsOnRequest)
                .HasColumnName("GDS_ON_REQUEST")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HurdleRate)
                .HasColumnName("HURDLE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Los1Yn)
                .HasColumnName("LOS1_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Los2Yn)
                .HasColumnName("LOS2_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Los3Yn)
                .HasColumnName("LOS3_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Los4Yn)
                .HasColumnName("LOS4_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Los5Yn)
                .HasColumnName("LOS5_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Los6Yn)
                .HasColumnName("LOS6_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Los7Yn)
                .HasColumnName("LOS7_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LosUnits)
                .HasColumnName("LOS_UNITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Ordr)
                .HasColumnName("ORDR")
                .HasMaxLength(107)
                .IsUnicode(false);

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateClass)
                .HasColumnName("RATE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateTier)
                .HasColumnName("RATE_TIER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservationRestrictionId)
                .HasColumnName("RESERVATION_RESTRICTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestrType)
                .HasColumnName("RESTR_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestrictionType)
                .IsRequired()
                .HasColumnName("RESTRICTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SeasonCode)
                .HasColumnName("SEASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YieldCreatedYn)
                .HasColumnName("YIELD_CREATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Yieldability)
                .HasColumnName("YIELDABILITY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
