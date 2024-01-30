namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RestrictionsActivityWithSeq
{
    public DateTime? ControlDate { get; set; }
    public DateTime? AppliedDate { get; set; }
    public string? RestrictionType { get; set; }
    public string? Resort { get; set; }
    public decimal? ReservationRestrictionId { get; set; }
    public string? RateCode { get; set; }
    public string? RoomCategory { get; set; }
    public decimal? LosUnits { get; set; }
    public string? SeasonCode { get; set; }
    public string? RateClass { get; set; }
    public string? RateCategory { get; set; }
    public string? RoomClass { get; set; }
    public string? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? RestrType { get; set; }
    public string? GdsHost { get; set; }
    public decimal? RoomCatDisplaySeq { get; set; }
    public decimal? RateCatDisplaySeq { get; set; }
    public decimal? RoomClassDisplaySeq { get; set; }
    public decimal? RateCodeDisplaySeq { get; set; }
    public string? Yieldability { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RestrictionsActivityWithSeq>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESTRICTIONS_ACTIVITY_WITH_SEQ");

            entity.Property(e => e.AppliedDate)
                .HasColumnName("APPLIED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ControlDate)
                .HasColumnName("CONTROL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .IsUnicode(false);

            entity.Property(e => e.LosUnits)
                .HasColumnName("LOS_UNITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCatDisplaySeq)
                .HasColumnName("RATE_CAT_DISPLAY_SEQ")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.RateCodeDisplaySeq)
                .HasColumnName("RATE_CODE_DISPLAY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationRestrictionId)
                .HasColumnName("RESERVATION_RESTRICTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestrType)
                .IsRequired()
                .HasColumnName("RESTR_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestrictionType)
                .HasColumnName("RESTRICTION_TYPE")
                .HasMaxLength(55)
                .IsUnicode(false);

            entity.Property(e => e.RoomCatDisplaySeq)
                .HasColumnName("ROOM_CAT_DISPLAY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClassDisplaySeq)
                .HasColumnName("ROOM_CLASS_DISPLAY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SeasonCode)
                .HasColumnName("SEASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Yieldability)
                .HasColumnName("YIELDABILITY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
