namespace Bridge.Opera.Domain.Entities.Tables;

public partial class HkDailyTaskRoom
{
    public decimal? TaskSeqNo { get; set; }
    public string? Resort { get; set; }
    public string? Room { get; set; }
    public decimal? Credits { get; set; }
    public string? CreditsRem { get; set; }
    public string? RoomInstructions { get; set; }
    public string? Turndown { get; set; }
    public string? ServiceTime { get; set; }
    public string? AutoAssignedYn { get; set; }
    public string? AssignmentCode { get; set; }
    public string? AssignmentComments { get; set; }

    public virtual ResortHkDailyTask TaskSeqNoNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HkDailyTaskRoom>(entity =>
        {
            entity.HasKey(e => new { e.TaskSeqNo, e.Resort, e.Room })
                .HasName("HK_DAILY_TASK_ROOM_PK");

            entity.ToTable("HK_DAILY_TASK_ROOM");

            entity.Property(e => e.TaskSeqNo)
                .HasColumnName("TASK_SEQ_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AssignmentCode)
                .HasColumnName("ASSIGNMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AssignmentComments)
                .HasColumnName("ASSIGNMENT_COMMENTS")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.AutoAssignedYn)
                .HasColumnName("AUTO_ASSIGNED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Credits)
                .HasColumnName("CREDITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditsRem)
                .HasColumnName("CREDITS_REM")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomInstructions)
                .HasColumnName("ROOM_INSTRUCTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ServiceTime)
                .HasColumnName("SERVICE_TIME")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Turndown)
                .HasColumnName("TURNDOWN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(ResortHkDailyTask)))
				entity.Ignore(e => e.TaskSeqNoNavigation);
			else
	            entity.HasOne(d => d.TaskSeqNoNavigation)
	                .WithMany(p => p.HkDailyTaskRoom)
	                .HasForeignKey(d => d.TaskSeqNo)
	                .HasConstraintName("HK_DAILY_TASK_ROOM_SEQ_FK");
        });
	}
}
