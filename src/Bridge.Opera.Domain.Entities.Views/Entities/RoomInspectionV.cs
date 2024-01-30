namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RoomInspectionV
{
    public string? Resort { get; set; }
    public decimal? RiId { get; set; }
    public decimal? RiTemplateId { get; set; }
    public string? RiTemplateLocationCode { get; set; }
    public DateTime? RiDate { get; set; }
    public decimal? RiBy { get; set; }
    public string? Room { get; set; }
    public string? Inspection { get; set; }
    public string? LocationRoomInd { get; set; }
    public string? LocationDesc { get; set; }
    public string? InspectedBy { get; set; }
    public decimal? NoOfQuestions { get; set; }
    public decimal? OverallScore { get; set; }
    public decimal? Acceptance { get; set; }
    public decimal? AboveAcceptance { get; set; }
    public decimal? BelowAcceptance { get; set; }
    public decimal? NotApplicable { get; set; }
    public decimal? LastInspection { get; set; }
    public decimal? LastInspectionScore { get; set; }
    public string? LastInspectionDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomInspectionV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ROOM_INSPECTION_V");

            entity.Property(e => e.AboveAcceptance)
                .HasColumnName("ABOVE_ACCEPTANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Acceptance)
                .HasColumnName("ACCEPTANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BelowAcceptance)
                .HasColumnName("BELOW_ACCEPTANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InspectedBy)
                .HasColumnName("INSPECTED_BY")
                .IsUnicode(false);

            entity.Property(e => e.Inspection)
                .HasColumnName("INSPECTION")
                .IsUnicode(false);

            entity.Property(e => e.LastInspection)
                .HasColumnName("LAST_INSPECTION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastInspectionDate)
                .HasColumnName("LAST_INSPECTION_DATE")
                .IsUnicode(false);

            entity.Property(e => e.LastInspectionScore)
                .HasColumnName("LAST_INSPECTION_SCORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocationDesc)
                .HasColumnName("LOCATION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.LocationRoomInd)
                .HasColumnName("LOCATION_ROOM_IND")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.NoOfQuestions)
                .HasColumnName("NO_OF_QUESTIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NotApplicable)
                .HasColumnName("NOT_APPLICABLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OverallScore)
                .HasColumnName("OVERALL_SCORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RiBy)
                .HasColumnName("RI_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiDate)
                .HasColumnName("RI_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RiId)
                .HasColumnName("RI_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiTemplateId)
                .HasColumnName("RI_TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiTemplateLocationCode)
                .HasColumnName("RI_TEMPLATE_LOCATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
