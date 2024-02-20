namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TaskitemsRooms
{
    public string? Resort { get; set; }
    public decimal? TaskitemNumber { get; set; }
    public string? Room { get; set; }
    public decimal? RoomUseCount { get; set; }
    public decimal? LastRoomUseCount { get; set; }
    public decimal? MaintAfterNights { get; set; }

    public virtual Taskitems Taskitems { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaskitemsRooms>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TaskitemNumber })
                .HasName("TR_PK");

            entity.ToTable("TASKITEMS_ROOMS");

            entity.HasIndex(e => new { e.TaskitemNumber, e.Resort })
                .HasName("TR_TASKITEM_FK_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaskitemNumber)
                .HasColumnName("TASKITEM_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastRoomUseCount)
                .HasColumnName("LAST_ROOM_USE_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaintAfterNights)
                .HasColumnName("MAINT_AFTER_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomUseCount)
                .HasColumnName("ROOM_USE_COUNT")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Taskitems)))
				entity.Ignore(e => e.Taskitems);
			else
	            entity.HasOne(d => d.Taskitems)
	                .WithMany(p => p.TaskitemsRooms)
	                .HasForeignKey(d => new { d.TaskitemNumber, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("TR_TASKITEM_FK");
        });
	}
}
