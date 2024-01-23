namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MeetingRoomWaitlist
{
    public decimal WaitlistId { get; set; }
    public string Resort { get; set; }
    public string Room { get; set; }
    public decimal BookId { get; set; }
    public decimal EventId { get; set; }
    public decimal Priority { get; set; }
    public DateTime WaitlistDate { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string EventType { get; set; }
    public decimal? Attendees { get; set; }
    public string CateringYn { get; set; }
    public string CatStatus { get; set; }
    public string TurntoStatus { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string RoomResort { get; set; }

    public virtual GemEvent Event { get; set; }
    public virtual Room RoomNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MeetingRoomWaitlist>(entity =>
        {
            entity.HasKey(e => e.WaitlistId)
                .HasName("MRW_PK");

            entity.ToTable("MEETING_ROOM$WAITLIST");

            entity.HasIndex(e => e.CatStatus)
                .HasName("MRW_BS1_IDX");

            entity.HasIndex(e => e.EventId)
                .HasName("MRW_GE_IDX");

            entity.HasIndex(e => e.TurntoStatus)
                .HasName("MRW_BS2_IDX");

            entity.HasIndex(e => new { e.RoomResort, e.Room })
                .HasName("MRW_ROOM_IDX");

            entity.HasIndex(e => new { e.Resort, e.Room, e.Priority, e.WaitlistDate, e.BookId, e.EventId })
                .HasName("MRW_UK")
                .IsUnique();

            entity.Property(e => e.WaitlistId)
                .HasColumnName("WAITLIST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatStatus)
                .IsRequired()
                .HasColumnName("CAT_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CateringYn)
                .HasColumnName("CATERING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventType)
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.RoomResort)
                .IsRequired()
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TurntoStatus)
                .IsRequired()
                .HasColumnName("TURNTO_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WaitlistDate)
                .HasColumnName("WAITLIST_DATE")
                .HasColumnType("DATE");

			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.Event);
			else
	            entity.HasOne(d => d.Event)
	                .WithMany(p => p.MeetingRoomWaitlist)
	                .HasForeignKey(d => d.EventId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MRW_GE_FK");

			if (!types.Contains(typeof(Room)))
				entity.Ignore(e => e.RoomNavigation);
			else
	            entity.HasOne(d => d.RoomNavigation)
	                .WithMany(p => p.MeetingRoomWaitlist)
	                .HasForeignKey(d => new { d.RoomResort, d.Room })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MRW_ROOM_FK");
        });
	}
}
