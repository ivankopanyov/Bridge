namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RestrictionsActivityLog
{
    public string? Resort { get; set; }
    public decimal? ReservationRestrictionId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? RestrictionType { get; set; }
    public string? RestrictionTypeDesc { get; set; }
    public string? RateCode { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomCategoryDesc { get; set; }
    public decimal? LosUnits { get; set; }
    public string? SeasonCode { get; set; }
    public string? RateClass { get; set; }
    public string? RateCategory { get; set; }
    public string? RoomClass { get; set; }
    public decimal? InsertUser { get; set; }
    public string? InsertUserDesc { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? GdsOnRequest { get; set; }
    public string? GdsHost { get; set; }
    public string? Yieldability { get; set; }
    public string? TriggerRestrictionTypeDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RestrictionsActivityLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESTRICTIONS_ACTIVITY_LOG");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

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

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertUserDesc)
                .HasColumnName("INSERT_USER_DESC")
                .IsUnicode(false);

            entity.Property(e => e.LosUnits)
                .HasColumnName("LOS_UNITS")
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

            entity.Property(e => e.ReservationRestrictionId)
                .HasColumnName("RESERVATION_RESTRICTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestrictionType)
                .HasColumnName("RESTRICTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestrictionTypeDesc)
                .HasColumnName("RESTRICTION_TYPE_DESC")
                .HasMaxLength(55)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryDesc)
                .HasColumnName("ROOM_CATEGORY_DESC")
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

            entity.Property(e => e.TriggerRestrictionTypeDesc)
                .HasColumnName("TRIGGER_RESTRICTION_TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Yieldability)
                .HasColumnName("YIELDABILITY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
