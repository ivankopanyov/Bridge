namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HkDailyTaskRoomView
{
    public decimal? TaskSeqNo { get; set; }
    public string? Resort { get; set; }
    public string? Room { get; set; }
    public decimal? Credits { get; set; }
    public string? CreditsRem { get; set; }
    public string? RoomInstructions { get; set; }
    public string? ServiceTime { get; set; }
    public string? Turndown { get; set; }
    public string? HkSectionCode { get; set; }
    public string? Floor { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HkDailyTaskRoomView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HK_DAILY_TASK_ROOM_VIEW");

            entity.Property(e => e.Credits)
                .HasColumnName("CREDITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditsRem)
                .HasColumnName("CREDITS_REM")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Floor)
                .HasColumnName("FLOOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HkSectionCode)
                .HasColumnName("HK_SECTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomInstructions)
                .HasColumnName("ROOM_INSTRUCTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ServiceTime)
                .HasColumnName("SERVICE_TIME")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.TaskSeqNo)
                .HasColumnName("TASK_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Turndown)
                .HasColumnName("TURNDOWN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
