namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MeetingRoomInventory
{
    public decimal MriId { get; set; }
    public string Resort { get; set; }
    public string Room { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal BookId { get; set; }
    public decimal? EventId { get; set; }
    public DateTime? EventStart { get; set; }
    public DateTime? EventEnd { get; set; }
    public decimal? Attendees { get; set; }
    public string SharedYn { get; set; }
    public decimal ResvNameId { get; set; }
    public string ComboRoom { get; set; }
    public string DontMoveYn { get; set; }
    public string Status { get; set; }
    public string RoomCategory { get; set; }
    public string RoomClass { get; set; }
    public string RoomResort { get; set; }

    public virtual AllotmentHeader AllotmentHeader { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MeetingRoomInventory>(entity =>
        {
            entity.HasKey(e => e.MriId)
                .HasName("MRI_PK");

            entity.ToTable("MEETING_ROOM$INVENTORY");

            entity.HasIndex(e => new { e.BookId, e.Resort })
                .HasName("MRI_AH_FK_IDX");

            entity.HasIndex(e => new { e.RoomResort, e.ResvNameId })
                .HasName("MRI_ER_IDX");

            entity.HasIndex(e => new { e.RoomResort, e.BeginDate, e.Room })
                .HasName("MRI_BEGINDATE_IDX");

            entity.HasIndex(e => new { e.RoomResort, e.EndDate, e.Room })
                .HasName("MRI_ENDDATE_IDX");

            entity.HasIndex(e => new { e.Resort, e.BookId, e.EventId, e.Room })
                .HasName("MRI_RESORTBOOKEV_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.RoomResort, e.BeginDate, e.EndDate, e.Room })
                .HasName("MRI_RESORTROOM_IDX");

            entity.HasIndex(e => new { e.RoomResort, e.Room, e.ResvNameId, e.EventId })
                .HasName("MRI_UK")
                .IsUnique();

            entity.Property(e => e.MriId)
                .HasColumnName("MRI_ID")
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

            entity.Property(e => e.ComboRoom)
                .HasColumnName("COMBO_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DontMoveYn)
                .HasColumnName("DONT_MOVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventEnd)
                .HasColumnName("EVENT_END")
                .HasColumnType("DATE");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventStart)
                .HasColumnName("EVENT_START")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
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

            entity.Property(e => e.RoomResort)
                .IsRequired()
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SharedYn)
                .HasColumnName("SHARED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.AllotmentHeader);
			else
	            entity.HasOne(d => d.AllotmentHeader)
	                .WithMany(p => p.MeetingRoomInventory)
	                .HasForeignKey(d => new { d.BookId, d.Resort })
	                .HasConstraintName("MRI_AH_FK");
        });
	}
}
