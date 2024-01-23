namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSpaceConfig
{
    public decimal? RecordType { get; set; }
    public string SourceSystem { get; set; }
    public string PropertyCode { get; set; }
    public string BusinessDate { get; set; }
    public string Room { get; set; }
    public string Description { get; set; }
    public string ComboYn { get; set; }
    public decimal? AreaF { get; set; }
    public decimal? AreaM { get; set; }
    public string MeetingroomType { get; set; }
    public string EndDate { get; set; }
    public string BeginDate { get; set; }
    public string RoomStatus { get; set; }
    public string ReasonCode { get; set; }
    public decimal? ScMinCap { get; set; }
    public decimal? ScMaxCap { get; set; }
    public string ScBuilding { get; set; }
    public string Floor { get; set; }
    public string DiaryDisplayYn { get; set; }
    public string ShareableYn { get; set; }
    public string ForceAlternateYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSpaceConfig>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SPACE_CONFIG");

            entity.Property(e => e.AreaF)
                .HasColumnName("AREA_F")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AreaM)
                .HasColumnName("AREA_M")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ComboYn)
                .HasColumnName("COMBO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DiaryDisplayYn)
                .HasColumnName("DIARY_DISPLAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Floor)
                .HasColumnName("FLOOR")
                .IsUnicode(false);

            entity.Property(e => e.ForceAlternateYn)
                .HasColumnName("FORCE_ALTERNATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MeetingroomType)
                .HasColumnName("MEETINGROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReasonCode)
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomStatus)
                .HasColumnName("ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScBuilding)
                .HasColumnName("SC_BUILDING")
                .IsUnicode(false);

            entity.Property(e => e.ScMaxCap)
                .HasColumnName("SC_MAX_CAP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ScMinCap)
                .HasColumnName("SC_MIN_CAP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareableYn)
                .HasColumnName("SHAREABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");
        });
	}
}
